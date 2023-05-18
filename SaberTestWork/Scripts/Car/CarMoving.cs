//CarMoving - пример реализации передвижения.
//Сначала проверка на то, что важные детали не сломаны,
//после смотрим на запас топлива в двигателе. Пуст - не двигаемся
//Если всё в порядке, то автомобиль передвигается

//Можно заметить, что все объекты мы получаем с контейнеров. Это пример агрегации.
//То есть вложенные эклземпляры классов не уничтожатся, если
//уничтожить возможность передвижения
namespace SaberTestWork;

public class CarMoving
{
    public event Action Moved;
    
    private Car _car;
    private Engine _engine;

    public CarMoving(Car car, Engine engine)
    {
        _car = car;
        _engine = engine;
    }

    public void ChangePosition(Vector2 direction)
    {
        foreach (var part in _car.Parts.ImportantParts)
        {
            if (part.TryUse() == false)
            {
                return;
            }
        }

        if (_engine.IsEmpty)
            return;
        
        _car.Position += direction;

        OnMoved();
    }

    private void OnMoved()
    {
        Moved?.Invoke();
    }
}