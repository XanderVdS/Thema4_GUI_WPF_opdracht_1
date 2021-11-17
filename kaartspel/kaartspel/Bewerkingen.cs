using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaartspel
{
    class Bewerkingen
    {
        public void Kaarttrekken(Speler speler)
        {
            speler.kaart.trekKaart();
            Console.WriteLine(speler.naam + speler.kaart.ToString());
        }

        public void VergelijkenNummer(Speler speler1, Speler speler2)
        {
            if (speler1.kaart.Waarde > speler2.kaart.Waarde)
            {
                gewonnen1(speler1, speler2);
            }
            if (speler1.kaart.Waarde < speler2.kaart.Waarde)
            {
                gewonnen2(speler1, speler2);
            }
            if (speler1.kaart.Waarde == speler2.kaart.Waarde)
            {
                VergelijkenSoort(speler1, speler2);
            }
        }
        public void VergelijkenSoort(Speler speler1, Speler speler2)
        {
            if (speler1.kaart.Soort > speler2.kaart.Soort)
            {
                gewonnen1(speler1, speler2);
            }
            if (speler1.kaart.Soort < speler2.kaart.Soort)
            {
                gewonnen2(speler1, speler2);
            }
            if (speler1.kaart.Soort == speler2.kaart.Soort)
            {
                Console.WriteLine("Gelijkstand");
            }
        }

        public void gewonnen1(Speler speler1, Speler speler2)
        {  
            speler1.Score += speler1.kaart.Waarde;
            speler2.Score -= speler2.kaart.Waarde;
        }

        public void gewonnen2(Speler speler1, Speler speler2)
        {
            speler2.Score += speler2.kaart.Waarde;
            speler1.Score -= speler1.kaart.Waarde;
        }

        public int Einde(Speler speler)
        {
            int controle = 0;
            if (speler.Gewonnen() == 1)
            {
                return controle = 1;
            }
            if (speler.Verloren() == 2)
            {
                return controle = 2;
            }
            return controle;
        }
    }
}
