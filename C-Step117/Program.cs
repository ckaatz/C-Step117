using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Step117
{
    class Program
    {
        static void Main(string[] args)
        {
            MoreMath Math1 = new MoreMath();
            Console.WriteLine("Pick a number:");
            int UserInput = Convert.ToInt32(Console.ReadLine());
            int OutPutValue;
            Math1.DivideByTwo(UserInput, out OutPutValue);
            Console.WriteLine(OutPutValue);
            Console.ReadLine();
        }
    }

    public class MoreMath
    {
        public void DivideByTwo(int Num1, out int Num2)
        {
            Num2 = Num1 / 2;
        }

        //method with output parameters:
        public void AddOne(int Num1, out int Num2, out int Num3)
        {
            Num2 = Num1 + 1;
            Num3 = Num2 + 1;
        }

        //overloaded methods:
        public int TimesOne(int Num1)
        {
            return Num1 * 1;
        }
        public decimal TimesOne(decimal Num1)
        {
            return Num1 * 1;
        }
    }
    //Static class:
    public static class NewClass
    {

    }
}
