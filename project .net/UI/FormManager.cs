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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void Products_Management_Button_Click(object sender, EventArgs e)
        {
            new FormProductsManagement().ShowDialog();
        }

        private void Customers_Management_Button_Click(object sender, EventArgs e)
        {
            new FormCustomersManagement().ShowDialog();
        }

        private void Sale_Management_Button_Click(object sender, EventArgs e)
        {
            new FormSaleManagement().ShowDialog();
        }

       
    }
}
