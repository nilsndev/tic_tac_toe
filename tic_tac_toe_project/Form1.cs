using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tic_tac_toe_project{
    public partial class Form1 : Form{
        Label[] buttonArr = new Label[9];
        Random random = new Random();
        int k = 0;
        public int xCount = 0;
        public int oCount = 0;
        public bool turn = true;
        bool winner = false;
        string player;
        bool playAgainstComputer = false;
        int drawCount = 0;
        int luckNumber;
        public Form1(){
            InitializeComponent();
        }
        //72; 80

        private void Form1_Load(object sender, EventArgs e){
            autoLoadButtons();
            //resetGameStates();
        }
        void autoLoadButtons(){
            int size = 100;
            int border = (this.buttons_panel1.Width - size * 3) / 3;
            int index = 0;
            for(int j = 0; j < 3; j++){
                for (int i = 0; i < 3; i++) {
                    buttonArr[index] = new Label();
                    buttonArr[index].Size = new Size(size, size);
                    buttonArr[index].BackColor = Color.Gray;
                    buttonArr[index].Tag = index;
                    buttonArr[index].Location = new Point(i * border + size * i, j * border + size * j);
                    buttonArr[index].Click += button7_Click;
                    buttonArr[index].TextAlign = ContentAlignment.MiddleCenter;
                    buttonArr[index].Font = new Font(buttonArr[index].Font.FontFamily, 20,FontStyle.Bold);
                    this.buttons_panel1.Controls.Add(buttonArr[index]);
                    index++;
                }
            }
        }
        private void button7_Click(object sender, EventArgs e){
            try{
                Label b = (Label)sender;
                if (turn){
                    b.Text = "X";
                    turn = false;
                }
                else if (!turn && playAgainstComputer == false){
                    b.Text = "O";
                    turn = true;
                }
                b.Enabled = false;
                checkGameOver();
            }
            catch (Exception ex){
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        void checkButtonsEquals(){
            checkHorizontalEqual();
            checkVerticalEqual();
            checkDiagonalEqual();
        }
        void checkHorizontalEqual(){
            for (int i = 0; i < 9; i+= 3){
                if(buttonArr[i].Text==buttonArr[i+1].Text&&
                buttonArr[i].Text == buttonArr[i+2].Text && buttonArr[i].Text != ""){
                    winner = true;
                    break;
                }
            }
        }
        void checkVerticalEqual(){
            for (int i = 0; i < 3; i ++){
                if (buttonArr[i].Text == buttonArr[i + 3].Text &&
                buttonArr[i].Text == buttonArr[i + 6].Text && buttonArr[i].Text != ""){
                    winner = true;
                    break;
                }
            }
        }
        void checkDiagonalEqual(){
            if (buttonArr[0].Text== buttonArr[4].Text&&
            buttonArr[0].Text== buttonArr[8].Text && buttonArr[0].Text!=""){
                winner = true;
            }
            if(buttonArr[2].Text== buttonArr[4].Text&& buttonArr[2].Text== buttonArr[6].Text&&
            buttonArr[2].Text != ""){
            winner = true;
            }
        }
        public void checkGameOver(){
            k++;
            checkButtonsEquals();
            if (k == 9 && winner == false){
                MessageBox.Show("No Winner");
                ResetGame();
                drawCount++;
                k = 0;
                this.draw_textBox1.Text = drawCount.ToString();
                return;
            }
            if (!turn && playAgainstComputer && !winner && !(k >= 9)){
                Random random = new Random();
                luckNumber = random.Next(1,10);
                randomButton();
                checkButtonsEquals();
                k++;
                turn = true;
            }
            if (winner){
               if(turn == false){
                    player = "X";
                    xCount++;
                }
                if (turn){
                    player = "O";
                    oCount++;
                }
                MessageBox.Show("The game is over " + player + " has won the Game!");
                this.X_winds_textBox1.Text = xCount.ToString();
                this.o_wins_textbox.Text = oCount.ToString();
                ResetGame();
            }
        }
        void randomButton(){
            if (buttonArr[4].Enabled){
                buttonArr[4].Text = "O";
                buttonArr[4].Enabled = false;
            }
            else{
                checkButtonEnabled(buttonArr[luckNumber - 1]);
            }
        } 
        void checkButtonEnabled(Label b){
            if (b.Enabled){
                b.Text = "O";
                b.Enabled = false;
            }
            else{
                luckNumber = random.Next(1,10);
                randomButton();
            }
        }
        void ResetGame(){
            k = 0;
            turn = true;
            winner = false;
            for (int i = 0; i < buttonArr.Length; i++){
                buttonArr[i].Enabled = true;
                buttonArr[i].Text = "";
            }
        }
        private void label1_Click(object sender, EventArgs e){
        }
        private void label1_MouseEnter(object sender, EventArgs e){
            Label b = (Label)sender;
            if (b.Enabled){
                if(turn)
                b.Text = "X";
                if(turn == false)
                    b.Text = "O";
            }
        }
        private void button1_MouseHover(object sender, EventArgs e){
        }
        private void button1_MouseLeave(object sender, EventArgs e){
           Label b = (Label)sender;
           if (b.Enabled){
                b.Text = "";
           }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e){
            ResetGame();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e){
            Application.Exit();
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e){
            resetGameStates();
            MessageBox.Show("Game Reset");
        }
      
        void resetGameStates(){
            this.draw_textBox1.Text = "0";
            this.X_winds_textBox1.Text = "0";
            this.o_wins_textbox.Text = "0";
            drawCount = 0;
            xCount = 0;
            oCount = 0;
            ResetGame();
        }
        private void new_game_toolStripButton1_Click(object sender, EventArgs e){
        }
        private void computerToolStripMenuItem_Click(object sender, EventArgs e){
            try{
                playAgainstComputer = true;
                resetGameStates();
            }
            catch (Exception ex){
                MessageBox.Show("Error: " +ex.Message);
            }
        }
        private void playerToolStripMenuItem_Click(object sender, EventArgs e){
            try{
                playAgainstComputer = false;
                resetGameStates();
            }
            catch(Exception ex){
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttons_panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }       
}

