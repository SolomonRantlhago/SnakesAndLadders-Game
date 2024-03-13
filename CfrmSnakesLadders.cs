using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakesAndLadders
{
    public partial class CfrmSnakesLadders : Form
    {
        private Player player1, player2;
        private bool isDone = false;

        public CfrmSnakesLadders()
        {
            InitializeComponent();

            Board board = new Board();
            picBoard.Image = board.image;
            Token token1 = new Token(board, this, Color.Red);
            Token token2 = new Token(board, this, Color.Blue);

            string player1Name = Interaction.InputBox("Player 1 name", "Player 1 name: ");

            player1 = new Player(player1Name, token1);
            btnPlayer1.Text = player1.ToString();
            player1.OnLadder += Player_OnLadder;
            player1.OnSnake += Player_OnSnake;
            player1.OnDone += Player_OnDone;
            player1.OnSix += Player_OnSix;

            string player2Name = Interaction.InputBox("Player 2 name", "Player 2 name: ");
            player2 = new Player(player2Name, token2);
            btnPlayer2.Text = player2.ToString();
            player2.OnLadder += Player_OnLadder;
            player2.OnSnake += Player_OnSnake;
            player2.OnDone += Player_OnDone;
            player2.OnSix += Player_OnSix;

        }  //Constructor

        private void Player_OnLadder(Player player, int block)
        {
            MessageBox.Show("Wow!! You hit a ladder and will now be advanced to block " + block, player.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        } //Player_OnLadder

        private void Player_OnSnake(Player player, int block)
        {
            MessageBox.Show("Sorry!! You hit a snake and will be moved back to block " + block, player.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
        } //Player_OnSnake

        private void Player_OnDone(Player player)
        {
            MessageBox.Show("Congratulations!! You are done.\n" + player + " wins.", "DONE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnPlayer1.Enabled = btnPlayer2.Enabled = false;
            isDone = true;
        } //Player_OnDone

        private void Player_OnSix(Player player)
        {
            MessageBox.Show("You have thrown a six and may throw the dice again.", player.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //Player_OnSix

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } //btnClose_Click

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnPlayer1.Enabled = true;
            player1.Reset();
            player2.Reset();
            isDone = false;
        } //btnStart_Click

        private int ThrowDice()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            return random.Next(1, 7);
        } //ThrowDice

        private void CfrmSnakesLadders_Shown(object sender, EventArgs e)
        {
            //token1.Move(btnPlayer1.Left + btnPlayer1.Width, btnPlayer1.Top);
            //token2.Move(btnPlayer2.Left + btnPlayer2.Width, btnPlayer2.Top);
        } //CfrmSnakesLadders_Shown

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int dice = ThrowDice();

            if (btn == btnPlayer1)
            {
                lblLastDiceRed.Text = "Last dice: " + dice;
                player1.Advance(dice);
            }
            else
            {
                lblLastDiceBlue.Text = "Last dice: " + dice;
                player2.Advance(dice);
            }

            //Switch between players
            if (dice != 6 && !isDone)
            {
                btnPlayer1.Enabled = btn == btnPlayer2;
                btnPlayer2.Enabled = btn == btnPlayer1;
            }

        } //btnPlayer1_Click
    } //class
} //namespace
