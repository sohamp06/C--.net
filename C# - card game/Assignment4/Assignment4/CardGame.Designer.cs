namespace Assignment4
{
    partial class CardGame
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_customButton = new System.Windows.Forms.Button();
            this.rankBox = new System.Windows.Forms.TextBox();
            this.suitBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.drawBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.cards_dealtList = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.deckList = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.view_deckButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.add_customButton);
            this.groupBox1.Controls.Add(this.rankBox);
            this.groupBox1.Controls.Add(this.suitBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card";
            // 
            // add_customButton
            // 
            this.add_customButton.Location = new System.Drawing.Point(254, 64);
            this.add_customButton.Name = "add_customButton";
            this.add_customButton.Size = new System.Drawing.Size(127, 44);
            this.add_customButton.TabIndex = 3;
            this.add_customButton.Text = "&Add Custom";
            this.add_customButton.UseVisualStyleBackColor = true;
            this.add_customButton.Click += new System.EventHandler(this.add_customButton_Click);
            // 
            // rankBox
            // 
            this.rankBox.Location = new System.Drawing.Point(71, 100);
            this.rankBox.Name = "rankBox";
            this.rankBox.Size = new System.Drawing.Size(133, 26);
            this.rankBox.TabIndex = 2;
            // 
            // suitBox
            // 
            this.suitBox.Location = new System.Drawing.Point(71, 38);
            this.suitBox.Name = "suitBox";
            this.suitBox.Size = new System.Drawing.Size(133, 26);
            this.suitBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suit";
            // 
            // drawBox
            // 
            this.drawBox.Location = new System.Drawing.Point(115, 248);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(133, 26);
            this.drawBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Draw";
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(298, 242);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(133, 44);
            this.dealButton.TabIndex = 5;
            this.dealButton.Text = "&Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // cards_dealtList
            // 
            this.cards_dealtList.HideSelection = false;
            this.cards_dealtList.Location = new System.Drawing.Point(55, 342);
            this.cards_dealtList.Name = "cards_dealtList";
            this.cards_dealtList.Size = new System.Drawing.Size(376, 97);
            this.cards_dealtList.TabIndex = 0;
            this.cards_dealtList.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cards Dealt";
            // 
            // deckList
            // 
            this.deckList.HideSelection = false;
            this.deckList.Location = new System.Drawing.Point(516, 79);
            this.deckList.Name = "deckList";
            this.deckList.Size = new System.Drawing.Size(247, 360);
            this.deckList.TabIndex = 0;
            this.deckList.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Deck";
            // 
            // view_deckButton
            // 
            this.view_deckButton.Location = new System.Drawing.Point(798, 79);
            this.view_deckButton.Name = "view_deckButton";
            this.view_deckButton.Size = new System.Drawing.Size(133, 51);
            this.view_deckButton.TabIndex = 6;
            this.view_deckButton.Text = "&View Deck";
            this.view_deckButton.UseVisualStyleBackColor = true;
            this.view_deckButton.Click += new System.EventHandler(this.view_deckButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(798, 194);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(133, 46);
            this.shuffleButton.TabIndex = 7;
            this.shuffleButton.Text = "&Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(798, 295);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(133, 47);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(798, 396);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 45);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CardGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 518);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.view_deckButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deckList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cards_dealtList);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drawBox);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deck Builder";
           // this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_customButton;
        private System.Windows.Forms.TextBox rankBox;
        private System.Windows.Forms.TextBox suitBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox drawBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.ListView cards_dealtList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView deckList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button view_deckButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

