namespace Assignment1
{
    partial class salesCalculator
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
            this.inputSale = new System.Windows.Forms.TextBox();
            this.result_sale = new System.Windows.Forms.TextBox();
            this.videogame_sale = new System.Windows.Forms.Label();
            this.number_day = new System.Windows.Forms.Label();
            this.listSales = new System.Windows.Forms.ListView();
            this.EnterButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputSale
            // 
            this.inputSale.BackColor = System.Drawing.SystemColors.Control;
            this.inputSale.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inputSale.Location = new System.Drawing.Point(236, 52);
            this.inputSale.Name = "inputSale";
            this.inputSale.Size = new System.Drawing.Size(100, 26);
            this.inputSale.TabIndex = 0;
            // 
            // result_sale
            // 
            this.result_sale.AcceptsTab = true;
            this.result_sale.BackColor = System.Drawing.SystemColors.Control;
            this.result_sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_sale.Location = new System.Drawing.Point(169, 293);
            this.result_sale.Name = "result_sale";
            this.result_sale.ReadOnly = true;
            this.result_sale.Size = new System.Drawing.Size(479, 26);
            this.result_sale.TabIndex = 2;
            this.result_sale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // videogame_sale
            // 
            this.videogame_sale.AutoSize = true;
            this.videogame_sale.Location = new System.Drawing.Point(87, 53);
            this.videogame_sale.Name = "videogame_sale";
            this.videogame_sale.Size = new System.Drawing.Size(134, 20);
            this.videogame_sale.TabIndex = 6;
            this.videogame_sale.Text = "Video Game Sale";
            // 
            // number_day
            // 
            this.number_day.AutoSize = true;
            this.number_day.Location = new System.Drawing.Point(636, 58);
            this.number_day.Name = "number_day";
            this.number_day.Size = new System.Drawing.Size(81, 20);
            this.number_day.TabIndex = 7;
            this.number_day.Text = "Day 1 to 7";
            // 
            // listSales
            // 
            this.listSales.BackColor = System.Drawing.SystemColors.Info;
            this.listSales.FullRowSelect = true;
            this.listSales.HideSelection = false;
            this.listSales.Location = new System.Drawing.Point(247, 117);
            this.listSales.Name = "listSales";
            this.listSales.Size = new System.Drawing.Size(297, 152);
            this.listSales.TabIndex = 8;
            this.listSales.UseCompatibleStateImageBehavior = false;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.Control;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.EnterButton.Location = new System.Drawing.Point(91, 354);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(91, 45);
            this.EnterButton.TabIndex = 9;
            this.EnterButton.Text = "&Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.SystemColors.Control;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ResetButton.Location = new System.Drawing.Point(364, 354);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(97, 45);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Control;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(640, 354);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(77, 45);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // salesCalculator
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.listSales);
            this.Controls.Add(this.number_day);
            this.Controls.Add(this.videogame_sale);
            this.Controls.Add(this.result_sale);
            this.Controls.Add(this.inputSale);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "salesCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Game sales Calculator";
            this.Load += new System.EventHandler(this.salesCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputSale;
        private System.Windows.Forms.TextBox result_sale;
        private System.Windows.Forms.Label videogame_sale;
        private System.Windows.Forms.Label number_day;
        private System.Windows.Forms.ListView listSales;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

