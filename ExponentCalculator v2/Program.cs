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


            userNameInput(); //Quentin
            numBase = userNumericalInput("base", 100);
            numExpon = userNumericalInput("exponent", 10);
            //userNumericalInput("exponent number.");
            //calculate();//Tyler
            //returnName(); //Sarah
        }

        public static int userNumericalInput(string s, int b)
        {

            int x = 0;

            bool valid = true;

            Console.WriteLine("Please enter the " + s + " number. It must be " + b + " or less.");
            var i = Console.ReadLine();

            while (valid)
            {

                if (!int.TryParse(i, out x) || x > b)
                {

                    Console.WriteLine(i + " is invalid. Re-enter.");
                    i = Console.ReadLine();

                }

                else
                {

                    valid = false;

                }

            }

            return x;

        }

        public static void userNameInput()
        {
            string userName;
            bool vaild = input.All(Char.IsLetter);
            Console.WriteLine("Enter you Name Here!");
            userName = Console.ReadLine();
            Console.WriteLine("Welcome " + userName);
            Console.ReadLine();

        }

        public static void calculate()
        {


        }

        public static void returnName()
        {


        }

    }
}
