using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace ConsoleApp1
{
    public class Game
    {
        string name = "";
        bool gameRunning = true;


        void ThankPlayer()
        {
            string thanks = """
                ██████████████████████████████████████████████████████████████

                                 T H A N K S   F O R

                                      P L A Y I N G

                                Your journey ends here.

                                  Until the next world...

                ██████████████████████████████████████████████████████████████
                """;
            Console.Clear();
            Console.WriteLine(thanks);
            
        }

        void ProcessMenuChoice(Byte choice, Player player)
        {
            if (false){

            }else if(false){

            }else if(choice == 3){
                PlayerStatsScreen.Render(player);
                
            }
            else if(choice == 4){
                gameRunning = false;
            }
        }
        internal void Start()
        {
            
            if (true) //here i'll check if there's already a name in the future for now it stays like this
            {
                name = InitialNameSelection.Render();
                
                
            }else {
                
            }

            Player player = new Player(name);
            while (gameRunning)
            {
                Byte choice = MainGameScreens.Render();
                ProcessMenuChoice(choice, player);
            }

            ThankPlayer();
        }

        

        
    }
}
