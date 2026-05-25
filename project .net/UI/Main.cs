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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void Manger_Button_Click(object sender, EventArgs e)
        {
            new FormManager().ShowDialog();
        }

        private void Cashier_Button_Click(object sender, EventArgs e)
        {
            new FormCashier().ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}