namespace RayCo_PMS_PC.Forms
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startschermToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectenBekijkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectledenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectledenBeherenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takenBeherenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knopMinimaliseer = new System.Windows.Forms.Button();
            this.KnopAfsluiten = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startschermToolStripMenuItem,
            this.projectenToolStripMenuItem,
            this.projectledenToolStripMenuItem,
            this.takenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startschermToolStripMenuItem
            // 
            this.startschermToolStripMenuItem.Name = "startschermToolStripMenuItem";
            this.startschermToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.startschermToolStripMenuItem.Text = "Startscherm";
            // 
            // projectenToolStripMenuItem
            // 
            this.projectenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectenBekijkenToolStripMenuItem});
            this.projectenToolStripMenuItem.Name = "projectenToolStripMenuItem";
            this.projectenToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.projectenToolStripMenuItem.Text = "Projecten";
            // 
            // projectenBekijkenToolStripMenuItem
            // 
            this.projectenBekijkenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.projectenBekijkenToolStripMenuItem.Name = "projectenBekijkenToolStripMenuItem";
            this.projectenBekijkenToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.projectenBekijkenToolStripMenuItem.Text = "Projecten bekijken";
            this.projectenBekijkenToolStripMenuItem.Click += new System.EventHandler(this.projectenBekijkenToolStripMenuItem_Click);
            // 
            // projectledenToolStripMenuItem
            // 
            this.projectledenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectledenBeherenToolStripMenuItem});
            this.projectledenToolStripMenuItem.Name = "projectledenToolStripMenuItem";
            this.projectledenToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.projectledenToolStripMenuItem.Text = "Projectleden";
            // 
            // projectledenBeherenToolStripMenuItem
            // 
            this.projectledenBeherenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.projectledenBeherenToolStripMenuItem.Name = "projectledenBeherenToolStripMenuItem";
            this.projectledenBeherenToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.projectledenBeherenToolStripMenuItem.Text = "Projectleden bekijken";
            this.projectledenBeherenToolStripMenuItem.Click += new System.EventHandler(this.projectledenBeherenToolStripMenuItem_Click);
            // 
            // takenToolStripMenuItem
            // 
            this.takenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.takenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takenBeherenToolStripMenuItem});
            this.takenToolStripMenuItem.Name = "takenToolStripMenuItem";
            this.takenToolStripMenuItem.Size = new System.Drawing.Size(69, 25);
            this.takenToolStripMenuItem.Text = "Taken";
            // 
            // takenBeherenToolStripMenuItem
            // 
            this.takenBeherenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.takenBeherenToolStripMenuItem.Name = "takenBeherenToolStripMenuItem";
            this.takenBeherenToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.takenBeherenToolStripMenuItem.Text = "Taken beheren";
            this.takenBeherenToolStripMenuItem.Click += new System.EventHandler(this.takenBeherenToolStripMenuItem_Click);
            // 
            // knopMinimaliseer
            // 
            this.knopMinimaliseer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.knopMinimaliseer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.knopMinimaliseer.FlatAppearance.BorderSize = 0;
            this.knopMinimaliseer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knopMinimaliseer.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopMinimaliseer.ForeColor = System.Drawing.Color.Black;
            this.knopMinimaliseer.Location = new System.Drawing.Point(1182, 0);
            this.knopMinimaliseer.Name = "knopMinimaliseer";
            this.knopMinimaliseer.Size = new System.Drawing.Size(40, 29);
            this.knopMinimaliseer.TabIndex = 3;
            this.knopMinimaliseer.Text = "-";
            this.knopMinimaliseer.UseVisualStyleBackColor = false;
            this.knopMinimaliseer.Click += new System.EventHandler(this.knopMinimaliseer_Click);
            // 
            // KnopAfsluiten
            // 
            this.KnopAfsluiten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.KnopAfsluiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KnopAfsluiten.FlatAppearance.BorderSize = 0;
            this.KnopAfsluiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KnopAfsluiten.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnopAfsluiten.ForeColor = System.Drawing.Color.Black;
            this.KnopAfsluiten.Location = new System.Drawing.Point(1228, 0);
            this.KnopAfsluiten.Name = "KnopAfsluiten";
            this.KnopAfsluiten.Size = new System.Drawing.Size(40, 29);
            this.KnopAfsluiten.TabIndex = 2;
            this.KnopAfsluiten.Text = "X";
            this.KnopAfsluiten.UseVisualStyleBackColor = false;
            this.KnopAfsluiten.Click += new System.EventHandler(this.KnopAfsluiten_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 722);
            this.Controls.Add(this.knopMinimaliseer);
            this.Controls.Add(this.KnopAfsluiten);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startschermToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectenBekijkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectledenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectledenBeherenToolStripMenuItem;
        private System.Windows.Forms.Button knopMinimaliseer;
        private System.Windows.Forms.Button KnopAfsluiten;
        private System.Windows.Forms.ToolStripMenuItem takenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takenBeherenToolStripMenuItem;
    }
}