using System;
using System.Collections.Generic;
using System.Text;

namespace kurs
{
    public class TopEmitter : Emitter
    {
        public int Width; // длина экрана
       // public int ParticlesPerTick = 1; // добавил новое поле


        public override void ResetParticle(Particle particle)
        {
            base.ResetParticle(particle); // вызываем базовый сброс частицы, там жизнь переопределяется и все такое

            // а теперь тут уже подкручиваем параметры движения
            particle.X = Particle.rand.Next(Width); // позиция X -- произвольная точка от 0 до Width
            particle.Y = 0;  // ноль -- это верх экрана 

            particle.SpeedY = 8; // падаем вниз по умолчанию
            particle.SpeedX = Particle.rand.Next(-2, 2); // разброс влево и вправа у частиц 
           // particle.ParticlesPerTick = 1; // добавил новое поле

    }
}
}