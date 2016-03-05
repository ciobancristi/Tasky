namespace Tasky
{
    partial class HomeForm
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
            this.panicButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panicButton
            // 
            this.panicButton.Location = new System.Drawing.Point(210, 211);
            this.panicButton.Name = "panicButton";
            this.panicButton.Size = new System.Drawing.Size(75, 23);
            this.panicButton.TabIndex = 0;
            this.panicButton.Text = "Crash it";
            this.panicButton.UseVisualStyleBackColor = true;
            this.panicButton.Click += new System.EventHandler(this.panicButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panicButton);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button panicButton;
    }
}