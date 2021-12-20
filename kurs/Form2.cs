using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kurs
{
    public partial class Form2 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        Emitter emitter1;

        // собственно список, пока пустой
        List<Particle> particles = new List<Particle>();
        private int MousePositionX = 0;
        private int MousePositionY = 0;
        //  Emitter emitter = new Emitter(); // добавили эмиттер
        GravityPoint2 point1; // добавил поле под первую точку
        GravityPoint2 point2; // добавил поле под вторую точку
        GravityPoint2 point3;
        GravityPoint2 point4;
        GravityPoint2 point5;
        public Form2()
        {
            InitializeComponent();
            picDisplay2.Image = new Bitmap(picDisplay2.Width, picDisplay2.Height);




            emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.MistyRose,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay2.Width / 5,
                Y = picDisplay2.Height / 5,
            };

            emitters.Add(emitter);


            emitter1 = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay2.Width / 2,
                Y = picDisplay2.Height / 2,
            };

            emitters.Add(emitter1);
            /*

                        this.emitter = new TopEmitter
                        {
                            Width = picDisplay2.Width,
                            GravitationY = 0.25f
                        };

                        emitters.Add(this.emitter);
            */
            // добавил гравитон
            //  emitter.impactPoints.Add(new GravityPoint
            //  {
            //      X = picDisplay.Width / 2 + 100,
            //      Y = picDisplay.Height / 2,
            //  });
            // point1 = new GravityPoint
            //   {
            //     X = picDisplay.Width / 2 + 100,
            //     Y = picDisplay.Height / 2,
            //  };

            point1 = new GravityPoint2
            {
                X = picDisplay2.Width / 2 ,
                Y = picDisplay2.Height / 2,
                color = Color.Purple

            };
            point2 = new GravityPoint2
            {
                X = picDisplay2.Width / 2+100,
                Y = picDisplay2.Height / 2+15,
                color = Color.Aqua
            };
            point3 = new GravityPoint2
            {
                X = picDisplay2.Width / 2-100,
                Y = picDisplay2.Height / 2+15,
                color = Color.Violet
            };
            point4 = new GravityPoint2
            {
                X = picDisplay2.Width / 2 - 200,
                Y = picDisplay2.Height / 2+30,
                color = Color.Aquamarine
            };
            point5 = new GravityPoint2
            {
                X = picDisplay2.Width / 2 + 200,
                Y = picDisplay2.Height / 2+30,
                color = Color.Red
            };
            
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point4);
            emitter.impactPoints.Add(point5);


            // добавил второй гравитон
            //  emitter.impactPoints.Add(new GravityPoint
            //  {
            //      X = picDisplay.Width / 2 - 100,
            //     Y = picDisplay.Height / 2,
            // });
            /*
            // гравитон
            emitter.impactPoints.Add(new GravityPoint
            {
                X = (float)(picDisplay.Width * 0.25),
                Y = picDisplay.Height / 2
            });

            // в центре антигравитон
            emitter.impactPoints.Add(new AntiGravityPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2
            });

            // снова гравитон
            emitter.impactPoints.Add(new GravityPoint
            {
                X = (float)(picDisplay.Width * 0.75),
                Y = picDisplay.Height / 2
            });*/
        }


        // функция рендеринга


        // ну и обработка тика таймера, тут просто декомпозицию выполнили


        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection2.Value; // направлению эмиттера присваиваем значение ползунка 
            lblDirection.Text = $"{tbDirection2.Value}°"; // добавил вывод значения

        }

      

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (var emitter in emitters)
                {
                    emitter.MousePositionX = e.X;
                    emitter.MousePositionY = e.Y;
                }

                // а тут передаем положение мыши, в положение гравитона
                point2.X = e.X;
                point2.Y = e.Y;
            }


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            point2.Power = tbGraviton2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new First();
            ifrm.Show(); // отображаем Form2
            this.Close(); // скрываем Form1 (this - текущая форма)
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            emitter.UpdateState(); // тут теперь обновляем эмиттер

            using (var g = Graphics.FromImage(picDisplay2.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }
           

            picDisplay2.Invalidate();

        }
    }
}
