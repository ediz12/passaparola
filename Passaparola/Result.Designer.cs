namespace Passaparola
{
    partial class Result
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeleft = new System.Windows.Forms.Label();
            this.totalpoints = new System.Windows.Forms.Label();
            this.totalwrongs = new System.Windows.Forms.Label();
            this.totalcorrects = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAME OVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "CORRECT ANSWERS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "WRONG ANSWERS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "POINTS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIME REMAINING:";
            // 
            // timeleft
            // 
            this.timeleft.AutoSize = true;
            this.timeleft.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeleft.Location = new System.Drawing.Point(382, 276);
            this.timeleft.Name = "timeleft";
            this.timeleft.Size = new System.Drawing.Size(33, 38);
            this.timeleft.TabIndex = 5;
            this.timeleft.Text = "0";
            // 
            // totalpoints
            // 
            this.totalpoints.AutoSize = true;
            this.totalpoints.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpoints.Location = new System.Drawing.Point(382, 208);
            this.totalpoints.Name = "totalpoints";
            this.totalpoints.Size = new System.Drawing.Size(33, 38);
            this.totalpoints.TabIndex = 6;
            this.totalpoints.Text = "0";
            // 
            // totalwrongs
            // 
            this.totalwrongs.AutoSize = true;
            this.totalwrongs.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalwrongs.Location = new System.Drawing.Point(382, 144);
            this.totalwrongs.Name = "totalwrongs";
            this.totalwrongs.Size = new System.Drawing.Size(33, 38);
            this.totalwrongs.TabIndex = 7;
            this.totalwrongs.Text = "0";
            // 
            // totalcorrects
            // 
            this.totalcorrects.AutoSize = true;
            this.totalcorrects.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcorrects.Location = new System.Drawing.Point(382, 71);
            this.totalcorrects.Name = "totalcorrects";
            this.totalcorrects.Size = new System.Drawing.Size(33, 38);
            this.totalcorrects.TabIndex = 8;
            this.totalcorrects.Text = "0";
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(12, 349);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(460, 100);
            this.menuButton.TabIndex = 9;
            this.menuButton.Text = "GO TO MENU";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.totalcorrects);
            this.Controls.Add(this.totalwrongs);
            this.Controls.Add(this.totalpoints);
            this.Controls.Add(this.timeleft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Result";
            this.Text = "Passaparola";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Result_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timeleft;
        private System.Windows.Forms.Label totalpoints;
        private System.Windows.Forms.Label totalwrongs;
        private System.Windows.Forms.Label totalcorrects;
        private System.Windows.Forms.Button menuButton;
    }
}