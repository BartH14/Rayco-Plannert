namespace RayCo_PMS_PC.Forms
{
    partial class ProjectToevoegen
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
            this.veldProjectnaam = new System.Windows.Forms.TextBox();
            this.knopAanmaken = new System.Windows.Forms.Button();
            this.knopAnnuleer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNaam
            // 
            this.labelNaam.AutoSize = true;
            this.labelNaam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaam.Location = new System.Drawing.Point(12, 46);
            this.labelNaam.Name = "labelNaam";
            this.labelNaam.Size = new System.Drawing.Size(119, 21);
            this.labelNaam.TabIndex = 0;
            this.labelNaam.Text = "Project naam:";
            this.labelNaam.Click += new System.EventHandler(this.label1_Click);
            // 
            // veldProjectnaam
            // 
            this.veldProjectnaam.Location = new System.Drawing.Point(171, 49);
            this.veldProjectnaam.Name = "veldProjectnaam";
            this.veldProjectnaam.Size = new System.Drawing.Size(191, 20);
            this.veldProjectnaam.TabIndex = 6;
            // 
            // knopAanmaken
            // 
            this.knopAanmaken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopAanmaken.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopAanmaken.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.knopAanmaken.Location = new System.Drawing.Point(249, 135);
            this.knopAanmaken.Name = "knopAanmaken";
            this.knopAanmaken.Size = new System.Drawing.Size(148, 35);
            this.knopAanmaken.TabIndex = 9;
            this.knopAanmaken.Text = "AANMAKEN";
            this.knopAanmaken.UseVisualStyleBackColor = false;
            this.knopAanmaken.Click += new System.EventHandler(this.knopAanmaken_Click);
            // 
            // knopAnnuleer
            // 
            this.knopAnnuleer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopAnnuleer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopAnnuleer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.knopAnnuleer.Location = new System.Drawing.Point(60, 135);
            this.knopAnnuleer.Name = "knopAnnuleer";
            this.knopAnnuleer.Size = new System.Drawing.Size(148, 35);
            this.knopAnnuleer.TabIndex = 10;
            this.knopAnnuleer.Text = "ANNULEER";
            this.knopAnnuleer.UseVisualStyleBackColor = false;
            this.knopAnnuleer.Click += new System.EventHandler(this.knopAnnuleer_Click);
            // 
            // ProjectToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 192);
            this.Controls.Add(this.knopAnnuleer);
            this.Controls.Add(this.knopAanmaken);
            this.Controls.Add(this.veldProjectnaam);
            this.Controls.Add(this.labelNaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectToevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaam;
        private System.Windows.Forms.TextBox veldProjectnaam;
        private System.Windows.Forms.Button knopAanmaken;
        private System.Windows.Forms.Button knopAnnuleer;
    }
}