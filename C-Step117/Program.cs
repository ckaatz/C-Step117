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
    }
}
