using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Core
{
   public class Exploration
    {
        bool isExploring = true;

        public void Start(Player player)
        {
            while (isExploring)
            {
                Console.Clear();
                Console.WriteLine(explorationScreen());

                Explore(player, RandomEventPicker.Pick());

                
            }
        }

        internal void Explore(Player player, Events pickedEvent) {
            if (pickedEvent == Events.Walk)
            {
                Walk.Render();
            }
        }

        public void StopRequest()
        {
           string stopRequestScreen = 
            """
                1. Keep exploring
                2. Leave
            """;

            Console.WriteLine(stopRequestScreen);

            if (byte.TryParse(Console.ReadLine(), out byte choice))
            {
                if (choice >= 1 && choice <= 2)
                {
                    if(choice == 2) { isExploring = false; }
                }
                
            }
        } 

        public string explorationScreen()
        {
            string expScreen = 
                """
                    
                """;

            return expScreen;
        }
    }

    internal static class RandomEventPicker{
        internal static Events Pick()
        {
            int roll = Random.Shared.Next(0, 2);

            return roll switch
            {
                0 => Events.Walk,
                1 => Events.Treasure,
                _ => throw new Exception("invalid event roll")
            };
        }
    }

    internal enum Events{
        Walk, Treasure
    }
}
