//Game отвечает за создание глобальных систем и классов.
//Например создание фабрик запчастей и машин, данные которые мы можем
//передать уже в другие классы и они будут работать с ними.

namespace SaberTestWork;

public class Game: IUpdatable
{
    //список обновляемых классов. Частая практика в Unity дня уменьшения
    //количества MonoBehaviour-ов и назначения очереди обновлений.
    private List<IUpdatable> _updatables = new();
    
    private PartFactory _partFactory;
    private CarFactory _carFactory;
    
    private PlayerInput _input = new();
    private MovingDirection _direction = new();

    //Также глобальный класс машины, который в первую очередь является Updatable,
    //во вторую нужен для привызяки к инпуту.
    private CarWork _carWork;
    
    public Game()
    {
        Initialize();
    }
    
    private void Initialize()
    {
        CreateFactories();
        SetInputLogic();
        CreateCar();
        SetUpdatables();
    }

    private void CreateFactories()
    {
        _partFactory = new PartFactory();
        _carFactory = new CarFactory();
    }

    //Создаём конкретную машину и инициализируем все её данные для работы.
    private void CreateCar()
    {
        string carName = CarNames.BmwName;
        
        _carFactory.CreateBmw(_partFactory.GetParts(carName));

        Engine engine = _partFactory.GetEngine(carName);
        
        //Пример DI. Мы храним в нашем "контейнере" глобальные данные и назначаем
        //компоннтам, классам
        CarMoving carMoving = new CarMoving(_carFactory.CurrentCar, engine);
        _carWork = new CarWork(carMoving, engine, _direction);

        _carWork.Collision.Collided += _carFactory.CurrentCar.Collided;
    }

    private void SetInputLogic()
    {
        _input.DirectionChanged += _direction.SetDirection;
    }

    private void SetUpdatables()
    {
        _updatables.Add(_carWork);
    }
    
    public void Update()
    {
        foreach (var updatable in _updatables)
        {
            updatable.Update();
        }
    }

    public void Destroy()
    {
        _input.DirectionChanged -= _direction.SetDirection;
        _carWork.Collision.Collided -= _carFactory.CurrentCar.Collided;
    }
}