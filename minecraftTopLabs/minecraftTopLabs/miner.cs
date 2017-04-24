using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using minecraftTopLabs;

namespace minecraftTopLabs
{
    public class miner
    {

        //դե անուն եմ նշանակում խաղացողի կլասին
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

        //խաղացողի կլասին նշանակում եմ perHit, որը ցույց կտա, թե ինչքնով է նվազում
        // հանքի amount-ը, չեմ թողնում, որ դա մեծ լինի 100-ից
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

        //ստեղծում եմ խաղացողի առոջություն, որը մեծ չի լինի 20-ից
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

        //ստեղծում եմ խաղացողի համար վնասվելու ֆունկցիա (delegate min-ի injuery -ին)
        public int healthChange()
        {
            if (gPerHit >= 0)
            {
                gHealth -= 1;
            }
            return gHealth;
        }


        //ֆունկցիա, որը գրաֆիկական ձևով ցույց կտա խաղացողի առողջությունը
        public void healthIndicator()
        {
            for (int i = 0; i < gHealth; i++)
            {
                Console.Write("#");
                
            }
            Console.WriteLine($"({gHealth})");
        }

        //delegat Mine-ում amount-ը նվազեցնելու (նայել mine class-Ի pooring ֆունկցիան)
        public mininng.mining mining { get; set; }

        //ստեղծում եմ place, որը համարժեք է Mine-ի type-ին, որ ըստ դրա 
        //պակասի խաղացողի առողջությունը
        public mineType place;
        public int injury(mineType place)
        {
            if (place == mineType.uran)
            {
                gHealth -= 10;

            }
            else gHealth -= 1;
            return gHealth;
        }

        //delegate հանքի pooring-Ին
        public void working()

        {
           
            mining(gPerHit);
        }

    }
}
