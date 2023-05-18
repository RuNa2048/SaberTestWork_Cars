//Ещё одна иерархия, которая отвечает за детали.
//В абстракции содержится лишь информация о состоянии запчасти,
//её уничтожение и починка. 

namespace SaberTestWork
{
    public abstract class CarPart
    {
        private PartConditionStudy _conditionStudy;
        private int _startHealth;
        private int _health;

        public void ChangeHealth(int takenAway)
        {
            _health -= takenAway;

            if (_health < 0)
                Destroy();
        }

        public void Repair()
        {
            _health = _startHealth;
            _conditionStudy = PartConditionStudy.Working;
        }

        public virtual void Destroy()
        {
            _health = 0;
            _conditionStudy = PartConditionStudy.Broken;
        }

        public PartConditionStudy ConditionStudy => _conditionStudy;
    }
}