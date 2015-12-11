namespace PocketMonsters
{
    partial class SelectMonster
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
            this.cmdMon4 = new System.Windows.Forms.Button();
            this.cmdMon5 = new System.Windows.Forms.Button();
            this.cmdMon2 = new System.Windows.Forms.Button();
            this.cmdMon3 = new System.Windows.Forms.Button();
            this.cmdMon0 = new System.Windows.Forms.Button();
            this.cmdMon1 = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdMon4
            // 
            this.cmdMon4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmdMon4.Location = new System.Drawing.Point(70, 327);
            this.cmdMon4.Name = "cmdMon4";
            this.cmdMon4.Size = new System.Drawing.Size(166, 64);
            this.cmdMon4.TabIndex = 1;
            this.cmdMon4.UseVisualStyleBackColor = true;
            this.cmdMon4.Click += new System.EventHandler(this.cmdMon4_Click);
            // 
            // cmdMon5
            // 
            this.cmdMon5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmdMon5.Location = new System.Drawing.Point(261, 327);
            this.cmdMon5.Name = "cmdMon5";
            this.cmdMon5.Size = new System.Drawing.Size(166, 64);
            this.cmdMon5.TabIndex = 1;
            this.cmdMon5.UseVisualStyleBackColor = true;
            this.cmdMon5.Click += new System.EventHandler(this.cmdMon5_Click);
            // 
            // cmdMon2
            // 
            this.cmdMon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmdMon2.Location = new System.Drawing.Point(70, 253);
            this.cmdMon2.Name = "cmdMon2";
            this.cmdMon2.Size = new System.Drawing.Size(166, 64);
            this.cmdMon2.TabIndex = 1;
            this.cmdMon2.UseVisualStyleBackColor = true;
            this.cmdMon2.Click += new System.EventHandler(this.cmdMon2_Click);
            // 
            // cmdMon3
            // 
            this.cmdMon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmdMon3.Location = new System.Drawing.Point(261, 253);
            this.cmdMon3.Name = "cmdMon3";
            this.cmdMon3.Size = new System.Drawing.Size(166, 64);
            this.cmdMon3.TabIndex = 1;
            this.cmdMon3.UseVisualStyleBackColor = true;
            this.cmdMon3.Click += new System.EventHandler(this.cmdMon3_Click);
            // 
            // cmdMon0
            // 
            this.cmdMon0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmdMon0.Location = new System.Drawing.Point(70, 179);
            this.cmdMon0.Name = "cmdMon0";
            this.cmdMon0.Size = new System.Drawing.Size(166, 64);
            this.cmdMon0.TabIndex = 1;
            this.cmdMon0.UseVisualStyleBackColor = true;
            this.cmdMon0.Click += new System.EventHandler(this.cmdMon0_Click);
            // 
            // cmdMon1
            // 
            this.cmdMon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmdMon1.Location = new System.Drawing.Point(261, 179);
            this.cmdMon1.Name = "cmdMon1";
            this.cmdMon1.Size = new System.Drawing.Size(166, 64);
            this.cmdMon1.TabIndex = 1;
            this.cmdMon1.UseVisualStyleBackColor = true;
            this.cmdMon1.Click += new System.EventHandler(this.cmdMon1_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblPlayerName.Location = new System.Drawing.Point(65, 101);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 29);
            this.lblPlayerName.TabIndex = 3;
            // 
            // SelectMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(484, 413);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.cmdMon1);
            this.Controls.Add(this.cmdMon3);
            this.Controls.Add(this.cmdMon5);
            this.Controls.Add(this.cmdMon0);
            this.Controls.Add(this.cmdMon2);
            this.Controls.Add(this.cmdMon4);
            this.Name = "SelectMonster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectMonster";
            this.Load += new System.EventHandler(this.SelectMonster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdMon4;
        private System.Windows.Forms.Button cmdMon5;
        private System.Windows.Forms.Button cmdMon2;
        private System.Windows.Forms.Button cmdMon3;
        private System.Windows.Forms.Button cmdMon0;
        private System.Windows.Forms.Button cmdMon1;
        private System.Windows.Forms.Label lblPlayerName;

    }
}