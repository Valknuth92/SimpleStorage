using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStorage
{
    public partial class Accepted : Form
    {
        SqlConnection sqlConnection;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ed\Downloads\SimpleStorage\SimpleStorage\DataBase.mdf;Integrated Security=True";
        int selectedID;
        public Accepted()
        {
            InitializeComponent();
            LoadData();
        }        

        private void LoadData()
        {

            sqlConnection = new SqlConnection(connectString);

            sqlConnection.Open();

            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Accepted]", sqlConnection);
            List<string[]> data = new List<string[]>();

            try {
                reader = command.ExecuteReader();                
                while (reader.Read())
                {
                    data.Add(new string[6]);
                    data[data.Count - 1][0] = reader[1].ToString();
                    data[data.Count - 1][1] = reader[2].ToString();
                    data[data.Count - 1][2] = reader[3].ToString();
                    data[data.Count - 1][3] = reader[4].ToString();
                    data[data.Count - 1][4] = (Int32.Parse(data[data.Count - 1][1]) * Int32.Parse(data[data.Count - 1][2])).ToString();
                    data[data.Count - 1][5] = reader[0].ToString();
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message.ToString(), e.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            sqlConnection.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        public void addGood(string name, string amount, string price, string date)
        {            
            SqlCommand addGood = new SqlCommand("INSERT INTO Accepted (name, amount, price, income) VALUES (@name, @amount, @price, @income);",sqlConnection);
            addGood.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            addGood.Parameters.Add("@amount", SqlDbType.NVarChar).Value = amount;
            addGood.Parameters.Add("@price",SqlDbType.NVarChar).Value = price;     
            addGood.Parameters.Add("@income", SqlDbType.DateTime).Value = date;

            sqlConnection.Open();

            if (addGood.ExecuteNonQuery() == 1)
            {
                //MessageBox.Show("Товар добавлен");
                
            }
            else
            {
                MessageBox.Show("Товар не был добавлен");
            }

            sqlConnection.Close();

            Refresh();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                AddingGood addGoodForm = new AddingGood();
                addGoodForm.Show();
            }
            else
            {
                AddingGoodWithDate addGoodWD = new AddingGoodWithDate();
                addGoodWD.Show();
            }
        }

        public void Refresh()
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

       

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1[0,e.RowIndex].Value.ToString());
            
            selectedID = int.Parse(dataGridView1[5, e.RowIndex].Value.ToString());

        }

        private void btnToStore_Click(object sender, EventArgs e)
        {            
            string name = dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString(); 
            string amount = dataGridView1[1, dataGridView1.CurrentCellAddress.Y].Value.ToString(); 
            string price = dataGridView1[2, dataGridView1.CurrentCellAddress.Y].Value.ToString(); 
            string income = dataGridView1[3, dataGridView1.CurrentCellAddress.Y].Value.ToString(); 
            selectedID = int.Parse(dataGridView1[5, dataGridView1.CurrentCellAddress.Y].Value.ToString());

            SqlCommand shiftToStore = new SqlCommand("INSERT INTO Store (Id, name, amount, price, income) VALUES(@ID, @name, @amount, @price, @income); ",sqlConnection);
            shiftToStore.Parameters.Add("@ID", SqlDbType.Int).Value = selectedID;
            shiftToStore.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            shiftToStore.Parameters.Add("@amount", SqlDbType.NVarChar).Value = amount;
            shiftToStore.Parameters.Add("@price", SqlDbType.NVarChar).Value = price;
            shiftToStore.Parameters.Add("@income", SqlDbType.DateTime).Value = income;

            SqlCommand deleteFromAccepted = new SqlCommand("DELETE Accepted WHERE Id = @ID", sqlConnection);
            deleteFromAccepted.Parameters.Add("@ID",SqlDbType.Int).Value = selectedID;
            sqlConnection.Open();
            shiftToStore.ExecuteNonQuery();            
            deleteFromAccepted.ExecuteNonQuery();
            sqlConnection.Close();

            Refresh();
           
        }

        private void openStore_Click(object sender, EventArgs e)
        {
            Store storeForm = new Store();
            this.Hide();
            storeForm.Show();
        }

        private void Accepted_Activated(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sold soldForm = new Sold();
            this.Hide();
            soldForm.Show();
        }

        private void Accepted_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
