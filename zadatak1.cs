using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sport Nogomet = new Sport("Nogomet",true,11);
            Sport Vaterpolo = new Sport("Vaterpolo",true);
            Sport Curling = new Sport("Curling");
        }
    }

    class Sport
    {
        private string Naziv;
        private bool IgraLiSeLoptom;
        private int BrojIgraca;

        public Sport(string NazivSporta)
        {
            Naziv = NazivSporta;
        }

        public Sport(string NazivSporta,bool IgraLiSeSportLoptom) 
        {
            Naziv = NazivSporta;
            IgraLiSeLoptom = IgraLiSeSportLoptom;
        }

        public Sport(string NazivSporta,bool IgraLiSeSportLoptom,int BrojIgracaSporta)
        {
            Naziv = NazivSporta;
            IgraLiSeLoptom = IgraLiSeSportLoptom;
            BrojIgraca = BrojIgracaSporta;
        }
        
    }


}
