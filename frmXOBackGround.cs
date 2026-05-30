using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class frmXOBackGround : Form
    {
        
        private Button[] matrixCells;

        public frmXOBackGround()
        {
            InitializeComponent();

            
            matrixCells = new Button[] { btnCell1, btnCell2, btnCell3, btnCell4, btnCell5, btnCell6, btnCell7, btnCell8, btnCell9 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableRoundInfoAndRestartGame();
        }


        private void NeonPanel_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            if (box == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen neonPen = new Pen(Color.FromArgb(189, 0, 255), 3))
            {
                e.Graphics.DrawRectangle(neonPen, 1, 10, box.Width - 3, box.Height - 13);
            }
        }

      
        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;
            if (pnl == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen cyanPen = new Pen(Color.FromArgb(0, 240, 255), 4))
            {
                e.Graphics.DrawRectangle(cyanPen, 2, 2, pnl.Width - 5, pnl.Height - 5);
            }
        }

               
        Image ImgX = Properties.Resources.X;
        Image ImgO = Properties.Resources.O;
        void EnablePlayersInfoAndStartGame()
        {
            tbPayersName.Enabled = true;
            tbPlayer1Name.Enabled = true;
            tbPlayer1.Enabled = true;
            tbPlayer2Name.Enabled = true;
            tbPlayer2.Enabled = true;
            btnStartGame.Enabled = true;
        }
        void DisablePlayersInfoAndStartGame()
        {
            tbPayersName.Enabled = false;
            tbPlayer1Name.Enabled = false;
            tbPlayer1.Enabled = false;
            tbPlayer2Name.Enabled = false;
            tbPlayer2.Enabled = false;
            btnStartGame.Enabled = false;
        }
        void EnableRoundInfoAndRestartGame()
        {
            tbRoundInfo.Enabled = true;
            tbT.Enabled = true;
            tbTurn.Enabled = true;
            tbW.Enabled = true;
            tbWinner.Enabled = true;
            btnRestartGame.Enabled = true;
            pnlGameBoard.Enabled = true;
        }
        void DisableRoundInfoAndRestartGame()
        {
            tbRoundInfo.Enabled = false;
            tbT.Enabled = false;
            tbTurn.Enabled = false;
            tbW.Enabled = false;
            tbWinner.Enabled = false;
            btnRestartGame.Enabled = false;
            pnlGameBoard.Enabled = false;
        }
        void ResetBoard()
        {
            btnCell1.Image = null;
            btnCell1.BackColor = Color.Transparent;
            btnCell2.Image = null;
            btnCell2.BackColor = Color.Transparent;
            btnCell3.Image = null;
            btnCell3.BackColor = Color.Transparent;
            btnCell4.Image = null;
            btnCell4.BackColor = Color.Transparent;
            btnCell5.Image = null;
            btnCell5.BackColor = Color.Transparent;
            btnCell6.Image = null;
            btnCell6.BackColor = Color.Transparent;
            btnCell7.Image = null;
            btnCell7.BackColor = Color.Transparent;
            btnCell8.Image = null;
            btnCell8.BackColor = Color.Transparent;
            btnCell9.Image = null;
            btnCell9.BackColor = Color.Transparent;

            tbWinner.Text = "Waiting...";
        }
        void GameOverMessage(string Message)
        {
            MessageBox.Show(Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pnlGameBoard.Enabled = false;
        }
        bool GameOver()
        {
            if (btnCell1.Image != null && btnCell2.Image != null && btnCell3.Image != null &&
                btnCell4.Image != null && btnCell5.Image != null && btnCell6.Image != null &&
                btnCell7.Image != null && btnCell8.Image != null && btnCell9.Image != null)
            {
                GameOverMessage("Game Over");
                return true;
            }
            else
                return false;
        }
        bool MulltipleChoice(object sender)
        {
            if (((Button)sender).Image != null)
            {
                MessageBox.Show("Wrong Choise", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
              return false;
        }
        void ColorCells(Image CurrentImagre)
        {
            if((btnCell1.Image == CurrentImagre && btnCell2.Image == CurrentImagre && btnCell3.Image == CurrentImagre))
            {
                btnCell1.BackColor = Color.MediumTurquoise;
                btnCell2.BackColor = Color.MediumTurquoise;
                btnCell3.BackColor = Color.MediumTurquoise;
                return;
            }

            else if ((btnCell4.Image == CurrentImagre && btnCell5.Image == CurrentImagre && btnCell6.Image == CurrentImagre))
            {
                btnCell4.BackColor = Color.MediumTurquoise;
                btnCell5.BackColor = Color.MediumTurquoise;
                btnCell6.BackColor = Color.MediumTurquoise;
                return;
            }

            else if ((btnCell7.Image == CurrentImagre && btnCell8.Image == CurrentImagre && btnCell9.Image == CurrentImagre))
            {
                btnCell7.BackColor = Color.MediumTurquoise;
                btnCell8.BackColor = Color.MediumTurquoise;
                btnCell9.BackColor = Color.MediumTurquoise;
                return;
            }
            
            else if ((btnCell1.Image == CurrentImagre && btnCell4.Image == CurrentImagre && btnCell7.Image == CurrentImagre))
            {
                btnCell1.BackColor = Color.MediumTurquoise;
                btnCell4.BackColor = Color.MediumTurquoise;
                btnCell7.BackColor = Color.MediumTurquoise;
                return;
            }

            else if ((btnCell2.Image == CurrentImagre && btnCell5.Image == CurrentImagre && btnCell8.Image == CurrentImagre))
            {
                btnCell2.BackColor = Color.MediumTurquoise;
                btnCell5.BackColor = Color.MediumTurquoise;
                btnCell8.BackColor = Color.MediumTurquoise;
                return;
            }

            else if ((btnCell3.Image == CurrentImagre && btnCell6.Image == CurrentImagre && btnCell9.Image == CurrentImagre))
            {
                btnCell3.BackColor = Color.MediumTurquoise;
                btnCell6.BackColor = Color.MediumTurquoise;
                btnCell9.BackColor = Color.MediumTurquoise;
                return;
            }

            else if ((btnCell1.Image == CurrentImagre && btnCell5.Image == CurrentImagre && btnCell9.Image == CurrentImagre))
            {
                btnCell1.BackColor = Color.MediumTurquoise;
                btnCell5.BackColor = Color.MediumTurquoise;
                btnCell9.BackColor = Color.MediumTurquoise;
                return;
            }

            else if ((btnCell3.Image == CurrentImagre && btnCell5.Image == CurrentImagre && btnCell7.Image == CurrentImagre))
            {
                btnCell3.BackColor = Color.MediumTurquoise;
                btnCell5.BackColor = Color.MediumTurquoise;
                btnCell7.BackColor = Color.MediumTurquoise;
                return;
            }
        }
        bool CheekWinner(Image CurrentImagre)
        {

            if ((btnCell1.Image == CurrentImagre && btnCell2.Image == CurrentImagre && btnCell3.Image == CurrentImagre) ||
                (btnCell4.Image == CurrentImagre && btnCell5.Image == CurrentImagre && btnCell6.Image == CurrentImagre) ||
                (btnCell7.Image == CurrentImagre && btnCell8.Image == CurrentImagre && btnCell9.Image == CurrentImagre) ||
                (btnCell1.Image == CurrentImagre && btnCell4.Image == CurrentImagre && btnCell7.Image == CurrentImagre) ||
                (btnCell2.Image == CurrentImagre && btnCell5.Image == CurrentImagre && btnCell8.Image == CurrentImagre) ||
                (btnCell3.Image == CurrentImagre && btnCell6.Image == CurrentImagre && btnCell9.Image == CurrentImagre) ||
                (btnCell1.Image == CurrentImagre && btnCell5.Image == CurrentImagre && btnCell9.Image == CurrentImagre) ||
                (btnCell3.Image == CurrentImagre && btnCell5.Image == CurrentImagre && btnCell7.Image == CurrentImagre))
            {
                ColorCells(CurrentImagre);
                return true;
            }

            else
                return false;
        }
      
        void FillBoard(object sender)
        {
            if (tbTurn.Text == tbPlayer1.Text)
            {
                if (MulltipleChoice(sender))
                    return;

                ((Button)sender).Image = ImgX;


                if (CheekWinner(((Button)sender).Image))
                {
                    GameOverMessage(tbPlayer1.Text + " Win");
                    tbWinner.Text = tbPlayer1.Text;
                    return;
                }

                if (GameOver())
                {
                    tbWinner.Text = "Draw";
                    return;
                }
            

                tbTurn.Text = tbPlayer2.Text;
            }

            else if (tbTurn.Text == tbPlayer2.Text)
            {
                if (MulltipleChoice(sender))
                    return;

                ((Button)sender).Image = ImgO;
                

                if (CheekWinner(((Button)sender).Image))
                {
                    GameOverMessage(tbPlayer2.Text + " Win");
                    tbWinner.Text = tbPlayer2.Text;
                    return;
                }

                if (GameOver())
                {
                    tbWinner.Text = "Draw";
                    return;
                }
                    

                tbTurn.Text = tbPlayer1.Text;
            }
        }
        void StartGame()
        {
            EnableRoundInfoAndRestartGame();
            DisablePlayersInfoAndStartGame();
            tbTurn.Text = tbPlayer1.Text;
            
        }

        void RestartGame()
        {
            EnablePlayersInfoAndStartGame();
            DisableRoundInfoAndRestartGame();
            ResetBoard();
        }
        private void tbPayersName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void tbPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void tbTurn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCell1_Click(object sender, EventArgs e)
        {
            FillBoard(sender);
        }

        private void btnCell2_Click(object sender, EventArgs e)
        {
            FillBoard(sender);
        }

        private void btnCell3_Click(object sender, EventArgs e)
        {
            FillBoard(sender);
        }

        private void btnCell4_Click(object sender, EventArgs e)
        {
            FillBoard(sender);
        }

        private void btnCell5_Click(object sender, EventArgs e)
        {
            FillBoard(sender);
        }

        private void btnCell6_Click(object sender, EventArgs e)
        {
            FillBoard(sender);
        }

        private void btnCell7_Click(object sender, EventArgs e)
        {
            FillBoard(sender);
        }

        private void btnCell8_Click(object sender, EventArgs e)
        {
            FillBoard(sender);
        }

        private void btnCell9_Click(object sender, EventArgs e)
        {
            FillBoard(sender);
        }
    }
}