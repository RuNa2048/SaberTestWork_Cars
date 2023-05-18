//Сам автомобиль. Содержит в освном только данные
//Это самый первый уровень абстракции

namespace SaberTestWork;

public abstract class Car
{
    public Vector2 Position { get; set; }

    //Класс, содержащий 2 списка: главных деталей и декоративных
    public Parts Parts => _parts;
    //Класс, содержащий данные о цене автомобиля и его название
    public CarData Data => _data;
    //Состояние автомобиля
    public CarCondition Condition => _condition;

    private Parts _parts;
    private CarData _data;
    private CarCondition _condition;
    
    public Car(Parts parts)
    {
        _parts = parts;

        _condition = new CarCondition(_parts);
    }

    //Срабатываение коллизии и нанесение урона частям
    public void Collided()
    {
        foreach (var part in _parts.ImportantParts)
        {
            part.ChangeHealth(120);
        }
    }
}