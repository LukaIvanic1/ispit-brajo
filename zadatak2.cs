using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);
            //nije moglo PC-21 jer ne smije biti '-' u nazivu objekta :p

        }
    }

    class Zrakoplov
    {
        private string Naziv;
        private double SnagaMotora;
        private int DosegLeta;

        public Zrakoplov(string nazivAviona,double snagaMotora,int dosegLeta)
        {
            Naziv = nazivAviona;
            SnagaMotora = snagaMotora;
            DosegLeta = dosegLeta;

        }
        
        
        
    }
}
