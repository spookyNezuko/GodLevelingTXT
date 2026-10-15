using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Enemy
    {
        protected int _HP;
        protected int _maxHP;
        protected int _baseDamage;
        protected int _level;
    }

    public class SmallGoblin : Enemy
    {
        public SmallGoblin(int level)
        {
            _level = level;
            _maxHP = 10 * _level;
            _HP = _maxHP;
            _baseDamage = 5 * _level;
        }
    }

    public class BigGoblin : Enemy
    {
        public BigGoblin(int level)
        {
            _level = level;
            _maxHP = 25 * _level;
            _HP = _maxHP;
            _baseDamage = 5 * _level;
        }
    }
}
