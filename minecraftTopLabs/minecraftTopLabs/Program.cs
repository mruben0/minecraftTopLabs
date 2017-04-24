using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using minecraftTopLabs;

namespace minecraftTopLabs
{
    class Program
    {
        
        static void Main(string[] args)
        {

            mine firstMine = new mine();

            Console.Write("set name for mine ");
            firstMine.gName = Console.ReadLine();

            Console.Write($"select type for {firstMine.gName} 1. for uran, 2. for gold, 3 for silver ");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t == 1)
                firstMine.type = mineType.uran;
            else if (t == 2)
                firstMine.type = mineType.gold;
            else firstMine.type = mineType.silver;

            Console.Write($"add amount of {firstMine.type} to {firstMine.gName} (0 to 10 000) ");
            firstMine.gAmount = Convert.ToInt32(Console.ReadLine());


            miner gago = new miner();

            Console.Write("set miners name ");
            gago.gminerName = Console.ReadLine();

            Console.Write($"{gago.gminerName}'s power (from 1 to 100) ");
            gago.gPerHit = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{gago.gminerName}'s health (from 1 to 20) ");
            gago.gHealth = Convert.ToInt32(Console.ReadLine());

            gago.mining = firstMine.pooring;


            string ok = "y";
            while (ok == "y")
            {
               

                Console.WriteLine("\n Before mining");

                Console.WriteLine($"mine name is {firstMine.gName}");
                Console.WriteLine($"{firstMine.gName}'s type is {firstMine.type}");
                Console.WriteLine($"{firstMine.gName}'s amount is {firstMine.gAmount} of {firstMine.type}");
                Console.WriteLine($"{firstMine.gName}'s state is {firstMine.gState}");

                Console.WriteLine($"miner's name is {gago.gminerName}");
                Console.WriteLine($"{gago.gminerName} can earn {gago.gPerHit} of {firstMine.type} per hit");
                Console.Write("miner's health: "); gago.healthIndicator();
                Console.WriteLine(" ");
                

                firstMine.playerInjury += gago.injury;

                gago.working();
                firstMine.injury();

                Console.WriteLine("After one hit");
                Console.WriteLine($"{firstMine.gName} amount is {firstMine.gAmount}");
                Console.WriteLine($"{firstMine.gName} state is {firstMine.gState}");
                Console.WriteLine($"{gago.gminerName}'s healt: "); gago.healthIndicator();

                Console.Write("\n \n \n ");
              

                if (gago.gHealth <= 0)
                { Console.WriteLine($"{gago.gminerName} is dead");
                    ok = "n";
                    
                } else if (firstMine.gAmount <= 10)
                {
                    Console.WriteLine($"{firstMine.gName} is too poor");
                    ok = "n";
                }
                else {
                    Console.WriteLine("ENTER for another hit, Esc for exit ");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                        ok = "y";
                }
                

            }
            Console.Write("Game over, press any key to exit");
            Console.Read();

            
        }
    }
}
