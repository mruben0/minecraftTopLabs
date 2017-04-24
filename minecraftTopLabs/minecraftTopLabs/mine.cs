using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using minecraftTopLabs;

namespace minecraftTopLabs
{

    public class mine
    {

        //նշանակում եմ հանք կլասի անունը
        string name = "yo";
        public string gName
        {
            get { return name; }
            set { if (!string.IsNullOrWhiteSpace(value))
                { name = value; }
                else name = "WRONGNAME";
                }
        }

        // type-ը վերցնում եմ նախորոք հայտարարված enum-Ից
        public mineType type;


        //ստեղծում եմ amount, չեմ թողնում, որ 10000-ից մեծ արժեք ընդունի
        int amount;
        public int gAmount
        {
            get { return amount; }
            set
            {
                if (value >= 0 && value <= 10000)
                {
                    amount = value;
                }
                else if (value > 10000) amount = 10000;
                else amount = 1;
            }
        }

           //նշանակում եմ state,, կախված amount-ից
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

        //ստեղծում եմ PH, որը հետո հավասար կլինի խաղացողի perHit-ին
        //public int PH;
        
        //delegate -ով ստեղծում եմ ֆունկցիա, որից կախված խաղացողը կվնասվի
        public mininng.injury playerInjury { get; set; }
        public void injury()
        {
            playerInjury(type);
        }

        //delegate-Ով ֆունկցիա, որը կպակասեցնի amount-ը
        public int pooring( int Ph)
        {
          
            
            gAmount -= Ph;
            return gAmount;
        }



    }
}
