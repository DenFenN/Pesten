namespace Pesten.App
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
            this.buttonShuffle = new System.Windows.Forms.Button();
            this.listBoxCards = new System.Windows.Forms.ListBox();
            this.textBoxCardCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPlayers = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLastPlayed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Location = new System.Drawing.Point(205, 36);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.Size = new System.Drawing.Size(75, 23);
            this.buttonShuffle.TabIndex = 0;
            this.buttonShuffle.Text = "Initialize";
            this.buttonShuffle.UseVisualStyleBackColor = true;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            // 
            // listBoxCards
            // 
            this.listBoxCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCards.FormattingEnabled = true;
            this.listBoxCards.ItemHeight = 20;
            this.listBoxCards.Location = new System.Drawing.Point(30, 36);
            this.listBoxCards.Name = "listBoxCards";
            this.listBoxCards.ScrollAlwaysVisible = true;
            this.listBoxCards.Size = new System.Drawing.Size(169, 304);
            this.listBoxCards.TabIndex = 1;
            // 
            // textBoxCardCount
            // 
            this.textBoxCardCount.Location = new System.Drawing.Point(99, 346);
            this.textBoxCardCount.Name = "textBoxCardCount";
            this.textBoxCardCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCardCount.TabIndex = 2;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(27, 349);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(38, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Count:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Deal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxPlayers
            // 
            this.comboBoxPlayers.FormattingEnabled = true;
            this.comboBoxPlayers.Location = new System.Drawing.Point(371, 36);
            this.comboBoxPlayers.Name = "comboBoxPlayers";
            this.comboBoxPlayers.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlayers.TabIndex = 5;
            this.comboBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayers_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(371, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 40);
            this.panel1.TabIndex = 6;
            // 
            // txtLastPlayed
            // 
            this.txtLastPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastPlayed.Location = new System.Drawing.Point(603, 53);
            this.txtLastPlayed.Name = "txtLastPlayed";
            this.txtLastPlayed.ReadOnly = true;
            this.txtLastPlayed.Size = new System.Drawing.Size(227, 31);
            this.txtLastPlayed.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 463);
            this.Controls.Add(this.txtLastPlayed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxPlayers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.textBoxCardCount);
            this.Controls.Add(this.listBoxCards);
            this.Controls.Add(this.buttonShuffle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShuffle;
        private System.Windows.Forms.ListBox listBoxCards;
        private System.Windows.Forms.TextBox textBoxCardCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxPlayers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLastPlayed;
    }
}

