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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.addTaskActivityButton = new System.Windows.Forms.Button();
            this.tasksComboBox = new System.Windows.Forms.ComboBox();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(242, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.titleLabel.ForeColor = System.Drawing.Color.Maroon;
            this.titleLabel.Location = new System.Drawing.Point(177, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(926, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Add task activity for selected date ";
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.ForeColor = System.Drawing.Color.Maroon;
            this.projectLabel.Location = new System.Drawing.Point(171, 129);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(52, 17);
            this.projectLabel.TabIndex = 2;
            this.projectLabel.Text = "Project";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.ForeColor = System.Drawing.Color.Maroon;
            this.taskLabel.Location = new System.Drawing.Point(184, 171);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(39, 17);
            this.taskLabel.TabIndex = 3;
            this.taskLabel.Text = "Task";
            // 
            // hoursWorkedDateTimePicker
            // 
            this.hoursWorkedDateTimePicker.AutoSize = true;
            this.hoursWorkedDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.hoursWorkedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedDateTimePicker.ForeColor = System.Drawing.Color.Maroon;
            this.hoursWorkedDateTimePicker.Location = new System.Drawing.Point(175, 212);
            this.hoursWorkedDateTimePicker.Name = "hoursWorkedDateTimePicker";
            this.hoursWorkedDateTimePicker.Size = new System.Drawing.Size(46, 17);
            this.hoursWorkedDateTimePicker.TabIndex = 4;
            this.hoursWorkedDateTimePicker.Text = "Hours";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.BackColor = System.Drawing.Color.Transparent;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.ForeColor = System.Drawing.Color.Maroon;
            this.commentsLabel.Location = new System.Drawing.Point(150, 265);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(74, 17);
            this.commentsLabel.TabIndex = 5;
            this.commentsLabel.Text = "Comments";
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTextBox.Location = new System.Drawing.Point(243, 209);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(121, 22);
            this.hoursTextBox.TabIndex = 6;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsTextBox.Location = new System.Drawing.Point(243, 261);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(342, 39);
            this.commentsTextBox.TabIndex = 9;
            this.commentsTextBox.Text = "";
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.AllowUserToAddRows = false;
            this.activitiesDataGridView.AllowUserToDeleteRows = false;
            this.activitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activitiesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.activitiesDataGridView.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.activitiesDataGridView.Location = new System.Drawing.Point(243, 320);
            this.activitiesDataGridView.MultiSelect = false;
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activitiesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.activitiesDataGridView.Size = new System.Drawing.Size(361, 123);
            this.activitiesDataGridView.TabIndex = 10;
            // 
            // myActivityLabel
            // 
            this.myActivityLabel.AutoSize = true;
            this.myActivityLabel.BackColor = System.Drawing.Color.Transparent;
            this.myActivityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myActivityLabel.ForeColor = System.Drawing.Color.Maroon;
            this.myActivityLabel.Location = new System.Drawing.Point(145, 320);
            this.myActivityLabel.Name = "myActivityLabel";
            this.myActivityLabel.Size = new System.Drawing.Size(74, 17);
            this.myActivityLabel.TabIndex = 11;
            this.myActivityLabel.Text = "My Activity";
            // 
            // addTaskActivityButton
            // 
            this.addTaskActivityButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addTaskActivityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskActivityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskActivityButton.ForeColor = System.Drawing.Color.Indigo;
            this.addTaskActivityButton.Location = new System.Drawing.Point(483, 506);
            this.addTaskActivityButton.Name = "addTaskActivityButton";
            this.addTaskActivityButton.Size = new System.Drawing.Size(121, 27);
            this.addTaskActivityButton.TabIndex = 13;
            this.addTaskActivityButton.Text = "Add Task Activity";
            this.addTaskActivityButton.UseVisualStyleBackColor = false;
            this.addTaskActivityButton.Click += new System.EventHandler(this.addTaskActivityButton_Click);
            // 
            // tasksComboBox
            // 
            this.tasksComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksComboBox.FormattingEnabled = true;
            this.tasksComboBox.Location = new System.Drawing.Point(243, 168);
            this.tasksComboBox.Name = "tasksComboBox";
            this.tasksComboBox.Size = new System.Drawing.Size(148, 24);
            this.tasksComboBox.TabIndex = 15;
            // 
            // projectComboBox
            // 
            this.projectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(243, 126);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(121, 24);
            this.projectComboBox.TabIndex = 16;
            this.projectComboBox.SelectedIndexChanged += new System.EventHandler(this.projectComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 560);
            this.panel2.TabIndex = 17;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(47, 526);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "log out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Maroon;
            this.button5.Location = new System.Drawing.Point(11, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "Message Users";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(10, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 30);
            this.button4.TabIndex = 10;
            this.button4.Text = "Projects";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Maroon;
            this.button6.Location = new System.Drawing.Point(10, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 30);
            this.button6.TabIndex = 9;
            this.button6.Text = "Client";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Tasky.Properties.Resources.tasky_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(10, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 91);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Maroon;
            this.button7.Location = new System.Drawing.Point(11, 242);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 30);
            this.button7.TabIndex = 3;
            this.button7.Text = "Users";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Maroon;
            this.button8.Location = new System.Drawing.Point(10, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 30);
            this.button8.TabIndex = 5;
            this.button8.Text = "Log Hours";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(11, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 128);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "full name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tasky.Properties.Resources.default_user_image;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(184, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date";
            // 
            // TimeCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.tasksComboBox);
            this.Controls.Add(this.addTaskActivityButton);
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
            this.DoubleBuffered = true;
            this.Name = "TimeCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TimeCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button addTaskActivityButton;
        private System.Windows.Forms.ComboBox tasksComboBox;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}