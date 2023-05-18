//MovingDirection получает ивент с PlayerInmput
//и сохраняет в себе данные этого инпута.

namespace SaberTestWork;

public enum Direction
{
    Left = 1,
    Right = 2,
    Up = 3,
    Down = 4,
}

public class MovingDirection
{
    private Direction _direction;

    private Dictionary<Direction, Vector2> _directionValues = new ();

    public MovingDirection()
    {
        _directionValues.Add(Direction.Left, new Vector2(-1, 0));
        _directionValues.Add(Direction.Right, new Vector2(1, 0));
        _directionValues.Add(Direction.Up, new Vector2(0, 1));
        _directionValues.Add(Direction.Down, new Vector2(0, -1));
    }

    public void SetDirection(Direction direction) => _direction = direction;
    
    public Vector2 GetDirectionValue()
    {
        _directionValues.TryGetValue(_direction, out Vector2 value);

        return value;
    }
}