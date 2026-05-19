using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCashier : Form
    {
        public FormCashier()
        {
            InitializeComponent();
        }

        private void Products_Cashier_Button_Click(object sender, EventArgs e)
        {
            new FormProductsCashier().ShowDialog();
        }

        private void Customers_Management_Button_Click(object sender, EventArgs e)
        {
            new FormCustomersManagement().ShowDialog();
        }
    }
}
