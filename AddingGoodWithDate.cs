using System;
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
    public partial class AddingGoodWithDate : Form
    {
        public AddingGoodWithDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Accepted acceptedForm = new Accepted();
            DateTime currentDate = Convert.ToDateTime(dateField.Text);

            string sqlFormattedDate = currentDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            acceptedForm.addGood(nameField.Text, amountField.Text, priceField.Text, sqlFormattedDate);
            acceptedForm.Refresh();
            this.Hide();
        }
    }
}
