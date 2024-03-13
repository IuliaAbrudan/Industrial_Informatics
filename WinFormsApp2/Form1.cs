namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show(); // afiseaza a doua forma
        }
    }
}
