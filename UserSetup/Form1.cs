using System;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace UserSetup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPrinters();
            vornameTextBox.Text = Program.vorname;
            nameTextBox.Text = Program.name;
            mailTextBox.Text = Program.mail;
            kurzelTextBox.Text = Program.id;
        }

        private void abteilungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.abteilung = abteilungComboBox.SelectedItem.ToString();
        }

        private void listPrinters()
        {
            foreach (var printer in PrinterSettings.InstalledPrinters)
            {
                this.printerListBox.Items.Add(printer.ToString());
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (Program.abteilung == null)
            {
                DialogResult result = MessageBox.Show("Bitte Abteilung definieren.", "Fehler", MessageBoxButtons.OK);
                if (result == DialogResult.OK) { }
            }
            if (Program.selectedPrinter == null)
            {
                DialogResult result = MessageBox.Show("Bitte Drucker definieren.", "Fehler", MessageBoxButtons.OK);
                if (result == DialogResult.OK) {  }
            }

            abteilungComboBox.Enabled = false;
            printerListBox.Enabled = false;

            // Execute Code
            Setup instance = new Setup();
            logTextBox.Clear();
            logTextBox.AppendText(instance.createDirectories1());
            logTextBox.AppendText(instance.createDirectories2());
            logTextBox.AppendText(instance.copyTemplate());
            logTextBox.AppendText(instance.copySignature());
            logTextBox.AppendText(instance.setDefaultPrinter());
            logTextBox.AppendText(instance.customizeSignature());
            logTextBox.AppendText(instance.setRegistryEntries());
            logTextBox.AppendText("#----------------------------------\n");
            logTextBox.AppendText("Fertig!");

            abteilungComboBox.Enabled = true;
            printerListBox.Enabled = true;
        }

        private void printerListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Program.selectedPrinter = printerListBox.SelectedItem.ToString();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }
    }
}
