using System;
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
        List<Particle> particles = new List<Particle>();
        GravityPoint point1; // добавил поле под первую точку
        GravityPoint point2; // добавил поле под вторую точку
        public Form1()
        {

            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.emitter = new Emitter
            {
                Direction = 45,
                Spreading = 200,
                SpeedMin = 1,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Height / 5,
                Y = picDisplay.Height / 5,
            };

            emitters.Add(this.emitter);
        }

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

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value; // направлению эмиттера присваиваем значение ползунка 
            lblDirection.Text = $"{tbDirection.Value}°"; // добавил вывод значения

        }

        private void tbGraviton_Scroll(object sender, EventArgs e)//j,объем частиц
        {
            emitter.ParticlesPerTick = tbGraviton.Value;

        }

        private void picDisplay_MouseClick(object sender, MouseEventArgs e)//появдение воронки при нажатии на мышь
        {
            if (e.Button == MouseButtons.Left)
            {
                point1 = new GravityPoint
                {
                    X = picDisplay.Width / 2 + 100,
                    Y = picDisplay.Height / 2,
                }; emitter.impactPoints.Add(point1);
                foreach (var emitter in emitters)
                {
                    emitter.MousePositionX = e.X;
                    emitter.MousePositionY = e.Y;
                }

                // а тут передаем положение мыши, в положение гравитона
                point1.X = e.X;
                point1.Y = e.Y;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new First();
            ifrm.Show(); // отображаем Form2
            this.Close();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
