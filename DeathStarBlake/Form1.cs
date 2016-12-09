using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace DeathStarBlake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            transmissionLabel.Visible = false;
            Refresh();

            Graphics fg = this.CreateGraphics();

            Pen whitePen = new Pen(Color.White, 1);
            Pen blackPen = new Pen(Color.Black, 4);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            fg.Clear(Color.Black);
            Font drawFont = new Font("Arial", 14, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Green);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            fg.DrawString("Fly over the death star and drop a bomb to explode it.\nGood Luck Rookie!", drawFont, drawBrush, 0, 0);
            Thread.Sleep(5000);
            fg.Clear(Color.Black);
            fg.DrawEllipse(whitePen, 90, 70, 350, 350);
            fg.DrawPie(whitePen, 215, 55, 100, 100, 218, 105);
            fg.DrawPie(blackPen, 215, 50, 100, 100, 218, 105);
            fg.FillPie(blackBrush, 215, 52, 100, 100, 218, 105);
            fg.DrawLine(whitePen, 260, 102, 260, 260);
            fg.DrawLine(whitePen, 270, 102, 270, 260);

            SoundPlayer player2 = new SoundPlayer(Properties.Resources.X_wing_Sound_Effects);
            player2.Play();
            for (int x = 0, y = 15; x <= 260; x++)
            {
                //act
                fg.Clear(Color.Black);


                fg.FillRectangle(whiteBrush, x, y, 10, 10);
                fg.DrawEllipse(whitePen, 90, 70, 350, 350);
                fg.DrawPie(whitePen, 215, 55, 100, 100, 218, 105);
                fg.DrawPie(blackPen, 215, 50, 100, 100, 218, 105);
                fg.FillPie(blackBrush, 215, 52, 100, 100, 218, 105);
                fg.DrawLine(whitePen, 260, 102, 260, 260);
                fg.DrawLine(whitePen, 270, 102, 270, 260);
                Thread.Sleep(10);

            }
            for (int x = 260, y = 15; y <= 265; y++)
            {
                x = x + 2;
                fg.Clear(Color.Black);

                fg.FillRectangle(whiteBrush, x, 15, 10, 10);
                fg.FillEllipse(whiteBrush, 260, y, 10, 10);
                fg.DrawEllipse(whitePen, 90, 70, 350, 350);
                fg.DrawPie(whitePen, 215, 55, 100, 100, 218, 105);
                fg.DrawPie(blackPen, 215, 50, 100, 100, 218, 105);
                fg.FillPie(blackBrush, 215, 52, 100, 100, 218, 105);
                fg.DrawLine(whitePen, 260, 102, 260, 260);
                fg.DrawLine(whitePen, 270, 102, 270, 260);
                Thread.Sleep(10);
            }
            SoundPlayer player = new SoundPlayer(Properties.Resources.Explosion_Death_Star_Star_Wars);
            player.Play();
            for (int x = 1; x < 400; x++)
                {
                
                fg.FillEllipse(redBrush, 240 - x/2, 265 - x/2, 50 + x  ,50 + x );
                

                  Thread.Sleep(10);
                
            }
            
        }
    }
}
