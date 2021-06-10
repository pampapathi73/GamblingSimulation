using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingSimulations
{
    class Usecase2
    {
        public void winLoss()
        {
            Random random = new Random();
            int value = random.Next(2);
            if (value == 1)
            {
                Console.WriteLine("Gambler own");
            }
            else
                Console.WriteLine("Gambler Loss");
        }

    }
}
