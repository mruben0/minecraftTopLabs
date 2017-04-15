using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using minecraftTopLabs;

namespace minecraftTopLabs
{
    class miner
    {
        string minerName;
        public string gminerName
        {
            get { return minerName.ToUpper(); }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))

                    minerName = value;
            }
        }
        int perHit;
        public int gPerHit
        {
            get
            {
                return perHit;
            }
            set
            {
                if (value <= 100 && value >= 1)
                {
                    perHit = value;
                }
                else if (value > 100)
                    perHit = 100;
                else if (value < 1)
                    perHit = 1;
            }
        }

        int health;
        public int gHealth
        {
            get { return health; }
            set
            {
                if (value <= 20 && value >= 0)
                    health = value;
                else if (value > 20)
                    health = 20;
                else health = 0;
            } 

        }

        public int healthChange()
        {
            if (gPerHit >= 0)
            {
                gHealth -= 1;
            }
            return gHealth;
        }

        public void healthIndicator()
        {
            for (int i = 0; i < gHealth; i++)
            {
                Console.Write("#");
                
            }
            Console.WriteLine($"({gHealth})");
        }

        public mininng.mining mining { get; set; }

        public mineType place;
        public int injury()
        {
            if (place == mineType.uran)
            {
                gHealth -= 10;

            }
            else gHealth -= 1;
            return gHealth;
        }

        public void working()

        {
           
            mining();
        }

    }
}
