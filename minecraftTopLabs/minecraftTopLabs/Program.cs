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
            Console.Write("select type for mine 1. for uran, 2. for gold, 3 for silver ");
            int t = Convert.ToInt32(Console.ReadLine());
            if (t == 1)
                firstMine.type = mineType.uran;
            else if (t == 2)
                firstMine.type = mineType.gold;
            else firstMine.type = mineType.silver;

            Console.Write("add amount (0 to 10 000) ");
            firstMine.gAmount = Convert.ToInt32(Console.ReadLine());


            miner gago = new miner();
            Console.Write("set miners name ");
            gago.gminerName = Console.ReadLine();
            Console.Write("miners power (from 1 to 100) ");
            gago.gPerHit = Convert.ToInt32(Console.ReadLine());
            Console.Write("miners health(from 1 to 20) ");
            gago.gHealth = Convert.ToInt32(Console.ReadLine());
            gago.mining = firstMine.pooring;
            gago.place = firstMine.type;

            string ok = "y";
            while (ok == "y")
            {
               

                Console.WriteLine("Before mining");

                Console.WriteLine($"mine name is {firstMine.gName}");
                Console.WriteLine($"mine type is {firstMine.type}");
                Console.WriteLine($"mine amount is {firstMine.gAmount}");
                Console.WriteLine($"mine state is {firstMine.gState}");

                Console.WriteLine($"miner's name is {gago.gminerName}");
                Console.WriteLine($"miner can earn {gago.gPerHit} {firstMine.type} per hit");
                Console.Write("miner's health: "); gago.healthIndicator();
                Console.WriteLine(" ");
                

                firstMine.playerInjury = gago.injury;


                firstMine.PH = gago.gPerHit;

                firstMine.playerInjury();
                gago.mining();

                Console.WriteLine("After one hit");
                Console.WriteLine($"mine name is {firstMine.gName}");
                Console.WriteLine($"mine type is {firstMine.type}");
                Console.WriteLine($"mine amount is {firstMine.gAmount}");
                Console.WriteLine($"mine state is {firstMine.gState}");

                Console.WriteLine($"miners name is {gago.gminerName}");
                Console.WriteLine($"miner can earn {gago.gPerHit} {firstMine.type} per hit");
                Console.Write("miners healt: "); gago.healthIndicator();
              

                if (gago.gHealth <= 0)
                { Console.WriteLine($"{gago.gminerName} is dead");
                    ok = "n";
                    
                } else if (firstMine.gAmount <= 10)
                {
                    Console.WriteLine($"{firstMine.gName} is too poor");
                    ok = "n";
                }
                else {
                    Console.WriteLine("y for another hit, n for exit ");
                    ok = Console.ReadLine();
                }
                

            }
            Console.Write("Game over, press any key to exit");
            Console.Read();

            
        }
    }
}
