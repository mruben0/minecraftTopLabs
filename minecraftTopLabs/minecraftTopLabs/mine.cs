using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using minecraftTopLabs;

namespace minecraftTopLabs
{

    class mine
    {
        string name = "yo";
        public string gName
        {
            get { return name; }
            set { if (!string.IsNullOrWhiteSpace(value))
                { name = value; }
                else name = "WRONGNAME";
                }
        }


        public mineType type;

        int amount;
        public int gAmount
        {
            get { return amount; }
            set
            {
                if (value >= 0 && value <= 10000)
                { 
                    amount = value; }
            }
        }

           
        string state;
        public string gState
        {
            get
            {
                if (amount >= 8000 && amount <= 10000)
                    state = "hood";

                else if (amount >= 4000 && amount < 8000)
                    state = "so so";

                else if (amount >= 100 && amount < 4000)
                    state = "mukuch poberi";

                else if (amount >= 0 && amount < 0)
                    state = "Pi%#ec";

                else state = "cheater";

                return state;
            }
        }
        public int PH;
        public mininng.injury playerInjury { get; set; }
        public void injury()
        {
            injury();
        }
        public int pooring()
        {
          
            
            gAmount -= PH;
            return gAmount;
        }



    }
}
