//Класс, который должен получить инпут с геймпада ,клавиатуры, кнопок.

namespace SaberTestWork;

public class PlayerInput
{
    public event Action<Direction> DirectionChanged;

    private readonly Random _random = new Random();
    private Direction _direction;
    
    private void ChangeDirection()
    {
        _direction = (Direction)_random.Next(1, 5);
        
        OnDirectionChanged();
    }
    
    private void OnDirectionChanged()
    {
        DirectionChanged?.Invoke(_direction);
    }
}