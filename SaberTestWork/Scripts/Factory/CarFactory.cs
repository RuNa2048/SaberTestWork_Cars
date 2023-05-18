//Мини паттерн фабрики

namespace SaberTestWork;

public class CarFactory
{
    private readonly List<Car> _cars = new ();
    
    private Parts _parts;
    private Car _currentCar;

    public Car CurrentCar => _currentCar;

    public void CreateBmw(Parts parts)
    {
        BmwX6 bmw = new BmwX6(parts);
        Create(bmw);
    }
    
    public void CreateLada(Parts parts)
    {
        LadaVesta lada = new LadaVesta(parts);
        Create(lada);
    }
    
    public void CreateTesla(Parts parts)
    {
        TeslaX tesla = new TeslaX(parts);
        Create(tesla);
    }
    
    //Использование полиморфизма
    private void Create(Car car)
    {
        _currentCar = car;
        
        _cars.Add(car);
    }
}