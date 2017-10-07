using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Threading;

namespace Shortcut_Generator
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        public bool hold = false;
        Point CP;
        //continue
        private void Continue_Click(object sender, EventArgs e)
        {
            string GDText = GameDirectory.Text;
            string SDText = ShortcutDirectory.Text;
            string CDText = CEMUDirectory.Text;
            string IDText = IconDirectory.Text;
            if (Directory.Exists(GDText))
            {
                if (Directory.Exists(SDText))
                {
                    if (File.Exists(CDText + @"\cemu.exe"))
                    {

                        RegistryKey Software =
                          Registry.CurrentUser.CreateSubKey("Software");
                        using (RegistryKey
                            Directories = Software.CreateSubKey("Shortcut-Generator"))
                        {
                            Directories.SetValue("GameDirectory", GDText);
                            Directories.SetValue("ShortcutDirectory", SDText);
                            Directories.SetValue("CEMUDirectory", CDText);
                            if (!IDText.StartsWith("[Experimental]"))
                            {
                                if (File.Exists(IDText + @"\#Credit (don't delete).txt"))
                                {
                                    Directories.SetValue("IconDirectory", IDText);
                                }
                                else
                                {
                                    MessageBox.Show("\"" + IDText + "\\#Credit (don't delete).txt\" not found!\r\nIt is important to keep that file for the Program to know,\r\nif the folder is correct!");
                                    DialogResult dialogResult = MessageBox.Show("Should the file be created in \"" + IDText + "\"?", "Shortcut-Generator", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        Directories.SetValue("IconDirectory", IDText);
                                    }
                                    else if (dialogResult == DialogResult.No)
                                    {
                                        MessageBox.Show("Continuing without Icons!");
                                    }
                                }
                            }
                        }

                        MainWindow m = new MainWindow();
                        this.Hide();
                        m.Show();


                    }
                    else
                    {
                        MessageBox.Show("\"" + SDText + "\\cemu.exe\" not found!");
                    }
                }
                else
                {
                    MessageBox.Show("\"" + SDText + "\" not found!");
                }
            }
            else
            {
                MessageBox.Show("\"" + GDText + "\" not found!");
            }
        }
        //Browse
        private void BrowseGame_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(GameDirectory.Text))
                fbd.SelectedPath = GameDirectory.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
                GameDirectory.Text = fbd.SelectedPath;
        }
        private void BrowseShortcut_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ShortcutDirectory.Text))
                fbd.SelectedPath = ShortcutDirectory.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
                ShortcutDirectory.Text = fbd.SelectedPath;
        }
        private void BrowseCEMU_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(CEMUDirectory.Text))
                fbd.SelectedPath = CEMUDirectory.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
                CEMUDirectory.Text = fbd.SelectedPath;
        }
        private void BrowseIcon_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(IconDirectory.Text))
                fbd.SelectedPath = IconDirectory.Text;
            if (fbd.ShowDialog() == DialogResult.OK)
                IconDirectory.Text = fbd.SelectedPath;
        }
        //move window
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            hold = true;
            CP = Cursor.Position;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            hold = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (hold)
            {
                Point FormLocation = Location;
                Point CursorLocation = Cursor.Position;
                if (FormLocation.Y <= CursorLocation.Y + 50)
                {

                    Top = FormLocation.Y + (CursorLocation.Y - CP.Y);
                    Left = FormLocation.X + (CursorLocation.X - CP.X);
                    //.Show((CursorLocation.X - FormLocation.X).ToString() + "\r\n" + (CursorLocation.Y - FormLocation.Y));
                    CP = Cursor.Position;
                }
            }
        }
        //control box
        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //X
        private void X_MouseEnter(object sender, EventArgs e)
        {
            this.X.Image = global::Shortcut_Generator.Properties.Resources.X_hover;
        }
        private void X_MouseLeave(object sender, EventArgs e)
        {
            this.X.Image = global::Shortcut_Generator.Properties.Resources.X;
        }
        private void X_MouseDown(object sender, MouseEventArgs e)
        {
            this.X.Image = global::Shortcut_Generator.Properties.Resources.X_click;
        }
        private void X_MouseUp(object sender, MouseEventArgs e)
        {
            this.X.Image = global::Shortcut_Generator.Properties.Resources.X_hover;
        }
        //minus
        private void minus_MouseEnter(object sender, EventArgs e)
        {
            this.minus.Image = global::Shortcut_Generator.Properties.Resources.minus_hover;
        }
        private void minus_MouseLeave(object sender, EventArgs e)
        {
            this.minus.Image = global::Shortcut_Generator.Properties.Resources.minus;
        }
        private void minus_MouseDown(object sender, MouseEventArgs e)
        {
            this.minus.Image = global::Shortcut_Generator.Properties.Resources.minus_click;
        }
        private void minus_MouseUp(object sender, MouseEventArgs e)
        {
            this.minus.Image = global::Shortcut_Generator.Properties.Resources.minus_hover;
        }
        //label-moving
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown(sender, e);
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Form1_MouseMove(sender, e);
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Form1_MouseUp(sender, e);
        }
        //credit
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sythriox.deviantart.com/art/Wii-U-game-icons-for-CEMU-667116100");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey Software =
                Registry.CurrentUser.OpenSubKey("Software");
            string SD;
            using (RegistryKey
     Directories = Software.OpenSubKey("Shortcut-Generator"))
            {
                try
                {
                    GameDirectory.Text = Directories.GetValue("GameDirectory").ToString();
                }
                catch
                {
                    GameDirectory.Text = "[Example] C:\\CEMU-Games";
                }
                try
                {
                    SD = Directories.GetValue("ShortcutDirectory").ToString();
                    ShortcutDirectory.Text = SD;
                }
                catch
                {
                    SD = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    ShortcutDirectory.Text = SD;
                }
                try
                {

                    CEMUDirectory.Text = Directories.GetValue("CEMUDirectory").ToString();
                }
                catch
                {
                    CEMUDirectory.Text = "[Example] C:\\Cemu_1.10.0";
                }
                try
                {

                    IconDirectory.Text = Directories.GetValue("IconDirectory").ToString();
                }
                catch
                {
                    IconDirectory.Text = "[Experimental] Directory with properly named files required!";
                }
            }
        }


    }
}
