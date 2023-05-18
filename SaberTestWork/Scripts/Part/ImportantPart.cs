//Также абстракция детали. Нужна для того проверки работоспобности.
//Если запчасть сломана, то мы никак не можем её использовать

namespace SaberTestWork;

public abstract class ImportantPart: CarPart
{
    public bool TryUse()
    {
        return ConditionStudy != PartConditionStudy.Broken;
    }
}