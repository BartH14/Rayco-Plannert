namespace RayCo_PMS_PC.Forms
{
    partial class ProjectLidToevoegen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVoornaam = new System.Windows.Forms.Label();
            this.labelAchternaam = new System.Windows.Forms.Label();
            this.labelWachtwoord = new System.Windows.Forms.Label();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.veldVoornaam = new System.Windows.Forms.TextBox();
            this.veldAchternaam = new System.Windows.Forms.TextBox();
            this.veldWachtwoord = new System.Windows.Forms.TextBox();
            this.knopAanmaken = new System.Windows.Forms.Button();
            this.knopAnnuleer = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.RadioButton();
            this.buttonGebruiker = new System.Windows.Forms.RadioButton();
            this.labelGebruikersnaam = new System.Windows.Forms.Label();
            this.veldGebruikersnaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelVoornaam
            // 
            this.labelVoornaam.AutoSize = true;
            this.labelVoornaam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoornaam.Location = new System.Drawing.Point(12, 57);
            this.labelVoornaam.Name = "labelVoornaam";
            this.labelVoornaam.Size = new System.Drawing.Size(97, 21);
            this.labelVoornaam.TabIndex = 1;
            this.labelVoornaam.Text = "Voornaam:";
            this.labelVoornaam.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAchternaam
            // 
            this.labelAchternaam.AutoSize = true;
            this.labelAchternaam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchternaam.Location = new System.Drawing.Point(12, 99);
            this.labelAchternaam.Name = "labelAchternaam";
            this.labelAchternaam.Size = new System.Drawing.Size(116, 21);
            this.labelAchternaam.TabIndex = 2;
            this.labelAchternaam.Text = "Achternaam:";
            // 
            // labelWachtwoord
            // 
            this.labelWachtwoord.AutoSize = true;
            this.labelWachtwoord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachtwoord.Location = new System.Drawing.Point(11, 140);
            this.labelWachtwoord.Name = "labelWachtwoord";
            this.labelWachtwoord.Size = new System.Drawing.Size(117, 21);
            this.labelWachtwoord.TabIndex = 3;
            this.labelWachtwoord.Text = "Wachtwoord:";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(8, 233);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(86, 21);
            this.labelAdmin.TabIndex = 4;
            this.labelAdmin.Text = "Projectrol:";
            // 
            // veldVoornaam
            // 
            this.veldVoornaam.Location = new System.Drawing.Point(166, 57);
            this.veldVoornaam.Name = "veldVoornaam";
            this.veldVoornaam.Size = new System.Drawing.Size(230, 20);
            this.veldVoornaam.TabIndex = 5;
            // 
            // veldAchternaam
            // 
            this.veldAchternaam.Location = new System.Drawing.Point(166, 99);
            this.veldAchternaam.Name = "veldAchternaam";
            this.veldAchternaam.Size = new System.Drawing.Size(230, 20);
            this.veldAchternaam.TabIndex = 6;
            // 
            // veldWachtwoord
            // 
            this.veldWachtwoord.Location = new System.Drawing.Point(166, 140);
            this.veldWachtwoord.Name = "veldWachtwoord";
            this.veldWachtwoord.Size = new System.Drawing.Size(230, 20);
            this.veldWachtwoord.TabIndex = 7;
            // 
            // knopAanmaken
            // 
            this.knopAanmaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopAanmaken.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopAanmaken.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.knopAanmaken.Location = new System.Drawing.Point(217, 273);
            this.knopAanmaken.Name = "knopAanmaken";
            this.knopAanmaken.Size = new System.Drawing.Size(148, 35);
            this.knopAanmaken.TabIndex = 8;
            this.knopAanmaken.Text = "AANMAKEN";
            this.knopAanmaken.UseVisualStyleBackColor = false;
            this.knopAanmaken.Click += new System.EventHandler(this.knopAanmaken_Click);
            // 
            // knopAnnuleer
            // 
            this.knopAnnuleer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopAnnuleer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopAnnuleer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.knopAnnuleer.Location = new System.Drawing.Point(34, 273);
            this.knopAnnuleer.Name = "knopAnnuleer";
            this.knopAnnuleer.Size = new System.Drawing.Size(148, 35);
            this.knopAnnuleer.TabIndex = 9;
            this.knopAnnuleer.Text = "ANNULEER";
            this.knopAnnuleer.UseVisualStyleBackColor = false;
            this.knopAnnuleer.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.AutoSize = true;
            this.buttonAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.Location = new System.Drawing.Point(136, 233);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(128, 25);
            this.buttonAdmin.TabIndex = 10;
            this.buttonAdmin.TabStop = true;
            this.buttonAdmin.Text = "Project leider";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonGebruiker
            // 
            this.buttonGebruiker.AutoSize = true;
            this.buttonGebruiker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGebruiker.Location = new System.Drawing.Point(276, 233);
            this.buttonGebruiker.Name = "buttonGebruiker";
            this.buttonGebruiker.Size = new System.Drawing.Size(121, 25);
            this.buttonGebruiker.TabIndex = 11;
            this.buttonGebruiker.TabStop = true;
            this.buttonGebruiker.Text = "Project lijder";
            this.buttonGebruiker.UseVisualStyleBackColor = true;
            // 
            // labelGebruikersnaam
            // 
            this.labelGebruikersnaam.AutoSize = true;
            this.labelGebruikersnaam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGebruikersnaam.Location = new System.Drawing.Point(12, 23);
            this.labelGebruikersnaam.Name = "labelGebruikersnaam";
            this.labelGebruikersnaam.Size = new System.Drawing.Size(143, 21);
            this.labelGebruikersnaam.TabIndex = 12;
            this.labelGebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // veldGebruikersnaam
            // 
            this.veldGebruikersnaam.Location = new System.Drawing.Point(166, 23);
            this.veldGebruikersnaam.Name = "veldGebruikersnaam";
            this.veldGebruikersnaam.Size = new System.Drawing.Size(230, 20);
            this.veldGebruikersnaam.TabIndex = 13;
            this.veldGebruikersnaam.TextChanged += new System.EventHandler(this.veldGebruikersnaam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Functie:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manager",
            "Developer",
            "Tester",
            "Architect",
            "Designer"});
            this.comboBox1.Location = new System.Drawing.Point(166, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 29);
            this.comboBox1.TabIndex = 15;
            // 
            // ProjectLidToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 320);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.veldGebruikersnaam);
            this.Controls.Add(this.labelGebruikersnaam);
            this.Controls.Add(this.buttonGebruiker);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.knopAnnuleer);
            this.Controls.Add(this.knopAanmaken);
            this.Controls.Add(this.veldWachtwoord);
            this.Controls.Add(this.veldAchternaam);
            this.Controls.Add(this.veldVoornaam);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.labelWachtwoord);
            this.Controls.Add(this.labelAchternaam);
            this.Controls.Add(this.labelVoornaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectLidToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectLidToevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVoornaam;
        private System.Windows.Forms.Label labelAchternaam;
        private System.Windows.Forms.Label labelWachtwoord;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.TextBox veldVoornaam;
        private System.Windows.Forms.TextBox veldAchternaam;
        private System.Windows.Forms.TextBox veldWachtwoord;
        private System.Windows.Forms.Button knopAanmaken;
        private System.Windows.Forms.Button knopAnnuleer;
        private System.Windows.Forms.RadioButton buttonAdmin;
        private System.Windows.Forms.RadioButton buttonGebruiker;
        private System.Windows.Forms.Label labelGebruikersnaam;
        private System.Windows.Forms.TextBox veldGebruikersnaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}