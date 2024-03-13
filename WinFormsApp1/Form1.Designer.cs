using System;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Adăugăm câteva cărți de exemplu în DataGridView
            dataGridViewBooks.Rows.Add("Povestea unei călătorii", "John Doe", "2005", "Ficțiune");
            dataGridViewBooks.Rows.Add("Arta programării", "Donald Knuth", "1968", "Informatică");
            dataGridViewBooks.Rows.Add("Geniul vorbirii", "Julian Treasure", "2017", "Dezvoltare personală");

            // Populăm combobox-ul cu criterii de căutare
            comboBoxSearchBy.Items.Add("Titlu");
            comboBoxSearchBy.Items.Add("Autor");
            comboBoxSearchBy.Items.Add("An");
            comboBoxSearchBy.Items.Add("Gen");

            comboBoxSearchBy.SelectedIndex = 0; // Setăm valoarea implicită
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            // Adăugăm o nouă carte în DataGridView
            dataGridViewBooks.Rows.Add(textBoxTitle.Text, textBoxAuthor.Text, textBoxYear.Text, textBoxGenre.Text);
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            // Ștergem cartea selectată din DataGridView
            if (dataGridViewBooks.SelectedRows.Count > 0)
            {
                dataGridViewBooks.Rows.RemoveAt(dataGridViewBooks.SelectedRows[0].Index);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Căutăm în DataGridView după criteriul selectat
            string searchKeyword = textBoxSearch.Text.ToLower();
            string searchBy = comboBoxSearchBy.SelectedItem.ToString().ToLower();

            foreach (DataGridViewRow row in dataGridViewBooks.Rows)
            {
                if (row.Cells[searchBy].Value.ToString().ToLower().Contains(searchKeyword))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}