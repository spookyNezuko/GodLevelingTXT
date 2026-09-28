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
        internal void Start()
        {
            if (true) //here i'll check if there's already a name in the future for now it stays like this
            {
                string name = InitialNameSelection.Render();
                Player player = new Player(name);
                PlayerStatsScreen.Render(player);
            }
        }

        
    }
}
