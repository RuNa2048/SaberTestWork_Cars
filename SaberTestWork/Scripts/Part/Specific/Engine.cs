//Наследник важной детали. Нужен для рабоыт с топливом.
//Прекрасный пример ООП. Мы создали объект, который может быть как ДВС,
//так и электро двигателем, так и другим любым типом. В любом случае суть одна.
//Есть какой-то двигатель и есть какое-то топливо, которое используется.

namespace SaberTestWork;

public class Engine: ImportantPart
{
    protected float _maxCapacity;
    protected float _currentCapacity;
    protected float _fuelConsumption;

    public void AddCapacity(float capacity)
    {
        _currentCapacity += capacity;
        _currentCapacity = Math.Max(_currentCapacity, _maxCapacity);
    }

    public void RemoveCapacity()
    {
        if (_currentCapacity <= 0)
            return;

        _currentCapacity -= _fuelConsumption;
        _currentCapacity = Math.Max(0, _currentCapacity);
    }

    public bool IsEmpty => _currentCapacity <= 0;
}