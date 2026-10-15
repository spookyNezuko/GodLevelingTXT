using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Core
{
    public class Items
    {
        public string _name;
        public string _description;
    }

    public class HealingPotion: Items
    {
        public HealingPotion()
        {
            _name = "healing potion";
            _description = "a consumable that gives the player health";
        }
    }

    public class SwordWooden: Items
    {
        public SwordWooden()
        {
            _name = "wooden sword";
            _description = "a sword made of wood, it gives the player 3 extra attack";
        }
    }

    public enum ItemsEnum
    {
        None, 
        HealingPotion, 
        SwordWooden
    }
}
