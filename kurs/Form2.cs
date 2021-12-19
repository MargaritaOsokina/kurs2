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
        // собственно список, пока пустой
        List<Particle> particles = new List<Particle>();
        private int MousePositionX = 0;
        private int MousePositionY = 0;
        //  Emitter emitter = new Emitter(); // добавили эмиттер
        GravityPoint point1; // добавил поле под первую точку
        GravityPoint point2; // добавил поле под вторую точку
        public Form2()
        {
            InitializeComponent();
            picDisplay2.Image = new Bitmap(picDisplay2.Width, picDisplay2.Height);

            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay2.Height / 5,
                Y = picDisplay2.Height / 5,
            };

            emitters.Add(this.emitter);

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
            point2 = new GravityPoint
            {
                X = picDisplay2.Width / 2 - 100,
                Y = picDisplay2.Height / 2,
            };
            //emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);



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
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // тут теперь обновляем эмиттер

            using (var g = Graphics.FromImage(picDisplay2.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }

            picDisplay2.Invalidate();
        }

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
    }
}
