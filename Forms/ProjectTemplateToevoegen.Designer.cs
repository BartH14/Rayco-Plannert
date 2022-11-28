namespace RayCo_PMS_PC.Forms
{
    partial class ProjectTemplateToevoegen
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
            this.KnopAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KnopAfsluiten
            // 
            this.KnopAfsluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KnopAfsluiten.FlatAppearance.BorderSize = 0;
            this.KnopAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KnopAfsluiten.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnopAfsluiten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.KnopAfsluiten.Location = new System.Drawing.Point(761, -1);
            this.KnopAfsluiten.Name = "KnopAfsluiten";
            this.KnopAfsluiten.Size = new System.Drawing.Size(39, 31);
            this.KnopAfsluiten.TabIndex = 6;
            this.KnopAfsluiten.Text = "X";
            this.KnopAfsluiten.UseVisualStyleBackColor = true;
            this.KnopAfsluiten.Click += new System.EventHandler(this.KnopAfsluiten_Click_1);
            // 
            // ProjectTemplateToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KnopAfsluiten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectTemplateToevoegen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectTemplateToevoegen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KnopAfsluiten;
    }
}