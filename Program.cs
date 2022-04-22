using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Plaer plaer = new Plaer();
            plaer.ShowPlaer();

            Console.ReadKey();
        }
    }

    class Plaer
    {
        int _healt;
        int _stamina;
        int _speed;

       public Plaer()
        {
            _healt = 500;
            _stamina = 100;
            _speed = 5;
        }

        public void ShowPlaer()
        {
            Console.WriteLine("Жизнь = " + _healt + "\nВыносливость = " + _stamina + "\nСкорость = " + _speed);
        }

    }
}
