namespace RayCo_PMS_PC.Forms
{
    partial class ProjectLedenOverzicht
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.knopMinimaliseer = new System.Windows.Forms.Button();
            this.KnopAfsluiten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(928, 622);
            this.dataGridView1.TabIndex = 0;
            // 
            // knopMinimaliseer
            // 
            this.knopMinimaliseer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knopMinimaliseer.FlatAppearance.BorderSize = 0;
            this.knopMinimaliseer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knopMinimaliseer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopMinimaliseer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopMinimaliseer.Location = new System.Drawing.Point(870, 0);
            this.knopMinimaliseer.Name = "knopMinimaliseer";
            this.knopMinimaliseer.Size = new System.Drawing.Size(39, 31);
            this.knopMinimaliseer.TabIndex = 3;
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
            this.KnopAfsluiten.Location = new System.Drawing.Point(916, 0);
            this.KnopAfsluiten.Name = "KnopAfsluiten";
            this.KnopAfsluiten.Size = new System.Drawing.Size(39, 31);
            this.KnopAfsluiten.TabIndex = 2;
            this.KnopAfsluiten.Text = "X";
            this.KnopAfsluiten.UseVisualStyleBackColor = true;
            this.KnopAfsluiten.Click += new System.EventHandler(this.KnopAfsluiten_Click);
            // 
            // ProjectLedenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 683);
            this.Controls.Add(this.knopMinimaliseer);
            this.Controls.Add(this.KnopAfsluiten);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectLedenOverzicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectLedenOverzicht";
            this.Load += new System.EventHandler(this.ProjectLedenOverzicht_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button knopMinimaliseer;
        private System.Windows.Forms.Button KnopAfsluiten;
    }
}