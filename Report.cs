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
    public partial class Report : Form
    {
        SqlConnection sqlConnection;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ed\Downloads\SimpleStorage\SimpleStorage\DataBase.mdf;Integrated Security=True";
        public Report()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadAcc()
        {

            sqlConnection = new SqlConnection(connectString);

            sqlConnection.Open();

            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Accepted]", sqlConnection);
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
                    data[data.Count - 1][5] = "Принят";
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

        private void LoadStore()
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
                    data[data.Count - 1][5] = "На складе";
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

        private void LoadSold()
        {

            sqlConnection = new SqlConnection(connectString);

            sqlConnection.Open();

            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM Sold", sqlConnection);
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
                    data[data.Count - 1][5] = "Продан";
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

        private void LoadData()
        {
            LoadAcc();
            LoadStore();
            LoadSold();            
        }
        
        private void RefreshData()
        {
            dataGridView1.Rows.Clear();

            if (checkBox1.Checked)
            {
                LoadAcc();
            }
            if (checkBox2.Checked)
            {
                LoadStore();
            }
            if (checkBox3.Checked)
            {
                LoadSold();
            }
            countTotal();
        }
       

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
           

            RefreshData();
            applyFilter();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                checkBox4.Checked = false;
            }
            RefreshData();
            applyFilter();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                checkBox4.Checked = false;
            }
            RefreshData();
            applyFilter();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                checkBox4.Checked = false;
            }
            RefreshData();
            applyFilter();
        }

       
        private void applyFilter()
        {
            RefreshData();
            DateTime since = Convert.ToDateTime(txtSince.Text); ;
            DateTime till = Convert.ToDateTime(txtTill.Text); ;
            int i = 0;

            while (i < dataGridView1.Rows.Count)
            {
                DateTime cDate = DateTime.Parse(dataGridView1[3, i].Value.ToString());

                if ((cDate.CompareTo(since) < 0) || (cDate.CompareTo(till) > 0))
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;
                }
                i++;
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            applyFilter();            
        }

        private void Report_Load(object sender, EventArgs e)
        {
            txtSince.Text = "01/01/2000";
            txtTill.Text = "01/01/2100";
            checkBox4.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSince.Text = "01/01/2000";
            txtTill.Text = "01/01/2100";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accepted accForm = new Accepted();
            this.Hide();
            accForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Store storeForm = new Store();
            this.Hide();
            storeForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sold soldform = new Sold();
            this.Hide();
            soldform.Show();
        }
        private void countTotal()
        {
            int totalSum = 0;
            for (int i=0;i<dataGridView1.Rows.Count;i++)
            {
                totalSum += int.Parse(dataGridView1[4,i].Value.ToString());                
            }
            lblTotal.Text = totalSum.ToString();
        }

        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
