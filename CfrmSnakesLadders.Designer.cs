namespace SnakesAndLadders
{
    partial class CfrmSnakesLadders
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
            this.picBoard = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLastDiceRed = new System.Windows.Forms.Label();
            this.lblLastDiceBlue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoard
            // 
            this.picBoard.Location = new System.Drawing.Point(0, 0);
            this.picBoard.Name = "picBoard";
            this.picBoard.Size = new System.Drawing.Size(506, 505);
            this.picBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoard.TabIndex = 0;
            this.picBoard.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(418, 519);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.BackColor = System.Drawing.Color.Red;
            this.btnPlayer1.Enabled = false;
            this.btnPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer1.ForeColor = System.Drawing.Color.White;
            this.btnPlayer1.Location = new System.Drawing.Point(104, 519);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(83, 36);
            this.btnPlayer1.TabIndex = 2;
            this.btnPlayer1.Text = "Player 1";
            this.btnPlayer1.UseVisualStyleBackColor = false;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackColor = System.Drawing.Color.Blue;
            this.btnPlayer2.Enabled = false;
            this.btnPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayer2.ForeColor = System.Drawing.Color.White;
            this.btnPlayer2.Location = new System.Drawing.Point(260, 519);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(85, 36);
            this.btnPlayer2.TabIndex = 3;
            this.btnPlayer2.Text = "Player 2";
            this.btnPlayer2.UseVisualStyleBackColor = false;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 519);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 36);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLastDiceRed
            // 
            this.lblLastDiceRed.AutoSize = true;
            this.lblLastDiceRed.Location = new System.Drawing.Point(193, 519);
            this.lblLastDiceRed.Name = "lblLastDiceRed";
            this.lblLastDiceRed.Size = new System.Drawing.Size(50, 13);
            this.lblLastDiceRed.TabIndex = 7;
            this.lblLastDiceRed.Text = "Last dice";
            // 
            // lblLastDiceBlue
            // 
            this.lblLastDiceBlue.AutoSize = true;
            this.lblLastDiceBlue.Location = new System.Drawing.Point(351, 519);
            this.lblLastDiceBlue.Name = "lblLastDiceBlue";
            this.lblLastDiceBlue.Size = new System.Drawing.Size(50, 13);
            this.lblLastDiceBlue.TabIndex = 8;
            this.lblLastDiceBlue.Text = "Last dice";
            this.lblLastDiceBlue.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // CfrmSnakesLadders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 566);
            this.ControlBox = false;
            this.Controls.Add(this.lblLastDiceBlue);
            this.Controls.Add(this.lblLastDiceRed);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlayer1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CfrmSnakesLadders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snakes and Ladders";
            this.Shown += new System.EventHandler(this.CfrmSnakesLadders_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoard;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLastDiceRed;
        private System.Windows.Forms.Label lblLastDiceBlue;
    }
}

