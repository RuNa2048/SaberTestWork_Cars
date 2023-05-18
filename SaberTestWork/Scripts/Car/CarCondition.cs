//Реализация оценки состояния автомобиля. Если хотя бы 1 важная
//деталь сломана, то автомобиль теряет возможность передвижения.
//Если только декоративные запчасти, то просто требуется починка,
//но не обязательна.

namespace SaberTestWork;

public class CarCondition
{
    private Parts _parts;
    
    public CarCondition(Parts parts)
    {
        _parts = parts;
    }

    public CarConditionsStudy Assess()
    {
        foreach (var part in _parts.ImportantParts)
        {
            if (part.ConditionStudy == PartConditionStudy.Broken)
                return CarConditionsStudy.Broken;
        }

        foreach (var part in _parts.DecorParts)
        {
            if (part.ConditionStudy == PartConditionStudy.Broken)
                return CarConditionsStudy.RequiresRepair;
        }

        return CarConditionsStudy.Working;
    }
}