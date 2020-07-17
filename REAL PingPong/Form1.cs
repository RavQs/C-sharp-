using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REAL_PingPong
{
    public partial class Form1 : Form
    {

        private int speed_horizontal = 4;
        private int speed_ver = 4;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;

            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            gamepanel.Top = background.Bottom - (background.Bottom / 10);

            loselabel.Visible = false;
            loselabel.Left = (background.Width / 2) - (loselabel.Width / 2);
            loselabel.Top = (background.Width / 2) - (loselabel.Width / 2);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.Space)
            {
                gamecube.Left = 70;
                gamecube.Top = 50;
                speed_horizontal = 4;
                speed_ver = 4;
                score = 0;
                timer.Enabled = true;
                Result.Text = "Результат: 0";
                loselabel.Visible = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gamepanel.Left = Cursor.Position.X - (gamepanel.Width / 2);

            gamecube.Left += speed_horizontal;
            gamecube.Top += speed_ver;

            if (gamecube.Left <= background.Left)
                speed_horizontal *= -1;
            if (gamecube.Right >= background.Right)
                speed_horizontal *= -1;
            if (gamecube.Top <= background.Top)
                speed_ver *= -1;
            if (gamecube.Bottom >= background.Bottom)
            {
                timer.Enabled = false;
                loselabel.Visible = true;
            }
                

            if (gamecube.Bottom >= gamepanel.Top
               && gamecube.Bottom <= gamepanel.Bottom
                 && gamecube.Left >= gamepanel.Left
                  && gamecube.Right <= gamepanel.Right)
            {
                speed_horizontal += 1;
                speed_ver += 1;
                speed_ver *= -1;
                score += 1;
                Result.Text = "Результат:" + score.ToString();

                Random RandColors = new Random();
                background.BackColor = Color.FromArgb(RandColors.Next(150, 255), RandColors.Next(150, 255), RandColors.Next(150, 255));
            }
        }
    }
}
