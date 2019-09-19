using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool isplayeroneTurn;
        private int buttonclickCount;
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Khan Games", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableButtons(false);
            startNewGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;
        
        
        }

        private void startNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableButtons(true);
            startNewGameToolStripMenuItem.Enabled = false;
            resetGameToolStripMenuItem.Enabled = true;
            enablesplayers(false);
            isplayeroneTurn = playerTwoStartrdbtn.Checked;
            buttonclickCount = 0;
        }
        private void EnableButtons(bool enable)
        {
            B1button.Enabled = enable;
            B2button.Enabled = enable;
            B3button.Enabled = enable;
            B4button.Enabled = enable;
            B5button.Enabled = enable;
            B6button.Enabled = enable;
            B7button.Enabled = enable;
            B8button.Enabled = enable;
            B9button.Enabled = enable;
        }

        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
            
        }

        private void buttonsClear()
        {
            B1button.Text= "";
            B2button.Text = "";
            B3button.Text = "";
            B4button.Text = "";
            B5button.Text = "";
            B6button.Text = "";
            B7button.Text = "";
            B8button.Text = "";
            B9button.Text = "";
           





        }

        private void ResetGame()
        {
            EnableButtons(false);
            startNewGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;
            enablesplayers(true);
            buttonsClear();
        }
        private void enablesplayers(bool enable)
        {
            plyrnamesgroupBox1.Enabled = enable;
            selectXgrpbox.Enabled = enable;
            selectStartgrpbox.Enabled = enable;

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (isplayeroneTurn == true)
            {
                if (playerTwoXrdbtn.Checked)

                    b.Text = "X";
                else
                    b.Text = "0";
                    isplayeroneTurn = false;
                    b.Enabled = false;
                
            
            }
            else
            {
                if (playerOneXrdbtn.Checked)

                    b.Text = "X";
                else
                    b.Text = "0";
                isplayeroneTurn = true;
             b.Enabled = false;
            }
            buttonclickCount++;
            CheckTheWinner();
        }

        private void CheckTheWinner()
        {
            bool iswinner = false;
            if (buttonclickCount==9)
            {
                MessageBox.Show("Match is draw,Please Reset The Game", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
            else
            {
                if ((B1button.Text == B2button.Text) && (B2button.Text == B3button.Text) && (!B1button.Enabled))
                    iswinner = true;
                if ((B4button.Text == B5button.Text) && (B5button.Text == B6button.Text) && (!B4button.Enabled))
                    iswinner = true;
                if ((B7button.Text == B8button.Text) && (B8button.Text == B9button.Text) && (!B7button.Enabled))
                    iswinner = true;
                if ((B1button.Text == B4button.Text) && (B4button.Text == B7button.Text) && (!B7button.Enabled))
                    iswinner = true;
                if ((B2button.Text == B5button.Text) && (B5button.Text == B8button.Text) && (!B8button.Enabled))
                    iswinner = true;
                if ((B3button.Text == B6button.Text) && (B6button.Text == B9button.Text) && (!B6button.Enabled))
                    iswinner = true;
                if ((B1button.Text == B5button.Text) && (B5button.Text == B9button.Text) && (!B1button.Enabled))
                    iswinner = true;
                if ((B3button.Text == B5button.Text) && (B5button.Text == B7button.Text) && (!B5button.Enabled))
                    iswinner = true;
                if (iswinner ==true)
                {
                    if (isplayeroneTurn == false)
                        MessageBox.Show(textBox1.Text +"is winner", "game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(textBox2.Text +"is winner", "game over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();
                }

            }
            
        }

       
    }
}
