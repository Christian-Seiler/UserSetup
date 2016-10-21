using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserSetup
{
    static class Program
    {
        public static string name;
        public static string vorname;
        public static string abteilung;
        public static string id;
        public static string mail;
        public static string selectedPrinter;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> list = Person.getInfo(Person.getID());

            id = list[0];
            vorname = list[1];
            name = list[2];
            mail = list[3];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            
        }
    }
}
