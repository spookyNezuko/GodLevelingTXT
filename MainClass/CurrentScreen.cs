using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace ConsoleApp1
{
    internal class InitialNameSelection
    {
        //chiedo il nome poi lo ritorno
         static internal string Render() {
            Console.WriteLine("Input your name: ");
            string name = Console.ReadLine();
            WelcomePlayer(name);
            return name;
        }

        static private void WelcomePlayer(string name)
        {
            Console.WriteLine($"welcome to God Leveling {name}");
        }
    }

    internal class PlayerStatsScreen
    {
        static internal void Render(Player player){
            Console.Clear();
            Console.WriteLine("these are your stats");
            Console.WriteLine();
            Console.WriteLine($"you're level: {player.GetLevel()}");
            Console.WriteLine($"your health points: {player.GetCurrentHP()} {player.HPmeter()}");
            Console.WriteLine();
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
    }

    internal class MainGameScreens
    {
        

        static internal Byte Render()
        {
            string selectionScreen = """
            

                         G O D  L E V E L I N G

                      The world awaits you.

                    1. Explore
                    2. Inventory
                    3. Stats
                    4. Leave this world

                        > Enter your choice

            
            """;
            Console.Clear();
            Console.WriteLine(selectionScreen);
            if (Byte.TryParse(Console.ReadLine(), out Byte choice)){
                if(choice >= 1 && choice <= 4)
                {
                    return choice;
                }
                else
                {
                    return Render();
                }
            }
            else
            {
                return Render();
            }
        }
    }
    
}
