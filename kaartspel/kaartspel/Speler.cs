using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaartspel
{
    class Speler
    {
        int score;
        public string naam;
        public SpeelkaartTrekken kaart = new SpeelkaartTrekken();
        public Speler(int score, string naam)
        {
            this.score = score;
            this.naam = naam;
        }
        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }


        public int Gewonnen()
        {
            if (score >= 200)
            {
                Console.WriteLine($"Speler {naam} heeft gewonnen");
                return 1;
            }
            return 0;
        }

        public int Verloren()
        {
            if (score <= 0)
            {
                Console.WriteLine($"Speler {naam} heeft verloren");
                return 2;
            }
            return 0;
        }
        public void reset()
        {
            score = 100;
        }

        public override string ToString()
        {
            return $"score {score}";
        }


    }

}
