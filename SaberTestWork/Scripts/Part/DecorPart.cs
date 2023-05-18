//Наследник класса запчасти
//Говорит о том, что каждая декоративная деталь имеет цвет

namespace SaberTestWork
{
    public abstract class DecorPart: CarPart
    {
        private Color _color;

        public DecorPart(Color color)
        {
            _color = color;
        }

        public Color Color => _color;
    }
}