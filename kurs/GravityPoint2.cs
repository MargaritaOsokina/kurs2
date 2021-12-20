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
        List<Particle> particles = new List<Particle>();
        public Color FromColor;
        public Color ToColor;
        public int Power = 80; // сила притяжения
        int count = 0;

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            Color pp = Color.Purple;
            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы
            if (r + particle.Radius < rad / 2) // если частица оказалось внутри окружности
            {
                if (color == Color.Red)
                {
                    if (particle is ParticleColorful)
                    {
                        var p = (particle as ParticleColorful);
                        (particle as ParticleColorful).FromColor = Color.Red;
                        p.ToColor = Color.Red;


                    }
                }
                else if (color == Color.Orange)
                {
                    if (particle is ParticleColorful)
                    {
                        var p = (particle as ParticleColorful);
                        (particle as ParticleColorful).FromColor = Color.Orange;
                        p.ToColor = Color.Orange;

                    }
                }
                else if (color == Color.Yellow)
                {
                    if (particle is ParticleColorful)
                    {
                        var p = (particle as ParticleColorful);
                        (particle as ParticleColorful).FromColor = Color.Yellow;
                        p.ToColor = Color.Yellow;

                    }
                }
                else if (color == Color.Green)
                {
                    if (particle is ParticleColorful)
                    {
                        var p = (particle as ParticleColorful);
                        (particle as ParticleColorful).FromColor = Color.Green;
                        p.ToColor = Color.Green;

                    }
                }
                else if (color == Color.Blue)
                {


                    if (particle is ParticleColorful)
                    {
                        var p = (particle as ParticleColorful);
                        (particle as ParticleColorful).FromColor = Color.Blue;
                        p.ToColor = Color.Blue;

                    }
                }
                else if (color == Color.DarkBlue)
                {


                    if (particle is ParticleColorful)
                    {
                        var p = (particle as ParticleColorful);
                        (particle as ParticleColorful).FromColor = Color.DarkBlue;
                        p.ToColor = Color.DarkBlue;

                    }
                }
                else if (color == Color.Violet)
                {


                    if (particle is ParticleColorful)
                    {
                        var p = (particle as ParticleColorful);
                        (particle as ParticleColorful).FromColor = Color.Violet;
                        p.ToColor = Color.Violet;

                    }
                }

                // float gX = X - particle.X;
                // float gY = Y - particle.Y;
                //  double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы

                /* if (r + particle.Radius < Power / 2&& r + particle.Radius > Power / 2 - Power / 100)
                 {

                     // particle.Life = 0;

                         count++;
                         var p = (particle as ParticleColorful);
                         (particle as ParticleColorful).FromColor = Color.BlueViolet;
                         p.ToColor = Color.BlueViolet;

                 }
                */



                // if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
                // {
                count++;


                /* if (particle is ParticleColorful)
                 {
                     var p = (particle as ParticleColorful);
                     (particle as ParticleColorful).FromColor = Color.BlueViolet;
                     p.ToColor = Color.BlueViolet;
                 }*/
                //   particle.Life = 0;
                // }


                //меняется цвет
                /*  if(particle is ParticleColorful)
                  {
                      var p = (particle as ParticleColorful);
                      (particle as ParticleColorful).FromColor = Color.BlueViolet;
                      p.ToColor = Color.BlueViolet;
                  }
                */


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
