using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace number_convertion_simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the denary number you want to convert");
            long DenaryNum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the base of number system you want to convert the denary number to");
            int BaseNum = Convert.ToInt16(Console.ReadLine());
            string convertedNum = "";
            while (DenaryNum > 0)
            {
                convertedNum = convertedNum.Insert(0, Convert.ToString(DenaryNum % BaseNum));
                DenaryNum = (DenaryNum / BaseNum);
            }
            Console.WriteLine(convertedNum);
        }
    }
}
