//Абстракция класса автомобиля. Основная идея была в том, чтобы
//дать особенному типу особенные возможности работы, но
//отказался от идеи

namespace SaberTestWork;

public abstract class ElectricCar: Car
{
    protected ElectricCar(Parts parts) : base(parts)
    {
    }
}