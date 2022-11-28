namespace RayCo_PMS_PC.Forms
{
    partial class TaakToevoegen
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
            this.labelNaam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tijdIndicator = new System.Windows.Forms.NumericUpDown();
            this.veldTaakNaam = new System.Windows.Forms.TextBox();
            this.knopAnnuleer = new System.Windows.Forms.Button();
            this.knopAanmaken = new System.Windows.Forms.Button();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.comboGebruiker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tijdIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaam
            // 
            this.labelNaam.AutoSize = true;
            this.labelNaam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaam.Location = new System.Drawing.Point(12, 38);
            this.labelNaam.Name = "labelNaam";
            this.labelNaam.Size = new System.Drawing.Size(99, 21);
            this.labelNaam.TabIndex = 0;
            this.labelNaam.Text = "Taaknaam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verwachte uren:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gekoppelde gebruiker:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gekoppelde project:";
            // 
            // tijdIndicator
            // 
            this.tijdIndicator.DecimalPlaces = 1;
            this.tijdIndicator.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tijdIndicator.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.tijdIndicator.Location = new System.Drawing.Point(218, 157);
            this.tijdIndicator.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tijdIndicator.Name = "tijdIndicator";
            this.tijdIndicator.Size = new System.Drawing.Size(120, 27);
            this.tijdIndicator.TabIndex = 4;
            // 
            // veldTaakNaam
            // 
            this.veldTaakNaam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veldTaakNaam.Location = new System.Drawing.Point(218, 41);
            this.veldTaakNaam.Name = "veldTaakNaam";
            this.veldTaakNaam.Size = new System.Drawing.Size(149, 27);
            this.veldTaakNaam.TabIndex = 5;
            this.veldTaakNaam.UseWaitCursor = true;
            // 
            // knopAnnuleer
            // 
            this.knopAnnuleer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopAnnuleer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopAnnuleer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.knopAnnuleer.Location = new System.Drawing.Point(36, 210);
            this.knopAnnuleer.Name = "knopAnnuleer";
            this.knopAnnuleer.Size = new System.Drawing.Size(148, 35);
            this.knopAnnuleer.TabIndex = 11;
            this.knopAnnuleer.Text = "ANNULEER";
            this.knopAnnuleer.UseVisualStyleBackColor = false;
            this.knopAnnuleer.Click += new System.EventHandler(this.knopAnnuleer_Click);
            // 
            // knopAanmaken
            // 
            this.knopAanmaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopAanmaken.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopAanmaken.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.knopAanmaken.Location = new System.Drawing.Point(219, 210);
            this.knopAanmaken.Name = "knopAanmaken";
            this.knopAanmaken.Size = new System.Drawing.Size(148, 35);
            this.knopAanmaken.TabIndex = 12;
            this.knopAanmaken.Text = "AANMAKEN";
            this.knopAanmaken.UseVisualStyleBackColor = false;
            this.knopAanmaken.Click += new System.EventHandler(this.knopAanmaken_Click);
            // 
            // comboProject
            // 
            this.comboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Location = new System.Drawing.Point(218, 76);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(149, 29);
            this.comboProject.Sorted = true;
            this.comboProject.TabIndex = 13;
            this.comboProject.SelectedIndexChanged += new System.EventHandler(this.comboProject_SelectedIndexChanged);
            // 
            // comboGebruiker
            // 
            this.comboGebruiker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGebruiker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGebruiker.FormattingEnabled = true;
            this.comboGebruiker.Location = new System.Drawing.Point(219, 118);
            this.comboGebruiker.Name = "comboGebruiker";
            this.comboGebruiker.Size = new System.Drawing.Size(149, 29);
            this.comboGebruiker.TabIndex = 14;
            // 
            // TaakToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 306);
            this.Controls.Add(this.comboGebruiker);
            this.Controls.Add(this.comboProject);
            this.Controls.Add(this.knopAanmaken);
            this.Controls.Add(this.knopAnnuleer);
            this.Controls.Add(this.veldTaakNaam);
            this.Controls.Add(this.tijdIndicator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaakToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaakToevoegen";
            this.Load += new System.EventHandler(this.TaakToevoegen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tijdIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tijdIndicator;
        private System.Windows.Forms.TextBox veldTaakNaam;
        private System.Windows.Forms.Button knopAnnuleer;
        private System.Windows.Forms.Button knopAanmaken;
        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.ComboBox comboGebruiker;
    }
}