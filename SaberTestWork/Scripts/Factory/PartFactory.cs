namespace SaberTestWork;

public class PartFactory
{
    private Dictionary<string, Parts> _carParts = new ();
    private Dictionary<string, Engine> _carEngines = new ();

    private Engine _engine;
    
    public PartFactory()
    {
        Parts parts;
        parts = CreateParts(4, 4, "red");
        LinkWithCar(CarNames.LadaName, parts);
        
        parts = CreateParts(4, 4, "gray");
        LinkWithCar(CarNames.TeslaName, parts);
        
        parts = CreateParts(4, 6, "blue");
        LinkWithCar(CarNames.BmwName, parts);
    }

    private Parts CreateParts(int doorsCount, int wheelsCount, string colorName)
    {
        List<ImportantPart> importantParts = new ();
        List<DecorPart> decorParts = new();
        
        Color color = new Color(colorName);
        
        Wheel wheel = new Wheel();
        Door door = new Door(color);
        Body body = new Body();
        
        _engine = new Engine();

        for (int i = 0; i < doorsCount; i++)
        {
            decorParts.Add(door);
        }

        for (int i = 0; i < wheelsCount; i++)
        {
            importantParts.Add(wheel);
        }
        
        importantParts.Add(_engine);
        importantParts.Add(body);
        
        Parts parts = new Parts(importantParts, decorParts);

        return parts;
    }

    private void LinkWithCar(string name, Parts parts)
    {
        _carParts.Add(name, parts);
        _carEngines.Add(name, _engine);
    }
    
    public Parts GetParts(string carName)
    {
        _carParts.TryGetValue(carName, out Parts parts);

        return parts;
    }

    public Engine GetEngine(string name)
    {
        _carEngines.TryGetValue(name, out Engine engine);

        return engine;
    }
}