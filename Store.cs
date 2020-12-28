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
    public partial class Store : Form
    {
        SqlConnection sqlConnection;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ed\Downloads\SimpleStorage\SimpleStorage\DataBase.mdf;Integrated Security=True";
        int selectedID;
        public Store()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

            sqlConnection = new SqlConnection(connectString);

            sqlConnection.Open();

            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM Store", sqlConnection);
            List<string[]> data = new List<string[]>();

            try
            {
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
            catch (Exception e)
            {
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

        public void Refresh()
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }
        private void toAcceptedForm_Click(object sender, EventArgs e)
        {
            Accepted accForm = new Accepted();
            this.Hide();
            accForm.Show();
        }

        private void toSoldForm_Click(object sender, EventArgs e)
        {
            Sold soldForm = new Sold();
            soldForm.Show();
            this.Hide();
        }

        private void sellGood()
        {
            string name = dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            string amount = dataGridView1[1, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            string price = dataGridView1[2, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            string income = dataGridView1[3, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            selectedID = int.Parse(dataGridView1[5, dataGridView1.CurrentCellAddress.Y].Value.ToString());

            SqlCommand shiftToStore = new SqlCommand("INSERT INTO Sold (Id, name, amount, price, income) VALUES(@ID, @name, @amount, @price, @income); ", sqlConnection);
            shiftToStore.Parameters.Add("@ID", SqlDbType.Int).Value = selectedID;
            shiftToStore.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            shiftToStore.Parameters.Add("@amount", SqlDbType.NVarChar).Value = amount;
            shiftToStore.Parameters.Add("@price", SqlDbType.NVarChar).Value = price;
            shiftToStore.Parameters.Add("@income", SqlDbType.DateTime).Value = income;

            SqlCommand deleteFromAccepted = new SqlCommand("DELETE Store WHERE Id = @ID", sqlConnection);
            deleteFromAccepted.Parameters.Add("@ID", SqlDbType.Int).Value = selectedID;
            sqlConnection.Open();
            shiftToStore.ExecuteNonQuery();
            deleteFromAccepted.ExecuteNonQuery();
            sqlConnection.Close();

            Refresh();
        }
        private void btnSell_Click(object sender, EventArgs e)
        {
            sellGood();
        }

        private void Store_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
                
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dataGridView1.ClearSelection();
                dataGridView1[e.ColumnIndex, e.RowIndex].Selected = true;
            }
        }

        private void продатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sellGood();
        }
    }
}
