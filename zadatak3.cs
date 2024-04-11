using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak3
{
    

    public class Vozilo
    {
        
        public bool JeLiLeti { get; set; }
        public bool JeLiPlovi { get; set; }

        
        public void KudaVozi()
        {
            Console.WriteLine("Ovo vozilo vozi:");


            Console.WriteLine("Letom: " + JeLiLeti);
            Console.WriteLine("Plovidbom: " + JeLiPlovi);
        }
    }

    public class Brod : Vozilo
    {
        
        public Brod()
        {
            JeLiLeti = false;
            JeLiPlovi = true;
        }
    }

    public class Zrakoplov : Vozilo
    {
        
        public Zrakoplov()
        {
            JeLiLeti = true;
            JeLiPlovi = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Brod brod = new Brod();
            Zrakoplov zrakoplov = new Zrakoplov();

            Console.WriteLine("Brod:");
            brod.KudaVozi();

            Console.WriteLine("\nZrakoplov:");
            zrakoplov.KudaVozi();

            Console.ReadKey();
        }
    }

}
