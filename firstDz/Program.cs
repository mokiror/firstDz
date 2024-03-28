using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstDz
{
    public class UsualFr
    {
       static public void Fr(ref double upNum, ref double numm)
        {
            if (upNum < numm)
            {
                Console.WriteLine($"Дробь: {upNum} / {numm}");
            }
            else
            {
                Console.WriteLine($"ERROR!!!");
            }
        }

        static public void Summ(ref double upNum, ref double numm, ref double forTheEnd, ref double forTheEnd2)
        {
            double end = (numm * forTheEnd2);
            double result = (end / numm) + (end / forTheEnd2);
            Console.WriteLine($"Сумма числа: {result} / {end}");
        }

        static public void NotSumm(ref double upNum, ref double numm, ref double forTheEnd, ref double forTheEnd2)
        {
            double end = (numm * forTheEnd2);
            double result = (end / numm) - (end / forTheEnd2);
            Console.WriteLine($"Вычитание: {result} / {end}");
        }

        static public void Mult(ref double upNum, ref double numm, ref double forTheEnd, ref double forTheEnd2)
        {
            double end = (numm * forTheEnd2);
            double result = upNum * forTheEnd;
            Console.WriteLine($"Умножение: {result} / {end}");
        }

        static public void NotMult(ref double upNum, ref double numm, ref double forTheEnd, ref double forTheEnd2)
        {
            if(forTheEnd2 == 0 || forTheEnd2 == 0) {
                Console.WriteLine($"ERROR");
            }
            else
            {
                double end = (numm * forTheEnd);
                double result = upNum * forTheEnd2;
                Console.WriteLine($"Деление: {result} / {end}");
            }
        }
        static public void Sokr(ref double upNum, ref double numm)
        {
           if(numm % upNum == 0)
            {
                double end = upNum / upNum;
                double result = numm / upNum;
                Console.WriteLine($"Сокращение: {end} / {result}");
            }
            else
            {
                Console.WriteLine($"ERROR");
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double upNum = 2;
            double numm = 4;
            double forTheEnd = 1;
            double forTheEnd2 = 5;

            UsualFr.Fr(ref upNum, ref numm);
            Console.WriteLine($"Вторая дробь: {forTheEnd} / {forTheEnd2}");
            Console.WriteLine("\n");
               

            UsualFr.Summ(ref upNum, ref numm, ref forTheEnd, ref forTheEnd2);
            UsualFr.NotSumm(ref upNum, ref numm, ref forTheEnd, ref forTheEnd2);
            UsualFr.Mult(ref upNum, ref numm, ref forTheEnd, ref forTheEnd2);
            UsualFr.NotMult(ref upNum, ref numm, ref forTheEnd, ref forTheEnd2);
            UsualFr.Sokr(ref upNum, ref numm);

            Console.ReadKey();

        }
    }
}
