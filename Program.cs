using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvtarAsztaliKonzolos
{
    internal static class Program
    {
        public static List<Book> book= new List<Book>();
        public static Adatbazis db = null;
        public static FormNyito formNyito = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            db = new Adatbazis();
            book = db.getAllBook();
            formNyito = new FormNyito();
            Application.Run(formNyito);
        }
    }
}
