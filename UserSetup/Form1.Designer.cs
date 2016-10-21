namespace UserSetup
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.kurzelTextBox = new System.Windows.Forms.TextBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.vornameLabel = new System.Windows.Forms.Label();
            this.kurzelLabel = new System.Windows.Forms.Label();
            this.abteilungComboBox = new System.Windows.Forms.ComboBox();
            this.abteilungLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.printerListBox = new System.Windows.Forms.ListBox();
            this.userSetupLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(382, 143);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(12, 91);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // kurzelTextBox
            // 
            this.kurzelTextBox.Enabled = false;
            this.kurzelTextBox.Location = new System.Drawing.Point(12, 146);
            this.kurzelTextBox.Name = "kurzelTextBox";
            this.kurzelTextBox.Size = new System.Drawing.Size(100, 20);
            this.kurzelTextBox.TabIndex = 2;
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.Enabled = false;
            this.vornameTextBox.Location = new System.Drawing.Point(118, 91);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(106, 20);
            this.vornameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 75);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Nachname";
            // 
            // vornameLabel
            // 
            this.vornameLabel.AutoSize = true;
            this.vornameLabel.Location = new System.Drawing.Point(115, 75);
            this.vornameLabel.Name = "vornameLabel";
            this.vornameLabel.Size = new System.Drawing.Size(49, 13);
            this.vornameLabel.TabIndex = 6;
            this.vornameLabel.Text = "Vorname";
            // 
            // kurzelLabel
            // 
            this.kurzelLabel.AutoSize = true;
            this.kurzelLabel.Location = new System.Drawing.Point(12, 127);
            this.kurzelLabel.Name = "kurzelLabel";
            this.kurzelLabel.Size = new System.Drawing.Size(36, 13);
            this.kurzelLabel.TabIndex = 7;
            this.kurzelLabel.Text = "Kürzel";
            // 
            // abteilungComboBox
            // 
            this.abteilungComboBox.FormattingEnabled = true;
            this.abteilungComboBox.Items.AddRange(new object[] {
            "Buchhaltung",
            "Einkauf",
            "Geschäftsleitung",
            "Human Resources",
            "Informatik",
            "Kursadministration",
            "Marketing",
            "Sekretariat",
            "Verkauf"});
            this.abteilungComboBox.Location = new System.Drawing.Point(230, 145);
            this.abteilungComboBox.Name = "abteilungComboBox";
            this.abteilungComboBox.Size = new System.Drawing.Size(146, 21);
            this.abteilungComboBox.TabIndex = 3;
            this.abteilungComboBox.SelectedIndexChanged += new System.EventHandler(this.abteilungComboBox_SelectedIndexChanged);
            // 
            // abteilungLabel
            // 
            this.abteilungLabel.AutoSize = true;
            this.abteilungLabel.Location = new System.Drawing.Point(230, 127);
            this.abteilungLabel.Name = "abteilungLabel";
            this.abteilungLabel.Size = new System.Drawing.Size(51, 13);
            this.abteilungLabel.TabIndex = 8;
            this.abteilungLabel.Text = "Abteilung";
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(230, 75);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(32, 13);
            this.mailLabel.TabIndex = 16;
            this.mailLabel.Text = "Email";
            // 
            // printerListBox
            // 
            this.printerListBox.FormattingEnabled = true;
            this.printerListBox.Location = new System.Drawing.Point(12, 191);
            this.printerListBox.Name = "printerListBox";
            this.printerListBox.Size = new System.Drawing.Size(206, 173);
            this.printerListBox.TabIndex = 17;
            this.printerListBox.SelectedValueChanged += new System.EventHandler(this.printerListBox_SelectedValueChanged);
            // 
            // userSetupLabel
            // 
            this.userSetupLabel.AutoSize = true;
            this.userSetupLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSetupLabel.Location = new System.Drawing.Point(306, 30);
            this.userSetupLabel.Name = "userSetupLabel";
            this.userSetupLabel.Size = new System.Drawing.Size(151, 32);
            this.userSetupLabel.TabIndex = 18;
            this.userSetupLabel.Text = "User Setup";
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logTextBox.Enabled = false;
            this.logTextBox.Location = new System.Drawing.Point(230, 191);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(227, 173);
            this.logTextBox.TabIndex = 20;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(68, 30);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(118, 32);
            this.logoLabel.TabIndex = 25;
            this.logoLabel.Text = "Allpower";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImage = global::UserSetup.Properties.Resources.Allpower;
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPictureBox.Location = new System.Drawing.Point(13, 13);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(50, 50);
            this.logoPictureBox.TabIndex = 26;
            this.logoPictureBox.TabStop = false;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(382, 373);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(75, 23);
            this.infoButton.TabIndex = 27;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // mailTextBox
            // 
            this.mailTextBox.Enabled = false;
            this.mailTextBox.Location = new System.Drawing.Point(230, 91);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(227, 20);
            this.mailTextBox.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 408);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.userSetupLabel);
            this.Controls.Add(this.printerListBox);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.abteilungLabel);
            this.Controls.Add(this.abteilungComboBox);
            this.Controls.Add(this.kurzelLabel);
            this.Controls.Add(this.vornameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(this.kurzelTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.startButton);
            this.Icon = global::UserSetup.Properties.Resources.favicon_allpower;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Allpower | User Setup";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.TextBox kurzelTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label vornameLabel;
        private System.Windows.Forms.Label kurzelLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox abteilungComboBox;
        private System.Windows.Forms.Label abteilungLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.ListBox printerListBox;
        private System.Windows.Forms.Label userSetupLabel;
        public System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.TextBox mailTextBox;
    }
}

