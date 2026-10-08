

namespace Core
{
    internal class Walk
    {
        internal static void Render()
        {
            Console.WriteLine(WalkScreen.walkScreenText);

            getDirection();
        }


        static byte getDirection()
        {
            if (byte.TryParse(Console.ReadLine(), out byte choice))
            {
                if (choice >= 1 && choice <= 3)
                {
                    return choice;
                }
                else
                {
                    return getDirection();
                }
            }
            else
            {
                return getDirection();
            }

            

            
        }
    }

    public static class WalkScreen
    {
        internal const string walkScreenText =
            """
                you walk and find nothing...

                1 turn left
                2 go straight
                3 turn right
            """;

        
    }
}
