
namespace tic_tac_toe_project
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.X_winds_textBox1 = new System.Windows.Forms.TextBox();
            this.o_wins_textbox = new System.Windows.Forms.TextBox();
            this.x_wins_label2 = new System.Windows.Forms.Label();
            this.o_wins_label2 = new System.Windows.Forms.Label();
            this.draw_label2 = new System.Windows.Forms.Label();
            this.draw_textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.new_game_toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titel_label = new System.Windows.Forms.Label();
            this.blink_Timer = new System.Windows.Forms.Timer(this.components);
            this.baum_label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(72, 80);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5);
            this.button1.Size = new System.Drawing.Size(130, 126);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button7_Click);
            this.button1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(222, 80);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(5);
            this.button2.Size = new System.Drawing.Size(130, 126);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button7_Click);
            this.button2.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(373, 80);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(5);
            this.button3.Size = new System.Drawing.Size(130, 126);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button7_Click);
            this.button3.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(72, 223);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(5);
            this.button4.Size = new System.Drawing.Size(130, 126);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button7_Click);
            this.button4.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(222, 223);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(5);
            this.button5.Size = new System.Drawing.Size(130, 126);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button7_Click);
            this.button5.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button5.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(373, 223);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(5);
            this.button6.Size = new System.Drawing.Size(130, 126);
            this.button6.TabIndex = 3;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button7_Click);
            this.button6.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button6.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(72, 365);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(5);
            this.button7.Size = new System.Drawing.Size(130, 126);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button7.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(222, 366);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(5);
            this.button8.Size = new System.Drawing.Size(130, 126);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button7_Click);
            this.button8.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.button8.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button8.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(373, 366);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(5);
            this.button9.Size = new System.Drawing.Size(130, 125);
            this.button9.TabIndex = 6;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button7_Click);
            this.button9.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button9.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // X_winds_textBox1
            // 
            this.X_winds_textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.X_winds_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_winds_textBox1.ForeColor = System.Drawing.Color.White;
            this.X_winds_textBox1.Location = new System.Drawing.Point(72, 563);
            this.X_winds_textBox1.Name = "X_winds_textBox1";
            this.X_winds_textBox1.ReadOnly = true;
            this.X_winds_textBox1.Size = new System.Drawing.Size(100, 30);
            this.X_winds_textBox1.TabIndex = 10;
            this.X_winds_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // o_wins_textbox
            // 
            this.o_wins_textbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.o_wins_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_wins_textbox.ForeColor = System.Drawing.Color.White;
            this.o_wins_textbox.Location = new System.Drawing.Point(377, 563);
            this.o_wins_textbox.Name = "o_wins_textbox";
            this.o_wins_textbox.ReadOnly = true;
            this.o_wins_textbox.Size = new System.Drawing.Size(100, 30);
            this.o_wins_textbox.TabIndex = 11;
            this.o_wins_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x_wins_label2
            // 
            this.x_wins_label2.AutoSize = true;
            this.x_wins_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_wins_label2.Location = new System.Drawing.Point(77, 517);
            this.x_wins_label2.Name = "x_wins_label2";
            this.x_wins_label2.Size = new System.Drawing.Size(95, 25);
            this.x_wins_label2.TabIndex = 12;
            this.x_wins_label2.Text = "X Wins :";
            // 
            // o_wins_label2
            // 
            this.o_wins_label2.AutoSize = true;
            this.o_wins_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_wins_label2.Location = new System.Drawing.Point(380, 517);
            this.o_wins_label2.Name = "o_wins_label2";
            this.o_wins_label2.Size = new System.Drawing.Size(97, 25);
            this.o_wins_label2.TabIndex = 13;
            this.o_wins_label2.Text = "O Wins :";
            // 
            // draw_label2
            // 
            this.draw_label2.AutoSize = true;
            this.draw_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_label2.Location = new System.Drawing.Point(253, 517);
            this.draw_label2.Name = "draw_label2";
            this.draw_label2.Size = new System.Drawing.Size(61, 25);
            this.draw_label2.TabIndex = 15;
            this.draw_label2.Text = "Draw";
            // 
            // draw_textBox1
            // 
            this.draw_textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.draw_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_textBox1.ForeColor = System.Drawing.Color.White;
            this.draw_textBox1.Location = new System.Drawing.Point(232, 563);
            this.draw_textBox1.Name = "draw_textBox1";
            this.draw_textBox1.ReadOnly = true;
            this.draw_textBox1.Size = new System.Drawing.Size(100, 30);
            this.draw_textBox1.TabIndex = 14;
            this.draw_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_game_toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 60);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // new_game_toolStripButton1
            // 
            this.new_game_toolStripButton1.AutoSize = false;
            this.new_game_toolStripButton1.BackColor = System.Drawing.Color.White;
            this.new_game_toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.new_game_toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.computerToolStripMenuItem,
            this.playerToolStripMenuItem});
            this.new_game_toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_game_toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.new_game_toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("new_game_toolStripButton1.Image")));
            this.new_game_toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.new_game_toolStripButton1.Name = "new_game_toolStripButton1";
            this.new_game_toolStripButton1.Size = new System.Drawing.Size(62, 41);
            this.new_game_toolStripButton1.Text = "Game";
            this.new_game_toolStripButton1.Click += new System.EventHandler(this.new_game_toolStripButton1_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // computerToolStripMenuItem
            // 
            this.computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            this.computerToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.computerToolStripMenuItem.Text = "Computer";
            this.computerToolStripMenuItem.Click += new System.EventHandler(this.computerToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.playerToolStripMenuItem.Text = "2Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // titel_label
            // 
            this.titel_label.AutoSize = true;
            this.titel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel_label.Location = new System.Drawing.Point(201, 19);
            this.titel_label.Name = "titel_label";
            this.titel_label.Size = new System.Drawing.Size(173, 32);
            this.titel_label.TabIndex = 17;
            this.titel_label.Text = "Tic Tac Toe";
            // 
            // blink_Timer
            // 
            this.blink_Timer.Enabled = true;
            this.blink_Timer.Interval = 500;
            this.blink_Timer.Tick += new System.EventHandler(this.blink_Timer_Tick);
            // 
            // baum_label2
            // 
            this.baum_label2.AutoSize = true;
            this.baum_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baum_label2.Location = new System.Drawing.Point(0, 628);
            this.baum_label2.Name = "baum_label2";
            this.baum_label2.Size = new System.Drawing.Size(60, 22);
            this.baum_label2.TabIndex = 18;
            this.baum_label2.Text = "Baum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(562, 669);
            this.Controls.Add(this.baum_label2);
            this.Controls.Add(this.titel_label);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.draw_label2);
            this.Controls.Add(this.draw_textBox1);
            this.Controls.Add(this.o_wins_label2);
            this.Controls.Add(this.x_wins_label2);
            this.Controls.Add(this.o_wins_textbox);
            this.Controls.Add(this.X_winds_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox X_winds_textBox1;
        private System.Windows.Forms.TextBox o_wins_textbox;
        private System.Windows.Forms.Label x_wins_label2;
        private System.Windows.Forms.Label o_wins_label2;
        private System.Windows.Forms.Label draw_label2;
        private System.Windows.Forms.TextBox draw_textBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton new_game_toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.Label titel_label;
        private System.Windows.Forms.Timer blink_Timer;
        private System.Windows.Forms.Label baum_label2;
    }
}

