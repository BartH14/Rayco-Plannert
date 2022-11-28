namespace RayCo_PMS_PC.Forms
{
    partial class TaakBeheren
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
            System.Windows.Forms.Label label3;
            this.knopMinimaliseer = new System.Windows.Forms.Button();
            this.KnopAfsluiten = new System.Windows.Forms.Button();
            this.comboTakenLijst = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericDeclaratie = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.UrenDisplay = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericDeclaratie)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(163, 160);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 21);
            label3.TabIndex = 13;
            label3.Text = "Taak status:";
            // 
            // knopMinimaliseer
            // 
            this.knopMinimaliseer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knopMinimaliseer.FlatAppearance.BorderSize = 0;
            this.knopMinimaliseer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knopMinimaliseer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopMinimaliseer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopMinimaliseer.Location = new System.Drawing.Point(715, 0);
            this.knopMinimaliseer.Name = "knopMinimaliseer";
            this.knopMinimaliseer.Size = new System.Drawing.Size(39, 31);
            this.knopMinimaliseer.TabIndex = 5;
            this.knopMinimaliseer.Text = "-";
            this.knopMinimaliseer.UseVisualStyleBackColor = true;
            this.knopMinimaliseer.Click += new System.EventHandler(this.knopMinimaliseer_Click);
            // 
            // KnopAfsluiten
            // 
            this.KnopAfsluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KnopAfsluiten.FlatAppearance.BorderSize = 0;
            this.KnopAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KnopAfsluiten.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnopAfsluiten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.KnopAfsluiten.Location = new System.Drawing.Point(761, 0);
            this.KnopAfsluiten.Name = "KnopAfsluiten";
            this.KnopAfsluiten.Size = new System.Drawing.Size(39, 31);
            this.KnopAfsluiten.TabIndex = 4;
            this.KnopAfsluiten.Text = "X";
            this.KnopAfsluiten.UseVisualStyleBackColor = true;
            this.KnopAfsluiten.Click += new System.EventHandler(this.KnopAfsluiten_Click);
            // 
            // comboTakenLijst
            // 
            this.comboTakenLijst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboTakenLijst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTakenLijst.FormattingEnabled = true;
            this.comboTakenLijst.Location = new System.Drawing.Point(12, 52);
            this.comboTakenLijst.Name = "comboTakenLijst";
            this.comboTakenLijst.Size = new System.Drawing.Size(121, 371);
            this.comboTakenLijst.TabIndex = 8;
            this.comboTakenLijst.SelectedIndexChanged += new System.EventHandler(this.comboTakenLijst_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mijn taken:";
            // 
            // numericDeclaratie
            // 
            this.numericDeclaratie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericDeclaratie.DecimalPlaces = 1;
            this.numericDeclaratie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDeclaratie.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericDeclaratie.Location = new System.Drawing.Point(352, 107);
            this.numericDeclaratie.Name = "numericDeclaratie";
            this.numericDeclaratie.Size = new System.Drawing.Size(120, 23);
            this.numericDeclaratie.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Te declareren uren:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(226, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Boeken";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Totaal geboekte uren:";
            // 
            // UrenDisplay
            // 
            this.UrenDisplay.AutoSize = true;
            this.UrenDisplay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrenDisplay.Location = new System.Drawing.Point(348, 61);
            this.UrenDisplay.Name = "UrenDisplay";
            this.UrenDisplay.Size = new System.Drawing.Size(57, 21);
            this.UrenDisplay.TabIndex = 17;
            this.UrenDisplay.Text = "label5";
            // 
            // TaakBeheren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UrenDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericDeclaratie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboTakenLijst);
            this.Controls.Add(this.knopMinimaliseer);
            this.Controls.Add(this.KnopAfsluiten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaakBeheren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaakBeheren";
            this.Load += new System.EventHandler(this.TaakBeheren_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericDeclaratie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button knopMinimaliseer;
        private System.Windows.Forms.Button KnopAfsluiten;
        private System.Windows.Forms.ComboBox comboTakenLijst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericDeclaratie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UrenDisplay;
    }
}