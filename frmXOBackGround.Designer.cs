namespace Tic_Tac_Toe_Game
{
    partial class frmXOBackGround
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            tbPayersName = new TextBox();
            btnStartGame = new Button();
            btnRestartGame = new Button();
            tbRoundInfo = new TextBox();
            tbT = new TextBox();
            tbW = new TextBox();
            tbWinner = new TextBox();
            tbPlayer1Name = new TextBox();
            tbPlayer2Name = new TextBox();
            tbTurn = new TextBox();
            tbPlayer2 = new TextBox();
            tbPlayer1 = new TextBox();
            btnCell9 = new Button();
            btnCell8 = new Button();
            btnCell7 = new Button();
            btnCell6 = new Button();
            btnCell5 = new Button();
            btnCell4 = new Button();
            btnCell3 = new Button();
            btnCell2 = new Button();
            pnlGameBoard = new Panel();
            btnCell1 = new Button();
            pnlGameBoard.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Bodoni MT", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MediumTurquoise;
            lblTitle.Location = new Point(183, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(519, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TIC TAC TOE GAME";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPayersName
            // 
            tbPayersName.BackColor = Color.FromArgb(21, 4, 34);
            tbPayersName.BorderStyle = BorderStyle.None;
            tbPayersName.Font = new Font("Bodoni MT", 16F, FontStyle.Bold);
            tbPayersName.ForeColor = Color.MediumTurquoise;
            tbPayersName.Location = new Point(18, 153);
            tbPayersName.Multiline = true;
            tbPayersName.Name = "tbPayersName";
            tbPayersName.ReadOnly = true;
            tbPayersName.Size = new Size(208, 265);
            tbPayersName.TabIndex = 5;
            tbPayersName.Text = "Players Info";
            tbPayersName.TextChanged += tbPayersName_TextChanged;
            // 
            // btnStartGame
            // 
            btnStartGame.AutoSize = true;
            btnStartGame.BackColor = Color.DarkSlateBlue;
            btnStartGame.FlatAppearance.BorderColor = Color.FromArgb(189, 0, 255);
            btnStartGame.FlatAppearance.BorderSize = 2;
            btnStartGame.FlatStyle = FlatStyle.Popup;
            btnStartGame.Font = new Font("Bodoni MT", 16F, FontStyle.Bold);
            btnStartGame.ForeColor = Color.MediumTurquoise;
            btnStartGame.Location = new Point(18, 438);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(208, 50);
            btnStartGame.TabIndex = 6;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnRestartGame
            // 
            btnRestartGame.AutoSize = true;
            btnRestartGame.BackColor = Color.DarkSlateBlue;
            btnRestartGame.Enabled = false;
            btnRestartGame.FlatAppearance.BorderColor = Color.FromArgb(189, 0, 255);
            btnRestartGame.FlatAppearance.BorderSize = 2;
            btnRestartGame.FlatStyle = FlatStyle.Popup;
            btnRestartGame.Font = new Font("Bodoni MT", 16F, FontStyle.Bold);
            btnRestartGame.ForeColor = Color.MediumTurquoise;
            btnRestartGame.Location = new Point(252, 438);
            btnRestartGame.Name = "btnRestartGame";
            btnRestartGame.Size = new Size(208, 50);
            btnRestartGame.TabIndex = 7;
            btnRestartGame.Text = "Restart Game";
            btnRestartGame.UseVisualStyleBackColor = false;
            btnRestartGame.Click += btnRestartGame_Click;
            // 
            // tbRoundInfo
            // 
            tbRoundInfo.BackColor = Color.FromArgb(21, 4, 34);
            tbRoundInfo.BorderStyle = BorderStyle.None;
            tbRoundInfo.Font = new Font("Bodoni MT", 16F, FontStyle.Bold);
            tbRoundInfo.ForeColor = Color.MediumTurquoise;
            tbRoundInfo.Location = new Point(252, 153);
            tbRoundInfo.Multiline = true;
            tbRoundInfo.Name = "tbRoundInfo";
            tbRoundInfo.Size = new Size(208, 265);
            tbRoundInfo.TabIndex = 9;
            tbRoundInfo.Text = "Round Info";
            // 
            // tbT
            // 
            tbT.BackColor = Color.FromArgb(21, 4, 34);
            tbT.BorderStyle = BorderStyle.None;
            tbT.Font = new Font("Bodoni MT", 16F, FontStyle.Bold);
            tbT.ForeColor = Color.MediumTurquoise;
            tbT.Location = new Point(274, 204);
            tbT.Multiline = true;
            tbT.Name = "tbT";
            tbT.ReadOnly = true;
            tbT.Size = new Size(166, 35);
            tbT.TabIndex = 10;
            tbT.Text = "Turn";
            tbT.TextAlign = HorizontalAlignment.Center;
            // 
            // tbW
            // 
            tbW.BackColor = Color.FromArgb(21, 4, 34);
            tbW.BorderStyle = BorderStyle.None;
            tbW.Font = new Font("Bodoni MT", 16F, FontStyle.Bold);
            tbW.ForeColor = Color.MediumTurquoise;
            tbW.Location = new Point(274, 314);
            tbW.Multiline = true;
            tbW.Name = "tbW";
            tbW.ReadOnly = true;
            tbW.Size = new Size(166, 35);
            tbW.TabIndex = 11;
            tbW.Text = "Winner";
            tbW.TextAlign = HorizontalAlignment.Center;
            // 
            // tbWinner
            // 
            tbWinner.BackColor = Color.FromArgb(21, 4, 34);
            tbWinner.BorderStyle = BorderStyle.None;
            tbWinner.Font = new Font("Bodoni MT", 16F, FontStyle.Bold);
            tbWinner.ForeColor = Color.MediumTurquoise;
            tbWinner.Location = new Point(274, 361);
            tbWinner.Multiline = true;
            tbWinner.Name = "tbWinner";
            tbWinner.ReadOnly = true;
            tbWinner.Size = new Size(166, 40);
            tbWinner.TabIndex = 12;
            tbWinner.Text = "Wating...";
            tbWinner.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPlayer1Name
            // 
            tbPlayer1Name.BackColor = Color.FromArgb(21, 4, 34);
            tbPlayer1Name.BorderStyle = BorderStyle.None;
            tbPlayer1Name.Font = new Font("Bodoni MT", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPlayer1Name.ForeColor = Color.MediumTurquoise;
            tbPlayer1Name.Location = new Point(37, 204);
            tbPlayer1Name.Multiline = true;
            tbPlayer1Name.Name = "tbPlayer1Name";
            tbPlayer1Name.ReadOnly = true;
            tbPlayer1Name.Size = new Size(166, 35);
            tbPlayer1Name.TabIndex = 15;
            tbPlayer1Name.Text = "Player1";
            tbPlayer1Name.TextAlign = HorizontalAlignment.Center;
            // 
            // tbPlayer2Name
            // 
            tbPlayer2Name.BackColor = Color.FromArgb(21, 4, 34);
            tbPlayer2Name.BorderStyle = BorderStyle.None;
            tbPlayer2Name.Font = new Font("Bodoni MT", 16F, FontStyle.Bold);
            tbPlayer2Name.ForeColor = Color.MediumTurquoise;
            tbPlayer2Name.Location = new Point(37, 314);
            tbPlayer2Name.Multiline = true;
            tbPlayer2Name.Name = "tbPlayer2Name";
            tbPlayer2Name.ReadOnly = true;
            tbPlayer2Name.Size = new Size(166, 35);
            tbPlayer2Name.TabIndex = 16;
            tbPlayer2Name.Text = "Player2";
            tbPlayer2Name.TextAlign = HorizontalAlignment.Center;
            // 
            // tbTurn
            // 
            tbTurn.BackColor = Color.FromArgb(21, 4, 34);
            tbTurn.BorderStyle = BorderStyle.None;
            tbTurn.Font = new Font("Bodoni MT", 16F, FontStyle.Bold);
            tbTurn.ForeColor = Color.MediumTurquoise;
            tbTurn.Location = new Point(274, 251);
            tbTurn.Multiline = true;
            tbTurn.Name = "tbTurn";
            tbTurn.ReadOnly = true;
            tbTurn.Size = new Size(166, 57);
            tbTurn.TabIndex = 17;
            tbTurn.Text = "Player1";
            tbTurn.TextAlign = HorizontalAlignment.Center;
            tbTurn.TextChanged += tbTurn_TextChanged;
            // 
            // tbPlayer2
            // 
            tbPlayer2.BackColor = Color.DarkSlateBlue;
            tbPlayer2.BorderStyle = BorderStyle.None;
            tbPlayer2.Font = new Font("Bodoni MT", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPlayer2.ForeColor = Color.MediumTurquoise;
            tbPlayer2.Location = new Point(49, 355);
            tbPlayer2.MaxLength = 8;
            tbPlayer2.Multiline = true;
            tbPlayer2.Name = "tbPlayer2";
            tbPlayer2.Size = new Size(140, 46);
            tbPlayer2.TabIndex = 19;
            tbPlayer2.Text = "Player2";
            tbPlayer2.TextAlign = HorizontalAlignment.Center;
            tbPlayer2.TextChanged += tbPlayer2_TextChanged;
            // 
            // tbPlayer1
            // 
            tbPlayer1.BackColor = Color.DarkSlateBlue;
            tbPlayer1.BorderStyle = BorderStyle.None;
            tbPlayer1.Font = new Font("Bodoni MT", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbPlayer1.ForeColor = Color.MediumTurquoise;
            tbPlayer1.Location = new Point(49, 245);
            tbPlayer1.MaxLength = 8;
            tbPlayer1.Multiline = true;
            tbPlayer1.Name = "tbPlayer1";
            tbPlayer1.Size = new Size(140, 46);
            tbPlayer1.TabIndex = 20;
            tbPlayer1.Text = "Player1";
            tbPlayer1.TextAlign = HorizontalAlignment.Center;
            tbPlayer1.TextChanged += tbPlayer1_TextChanged;
            // 
            // btnCell9
            // 
            btnCell9.BackColor = Color.FromArgb(21, 4, 34);
            btnCell9.FlatAppearance.BorderColor = Color.FromArgb(0, 240, 255);
            btnCell9.FlatStyle = FlatStyle.Flat;
            btnCell9.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btnCell9.Location = new Point(280, 280);
            btnCell9.Name = "btnCell9";
            btnCell9.Size = new Size(120, 120);
            btnCell9.TabIndex = 8;
            btnCell9.UseVisualStyleBackColor = false;
            btnCell9.Click += btnCell9_Click;
            // 
            // btnCell8
            // 
            btnCell8.BackColor = Color.FromArgb(21, 4, 34);
            btnCell8.FlatAppearance.BorderColor = Color.FromArgb(0, 240, 255);
            btnCell8.FlatStyle = FlatStyle.Flat;
            btnCell8.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btnCell8.Location = new Point(145, 280);
            btnCell8.Name = "btnCell8";
            btnCell8.Size = new Size(120, 120);
            btnCell8.TabIndex = 7;
            btnCell8.UseVisualStyleBackColor = false;
            btnCell8.Click += btnCell8_Click;
            // 
            // btnCell7
            // 
            btnCell7.BackColor = Color.FromArgb(21, 4, 34);
            btnCell7.FlatAppearance.BorderColor = Color.FromArgb(0, 240, 255);
            btnCell7.FlatStyle = FlatStyle.Flat;
            btnCell7.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btnCell7.Location = new Point(10, 280);
            btnCell7.Name = "btnCell7";
            btnCell7.Size = new Size(120, 120);
            btnCell7.TabIndex = 6;
            btnCell7.UseVisualStyleBackColor = false;
            btnCell7.Click += btnCell7_Click;
            // 
            // btnCell6
            // 
            btnCell6.BackColor = Color.FromArgb(21, 4, 34);
            btnCell6.FlatAppearance.BorderColor = Color.FromArgb(0, 240, 255);
            btnCell6.FlatStyle = FlatStyle.Flat;
            btnCell6.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btnCell6.Location = new Point(280, 145);
            btnCell6.Name = "btnCell6";
            btnCell6.Size = new Size(120, 120);
            btnCell6.TabIndex = 5;
            btnCell6.UseVisualStyleBackColor = false;
            btnCell6.Click += btnCell6_Click;
            // 
            // btnCell5
            // 
            btnCell5.BackColor = Color.FromArgb(21, 4, 34);
            btnCell5.FlatAppearance.BorderColor = Color.FromArgb(0, 240, 255);
            btnCell5.FlatStyle = FlatStyle.Flat;
            btnCell5.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btnCell5.Location = new Point(145, 145);
            btnCell5.Name = "btnCell5";
            btnCell5.Size = new Size(120, 120);
            btnCell5.TabIndex = 4;
            btnCell5.UseVisualStyleBackColor = false;
            btnCell5.Click += btnCell5_Click;
            // 
            // btnCell4
            // 
            btnCell4.BackColor = Color.FromArgb(21, 4, 34);
            btnCell4.FlatAppearance.BorderColor = Color.FromArgb(0, 240, 255);
            btnCell4.FlatStyle = FlatStyle.Flat;
            btnCell4.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btnCell4.Location = new Point(10, 145);
            btnCell4.Name = "btnCell4";
            btnCell4.Size = new Size(120, 120);
            btnCell4.TabIndex = 3;
            btnCell4.UseVisualStyleBackColor = false;
            btnCell4.Click += btnCell4_Click;
            // 
            // btnCell3
            // 
            btnCell3.BackColor = Color.FromArgb(21, 4, 34);
            btnCell3.FlatAppearance.BorderColor = Color.FromArgb(0, 240, 255);
            btnCell3.FlatStyle = FlatStyle.Flat;
            btnCell3.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btnCell3.Location = new Point(280, 10);
            btnCell3.Name = "btnCell3";
            btnCell3.Size = new Size(120, 120);
            btnCell3.TabIndex = 2;
            btnCell3.UseVisualStyleBackColor = false;
            btnCell3.Click += btnCell3_Click;
            // 
            // btnCell2
            // 
            btnCell2.BackColor = Color.FromArgb(21, 4, 34);
            btnCell2.FlatAppearance.BorderColor = Color.FromArgb(0, 240, 255);
            btnCell2.FlatStyle = FlatStyle.Flat;
            btnCell2.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btnCell2.Location = new Point(145, 10);
            btnCell2.Name = "btnCell2";
            btnCell2.Size = new Size(120, 120);
            btnCell2.TabIndex = 1;
            btnCell2.UseVisualStyleBackColor = false;
            btnCell2.Click += btnCell2_Click;
            // 
            // pnlGameBoard
            // 
            pnlGameBoard.AutoSize = true;
            pnlGameBoard.Controls.Add(btnCell1);
            pnlGameBoard.Controls.Add(btnCell2);
            pnlGameBoard.Controls.Add(btnCell3);
            pnlGameBoard.Controls.Add(btnCell4);
            pnlGameBoard.Controls.Add(btnCell5);
            pnlGameBoard.Controls.Add(btnCell6);
            pnlGameBoard.Controls.Add(btnCell7);
            pnlGameBoard.Controls.Add(btnCell8);
            pnlGameBoard.Controls.Add(btnCell9);
            pnlGameBoard.Location = new Point(495, 117);
            pnlGameBoard.Name = "pnlGameBoard";
            pnlGameBoard.Size = new Size(412, 412);
            pnlGameBoard.TabIndex = 2;
            pnlGameBoard.Paint += GameBoard_Paint;
            // 
            // btnCell1
            // 
            btnCell1.BackColor = Color.FromArgb(21, 4, 34);
            btnCell1.FlatAppearance.BorderColor = Color.FromArgb(0, 240, 255);
            btnCell1.FlatStyle = FlatStyle.Flat;
            btnCell1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            btnCell1.Location = new Point(10, 10);
            btnCell1.Name = "btnCell1";
            btnCell1.Size = new Size(120, 120);
            btnCell1.TabIndex = 0;
            btnCell1.Tag = "";
            btnCell1.UseVisualStyleBackColor = false;
            btnCell1.Click += btnCell1_Click;
            // 
            // frmXOBackGround
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 2, 20);
            BackgroundImage = Properties.Resources.Tic_Tac_Toe_BackGround;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(962, 550);
            Controls.Add(tbPlayer1);
            Controls.Add(tbPlayer2);
            Controls.Add(tbTurn);
            Controls.Add(tbPlayer2Name);
            Controls.Add(tbPlayer1Name);
            Controls.Add(tbWinner);
            Controls.Add(tbW);
            Controls.Add(tbT);
            Controls.Add(tbRoundInfo);
            Controls.Add(btnRestartGame);
            Controls.Add(btnStartGame);
            Controls.Add(tbPayersName);
            Controls.Add(lblTitle);
            Controls.Add(pnlGameBoard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmXOBackGround";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe BackGround";
            Load += Form1_Load;
            pnlGameBoard.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPayersName;
        private Button btnStartGame;
        private Button btnRestartGame;
        private TextBox tbRoundInfo;
        private TextBox tbT;
        private TextBox tbW;
        private TextBox tbWinner;
        private TextBox tbPlayer1Name;
        private TextBox tbPlayer2Name;
        private TextBox tbTurn;
        private TextBox tbPlayer2;
        private TextBox tbPlayer1;
        
        private Button btnCell9;
        private Button btnCell8;
        private Button btnCell7;
        private Button btnCell6;
        private Button btnCell5;
        private Button btnCell4;
        private Button btnCell3;
        private Button btnCell2;
        private Panel pnlGameBoard;
        private Button btnCell1;
    }
}