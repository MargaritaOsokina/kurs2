﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static kurs.Particle;

namespace kurs
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;
        // собственно список, пока пустой
        List<Particle> particles = new List<Particle>();
        private int MousePositionX = 0;
        private int MousePositionY = 0;
      //  Emitter emitter = new Emitter(); // добавили эмиттер

        public Form1()
        {
            
                InitializeComponent();
                picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

                this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
                {
                    Direction = 0,
                    Spreading = 10,
                    SpeedMin = 10,
                    SpeedMax = 10,
                    ColorFrom = Color.Gold,
                    ColorTo = Color.FromArgb(0, Color.Red),
                    ParticlesPerTick = 10,
                    X = picDisplay.Width / 2,
                    Y = picDisplay.Height / 2,
                };

                emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся
            
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

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g); // а тут теперь рендерим через эмиттер
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value; // направлению эмиттера присваиваем значение ползунка 
            lblDirection.Text = $"{tbDirection.Value}°"; // добавил вывод значения

        }
    }
}
