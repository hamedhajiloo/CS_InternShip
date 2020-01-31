namespace P11_WinForm
{
    partial class Form1
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
            this.Test = new System.Windows.Forms.Button();
            this.headerListTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(1, 12);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 0;
            this.Test.Text = "Clicke Me";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // headerListTextBox
            // 
            this.headerListTextBox.Location = new System.Drawing.Point(105, 15);
            this.headerListTextBox.Multiline = true;
            this.headerListTextBox.Name = "headerListTextBox";
            this.headerListTextBox.Size = new System.Drawing.Size(354, 259);
            this.headerListTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 339);
            this.Controls.Add(this.headerListTextBox);
            this.Controls.Add(this.Test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.TextBox headerListTextBox;
    }
}

