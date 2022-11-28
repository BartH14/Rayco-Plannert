namespace RayCo_PMS_PC.Forms
{
    partial class ProjectBeheren
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
            this.knopMinimaliseer = new System.Windows.Forms.Button();
            this.KnopAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // knopMinimaliseer
            // 
            this.knopMinimaliseer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knopMinimaliseer.FlatAppearance.BorderSize = 0;
            this.knopMinimaliseer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knopMinimaliseer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopMinimaliseer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopMinimaliseer.Location = new System.Drawing.Point(1247, 0);
            this.knopMinimaliseer.Name = "knopMinimaliseer";
            this.knopMinimaliseer.Size = new System.Drawing.Size(40, 40);
            this.knopMinimaliseer.TabIndex = 3;
            this.knopMinimaliseer.Text = "-";
            this.knopMinimaliseer.UseVisualStyleBackColor = true;
            // 
            // KnopAfsluiten
            // 
            this.KnopAfsluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KnopAfsluiten.FlatAppearance.BorderSize = 0;
            this.KnopAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KnopAfsluiten.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnopAfsluiten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.KnopAfsluiten.Location = new System.Drawing.Point(1293, 0);
            this.KnopAfsluiten.Name = "KnopAfsluiten";
            this.KnopAfsluiten.Size = new System.Drawing.Size(40, 40);
            this.KnopAfsluiten.TabIndex = 2;
            this.KnopAfsluiten.Text = "X";
            this.KnopAfsluiten.UseVisualStyleBackColor = true;
            // 
            // ProjectBeheren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.knopMinimaliseer);
            this.Controls.Add(this.KnopAfsluiten);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ProjectBeheren";
            this.Text = "ProjectBeheren";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button knopMinimaliseer;
        private System.Windows.Forms.Button KnopAfsluiten;
    }
}