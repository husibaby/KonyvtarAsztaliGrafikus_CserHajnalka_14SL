using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KonyvtarAsztaliKonzolos
{
    internal class Adatbazis
    {
        static MySqlConnection connection = null;
        static MySqlCommand command = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "book";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);
            command = connection.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            finally
            {
                kapcsolatZar();
            }
        }
        private void kapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed) connection.Close();
        }
        private void kapcsolatNyit()
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();

        }

        internal List<Book> getAllBook()
        {
            List<Book> book= new List<Book>();
            command.CommandText = "SELECT * FROM `books`";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int id = dr.GetInt32("id");
                        string title = dr.GetString("title");
                        string author = dr.GetString("author");
                        int publish_year = dr.GetInt32("publish_year");
                        int page_count = dr.GetInt32("page_count");
                        book.Add(new Book(id, title, author, publish_year, page_count));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
            return book;
        }

        internal void updateBook(Book book)
        {
            command.CommandText = "UPDATE `books` SET `id`=@id,`title`=@title,`author`=@author,`publish_year`=@publish_year,`page_count`=@page_count WHERE `id`= @id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", book.Id);
            command.Parameters.AddWithValue("@title", book.Title);
            command.Parameters.AddWithValue("@author", book.Author);
            command.Parameters.AddWithValue("@publish_year", book.Publish_year);
            command.Parameters.AddWithValue("@page_count", book.Page_count);
            try
            {
                kapcsolatNyit();
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }
        internal void deleteBook(Book book)
        {
            command.CommandText = "DELETE FROM `books` WHERE `id`= @id";

            try
            {
                kapcsolatNyit();
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }
        internal void insertBook(Book book)
        {
            command.CommandText = "INSERT INTO `books`(`title`, `author`, `publish_year`, `page_count`) VALUES (@title,@author,@publish_year,@page_count)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@title", book.Title);
            command.Parameters.AddWithValue("@author", book.Author);
            command.Parameters.AddWithValue("@publish_year", book.Publish_year);
            command.Parameters.AddWithValue("@page_count", book.Page_count);
            try
            {
                kapcsolatNyit();
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }
    }





}
