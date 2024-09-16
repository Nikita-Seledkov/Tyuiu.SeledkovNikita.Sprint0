using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SeledkovNikita.Sprint0.Task1.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Word");                                                                // текст первый
            string name = "Призрак";                                                                        // Имя
                int age = 42;                                                                              // указанные года
            Console.WriteLine("Здраствуйте меня не зовут " + name + " мне не " + age + " столетей!");     // последный текс
            Console.ReadKey();                                                                           // ожидания ответа
        }
    }
}
