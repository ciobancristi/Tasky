﻿namespace Tasky
{
    partial class AdminProjectsForm
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
            this.addProjectButton = new System.Windows.Forms.Button();
            this.projectsDataGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addProjectButton
            // 
            this.addProjectButton.Location = new System.Drawing.Point(90, 347);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(75, 23);
            this.addProjectButton.TabIndex = 0;
            this.addProjectButton.Text = "Add Project";
            this.addProjectButton.UseVisualStyleBackColor = true;
            this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // projectsDataGridView
            // 
            this.projectsDataGridView.AllowUserToAddRows = false;
            this.projectsDataGridView.AllowUserToDeleteRows = false;
            this.projectsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.projectsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.projectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.projectsDataGridView.Name = "projectsDataGridView";
            this.projectsDataGridView.ReadOnly = true;
            this.projectsDataGridView.Size = new System.Drawing.Size(461, 285);
            this.projectsDataGridView.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(339, 347);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AdminProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 416);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.projectsDataGridView);
            this.Controls.Add(this.addProjectButton);
            this.Name = "AdminProjectsForm";
            this.Text = "AdminProjectsForm";
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.DataGridView projectsDataGridView;
        private System.Windows.Forms.Button closeButton;
    }
}