namespace Tasky
{
    partial class AddProjectForm
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
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.usersLabel = new System.Windows.Forms.Label();
            this.projectNameTexBox = new System.Windows.Forms.TextBox();
            this.addProjectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.taskCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.userCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.clientsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectNameLabel.Location = new System.Drawing.Point(125, 54);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(45, 16);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Name";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientNameLabel.Location = new System.Drawing.Point(125, 110);
            this.clientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(41, 16);
            this.clientNameLabel.TabIndex = 1;
            this.clientNameLabel.Text = "Client";
            // 
            // tasksLabel
            // 
            this.tasksLabel.AutoSize = true;
            this.tasksLabel.BackColor = System.Drawing.Color.Transparent;
            this.tasksLabel.Location = new System.Drawing.Point(125, 161);
            this.tasksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(46, 16);
            this.tasksLabel.TabIndex = 3;
            this.tasksLabel.Text = "Tasks";
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.BackColor = System.Drawing.Color.Transparent;
            this.usersLabel.Location = new System.Drawing.Point(125, 306);
            this.usersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(44, 16);
            this.usersLabel.TabIndex = 4;
            this.usersLabel.Text = "Users";
            // 
            // projectNameTexBox
            // 
            this.projectNameTexBox.Location = new System.Drawing.Point(192, 54);
            this.projectNameTexBox.Margin = new System.Windows.Forms.Padding(4);
            this.projectNameTexBox.Name = "projectNameTexBox";
            this.projectNameTexBox.Size = new System.Drawing.Size(217, 22);
            this.projectNameTexBox.TabIndex = 5;
            // 
            // addProjectButton
            // 
            this.addProjectButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProjectButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProjectButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addProjectButton.Location = new System.Drawing.Point(113, 466);
            this.addProjectButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(105, 37);
            this.addProjectButton.TabIndex = 8;
            this.addProjectButton.Text = "Add Project";
            this.addProjectButton.UseVisualStyleBackColor = false;
            this.addProjectButton.Click += new System.EventHandler(this.addProjectButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cancelButton.Location = new System.Drawing.Point(325, 466);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(103, 37);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // taskCheckedListBox
            // 
            this.taskCheckedListBox.FormattingEnabled = true;
            this.taskCheckedListBox.Location = new System.Drawing.Point(192, 161);
            this.taskCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.taskCheckedListBox.Name = "taskCheckedListBox";
            this.taskCheckedListBox.Size = new System.Drawing.Size(217, 106);
            this.taskCheckedListBox.TabIndex = 10;
            // 
            // userCheckedListBox
            // 
            this.userCheckedListBox.FormattingEnabled = true;
            this.userCheckedListBox.Location = new System.Drawing.Point(192, 306);
            this.userCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.userCheckedListBox.Name = "userCheckedListBox";
            this.userCheckedListBox.Size = new System.Drawing.Size(217, 106);
            this.userCheckedListBox.TabIndex = 11;
            // 
            // clientsComboBox
            // 
            this.clientsComboBox.FormattingEnabled = true;
            this.clientsComboBox.Location = new System.Drawing.Point(192, 107);
            this.clientsComboBox.Name = "clientsComboBox";
            this.clientsComboBox.Size = new System.Drawing.Size(217, 24);
            this.clientsComboBox.TabIndex = 12;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tasky.Properties.Resources.rauzcdht;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 561);
            this.Controls.Add(this.clientsComboBox);
            this.Controls.Add(this.userCheckedListBox);
            this.Controls.Add(this.taskCheckedListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addProjectButton);
            this.Controls.Add(this.projectNameTexBox);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.tasksLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.projectNameLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label tasksLabel;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.TextBox projectNameTexBox;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckedListBox taskCheckedListBox;
        private System.Windows.Forms.CheckedListBox userCheckedListBox;
        private System.Windows.Forms.ComboBox clientsComboBox;
    }
}