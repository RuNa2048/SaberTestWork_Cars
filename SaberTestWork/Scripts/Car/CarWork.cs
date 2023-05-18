//Класс контейнер, отвечаюшщий за работоспособность компонентов передвижения,
//работы двигателя и получения инпута, с привязкой к классу передвижения

namespace SaberTestWork;

public class CarWork: IUpdatable
{
    private CarMoving _moving;
    private Engine _engine;
    private MovingDirection _direction;
    private CarCollision _collision;

    public CarCollision Collision => _collision;

    public CarWork(CarMoving moving, Engine engine, MovingDirection direction)
    {
        _moving = moving;
        _engine = engine;
        _direction = direction;

        //Пример композиции. Если удалить CarWork, то экземпляр класса
        //коллизии также уничтожится
        _collision = new CarCollision();
        
        _moving.Moved += _engine.RemoveCapacity;
    }

    public void Update()
    {
        _moving.ChangePosition(_direction.GetDirectionValue());
    }

    public void Destroy()
    {
        _moving.Moved -= _engine.RemoveCapacity;
    }
}