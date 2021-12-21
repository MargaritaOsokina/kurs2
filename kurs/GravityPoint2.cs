using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace kurs
{
    class GravityPoint2 : IImpactPoint
    {
        public int rad = 80;
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>(); // <<< ТАК ВОТ
        public Color FromColor;
        public Color ToColor;
        public int Power = 80; // сила притяжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < rad / 2) // если частица оказалось внутри окружности
            {
                if (color == Color.Red)
                {  var p = (particle as ParticleColorful);
                        (particle as ParticleColorful).FromColor = color;
                        p.ToColor = color;
                }
                else if (color == Color.Orange)
                {
                    var p = (particle as ParticleColorful);
                    (particle as ParticleColorful).FromColor = color;
                    p.ToColor = color;
                }
                else if (color == Color.Yellow)
                {
                    var p = (particle as ParticleColorful);
                    (particle as ParticleColorful).FromColor = color;
                    p.ToColor = color;
                }
                else if (color == Color.Green)
                {
                    var p = (particle as ParticleColorful);
                    (particle as ParticleColorful).FromColor = color;
                    p.ToColor = color;
                }
                else if (color == Color.Blue)
                {
                    var p = (particle as ParticleColorful);
                    (particle as ParticleColorful).FromColor = color;
                    p.ToColor = color;
                }
                else if (color == Color.DarkBlue)
                {
                    var p = (particle as ParticleColorful);
                    (particle as ParticleColorful).FromColor = color;
                    p.ToColor = color;
                }
                else if (color == Color.Violet)
                {
                    var p = (particle as ParticleColorful);
                    (particle as ParticleColorful).FromColor = color;
                    p.ToColor = color;
                }
            }
        }

        public override void Render(Graphics g)
        {
            {
                g.DrawEllipse(
                   new Pen(color),
                   X - rad / 2,
                   Y - rad / 2,
                   rad,
                  rad
               );

            }
        }
    }
}
