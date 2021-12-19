using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace kurs
{
    public class GravityPoint : IImpactPoint
    {
        public int Power = 100; // сила притяжения

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
       
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {if(particle is ParticleColorful)
                {
                    var p = (particle as ParticleColorful);
                    (particle as ParticleColorful).FromColor = Color.BlueViolet;
                    p.ToColor = Color.BlueViolet;
                }



               /// Color color = Color.White;



               // particle.ToColor = ColorTo;

                //  var particle = new ParticleColorful();
                // var color = Color.FromArgb();
                //Color ColorFrom = Color.White;
                // ColorFrom = Color.White,
                //  ColorTo = Color.FromArgb(0, Color.Red),
            }
        }
        public override void Render(Graphics g)
        {
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
       
    }
}
