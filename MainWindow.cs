using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Threading;
using System.Text.RegularExpressions;

namespace Shortcut_Generator
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public bool hold = false;
        Point CP;
        List<string> NoIco = new List<string>();
        List<string> GamePaths = new List<string>();
        List<string> Games = new List<string>();
        List<string> SelectedGames = new List<string>();
        string GD;
        string SD;
        string CD;
        string ID = "";
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        private void reset()
        {
            CheckGames.Items.Clear();
            GamePaths = new List<string>();
            Games = new List<string>();
            SelectedGames = new List<string>();
            try
            {
                GamePaths.AddRange(Directory.GetFiles(GD, "*.rpx", SearchOption.AllDirectories));
                GamePaths.AddRange(Directory.GetFiles(GD, "*.wud", SearchOption.AllDirectories));
                GamePaths.AddRange(Directory.GetFiles(GD, "*.wux", SearchOption.AllDirectories));
                GamePaths.AddRange(Directory.GetFiles(GD, "*.iso", SearchOption.AllDirectories));
                GamePaths.AddRange(Directory.GetFiles(GD, "*.wad", SearchOption.AllDirectories));
            }
            catch (System.UnauthorizedAccessException e)
            {
                MessageBox.Show("No Access to " + GD + "\r\n" + e.Message);
                Back_Click(new object(), new EventArgs());
            }
            foreach (var s in GamePaths)
            {
                Games.Add(ToGameName(s));
            }
            CheckGames.Items.AddRange(Games.ToArray());
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            RegistryKey Software =
            Registry.CurrentUser.OpenSubKey("Software");
            using (RegistryKey
                Directories = Software.OpenSubKey("Shortcut-Generator"))
            {
                GD = Directories.GetValue("GameDirectory").ToString();
                SD = Directories.GetValue("ShortcutDirectory").ToString();
                CD = Directories.GetValue("CEMUDirectory").ToString();
                try
                {
                    ID = Directories.GetValue("IconDirectory").ToString();
                }
                catch
                {
                    checkBox1.Enabled = false;
                }
            }
            reset();
        }
        private void CreateShortcut(string shpath, string CMpath, string Game, string Gamepath, string GameID, string icopath)
        {

            WshShell shell = new WshShell();
            object shDesktop = (object)"Desktop";
            string shortcutAddress = shpath + @"\" + Game + ".lnk";

            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "Created by Shortcut-Generator for CEMU";
            shortcut.Hotkey = "Ctrl+Shift+N";
            shortcut.TargetPath = CMpath + @"\cemu.exe";
            shortcut.WorkingDirectory = CMpath;
            if (checkBox1.Checked)
            {
                if (Directory.Exists(icopath))
                {
                    string ico = icopath + @"\" + GameID + @".ico";
                    if (System.IO.File.Exists(ico))
                    {
                        shortcut.IconLocation = ico;
                    }
                    else
                    {
                        NoIco.Add(Game + " [" + GameID + "]\r\n");
                    }
                }
                else
                {
                    MessageBox.Show("Your Icon-Path hasn't been found?");
                    DialogResult dialogResult = MessageBox.Show("Do you want to select a new one?\r\n(Alternatively Icons are unavailable)", "Shortcut-Generator", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Back_Click(new object(), new EventArgs());
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Continuing without Icons!");
                    }
                }
            }
            string args = "-g \"" + Gamepath + "\"";
            if (checkBox1.Checked)
                args += " -f";
            shortcut.Arguments = args;
            shortcut.Save();

            reset();
            //MainWindow_Load(new object(), new EventArgs());
        }
        private void Continue_Click(object sender, EventArgs e)
        {
            foreach (Object item in CheckGames.CheckedItems)
            {
                int index = CheckGames.Items.IndexOf(item);
                SelectedGames.Add(GamePaths[index]);
                //MessageBox.Show(index.ToString());
            }
            foreach (var item in SelectedGames)
            {
                CreateShortcut(SD, CD, ToGameName(item), item, ToID(item), ID);
            }
            if (NoIco.Count > 0)
            {
                MessageBox.Show("Icons not found for:\r\n" + string.Join("", NoIco));
                NoIco = new List<string>();
            }
        }
        private string ToGameName(string s)
        {
            string a = s;
            a = a.Substring(GD.Length + 1, a.Length - GD.Length - 1);
            a = a.Substring(0, a.IndexOfAny(new char[] { '\\', '[' }));
            a = a.TrimEnd(' ');
            return a;
        }
        private string ToID(string s)
        {
            string a = s;
            a = a.Substring(GD.Length + 1, a.Length - GD.Length - 1);
            a = a.Substring(0, a.IndexOf('\\'));
            a = Regex.Match(a, @"\[([^)]*)\]").Groups[1].Value;
            //MessageBox.Show((a.Substring(Math.Max(0, a.Length - 4))).ToString());
            if (a.Substring(Math.Max(0, a.Length - 2)) == "01")
            {
                //MessageBox.Show("1");
                a = a.Substring(0, a.Length - 2);
                StringBuilder sb = new StringBuilder(a);
                if (a.Substring(Math.Max(0, a.Length - 2)) == "01")
                {
                    sb[a.Length - 3] = 'E';
                }
                else
                {
                    sb[a.Length - 1] = 'E';
                }
                a = sb.ToString();
            }
            else
            {
                StringBuilder sb = new StringBuilder(a);
                //sb[a.Length - 3] = 'E';
                //a = sb.ToString();
                try
                {
                    a = a.Substring(0, a.LastIndexOf('P'));
                }
                catch
                {
                    return "ERROR, for not Erupean games with strange ID-Thingys\r\n--(like [BRX(E/P/A)NV]; not ending on 01 or 0101), not supported quite yet!\r\n--Also, dont put .rpx/.iso/.wud/.wad files in folders, without []!";
                }
                a += "E";
            }
            //MessageBox.Show(a);
            return a;
        }
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            hold = true;
            CP = Cursor.Position;
        }
        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            hold = false;
        }
        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
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
            MainWindow_MouseDown(sender, e);
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            MainWindow_MouseMove(sender, e);
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            MainWindow_MouseUp(sender, e);
        }
        //credit
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sythriox.deviantart.com/art/Wii-U-game-icons-for-CEMU-667116100");
        }
        private void MainWindow_OnClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void CheckAll_Click(object sender, EventArgs e)
        {
            bool b = true;
            if (CheckGames.CheckedItems.Count == Games.Count)
                b = false;
            for (int i = 0; i < CheckGames.Items.Count; i++)
            {
                CheckGames.SetItemChecked(i, b);
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Setup s = new Setup();
            s.Show();
            this.Hide();
        }
    }
}