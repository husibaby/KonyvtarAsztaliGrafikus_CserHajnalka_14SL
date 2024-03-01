using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtarAsztaliKonzolos
{
    public partial class FormNyito : Form
    {
        public FormNyito()
        {
            InitializeComponent();
        }

        private void FormNyito_Load(object sender, EventArgs e)
        {
            foreach (string author in Program.book.Select(a => a.Author).Distinct())
            {
                CheckBox cb = new CheckBox();
                cb.Text = author;
                cb.Checked = true;
                cb.Location = new Point(10, panel_Author.Controls.Count * 20);
                cb.CheckedChanged += new EventHandler(author_change);
                panel_Author.Controls.Add(cb);
            }
            updateBookLista();
        }

        private void author_change(object sender, EventArgs e)
        {
            updateBookLista();
        }
        private void updateBookLista()
        {

            listBox_Book.Items.Clear();
            List<string> kivalasztottak = new List<string>();
            foreach (CheckBox item in panel_Author.Controls)
            {
                if (item.Checked) { kivalasztottak.Add(item.Text); };
            }
            foreach (Book item in Program.book)
            {
                if (kivalasztottak.Contains(item.Author))
                {
                    listBox_Book.Items.Add(item);
                }
            }
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBook formBook = new FormBook("add");
            formBook.ShowDialog();
        }

        private void módosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Book.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormBook formBook = new FormBook("edit");
            formBook.ShowDialog();
        }
        private void törölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Book.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott elem!");
                return;
            }
            FormBook formBook = new FormBook("delete");
            formBook.ShowDialog();
        }

       
    }
}

