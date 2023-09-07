using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float heath;
            int armor;
            int damage;
            int percentConvertor = 100;

            Console.Write("Введите колличество здоровья: ");
            heath = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите колличество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите колличество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            heath -= Convert.ToSingle(damage)/percentConvertor * armor;

            Console.WriteLine($"Вам нанесли {damage} урона, у вас осталось {heath} здоровья.");
            Console.ReadKey();
        }
    }
}
