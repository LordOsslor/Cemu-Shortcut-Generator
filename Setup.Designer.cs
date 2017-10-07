using Microsoft.Win32;
using System;

namespace Shortcut_Generator
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.X = new System.Windows.Forms.PictureBox();
            this.minus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameDirectory = new System.Windows.Forms.TextBox();
            this.BrowseGame = new System.Windows.Forms.Button();
            this.BrowseShortcut = new System.Windows.Forms.Button();
            this.ShortcutDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Continue = new System.Windows.Forms.Button();
            this.BrowseCEMU = new System.Windows.Forms.Button();
            this.CEMUDirectory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseIcon = new System.Windows.Forms.Button();
            this.IconDirectory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).BeginInit();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.Image = ((System.Drawing.Image)(resources.GetObject("X.Image")));
            this.X.Location = new System.Drawing.Point(282, 9);
            this.X.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(22, 19);
            this.X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X.TabIndex = 0;
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
            this.minus.Location = new System.Drawing.Point(257, 9);
            this.minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(22, 19);
            this.minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minus.TabIndex = 1;
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
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Shortcut-Generator";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Game Directory";
            // 
            // GameDirectory
            // 
            this.GameDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GameDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.GameDirectory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.GameDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameDirectory.Location = new System.Drawing.Point(12, 83);
            this.GameDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GameDirectory.Name = "GameDirectory";
            this.GameDirectory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GameDirectory.Size = new System.Drawing.Size(294, 13);
            this.GameDirectory.TabIndex = 12;
            // 
            // BrowseGame
            // 
            this.BrowseGame.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BrowseGame.FlatAppearance.BorderSize = 0;
            this.BrowseGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseGame.Location = new System.Drawing.Point(12, 100);
            this.BrowseGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrowseGame.Name = "BrowseGame";
            this.BrowseGame.Size = new System.Drawing.Size(60, 22);
            this.BrowseGame.TabIndex = 13;
            this.BrowseGame.Text = "Browse";
            this.BrowseGame.UseVisualStyleBackColor = false;
            this.BrowseGame.Click += new System.EventHandler(this.BrowseGame_Click);
            // 
            // BrowseShortcut
            // 
            this.BrowseShortcut.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BrowseShortcut.FlatAppearance.BorderSize = 0;
            this.BrowseShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseShortcut.Location = new System.Drawing.Point(12, 180);
            this.BrowseShortcut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrowseShortcut.Name = "BrowseShortcut";
            this.BrowseShortcut.Size = new System.Drawing.Size(60, 22);
            this.BrowseShortcut.TabIndex = 16;
            this.BrowseShortcut.Text = "Browse";
            this.BrowseShortcut.UseVisualStyleBackColor = false;
            this.BrowseShortcut.Click += new System.EventHandler(this.BrowseShortcut_Click);
            // 
            // ShortcutDirectory
            // 
            this.ShortcutDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ShortcutDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.ShortcutDirectory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ShortcutDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShortcutDirectory.Location = new System.Drawing.Point(12, 163);
            this.ShortcutDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShortcutDirectory.Name = "ShortcutDirectory";
            this.ShortcutDirectory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ShortcutDirectory.Size = new System.Drawing.Size(294, 13);
            this.ShortcutDirectory.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Shortcut Directory";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.linkLabel1.Location = new System.Drawing.Point(10, 394);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Credit for Icons";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Continue
            // 
            this.Continue.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Continue.FlatAppearance.BorderSize = 0;
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Location = new System.Drawing.Point(246, 390);
            this.Continue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(60, 22);
            this.Continue.TabIndex = 21;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // BrowseCEMU
            // 
            this.BrowseCEMU.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BrowseCEMU.FlatAppearance.BorderSize = 0;
            this.BrowseCEMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseCEMU.Location = new System.Drawing.Point(12, 260);
            this.BrowseCEMU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrowseCEMU.Name = "BrowseCEMU";
            this.BrowseCEMU.Size = new System.Drawing.Size(60, 22);
            this.BrowseCEMU.TabIndex = 24;
            this.BrowseCEMU.Text = "Browse";
            this.BrowseCEMU.UseVisualStyleBackColor = false;
            this.BrowseCEMU.Click += new System.EventHandler(this.BrowseCEMU_Click);
            // 
            // CEMUDirectory
            // 
            this.CEMUDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CEMUDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.CEMUDirectory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CEMUDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CEMUDirectory.Location = new System.Drawing.Point(12, 243);
            this.CEMUDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CEMUDirectory.Name = "CEMUDirectory";
            this.CEMUDirectory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CEMUDirectory.Size = new System.Drawing.Size(294, 13);
            this.CEMUDirectory.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "CEMU Directory";
            // 
            // BrowseIcon
            // 
            this.BrowseIcon.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BrowseIcon.FlatAppearance.BorderSize = 0;
            this.BrowseIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseIcon.Location = new System.Drawing.Point(8, 341);
            this.BrowseIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrowseIcon.Name = "BrowseIcon";
            this.BrowseIcon.Size = new System.Drawing.Size(60, 22);
            this.BrowseIcon.TabIndex = 27;
            this.BrowseIcon.Text = "Browse";
            this.BrowseIcon.UseVisualStyleBackColor = false;
            this.BrowseIcon.Click += new System.EventHandler(this.BrowseIcon_Click);
            // 
            // IconDirectory
            // 
            this.IconDirectory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IconDirectory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.IconDirectory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.IconDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IconDirectory.Location = new System.Drawing.Point(8, 324);
            this.IconDirectory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IconDirectory.Name = "IconDirectory";
            this.IconDirectory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.IconDirectory.Size = new System.Drawing.Size(294, 13);
            this.IconDirectory.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "(Icon Directory)";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(314, 447);
            this.ControlBox = false;
            this.Controls.Add(this.BrowseIcon);
            this.Controls.Add(this.IconDirectory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BrowseCEMU);
            this.Controls.Add(this.CEMUDirectory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BrowseShortcut);
            this.Controls.Add(this.ShortcutDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BrowseGame);
            this.Controls.Add(this.GameDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.X);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Setup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox X;
        private System.Windows.Forms.PictureBox minus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GameDirectory;
        private System.Windows.Forms.Button BrowseGame;
        private System.Windows.Forms.Button BrowseShortcut;
        private System.Windows.Forms.TextBox ShortcutDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button BrowseCEMU;
        private System.Windows.Forms.TextBox CEMUDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrowseIcon;
        private System.Windows.Forms.TextBox IconDirectory;
        private System.Windows.Forms.Label label5;
    }
}

