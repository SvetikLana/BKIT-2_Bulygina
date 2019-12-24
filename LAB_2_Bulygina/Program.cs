using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2_Bulygina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2");

            Console.Title = "Булыгина Светлана, ИУ5Ц-51Б";


            // Объект класса Rectangle
            Rectangle rect = new Rectangle(4, 9);
            rect.Print();

            // Объект класса 
            Square square = new Square(5);
            square.Print();

            // Объект класса 
            Circle circle = new Circle(3);
            circle.Print();

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}

