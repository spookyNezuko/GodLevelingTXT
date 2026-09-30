namespace Core
{
    public class Player
    {
        string _playerName;
        int _level = 1;
        int _maximumHealthPoints = 100;
        int _HealthPoints = 100;

        public Player(string name)
        {
            _playerName = name;
        }

        public int GetLevel() => _level;
        public int GetMaxHP() => _maximumHealthPoints;
        public int GetCurrentHP() => _HealthPoints;
        public string HPmeter()
        {
            float percent = getHpPercent();
            
            return percent switch
            {
                >= 81 => "|█████|",
                >= 61 => "|████░|",
                >= 41 => "|███░░|",
                >= 21 => "|██░░░|",
                > 0 => "|█░░░░|",
                _ => "|░░░░░|"
            };
        }

        public float getHpPercent() => (_HealthPoints * 100 ) / _maximumHealthPoints ;
    }
}
