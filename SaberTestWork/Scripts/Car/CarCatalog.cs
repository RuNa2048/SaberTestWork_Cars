namespace SaberTestWork;

public class CarCatalog
{
    private List<Car> _cars;

    private Cash _cash;
    
    public CarCatalog(List<Car> cars, Cash cash)
    {
        _cars = cars;
        _cash = cash;
    }

    public CarData Choose(int index)
    {
        return _cars[index].Data;
    }

    public Car TryBuy(int index)
    {
        int carPrice = _cars[index].Data.Price;
        
        if(_cash.TryRemoveMoney(carPrice))
            return _cars[index];

        return null;
    }
}