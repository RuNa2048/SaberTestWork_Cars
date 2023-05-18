//Единственный наследник декоративной части. Нужен для разрешения и
//запрета входа в кузов.

namespace SaberTestWork;

public class Door: DecorPart
{
    private bool _isOpen;

    public bool IsOpen => _isOpen;
    
    public Door(Color color) : base(color)
    {
    }

    public void Open()
    {
        _isOpen = true;
    }

    public void Close()
    {
        _isOpen = false;
    }

    public void Destroy()
    {
        
    }
}