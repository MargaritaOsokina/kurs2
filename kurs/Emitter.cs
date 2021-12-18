using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static kurs.Particle;

namespace kurs
{
    public class Emitter
    {
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>(); // <<< ТАК ВОТ
        List<Particle> particles = new List<Particle>();
        public int MousePositionX;
        public int MousePositionY;
        public float GravitationX = 0;
        public float GravitationY = 1;

        public void UpdateState()
        {

            foreach (var particle in particles)
            {
                particle.Life -= 1;  // не трогаем
                if (particle.Life < 0)
                {
                    ResetParticle(particle);
                }
                    else
        {
                    // каждая точка по-своему воздействует на вектор скорости
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    // это не трогаем
                    particle.SpeedX += GravitationX;
            particle.SpeedY += GravitationY;

            particle.X += particle.SpeedX;
            particle.Y += particle.SpeedY;
        }
            }
            for (var i = 0; i < 10; ++i)
            {
                if (particles.Count < 500)
                {
                    /* ну и тут чуток подкрутили */
                    var particle = new ParticleColorful();
                    particle.FromColor = Color.White;
                    particle.ToColor = Color.FromArgb(0, Color.Black);

                    ResetParticle(particle); // добавили вызов ResetParticle

                    particles.Add(particle);
                }
                else
                {
                    break;
                }
            }
        }
        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = 20 + Particle.rand.Next(100);
            particle.X = MousePositionX;
            particle.Y = MousePositionY;

            var direction = (double)Particle.rand.Next(360);
            var speed = 1 + Particle.rand.Next(10);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = 2 + Particle.rand.Next(10);
        }
        public void Render(Graphics g)
        {
            // не трогаем
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }

            foreach (var point in impactPoints) // тут теперь  impactPoints
            {
                /* это больше не надо
                g.FillEllipse(
                    new SolidBrush(Color.Red),
                    point.X - 5,
                    point.Y - 5,
                    10,
                    10
                );
                */
                point.Render(g); // это добавили
            }
        }
    }
}
