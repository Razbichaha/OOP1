using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.ShowParametrs();

            Console.ReadKey();
        }
    }

    class Player
    {
       private int _health;
       private int _stamina;
       private int _speed;

       public Player()
        {
            _health = 500;
            _stamina = 100;
            _speed = 5;
        }

        public void ShowParametrs()
        {
            Console.WriteLine("Жизнь = " + _health + "\nВыносливость = " + _stamina + "\nСкорость = " + _speed);
        }

    }
}
