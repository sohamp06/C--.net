namespace Assignment5
{
    partial class AboutDCRegistationApp
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
            this.aboutDCAppButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // aboutDCAppButton
            // 
            this.aboutDCAppButton.Location = new System.Drawing.Point(401, 432);
            this.aboutDCAppButton.Name = "aboutDCAppButton";
            this.aboutDCAppButton.Size = new System.Drawing.Size(90, 40);
            this.aboutDCAppButton.TabIndex = 2;
            this.aboutDCAppButton.Text = "Exit ";
            this.aboutDCAppButton.UseVisualStyleBackColor = true;
            this.aboutDCAppButton.Click += new System.EventHandler(this.aboutDCAppButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(100, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(726, 309);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // AboutDCRegistationApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 505);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.aboutDCAppButton);
            this.Name = "AboutDCRegistationApp";
            this.Text = "AboutDCRegistationApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aboutDCAppButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}