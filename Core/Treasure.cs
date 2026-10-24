using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public static class Treasure
    {
        public static void GiveReward(Player player)
        {
            int roll = Random.Shared.Next(0, 2);
            ItemsEnum chosenItem = ItemsEnum.None;

            if (roll == 0)
            {
                chosenItem = ItemsEnum.HealingPotion;
            }
            else if (roll == 1)
            {
                chosenItem = ItemsEnum.SwordWooden;
            }

            player._inventory.AddItem(chosenItem);

            Render(chosenItem);
        }

        internal static void Render(ItemsEnum item)
        {
            string TreasureMessage = $"""
                __________________________________

                    You found a treasure!

                    you found: {item}
                __________________________________
                """;
        }
    }
}
