using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temporary1
{
    class Program
    {
        static void Print(int[] arrayPrint, int i = 0)
        {
            if (i < arrayPrint.Length)
            {
                Console.WriteLine(arrayPrint[i]);              

                Print(arrayPrint,++i);
            }

        }//return value < 10 ? value : value % 10 + Foo(value / 10);

        static int Sum(int[] arrayPrint, int i = 0, int Res = 0)
        {
            return arrayPrint.Length > i ? Res += arrayPrint[i]+ Sum(arrayPrint,i+1, Res):Res;            
        }
        static void SumDigit(int number, int i = 0, int y = 1, int Res = 0)
        {
            if (y == 1)
            {
                string Quantity = Convert.ToString(number);

                for (int j = 0; j < Quantity.Length - 1; j++)
                {
                    y = y * 10;
                }
            }
            

            if (y != 0)
            {
                i = (number / y);

                if (i != 0)
                {
                    number = number - y*i;
                    Res += i;
                }

                y = y / 10;

                SumDigit(number, y: y, Res: Res);
            }
            else
            {
                Console.WriteLine(Res);
            }
        }

        static int Foo(int value) //551
        {
            //return value < 10 ? value : value % 10 + Foo(value / 10);
            if (value < 10)
            {
                return value;
            }
            else
            {
                return value % 10 + Foo(value / 10);
            }
        }
        static void Main(string[] args)
        {            
            int[] value = { 1, 2, 3, 4 };
            Print(value);            
        }


    }
}
