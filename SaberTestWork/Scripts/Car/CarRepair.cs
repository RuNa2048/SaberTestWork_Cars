//Система для работы с попыткой починкой автомобиля и его деталей

namespace SaberTestWork;

public class CarRepair
{
    public Car _car;

    public CarRepair(Car car)
    {
        _car = car;
    }

    //Считывает состояние машины. Если сломана важная деталь, то чинит все детали.
    //Если просто требует ремонта, то только декаротивные.
    //Понимаю, что по-хорошему тут нужно было делать логику починки именно конкретной детали
    //Опять же пример полиморфизма, где мы не работает с конкретной реализацией, а абстракцией.
    //Это также 5 принцип SOLID. Dipendecy inversion
    public bool TryRepair()
    {
        CarConditionsStudy conditionsStudy = _car.Condition.Assess();

        if (conditionsStudy == CarConditionsStudy.Broken)
        {
            RepairImportant();

            RepairDecor();

            return true;
        }
        
        if (conditionsStudy == CarConditionsStudy.RequiresRepair)
        {
            RepairDecor();

            return true;
        }

        return false;
    }

    private void RepairImportant()
    {
        foreach (var part in _car.Parts.ImportantParts)
        {
            part.Repair();
        }
    }
    
    private void RepairDecor()
    {
        foreach (var part in _car.Parts.DecorParts)
        {
            part.Repair();
        }
    }
}