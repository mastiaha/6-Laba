using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания");
            string sl = Console.ReadLine();
            
            string[] slova = sl.Split(new[] { " " }, StringSplitOptions.None);

            foreach (string a in slova)
            {
                string revers = string.Join("", a.ToUpper().Reverse());
                if (revers==a)
                {
                    Console.WriteLine("Предложение является полиндромом");
                    break;
                }
                else
                    Console.WriteLine("Предложение не является полиндромом");
                break;
            }
            Console.WriteLine("Для выхода из программы нажмите любую клавишу");
            
            Console.ReadKey();
        }
    }
}
