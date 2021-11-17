using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaartspel
{
    class SpeelkaartTrekken
    {
        public string[,] arrayPicture;
        int soort, waarde;
        Random randomSoort = new Random();
        Random randomWaarde = new Random();

        public SpeelkaartTrekken()
        {
            
            this.arrayPicture = new string[4, 13]
            {
                {"cards/AS.png","cards/2S.png","cards/3S.png","cards/4S.png","cards/5S.png","cards/6S.png","cards/7S.png","cards/8S.png","cards/9S.png","cards/10S.png","cards/JS.png","cards/QS.png","cards/KS.png" },
                {"cards/AC.png","cards/2C.png","cards/3C.png","cards/4C.png","cards/5C.png","cards/6C.png","cards/7C.png","cards/8C.png","cards/9C.png","cards/10C.png","cards/JC.png","cards/QC.png","cards/KC.png" },
                {"cards/AD.png","cards/2D.png","cards/3D.png","cards/4D.png","cards/5D.png","cards/6D.png","cards/7D.png","cards/8D.png","cards/9D.png","cards/10D.png","cards/JD.png","cards/QD.png","cards/KD.png" },
                {"cards/AH.png","cards/2H.png","cards/3H.png","cards/4H.png","cards/5H.png","cards/6H.png","cards/7H.png","cards/8H.png","cards/9H.png","cards/10H.png","cards/JH.png","cards/QH.png","cards/KH.png" }
            };
            this.soort = 0;
            this.waarde = 0;
        }

        public void trekKaart()
        {
           
            this.soort = randomSoort.Next(1, 5);
            this.waarde = randomWaarde.Next(1, 14);
        }

        public int Soort
        {
            get { return this.soort; }
            set { this.soort = value; }
        }

        public int Waarde
        {
            get { return this.waarde; }
            set { this.waarde = value; }
        }

        public string soortKaart()
        {
            if (soort == 1)
            {
                return "schoppen";
            }
            if (soort == 2)
            {
                return "klaveren";
            }
            if (soort == 3)
            {
                return "ruiten";
            }
            if (soort == 4)
            {
                return "harten";
            }
            return "";
        }
        public override string ToString()
        {
            return "ok";
        }
    }
}
