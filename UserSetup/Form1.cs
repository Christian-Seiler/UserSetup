using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace UserSetup
{
    public partial class Form1 : Form
    {
        private string kurzel1;
        private string kurzel2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPrinters();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            Program.name = nameTextBox.Text;
            if (nameTextBox.Text.Length >= 2) {
                kurzel1 = nameTextBox.Text.Substring(0, 2);
                createKurzel();
            }
        }

        private void vornameTextBox_TextChanged(object sender, EventArgs e)
        {
            Program.vorname = vornameTextBox.Text;
            kurzel2 = vornameTextBox.Text.Substring(0, 1);
            createKurzel();
        }

        private void kurzelTextBox_TextChanged(object sender, EventArgs e)
        {
            Program.kurzel = kurzelTextBox.Text;
        }

        private void createKurzel()
        {
            Program.kurzel = "";
            if (kurzel1 != null)
            {
                Program.kurzel = kurzel1.ToUpper();
            }
            if (kurzel2 != null)
            {
                Program.kurzel += kurzel2.ToUpper();
            }
            if (Program.kurzel.Length == 3)
            {
                kurzelTextBox.Text = Program.kurzel;
            }
        }

        private void createMail()
        {
            Program.mail = "";
            var strippedName = Program.name.Replace(" ", "");
            Program.mail += Program.vorname;
            Program.mail += ".";
            Program.mail += strippedName;
            Program.mail += "@allpower.ch";

            Program.mail = Program.mail.ToLower();
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

        private void mailButton_Click(object sender, EventArgs e)
        {
            if (Program.name == "")
            {
                DialogResult result = MessageBox.Show("Nachname ist erforderlich!", "Fehler!" , MessageBoxButtons.OK);
                if (result == DialogResult.OK) { }
            }
            else if (Program.vorname == "")
            {
                DialogResult result = MessageBox.Show("Vorname ist erforderlich!", "Fehler!", MessageBoxButtons.OK);
                if (result == DialogResult.OK) { }
            } else
            {
                createMail();
                mailLabel.Text = Program.mail;
            }
        }

        private void weiterButton_Click(object sender, EventArgs e)
        {
            if (Program.name == null)
            {
                DialogResult result = MessageBox.Show("Bitte Nachname definieren.", "Fehler", MessageBoxButtons.OK);
                if (result == DialogResult.OK) { }
            }

            if (Program.vorname == null)
            {
                DialogResult result = MessageBox.Show("Bitte Vorname definieren.", "Fehler", MessageBoxButtons.OK);
                if (result == DialogResult.OK) { }
            }
            if (Program.kurzel == null)
            {
                DialogResult result = MessageBox.Show("Bitte Kürzel definieren.", "Fehler", MessageBoxButtons.OK);
                if (result == DialogResult.OK) { }
            }
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

            nameTextBox.Enabled = false;
            vornameTextBox.Enabled = false;
            kurzelTextBox.Enabled = false;
            abteilungComboBox.Enabled = false;
            printerListBox.Enabled = false;

            createMail();
            logTextBox.Text = ($"Name: {Program.name}\n");
            logTextBox.AppendText($"Vorname: {Program.vorname}\n");
            logTextBox.AppendText($"Kürzel: {Program.kurzel}\n");
            logTextBox.AppendText($"Abteilung: {Program.abteilung}\n");
            logTextBox.AppendText($"eMail: {Program.mail}\n");
            logTextBox.AppendText($"Drucker {Program.selectedPrinter}\n");
            logTextBox.AppendText("#----------------------------------\n");

            // Execute Code
            Setup instance = new Setup();
            logTextBox.AppendText(instance.createDirectories1());
            logTextBox.AppendText(instance.createDirectories2());
            logTextBox.AppendText(instance.copyTemplate());
            logTextBox.AppendText(instance.copySignature());
            logTextBox.AppendText(instance.setDefaultPrinter());
            logTextBox.AppendText(instance.customizeSignature());
            logTextBox.AppendText(instance.setRegistryEntries());
            logTextBox.AppendText("#----------------------------------\n");
            logTextBox.AppendText("Fertig!");
        }

        private void printerListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Program.selectedPrinter = printerListBox.SelectedItem.ToString();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Allpower User Setup\nVersion: {ProductVersion}\n\nDieses Produkt ist Urheberrechtlich geschützt.\n© 2016 Christian Seiler Services\nAlle Rechte vorbehalten.", "Info", MessageBoxButtons.OK);

            if (result == DialogResult.OK) { }
        }
    }
}
