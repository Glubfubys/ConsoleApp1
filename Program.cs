using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private const string V = "+";

        static void Main(string[] args)
        {
            string j = "+"; // обьявляем переменные, отвечающие за знак действия
            string o = "-"; 
            string l = "*";
            string p = "/";
            float g = 0f;
            float x;
            float z;
            char c;
            Console.WriteLine("Введите первое значение."); // Тут выводится запрос №1
            while (!float.TryParse(Console.ReadLine(), out x)) //после нажатия на ENTER идёт проверка на то, введено-ли X. Если введено то возвращяет X (out x)
                {
                    Console.WriteLine("Попробуйте снова"); //иначе выводится просьба о повторе ввода
                }
            Console.WriteLine("Введит второе значение."); // Тут выводится запрос №2
            while (!float.TryParse(Console.ReadLine(), out z)) // то же что и в строчке №24, только выводится уже Z
                {
                Console.WriteLine("Попробуйте снова"); //без комментариев
                }
            Console.WriteLine("Что с ними нужно сделать?");
            while (!char.TryParse(Console.ReadLine(), out c)) // то же что и в строчке №24, только выводится уже C
            {
                Console.WriteLine("Попробуйте снова");
            }
            if (j.Contains(c)) // если j содержит C, // be like Yoda
            {
                g = z + x; // выполняется вот это
            }
            if (o.Contains(c)) // аналогично 38
            {
                g = z - x;
            }
            if (l.Contains(c))
            {
                g = z * x;
            }
            if (p.Contains(c))
            {
                g = z / x;
            }
            string f = $"{x} {c} {z} = {g}"; // пример записи текста с переменными
            Console.WriteLine(f);
            Console.WriteLine("Надмите на любую кнопку для выхода.");
            Console.ReadKey(); // нужно, чтобы прога не закрывалась сразу послу вывода ответа

        }
    }
}
