using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tick_tock
{
    public partial class Form1 : Form
    {
        private bool is_player1_turn;
        private int button_click_count;
        private string P1_sign,P2_sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enable_disable_buttons(false);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Khan Company Game", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (P1first.Checked == true)
                is_player1_turn = true;
            else
                is_player1_turn = false;
            if (P1cross.Checked == true)
            {
                P1_sign = "X";
                P2_sign = "O";
            }
            else
            {
                P1_sign = "O";
                P2_sign = "X";
            }
            enable_disable_buttons(true);
            enable_disable_player_options(false);
            button_click_count = 0;
        }
        private void enable_disable_buttons(bool enable)
        {
            button1.Enabled = enable;
            button2.Enabled = enable;
            button3.Enabled = enable;
            button4.Enabled = enable;
            button5.Enabled = enable;
            button6.Enabled = enable;
            button7.Enabled = enable;
            button8.Enabled = enable;
            button9.Enabled = enable;
            newToolStripMenuItem.Enabled = !enable;
            resetToolStripMenuItem.Enabled = enable;
            clear_buttons();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enable_disable_buttons(false);
            enable_disable_player_options(true);
        }
        private void enable_disable_player_options(bool enable)
        {
            NamesgroupBox3.Enabled = enable;
            CrossgroupBox1.Enabled = enable;
            FirstgroupBox2.Enabled = enable;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (is_player1_turn == true)
            {
                b.Text = P1_sign;
                is_player1_turn = false;
                b.Enabled = false;
            }
            else
            {
                b.Text = P2_sign;
                is_player1_turn = true;
                b.Enabled = false;
            }
            button_click_count++;
            check_winner();
        }

        private void check_winner()
        {
            bool win = false;
            string winner = "";
            if (button_click_count <=9)
            {
                if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
                {
                    win = true;
                    winner = button1.Text;
                }
                else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
                {
                    win = true;
                    winner = button4.Text;
                }
                else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
                {
                    win = true;
                    winner = button7.Text;
                }
                else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
                {
                    win = true;
                    winner = button1.Text;
                }
                else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
                {
                    win = true;
                    winner = button2.Text;
                }
                else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
                {
                    win = true;
                    winner = button3.Text;
                }
                else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
                {
                    win = true;
                    winner = button1.Text;
                }
                else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
                {
                    win = true;
                    winner = button3.Text;
                }
                if (win == true)
                {
                    if (winner == P1_sign)
                        MessageBox.Show(textBox1.Text + " is winner", "Result");
                    else
                        MessageBox.Show(textBox2.Text + " is winner", "Result");
                    enable_disable_buttons(false);//to reset Game
                    enable_disable_player_options(true);
                }
            }
            if(button_click_count==9)
            {
                if (!win)
                {
                    MessageBox.Show("The Game is Draw", "Result");
                    enable_disable_buttons(false);//to reset Game
                    enable_disable_player_options(true);
                }
            }
        }
        private void clear_buttons()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

    }
}
