using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TiltaMacro.Properties;

namespace TiltaMacro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Imports
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Int32 vKey);


        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

#endregion
        public static bool Tecla(Keys vKey)
        {
            return 0 != (GetAsyncKeyState((int)vKey) & 0x8000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (Tecla(Keys.F1))
                {
                    label1.Text = "F1";
                    textBox1.Text = Settings.Default.F1;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F2))
                {
                    label1.Text = "F2";
                    textBox1.Text = Settings.Default.F2;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F3))
                {
                    label1.Text = "F3";
                    textBox1.Text = Settings.Default.F3;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F4))
                {
                    label1.Text = "F4";
                    textBox1.Text = Settings.Default.F4;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F5))
                {
                    label1.Text = "F5";
                    textBox1.Text = Settings.Default.F5;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F6))
                {
                    label1.Text = "F6";
                    textBox1.Text = Settings.Default.F6;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F7))
                {
                    label1.Text = "F7";
                    textBox1.Text = Settings.Default.F7;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F8))
                {
                    label1.Text = "F8";
                    textBox1.Text = Settings.Default.F8;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F9))
                {
                    label1.Text = "F9";
                    textBox1.Text = Settings.Default.F9;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F10))
                {
                    label1.Text = "F10";
                    textBox1.Text = Settings.Default.F10;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F11))
                {
                    label1.Text = "F11";
                    textBox1.Text = Settings.Default.F11;
                    Func1(true);
                    textBox1.Focus();
                }
                else if (Tecla(Keys.F12))
                {
                    label1.Text = "F12";
                    textBox1.Text = Settings.Default.F12;
                    Func1(true);
                    textBox1.Focus();
                }
            }
            else
            {
                if (Tecla(Keys.F1))
                {
                    if (Settings.Default.F1 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F1);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }

                }
                else if (Tecla(Keys.F2))
                {
                    if (Settings.Default.F2 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F2);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F3))
                {
                    if (Settings.Default.F3 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F3);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F4))
                {
                    if (Settings.Default.F4 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F4);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F5))
                {
                    if (Settings.Default.F5 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F5);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F6))
                {
                    if (Settings.Default.F6 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F6);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F7))
                {
                    if (Settings.Default.F7 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F7);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F8))
                {
                    if (Settings.Default.F8 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F8);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F9))
                {
                    if (Settings.Default.F9 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F9);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F10))
                {
                    if (Settings.Default.F10 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F10);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F11))
                {
                    if (Settings.Default.F11 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F11);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
                else if (Tecla(Keys.F12))
                {
                    if (Settings.Default.F12 != "")
                    {
                        timer1.Enabled = false;
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("/all " + Settings.Default.F12);
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.Flush();
                        timer1.Enabled = true;
                    }
                }
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                label1.Visible = true;
                BackgroundImage = Resources.TM_C;

                pictureBox5.Visible = true;
                pictureBox5.Enabled = true;
            }
            else
            {
                label1.Visible = false;
                BackgroundImage = Resources.TM_R;
                label1.Text = "F_";
                pictureBox5.Visible = false;
                pictureBox5.Enabled = false;
                Func1(false);
                label2.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (label1.Text == "F1")
            {
                Settings.Default.F1 = textBox1.Text;
            }
            else if (label1.Text == "F2")
            {
                Settings.Default.F2 = textBox1.Text;
            }
            else if (label1.Text == "F3")
            {
                Settings.Default.F3 = textBox1.Text;
            }
            else if (label1.Text == "F4")
            {
                Settings.Default.F4 = textBox1.Text;
            }
            else if (label1.Text == "F5")
            {
                Settings.Default.F5 = textBox1.Text;
            }
            else if (label1.Text == "F6")
            {
                Settings.Default.F6 = textBox1.Text;
            }
            else if (label1.Text == "F7")
            {
                Settings.Default.F7 = textBox1.Text;
            }
            else if (label1.Text == "F8")
            {
                Settings.Default.F8 = textBox1.Text;
            }
            else if (label1.Text == "F9")
            {
                Settings.Default.F9 = textBox1.Text;
            }
            else if (label1.Text == "F10")
            {
                Settings.Default.F10 = textBox1.Text;
            }
            else if (label1.Text == "F11")
            {
                Settings.Default.F11 = textBox1.Text;
            }
            else if (label1.Text == "F12")
            {
                Settings.Default.F12 = textBox1.Text;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            checkBox1.Checked = false;
            Func1(false);
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Resources.TM_S_2;            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Default;
            pictureBox1.Image = Resources.TM_S_1;
           
        }

        public void Func1(bool estado)
        {
            label1.Visible = estado;
            pictureBox1.Visible = estado;
            pictureBox1.Enabled = estado;
            textBox1.Enabled = estado;
            textBox1.Visible = estado;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Resources.TM_X2;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Default;
            pictureBox2.Image = Resources.TM_X;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            /* Minimizando aplicação na bandeja do windows */
            Visible = false;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;

            if (Settings.Default.NMinimiza == true)
            {
                notifyIcon1.BalloonTipText = "Quando minimizado, ficarei na bandeja do windows";
                notifyIcon1.ShowBalloonTip(1000);
                notifyIcon1.Text = "Na primeira vez minimizado, suas configurações são salvas";
                notifyIcon1.ShowBalloonTip(1000);
                Settings.Default.NMinimiza = false;

                Settings.Default.Save();
            }

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Cursor = Cursors.Default;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = true;
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.me/desceproplay");
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Cursor = Cursors.Hand;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Cursor = Cursors.Default;
        }

        private void discordDPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.me/desceproplay");
        }

        private void facebookDPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/DesceProPlayDPP");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Resources.TM_L_2;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Cursor = Cursors.Default;
            pictureBox5.Image = Resources.TM_L_1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja mesmo apagar as configurações salvas? \n Todas suas frases serão permanentemente apagadas...","Apagar configurações",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Settings.Default.F1 = "";
                Settings.Default.F2 = "";
                Settings.Default.F3 = "";
                Settings.Default.F4 = "";
                Settings.Default.F5 = "";
                Settings.Default.F6 = "";
                Settings.Default.F7 = "";
                Settings.Default.F8 = "";
                Settings.Default.F9 = "";
                Settings.Default.F10 = "";
                Settings.Default.F11 = "";
                Settings.Default.F12 = "";

                textBox1.Text = "";

                Settings.Default.Save();
            }
        }
    }
}
