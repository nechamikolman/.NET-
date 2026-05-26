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
            //this.BackgroundImage = Properties.Resources._69b68fd7300b151284f7f44ed452e64a_1_;
            //this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}