using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click1(object sender, EventArgs e)
        {
           
            MessageBox.Show("Programare facuta cu succes", "Programari online");
        }

       private void Form1_Load(object sender, EventArgs e) {
            StreamWriter str = new StreamWriter("fisier.txt", true);
            str.WriteLine("Acesta este un fisier text!");
            str.Close();
        }
    }
}
