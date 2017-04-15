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
            get { return minerName; }
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
                if (perHit <= 10000 && perHit >= 0)
                {
                    perHit = value;
                }

            }
        }

        int health;
        public int gHealth
        {
            get { return health; }
            set
            {
                if (health <= 20)
                    health = value;
            }

        }

        public int healthChange()
        {
            if (gPerHit > 0)
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
