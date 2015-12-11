namespace PocketMonsters
{
    partial class Winner
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
            this.lblWinnerTitle = new System.Windows.Forms.Label();
            this.lblWinnerName = new System.Windows.Forms.Label();
            this.lblWinnerDesc = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinnerTitle
            // 
            this.lblWinnerTitle.AutoSize = true;
            this.lblWinnerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.lblWinnerTitle.ForeColor = System.Drawing.Color.White;
            this.lblWinnerTitle.Location = new System.Drawing.Point(135, 57);
            this.lblWinnerTitle.Name = "lblWinnerTitle";
            this.lblWinnerTitle.Size = new System.Drawing.Size(199, 59);
            this.lblWinnerTitle.TabIndex = 0;
            this.lblWinnerTitle.Text = "Winner!";
            // 
            // lblWinnerName
            // 
            this.lblWinnerName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWinnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblWinnerName.ForeColor = System.Drawing.Color.White;
            this.lblWinnerName.Location = new System.Drawing.Point(35, 205);
            this.lblWinnerName.Margin = new System.Windows.Forms.Padding(0);
            this.lblWinnerName.Name = "lblWinnerName";
            this.lblWinnerName.Size = new System.Drawing.Size(129, 28);
            this.lblWinnerName.TabIndex = 0;
            this.lblWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWinnerDesc
            // 
            this.lblWinnerDesc.AutoSize = true;
            this.lblWinnerDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerDesc.Location = new System.Drawing.Point(28, 207);
            this.lblWinnerDesc.Name = "lblWinnerDesc";
            this.lblWinnerDesc.Size = new System.Drawing.Size(435, 50);
            this.lblWinnerDesc.TabIndex = 0;
            this.lblWinnerDesc.Text = "            is the winner of the battle!\r\nClick the buttons below to exit or have" +
                " a rematch!";
            this.lblWinnerDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(258, 302);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdRestart
            // 
            this.cmdRestart.Location = new System.Drawing.Point(122, 302);
            this.cmdRestart.Name = "cmdRestart";
            this.cmdRestart.Size = new System.Drawing.Size(75, 23);
            this.cmdRestart.TabIndex = 2;
            this.cmdRestart.Text = "Restart";
            this.cmdRestart.UseVisualStyleBackColor = true;
            this.cmdRestart.Click += new System.EventHandler(this.cmdRestart_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(251)))));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(484, 413);
            this.Controls.Add(this.cmdRestart);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblWinnerName);
            this.Controls.Add(this.lblWinnerTitle);
            this.Controls.Add(this.lblWinnerDesc);
            this.Name = "Winner";
            this.Text = "Winner";
            this.Load += new System.EventHandler(this.Winner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinnerTitle;
        private System.Windows.Forms.Label lblWinnerName;
        private System.Windows.Forms.Label lblWinnerDesc;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdRestart;
    }
}