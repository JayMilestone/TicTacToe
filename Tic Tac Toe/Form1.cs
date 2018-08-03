using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int amount = 0;
        bool hasWon = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked!!");
            Button b = (Button)sender;
            if(turn)
            {
                amount++;
                b.Text = "X";
                b.ForeColor = Color.Blue;
                turn = !turn;
                b.Enabled = false;
                TextColorChanger(b);
            }
            else
            {
                amount++;
                b.Text = "O";
                turn = !turn;
                b.ForeColor = Color.Red;
                b.Enabled = false;
                TextColorChanger(b);
            }
            CheckForWinner(b);
        }
        void TextColorChanger(Button b)
        {
            if(b.Name == "A1")
            {
                if(b.Text == "X")
                {
                    A1Text.Text = b.Text;
                    A1Text.ForeColor = Color.Blue;
                }
                else
                {
                    A1Text.Text = b.Text;
                    A1Text.ForeColor = Color.Red;
                }
            }
            if (b.Name == "A2")
            {
                if (b.Text == "X")
                {
                    B1Text.Text = b.Text;
                    B1Text.ForeColor = Color.Blue;
                }
                else
                {
                    B1Text.Text = b.Text;
                    B1Text.ForeColor = Color.Red;
                }
            }
            if (b.Name == "A3")
            {
                if (b.Text == "X")
                {
                    C1Text.Text = b.Text;
                    C1Text.ForeColor = Color.Blue;
                }
                else
                {
                    C1Text.Text = b.Text;
                    C1Text.ForeColor = Color.Red;
                }
            }
            if (b.Name == "B1")
            {
                if (b.Text == "X")
                {
                    A2Text.Text = b.Text;
                    A2Text.ForeColor = Color.Blue;
                }
                else
                {
                    A2Text.Text = b.Text;
                    A2Text.ForeColor = Color.Red;
                }
            }
            if (b.Name == "B2")
            {
                if (b.Text == "X")
                {
                    B2Text.Text = b.Text;
                    B2Text.ForeColor = Color.Blue;
                }
                else
                {
                    B2Text.Text = b.Text;
                    B2Text.ForeColor = Color.Red;
                }
            }
            if (b.Name == "B3")
            {
                if (b.Text == "X")
                {
                    C2Text.Text = b.Text;
                    C2Text.ForeColor = Color.Blue;
                }
                else
                {
                    C2Text.Text = b.Text;
                    C2Text.ForeColor = Color.Red;
                }
            }
            if (b.Name == "C1")
            {
                if (b.Text == "X")
                {
                    A3Text.Text = b.Text;
                    A3Text.ForeColor = Color.Blue;
                }
                else
                {
                    A3Text.Text = b.Text;
                    A3Text.ForeColor = Color.Red;
                }
            }
            if (b.Name == "C2")
            {
                if (b.Text == "X")
                {
                    B3Text.Text = b.Text;
                    B3Text.ForeColor = Color.Blue;
                }
                else
                {
                    B3Text.Text = b.Text;
                    B3Text.ForeColor = Color.Red;
                }
            }
            if (b.Name == "C3")
            {
                if (b.Text == "X")
                {
                    C3Text.Text = b.Text;
                    C3Text.ForeColor = Color.Blue;
                }
                else
                {
                    C3Text.Text = b.Text;
                    C3Text.ForeColor = Color.Red;
                }
            }
        }
        void ResetText()
        {
            A1Text.Text = "";
            A2Text.Text = "";
            A3Text.Text = "";
            B1Text.Text = "";
            B2Text.Text = "";
            B3Text.Text = "";
            C1Text.Text = "";
            C2Text.Text = "";
            C3Text.Text = "";
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a button that says", "things about the application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void CheckForWinner(Button b)
        {
            if(A1.Text == A2.Text && A1.Enabled == false && A2.Text == A3.Text && A2.Enabled == false)
            {
                MessageBox.Show(A1.Text + " has won!");
                hasWon = true;
                // You won
            }
            if (B1.Text == B2.Text && B1.Enabled == false && B2.Text == B3.Text && B2.Enabled == false)
            {
                MessageBox.Show(B1.Text + " has won!");
                hasWon = true;
                // You won
            }
            if (C1.Text == C2.Text && A1.Enabled == false && C2.Text == C3.Text && C2.Enabled == false)
            {
                MessageBox.Show(C1.Text + " has won!");
                hasWon = true;
                // You won
            }
            if (A1.Text == B1.Text && A1.Enabled == false && B1.Text == C1.Text && B1.Enabled == false)
            {
                MessageBox.Show(A1.Text + " has won!");
                hasWon = true;
                // You won
            }
            if (A2.Text == B2.Text && A2.Enabled == false && B2.Text == C2.Text && B2.Enabled == false)
            {
                MessageBox.Show(A2.Text + " has won!");
                hasWon = true;
                // You won
            }

            if (A3.Text == B3.Text && A3.Enabled == false && B3.Text == C3.Text && B3.Enabled == false)
            {
                MessageBox.Show(A3.Text + " has won!");
                hasWon = true;
                // You won
            }
            if (A1.Text == B2.Text && A1.Enabled == false && B2.Text == C3.Text && B2.Enabled == false)
            {
                MessageBox.Show(A1.Text + " has won!");
                hasWon = true;
                // You won
            }
            if(A3.Text == B2.Text && A3.Enabled == false && B2.Text == C1.Text && B2.Enabled == false)
            {
                MessageBox.Show(A3.Text + " has won!");
                hasWon = true;
                // You won
            }
            if(hasWon == false)
            {
                if (amount == 9)
                {
                    MessageBox.Show("Draw!");
                    hasWon = true;
                    amount = 0;
                }
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            hasWon = false;
            turn = true;
            amount = 0; 
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            ResetText();
        }
    }
}
