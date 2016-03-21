namespace Tasky
{
    partial class AdminEmailForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sendButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(174, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(104, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Send emails to users";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(92, 95);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(26, 13);
            this.toLabel.TabIndex = 1;
            this.toLabel.Text = "To: ";
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(69, 146);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(49, 13);
            this.subjectLabel.TabIndex = 2;
            this.subjectLabel.Text = "Subject: ";
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(35, 193);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(83, 13);
            this.bodyLabel.TabIndex = 3;
            this.bodyLabel.Text = "Message Body: ";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(142, 87);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(236, 20);
            this.toTextBox.TabIndex = 4;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(142, 146);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(236, 20);
            this.subjectTextBox.TabIndex = 5;
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Location = new System.Drawing.Point(142, 193);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.Size = new System.Drawing.Size(236, 199);
            this.bodyTextBox.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(472, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel1.Text = "Tasky";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(142, 399);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(235, 38);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Send mail";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // adminEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 549);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminEmailForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label bodyLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button sendButton;
    }
}