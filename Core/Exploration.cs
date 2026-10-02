using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public class Exploration
    {
        bool isExploring = true;

        public void Start()
        {
            while (isExploring)
            {
                Console.Clear();
                Console.WriteLine(explorationScreen());

                StopRequest();
            }
        }

        public void StopRequest()
        {
            string stopRequestScreen = """
                1. Keep exploring
                2. Leave
            """;

            Console.WriteLine(stopRequestScreen);

            if (Byte.TryParse(Console.ReadLine(), out Byte choice))
            {
                if (choice >= 1 && choice <= 2)
                {
                    if(choice == 2) { isExploring = false; }
                }
                else
                {
                    
                }
            }
        } 

        public string explorationScreen()
        {
            string expScreen = """
                    you're exploring...
                """;

            return expScreen;
        }
    }
}
