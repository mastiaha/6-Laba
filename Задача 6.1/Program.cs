using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков препинания");
            string sl = Console.ReadLine();
            string max = string.Empty;
            string[] slova = sl.Split(new[] { " " }, StringSplitOptions.None);

            for (int i = 0; i < slova.Length; i++)
            {
                if (slova[i].Length > max.Length)
                {
                    max = slova[i];
                }
            }
            Console.WriteLine("Самым длинным словом в предложении будет {0}", max);
            Console.ReadKey();
        }
    }
}
