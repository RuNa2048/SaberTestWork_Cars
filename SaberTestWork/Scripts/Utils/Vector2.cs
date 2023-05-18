//Класс для демонстрирования перегрузки оператора и 
//попытке выполнить проект в рантайме с показом работоспособности передвижения

namespace SaberTestWork;

public class Vector2
{
    public int X { get; }
    public int Y { get; }

    public Vector2(int x, int y)
    {
        X = x;
        Y = y;
    }

    //Ещё один пример полиморфизма - перегрузка оператора
    public static Vector2 operator +(Vector2 first, Vector2 second)
    {
        return new Vector2(first.X + second.X, first.Y + second.Y);
    }
}