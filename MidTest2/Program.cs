using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isNextRound = true;
            Game.WhatsYourName();
            Game.StartGame();
            while (isNextRound)
            {
                isNextRound = Game.NextRound();
                if (!isNextRound)
                {
                    if (Game.GameOver())
                    {
                        isNextRound = true;
                        Game.IsGameOverAndWhy = 0;
                        Game.StartGame();
                    }
                }
            }

        }
    }
}
