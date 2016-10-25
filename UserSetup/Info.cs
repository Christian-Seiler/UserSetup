using System;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;

namespace UserSetup
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();

            productNameLabel.Text = ProductName;
            versionLabel.Text = $"Version {ProductVersion} ({Assembly.GetExecutingAssembly().GetName().Version})";
            copyrightLabel.Text = "Copyright © 2016 Christian Seiler Services.\n" +
                "Alle Rechte vorbehalten.";
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            string url = "http://www.christianseiler.ch";

            Process.Start(url);
        }

        private void bugButton_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Christian-Seiler/UserSetup/issues/new";

            Process.Start(url);
        }
    }
}
