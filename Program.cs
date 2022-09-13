using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Vasita vasitaAraba = new Vasita(new Araba());
            vasitaAraba.Kullan();

            Vasita vasitaMotor = new Vasita(new Motor());
            vasitaMotor.Kullan();

            Vasita vasitaOtobus = new Vasita(new Otobus());
            vasitaOtobus.Kullan();

            Console.ReadKey();
        }
    }
}
