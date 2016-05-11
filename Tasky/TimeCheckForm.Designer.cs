namespace Tasky
{
    partial class TimeCheckForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.hoursWorkedDateTimePicker = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.commentsTextBox = new System.Windows.Forms.RichTextBox();
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.myActivityLabel = new System.Windows.Forms.Label();
            this.noActivityLabel = new System.Windows.Forms.Label();
            this.addTaskActivityButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.tasksComboBox = new System.Windows.Forms.ComboBox();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(103, 77);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(97, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(258, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Add task activity for ";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.Location = new System.Drawing.Point(100, 135);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(50, 16);
            this.projectLabel.TabIndex = 2;
            this.projectLabel.Text = "Project";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.Location = new System.Drawing.Point(327, 135);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(39, 16);
            this.taskLabel.TabIndex = 3;
            this.taskLabel.Text = "Task";
            // 
            // hoursWorkedDateTimePicker
            // 
            this.hoursWorkedDateTimePicker.AutoSize = true;
            this.hoursWorkedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedDateTimePicker.Location = new System.Drawing.Point(528, 135);
            this.hoursWorkedDateTimePicker.Name = "hoursWorkedDateTimePicker";
            this.hoursWorkedDateTimePicker.Size = new System.Drawing.Size(44, 16);
            this.hoursWorkedDateTimePicker.TabIndex = 4;
            this.hoursWorkedDateTimePicker.Text = "Hours";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(100, 186);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(72, 16);
            this.commentsLabel.TabIndex = 5;
            this.commentsLabel.Text = "Comments";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextBox.Location = new System.Drawing.Point(578, 132);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(121, 22);
            this.hoursTextBox.TabIndex = 6;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.Location = new System.Drawing.Point(178, 186);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(317, 91);
            this.commentsTextBox.TabIndex = 9;
            this.commentsTextBox.Text = "";
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Location = new System.Drawing.Point(108, 325);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.Size = new System.Drawing.Size(575, 150);
            this.activitiesDataGridView.TabIndex = 10;
            // 
            // myActivityLabel
            // 
            this.myActivityLabel.AutoSize = true;
            this.myActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myActivityLabel.Location = new System.Drawing.Point(104, 302);
            this.myActivityLabel.Name = "myActivityLabel";
            this.myActivityLabel.Size = new System.Drawing.Size(82, 20);
            this.myActivityLabel.TabIndex = 11;
            this.myActivityLabel.Text = "My Activity";
            // 
            // noActivityLabel
            // 
            this.noActivityLabel.AutoSize = true;
            this.noActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noActivityLabel.Location = new System.Drawing.Point(105, 336);
            this.noActivityLabel.Name = "noActivityLabel";
            this.noActivityLabel.Size = new System.Drawing.Size(158, 16);
            this.noActivityLabel.TabIndex = 12;
            this.noActivityLabel.Text = "No Activity Added Today";
            this.noActivityLabel.Visible = false;
            // 
            // addTaskActivityButton
            // 
            this.addTaskActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskActivityButton.Location = new System.Drawing.Point(578, 254);
            this.addTaskActivityButton.Name = "addTaskActivityButton";
            this.addTaskActivityButton.Size = new System.Drawing.Size(100, 23);
            this.addTaskActivityButton.TabIndex = 13;
            this.addTaskActivityButton.Text = "Add Task Activity";
            this.addTaskActivityButton.UseVisualStyleBackColor = true;
            this.addTaskActivityButton.Click += new System.EventHandler(this.addTaskActivityButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(578, 496);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 23);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // tasksComboBox
            // 
            this.tasksComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksComboBox.FormattingEnabled = true;
            this.tasksComboBox.Location = new System.Drawing.Point(372, 132);
            this.tasksComboBox.Name = "tasksComboBox";
            this.tasksComboBox.Size = new System.Drawing.Size(121, 24);
            this.tasksComboBox.TabIndex = 15;
            // 
            // projectComboBox
            // 
            this.projectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(156, 132);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(121, 24);
            this.projectComboBox.TabIndex = 16;
            // 
            // TimeCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.tasksComboBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addTaskActivityButton);
            this.Controls.Add(this.noActivityLabel);
            this.Controls.Add(this.myActivityLabel);
            this.Controls.Add(this.activitiesDataGridView);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.hoursWorkedDateTimePicker);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "TimeCheckForm";
            this.Text = "TimeCheckForm";
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label hoursWorkedDateTimePicker;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.RichTextBox commentsTextBox;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.Label myActivityLabel;
        private System.Windows.Forms.Label noActivityLabel;
        private System.Windows.Forms.Button addTaskActivityButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox tasksComboBox;
        private System.Windows.Forms.ComboBox projectComboBox;
    }
}