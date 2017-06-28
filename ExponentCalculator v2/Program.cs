using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentCalculator_v2
{
    class Program
    {
        static int numBase = 0;
        static int numExpon = 0;
        static void Main(string[] args)
        {

            Console.WriteLine("Hello world");
            Console.ReadLine();

            //userNameInput(); //Quentin
            userNumericalInput("base number.");//Trevor
            //userNumericalInput("exponent number.");
            //calculate();//Tyler
            //returnName(); //Sarah
        }

        public static int userNumericalInput(string s)
        {
            int n = 0;

            Console.WriteLine("Please enter the " + s);
            Console.ReadLine();

            return n;
        }

        public static void userNameInput()
        {


        }

        public static void returnName()
        {


        }

        public static void calculate()
        {


        }



    }
}
