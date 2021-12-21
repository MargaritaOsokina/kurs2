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
        List<Particle> particles = new List<Particle>();
        GravityPoint2 point1; // добавил поле под первую точку
        GravityPoint2 point2; // добавил поле под вторую точку
        GravityPoint2 point3;
        GravityPoint2 point4;
        GravityPoint2 point5;
        GravityPoint2 point6;
        GravityPoint2 point7;
        public Form2()
        {
            InitializeComponent();
            picDisplay2.Image = new Bitmap(picDisplay2.Width, picDisplay2.Height);


            emitter = new TopEmitter
            { ParticlesPerTick = 10,
                Width = picDisplay2.Width,
                GravitationY = 0.25f
            };

            emitters.Add(emitter);


            point1 = new GravityPoint2
            {
                X = picDisplay2.Width / 2 ,
                Y = picDisplay2.Height / 2,
                color = Color.Red

            };
            point2 = new GravityPoint2
            {
                X = picDisplay2.Width / 2+100,
                Y = picDisplay2.Height / 2+15,
                color = Color.Orange
            };
            point3 = new GravityPoint2
            {
                X = picDisplay2.Width / 2-100,
                Y = picDisplay2.Height / 2+15,
                color = Color.Yellow
            };
            point4 = new GravityPoint2
            {
                X = picDisplay2.Width / 2 - 200,
                Y = picDisplay2.Height / 2+30,
                color = Color.Green
            };
            point5 = new GravityPoint2
            {
                X = picDisplay2.Width / 2 + 200,
                Y = picDisplay2.Height / 2+30,
                color = Color.Blue
            };
            point6 = new GravityPoint2
            {
                X = picDisplay2.Width / 2 + 300,
                Y = picDisplay2.Height / 2 + 45,
                color = Color.DarkBlue
            };
            point7 = new GravityPoint2
            {
                X = picDisplay2.Width / 2 - 300,
                Y = picDisplay2.Height / 2 + 45,
                color = Color.Violet
            };

            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point4);
            emitter.impactPoints.Add(point5);
            emitter.impactPoints.Add(point6);
            emitter.impactPoints.Add(point7);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {


            point1.Y = tbGraviton2.Value;
            point2.Y = tbGraviton2.Value+15;
            point3.Y = tbGraviton2.Value+15;
            point4.Y = tbGraviton2.Value+30;
            point5.Y = tbGraviton2.Value+30; 
            point6.Y = tbGraviton2.Value+45;
            point7.Y = tbGraviton2.Value+45;
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

        private void tbDirection2_Scroll(object sender, EventArgs e)
        {
            point1.rad = tbDirection2.Value;
            point2.rad = tbDirection2.Value;
            point3.rad = tbDirection2.Value;
            point4.rad = tbDirection2.Value;
            point5.rad = tbDirection2.Value;
            point6.rad = tbDirection2.Value;
            point7.rad = tbDirection2.Value;
        }

}
}
