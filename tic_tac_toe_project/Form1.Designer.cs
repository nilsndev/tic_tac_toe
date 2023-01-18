
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.buttons_panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // X_winds_textBox1
            // 
            this.X_winds_textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.X_winds_textBox1.Enabled = false;
            this.X_winds_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_winds_textBox1.ForeColor = System.Drawing.Color.White;
            this.X_winds_textBox1.Location = new System.Drawing.Point(72, 562);
            this.X_winds_textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X_winds_textBox1.Name = "X_winds_textBox1";
            this.X_winds_textBox1.ReadOnly = true;
            this.X_winds_textBox1.Size = new System.Drawing.Size(100, 26);
            this.X_winds_textBox1.TabIndex = 10;
            this.X_winds_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // o_wins_textbox
            // 
            this.o_wins_textbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.o_wins_textbox.Enabled = false;
            this.o_wins_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_wins_textbox.ForeColor = System.Drawing.Color.White;
            this.o_wins_textbox.Location = new System.Drawing.Point(377, 562);
            this.o_wins_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.o_wins_textbox.Name = "o_wins_textbox";
            this.o_wins_textbox.ReadOnly = true;
            this.o_wins_textbox.Size = new System.Drawing.Size(100, 26);
            this.o_wins_textbox.TabIndex = 11;
            this.o_wins_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // x_wins_label2
            // 
            this.x_wins_label2.AutoSize = true;
            this.x_wins_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_wins_label2.Location = new System.Drawing.Point(77, 517);
            this.x_wins_label2.Name = "x_wins_label2";
            this.x_wins_label2.Size = new System.Drawing.Size(75, 20);
            this.x_wins_label2.TabIndex = 12;
            this.x_wins_label2.Text = "X Wins :";
            // 
            // o_wins_label2
            // 
            this.o_wins_label2.AutoSize = true;
            this.o_wins_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o_wins_label2.Location = new System.Drawing.Point(380, 517);
            this.o_wins_label2.Name = "o_wins_label2";
            this.o_wins_label2.Size = new System.Drawing.Size(76, 20);
            this.o_wins_label2.TabIndex = 13;
            this.o_wins_label2.Text = "O Wins :";
            // 
            // draw_label2
            // 
            this.draw_label2.AutoSize = true;
            this.draw_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_label2.Location = new System.Drawing.Point(253, 517);
            this.draw_label2.Name = "draw_label2";
            this.draw_label2.Size = new System.Drawing.Size(50, 20);
            this.draw_label2.TabIndex = 15;
            this.draw_label2.Text = "Draw";
            // 
            // draw_textBox1
            // 
            this.draw_textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.draw_textBox1.Enabled = false;
            this.draw_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_textBox1.ForeColor = System.Drawing.Color.White;
            this.draw_textBox1.Location = new System.Drawing.Point(232, 562);
            this.draw_textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.draw_textBox1.Name = "draw_textBox1";
            this.draw_textBox1.ReadOnly = true;
            this.draw_textBox1.Size = new System.Drawing.Size(100, 26);
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
            this.toolStrip1.Size = new System.Drawing.Size(563, 60);
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
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // computerToolStripMenuItem
            // 
            this.computerToolStripMenuItem.Name = "computerToolStripMenuItem";
            this.computerToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.computerToolStripMenuItem.Text = "Computer";
            this.computerToolStripMenuItem.Click += new System.EventHandler(this.computerToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.playerToolStripMenuItem.Text = "2Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // titel_label
            // 
            this.titel_label.AutoSize = true;
            this.titel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel_label.Location = new System.Drawing.Point(201, 18);
            this.titel_label.Name = "titel_label";
            this.titel_label.Size = new System.Drawing.Size(134, 26);
            this.titel_label.TabIndex = 17;
            this.titel_label.Text = "Tic Tac Toe";
            // 
            // buttons_panel1
            // 
            this.buttons_panel1.Location = new System.Drawing.Point(63, 84);
            this.buttons_panel1.Name = "buttons_panel1";
            this.buttons_panel1.Size = new System.Drawing.Size(432, 412);
            this.buttons_panel1.TabIndex = 18;
            this.buttons_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.buttons_panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(563, 670);
            this.Controls.Add(this.buttons_panel1);
            this.Controls.Add(this.titel_label);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.draw_label2);
            this.Controls.Add(this.draw_textBox1);
            this.Controls.Add(this.o_wins_label2);
            this.Controls.Add(this.x_wins_label2);
            this.Controls.Add(this.o_wins_textbox);
            this.Controls.Add(this.X_winds_textBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Panel buttons_panel1;
    }
}

