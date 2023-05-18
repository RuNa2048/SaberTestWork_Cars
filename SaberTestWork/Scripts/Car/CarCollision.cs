//Класс, отвечающий за коллизию с другими объектами

namespace SaberTestWork;

public class CarCollision
{
    public event Action Collided;

    public void OnCollided()
    {
        Collided?.Invoke();
    }
}