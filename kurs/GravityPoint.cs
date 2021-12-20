using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace kurs
{
    public class GravityPoint : IImpactPoint
    {
        public int Power = 100; // сила притяжения
        int count = 0;
        public Color ColorFrom = Color.White; // начальный цвет частицы
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
            // буду рисовать окружность с диаметром равным Power
            g.DrawEllipse(
                   new Pen(Color.Green),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
          

            if (count>0) // если частица оказалось внутри окружности
            {
                g.DrawString(
          $"{count}", // надпись, можно перенос строки вставлять (если вы Катя, то может не работать и надо использовать \r\n)
           new Font("Verdana", 10), // шрифт и его размер
           new SolidBrush(Color.White), // цвет шрифта
           X, // расположение в пространстве
           Y
       );
            }
        }
       
    }
}
