using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace kurs
{
    public abstract class IImpactPoint
    {
        public float X; // ну точка же, вот и две координаты
        public float Y;
        public Color color;
        public int schet = 0;


        // абстрактный метод с помощью которого будем изменять состояние частиц
        // например притягивать
        public abstract void ImpactParticle(Particle particle);

        // базовый класс для отрисовки точечки
        public virtual void Render(Graphics g)
        {

        }
    }
}
