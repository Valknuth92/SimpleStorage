using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStorage
{
    public partial class Sold : Form
    {
        SqlConnection sqlConnection;
        string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ed\Downloads\SimpleStorage\SimpleStorage\DataBase.mdf;Integrated Security=True";
        int selectedID;

        public Sold()
        {
            InitializeComponent();
            LoadData();
        }
        
        private void LoadData()
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

        private void toReportForm_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report();
            reportForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Store storeForm = new Store();
            this.Hide();
            storeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accepted accForm = new Accepted();
            this.Hide();
            accForm.Show();
        }

        private void Sold_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
