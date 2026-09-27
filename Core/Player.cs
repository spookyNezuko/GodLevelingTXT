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
    }
}
