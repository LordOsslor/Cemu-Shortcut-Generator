using System.Windows.Forms;

namespace Shortcut_Generator
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.X = new System.Windows.Forms.PictureBox();
            this.minus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckGames = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateShortcuts = new System.Windows.Forms.Button();
            this.CheckAll = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.Image = ((System.Drawing.Image)(resources.GetObject("X.Image")));
            this.X.Location = new System.Drawing.Point(408, 9);
            this.X.Margin = new System.Windows.Forms.Padding(2);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(22, 19);
            this.X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X.TabIndex = 1;
            this.X.TabStop = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            this.X.MouseDown += new System.Windows.Forms.MouseEventHandler(this.X_MouseDown);
            this.X.MouseEnter += new System.EventHandler(this.X_MouseEnter);
            this.X.MouseLeave += new System.EventHandler(this.X_MouseLeave);
            this.X.MouseUp += new System.Windows.Forms.MouseEventHandler(this.X_MouseUp);
            // 
            // minus
            // 
            this.minus.Image = ((System.Drawing.Image)(resources.GetObject("minus.Image")));
            this.minus.Location = new System.Drawing.Point(382, 9);
            this.minus.Margin = new System.Windows.Forms.Padding(2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(22, 19);
            this.minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minus.TabIndex = 2;
            this.minus.TabStop = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            this.minus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minus_MouseDown);
            this.minus.MouseEnter += new System.EventHandler(this.minus_MouseEnter);
            this.minus.MouseLeave += new System.EventHandler(this.minus_MouseLeave);
            this.minus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minus_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Shortcut-Generator";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // CheckGames
            // 
            this.CheckGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckGames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckGames.CheckOnClick = true;
            this.CheckGames.Items.AddRange(new object[] {
            ""});
            this.CheckGames.Location = new System.Drawing.Point(10, 58);
            this.CheckGames.Margin = new System.Windows.Forms.Padding(2);
            this.CheckGames.Name = "CheckGames";
            this.CheckGames.Size = new System.Drawing.Size(420, 150);
            this.CheckGames.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Games to create Shortcuts for:";
            // 
            // CreateShortcuts
            // 
            this.CreateShortcuts.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CreateShortcuts.FlatAppearance.BorderSize = 0;
            this.CreateShortcuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateShortcuts.Location = new System.Drawing.Point(370, 306);
            this.CreateShortcuts.Margin = new System.Windows.Forms.Padding(2);
            this.CreateShortcuts.Name = "CreateShortcuts";
            this.CreateShortcuts.Size = new System.Drawing.Size(60, 22);
            this.CreateShortcuts.TabIndex = 24;
            this.CreateShortcuts.Text = "Continue";
            this.CreateShortcuts.UseVisualStyleBackColor = false;
            this.CreateShortcuts.Click += new System.EventHandler(this.Continue_Click);
            // 
            // CheckAll
            // 
            this.CheckAll.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CheckAll.FlatAppearance.BorderSize = 0;
            this.CheckAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.CheckAll.Location = new System.Drawing.Point(10, 274);
            this.CheckAll.Margin = new System.Windows.Forms.Padding(2);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(60, 28);
            this.CheckAll.TabIndex = 25;
            this.CheckAll.Text = "Check all";
            this.CheckAll.UseVisualStyleBackColor = false;
            this.CheckAll.Click += new System.EventHandler(this.CheckAll_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(211, 310);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Try to use matching icons";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Back.FlatAppearance.BorderSize = 0;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(10, 306);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(60, 22);
            this.Back.TabIndex = 27;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(439, 338);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.CreateShortcuts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.X);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_OnClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox X;
        private System.Windows.Forms.PictureBox minus;
        private System.Windows.Forms.Label label1;
        private CheckedListBox CheckGames;
        private Label label2;
        private Button CreateShortcuts;
        private Button CheckAll;
        private CheckBox checkBox1;
        private Button Back;
    }
}