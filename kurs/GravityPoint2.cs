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

        public int Power = 80; // сила притяжения
        int count = 0;

        // а сюда по сути скопировали с минимальными правками то что было в UpdateState
        public override void ImpactParticle(Particle particle)
        {

            float gX = X - particle.X;
            float gY = Y - particle.Y;
            double r = Math.Sqrt(gX * gX + gY * gY); // считаем расстояние от центра точки до центра частицы

            /* if (r + particle.Radius < Power / 2&& r + particle.Radius > Power / 2 - Power / 100)
             {

                 // particle.Life = 0;

                     count++;
                     var p = (particle as ParticleColorful);
                     (particle as ParticleColorful).FromColor = Color.BlueViolet;
                     p.ToColor = Color.BlueViolet;

             }
            */



            if (r + particle.Radius < Power / 2) // если частица оказалось внутри окружности
            {
                count++;


                /* if (particle is ParticleColorful)
                 {
                     var p = (particle as ParticleColorful);
                     (particle as ParticleColorful).FromColor = Color.BlueViolet;
                     p.ToColor = Color.BlueViolet;
                 }*/
                particle.Life = 0;
            }


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
                var stringFormat = new StringFormat(); // создаем экземпляр класса
                stringFormat.Alignment = StringAlignment.Center; // выравнивание по горизонтали
                stringFormat.LineAlignment = StringAlignment.Center; // выравнивание по вертикали

                if (color == Color.Red)
                {
                    if (schet >= 250)
                    {
                        g.FillEllipse(
                        new SolidBrush(Color.Red),
                        X - rad / 2,
                        Y - rad / 2,
                        rad,
                        rad);

                        g.DrawString(
                        $"{schet}",
                        new Font("Verdana", 14),
                        new SolidBrush(Color.DeepSkyBlue),
                        X,
                        Y,
                        stringFormat
                         );
                    }
                    else
                    {
                        g.DrawString(
                         $"{schet}",
                         new Font("Verdana", 10),
                         new SolidBrush(Color.DeepSkyBlue),
                         X,
                         Y,
                         stringFormat
                          );
                    }
                }

            }
        }
    }
}
