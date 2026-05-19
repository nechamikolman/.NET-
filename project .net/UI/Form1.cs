namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void welcom_button_Click(object sender, EventArgs e)
        {
            new Main().ShowDialog();

        }
    }
}
