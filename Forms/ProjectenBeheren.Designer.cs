namespace RayCo_PMS_PC.Forms
{
    partial class ProjectenBeheren
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
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.knopVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboProject
            // 
            this.comboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProject.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Location = new System.Drawing.Point(12, 65);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(149, 29);
            this.comboProject.Sorted = true;
            this.comboProject.TabIndex = 14;
            this.comboProject.SelectedIndexChanged += new System.EventHandler(this.comboProject_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Selecteer Project:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // knopVerwijderen
            // 
            this.knopVerwijderen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knopVerwijderen.Location = new System.Drawing.Point(12, 130);
            this.knopVerwijderen.Name = "knopVerwijderen";
            this.knopVerwijderen.Size = new System.Drawing.Size(141, 35);
            this.knopVerwijderen.TabIndex = 16;
            this.knopVerwijderen.Text = "VERWIJDEREN";
            this.knopVerwijderen.UseVisualStyleBackColor = true;
            this.knopVerwijderen.Click += new System.EventHandler(this.knopVerwijderen_Click);
            // 
            // ProjectenBeheren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 418);
            this.Controls.Add(this.knopVerwijderen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectenBeheren";
            this.Text = "ProjectenBeheren";
            this.Load += new System.EventHandler(this.ProjectenBeheren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button knopVerwijderen;
    }
}