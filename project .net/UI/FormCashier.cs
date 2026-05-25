using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FormCashier : Form
    {
        public FormCashier()
        {
            InitializeComponent();
        }

        private void Order_Button_Click(object sender, EventArgs e)
        {
            new FormOrderCashier().ShowDialog();
        }

        private void FormCashier_Load(object sender, EventArgs e)
        {

        }
    }
}