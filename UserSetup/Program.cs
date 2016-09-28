using System;
using System.Windows.Forms;

namespace UserSetup
{
    static class Program
    {
        public static string name;
        public static string vorname;
        public static string kurzel;
        public static string abteilung;
        public static string mail;
        public static string selectedPrinter;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {

            name = "";
            vorname = "";
            kurzel = "";
            abteilung = "";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
        }
    }
}
