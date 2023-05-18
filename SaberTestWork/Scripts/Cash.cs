//Класс Для работы с деньгами. Отвечаю за хранение, добавление и снятие

namespace SaberTestWork;

public class Cash
{
    private int _currentMoney;
    
    public int MoneyQuantity => _currentMoney;

    public void AddMoney(int amount)
    {
        _currentMoney += amount;
    }
    
    public bool TryRemoveMoney(int amount)
    {
        if (_currentMoney < amount)
            return false;
        
        _currentMoney -= amount;

        return true;
    }
}