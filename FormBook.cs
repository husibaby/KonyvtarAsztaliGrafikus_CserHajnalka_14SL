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
    public partial class FormBook : Form
    {
        string muvelet;
        public FormBook(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "add":
                    this.Text = "Új könyv";
                    button_Muvelet.Text = "Rögzítés";
                    button_Muvelet.BackColor = Color.Green;
                    button_Muvelet.ForeColor = Color.Black;
                    button_Muvelet.Click += new EventHandler(insertBook);
                    break;

                case "edit":
                    this.Text = "Módosítás";
                    button_Muvelet.Text = "Módosítás";
                    button_Muvelet.BackColor = Color.Yellow;
                    button_Muvelet.ForeColor = Color.Black;
                    button_Muvelet.Click += new EventHandler(updateBook);
                    adatokFeltoltese();
                    break;

                case "delete":
                    this.Text = "Törlés";
                    button_Muvelet.Text = "Törlés";
                    button_Muvelet.BackColor = Color.Blue;
                    button_Muvelet.ForeColor = Color.Black;
                    button_Muvelet.Click += new EventHandler(deleteBook);
                    adatokFeltoltese();
                    break;
            }
        }
        private void adatokFeltoltese()
        {
            Book book = (Book)Program.formNyito.listBox_Book.SelectedItem;
            textBox_Title.Text = book.Title.ToString();
            textBox_Author.Text = book.Author.ToString();
            numericUpDown_PublishYear.Value = (int)book.Publish_year;
            numericUpDown_PageCount.Value = (int)book.Page_count;          
        }


        private void updateBook(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = textBox_Title.Text;
            book.Author = textBox_Author.Text;
            book.Publish_year = (int)numericUpDown_PublishYear.Value;
            book.Page_count = (int)numericUpDown_PageCount.Value;
            Program.db.updateBook(book);

            this.Close();
        }

        private void insertBook(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = textBox_Title.Text;
            book.Author = textBox_Author.Text;
            book.Publish_year = (int)numericUpDown_PublishYear.Value;
            book.Page_count = (int)numericUpDown_PageCount.Value;
            Program.db.insertBook(book);

            this.Close();
        }

        private void deleteBook(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = textBox_Title.Text;
            book.Author = textBox_Author.Text;
            book.Publish_year = (int)numericUpDown_PublishYear.Value;
            book.Page_count = (int)numericUpDown_PageCount.Value;
            Program.db.deleteBook(book);

            this.Close();
            Program.db.getAllBook();
        }

        
    }
}


