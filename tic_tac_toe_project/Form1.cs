using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toe_project
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int zufall = 0;
        int k = 0;
        public int xCount = 0;
        public int oCount = 0;
        public bool turn = true;
        bool winner = false;
        string player;
        bool playAgainstComputer = false;
        int drawCount = 0;
        int luckNumber;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                resetGameStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
     

      
        private  void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;


                if (turn)
                {
                    b.Text = "X";
                    turn = false;

                }
                else if (!turn && playAgainstComputer == false)
                {
                    b.Text = "O";
                    turn = true;
                }
                b.Enabled = false;

                checkGameOver();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       

        void checkButtonsEquals()
        {
            //Horizontal

            if (button1.Text == button2.Text && button1.Text == button3.Text && button1.Text != "") { winner = true; }
            if (button4.Text == button5.Text && button4.Text == button6.Text && button4.Text != "") { winner = true; }
            if (button7.Text == button8.Text && button7.Text == button9.Text && button7.Text != "") { winner = true; }

            //Vertical

            if (button1.Text == button4.Text && button1.Text == button7.Text && button7.Text != "") { winner = true; }
            if (button2.Text == button5.Text && button2.Text == button8.Text && button2.Text != "") { winner = true; }
            if (button3.Text == button6.Text && button3.Text == button9.Text && button3.Text != "") { winner = true; }

            //Diagonal

            if (button1.Text == button5.Text && button1.Text == button9.Text && button1.Text != "") { winner = true; }
            if (button3.Text == button5.Text && button3.Text == button7.Text && button3.Text != "") { winner = true; }
        }
        public void checkGameOver()
        {




            k++;
            
            //butt
            checkButtonsEquals();

            if (k == 9 && winner == false)
            {
                MessageBox.Show("No Winner");
                ResetGame();
                drawCount++;
                k = 0;

                this.draw_textBox1.Text = drawCount.ToString();
                return;
            }

            if (!turn && playAgainstComputer && !winner && !(k >= 9))
            {
              
                Random random = new Random();
                luckNumber = random.Next(1,10);

                randomButton();
                checkButtonsEquals();
                k++;
               
                turn = true;
            }
         
            if (winner)
            {
               if(turn == false)
                {
                    player = "X";
                    xCount++;
                }

             
                if (turn)
                {
                    player = "O";
                    oCount++;
                }
              

                MessageBox.Show("The game is over " + player + " has won the Game!");
                this.X_winds_textBox1.Text = xCount.ToString();
                this.o_wins_textbox.Text = oCount.ToString();
               



                ResetGame();

               
            }
            

          

        }
           void randomButton()
        {
            
            if (computerKi() == true)
            {
                return;
            }
            else
            {
                switch (luckNumber)
                {
                    case 1: checkButtonEnabled(button1); break;


                    case 2: checkButtonEnabled(button2); break;
                    case 3: checkButtonEnabled(button3); break;
                    case 4: checkButtonEnabled(button4); break;
                    case 5: checkButtonEnabled(button5); break;
                    case 6: checkButtonEnabled(button6); break;
                    case 7: checkButtonEnabled(button7); break;
                    case 8: checkButtonEnabled(button8); break;
                    case 9: checkButtonEnabled(button9); break;
                }
            }
          
        }
        bool computerKi()
        {

            //Middle Button
            if (button5.Enabled)
            {
                button5.Text = "O";
                button5.Enabled = false;

                return true;
            }
            //Diagonal
            if (button5.Text == "X" && button9.Text == "X" && button1.Enabled)
            {
                button1.Text = "O";
                button1.Enabled = false;
                return true;
            }
            if (button5.Text == "X" && button1.Text == "X" && button9.Enabled)
            {
                button9.Text = "O";
                button9.Enabled = false;
                return true;
            }
            if (button5.Text == "X" && button3.Text == "X" && button7.Enabled)
            {
                button7.Text = "O";
                button7.Enabled = false;
                return true;
            }
            if (button5.Text == "X" && button7.Text == "X" && button3.Enabled)
            {
                button3.Text = "O";
                button3.Enabled = false;
                return true;
            }
            // Horizontal Middle
            if (button5.Text == "X" && button6.Text == "X" && button4.Enabled)
            {
                button4.Text = "O";
                button4.Enabled = false;
                return true;
            }
            if (button5.Text == "X" && button4.Text == "X" && button6.Enabled)
            {
                button6.Text = "O";
                button6.Enabled = false;
                return true;
            }
            //Horizontal Top
            if (button1.Text == "X" && button2.Text == "X" && button3.Enabled)
            {
                button3.Text = "O";
                button3.Enabled = false;
                return true;
            }
            if (button1.Text == "X" && button3.Text == "X" && button2.Enabled)
            {
                button2.Text = "O";
                button2.Enabled = false;
                return true;
            }
            if (button3.Text == "X" && button2.Text == "X" && button1.Enabled)
            {
                button1.Text = "O";
                button1.Enabled = false;
                return true;
            }
            //Horizontal Bottom
            //Vertical Middle
            if (button5.Text == "X" && button2.Text == "X" && button8.Enabled)
            {
                button8.Text = "O";

                button8.Enabled = false;
                return true;
            }
            if (button5.Text == "X" && button8.Text == "X" && button2.Enabled)
            {
                button2.Text = "O";
                button2.Enabled = false;
                return true;
            }
            // Vertical Left
            if (button1.Text == "X" && button4.Text == "X" && button7.Enabled)
            {
                button7.Text = "O";
                button7.Enabled = false;
                return true;
            }
            if (button7.Text == "X" && button1.Text == "X" && button4.Enabled)
            {
                button4.Text = "O";
                button4.Enabled = false;
                return true;

              
            }
            if (button7.Text == "X" && button4.Text == "X" && button1.Enabled)
            {
                button1.Text = "O";
                button1.Enabled = false;
                return true;
            }
            //Vertical Right
            if (button3.Text == "X" && button6.Text == "X" && button9.Enabled)
            {
                button9.Text = "O";
                button9.Enabled = false;
                return true;


            }
            if (button9.Text == "X" && button3.Text == "X" && button6.Enabled)
            {
                button6.Text = "O";
                button6.Enabled = false;
                return true;
            }
            if (button6.Text == "X" && button9.Text == "X" && button3.Enabled)
            {
                button3.Text = "O";
                button3.Enabled = false;
                return true;
            }
            return false;

            

        }
        void checkButtonEnabled(Button b)
        {
            if (b.Enabled)
            {
                b.Text = "O";
                b.Enabled = false;
            }
            else
            {
                luckNumber = random.Next(1,10);
                randomButton();
            }
        }
             void ResetGame()
            {
            k = 0;
            turn = true;
            winner = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";


            k = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if(turn)
                b.Text = "X";

                if(turn == false)
                    b.Text = "O";
            }
           

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGameStates();
            MessageBox.Show("Game Reset");
        }


        void resetGameStates()
        {
            this.draw_textBox1.Text = "0";
            this.X_winds_textBox1.Text = "0";
            this.o_wins_textbox.Text = "0";
            drawCount = 0;
            xCount = 0;
            oCount = 0;
         
            ResetGame();
            
        }

        private void new_game_toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                playAgainstComputer = true;
                resetGameStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex.Message);
            }
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                playAgainstComputer = false;
                resetGameStates();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void blink_Timer_Tick(object sender, EventArgs e)
        {
        
        }
    }

       
    }

