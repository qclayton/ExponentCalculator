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
        static double answer;
        static void Main(string[] args)
        {


            userNameInput(); //Quentin
            numBase = userNumericalInput("base", 100);
            numExpon = userNumericalInput("exponent", 10);
            //userNumericalInput("exponent number.");
            calculate();//Tyler
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

        static void userNameInput()
        {
            Console.WriteLine("Enter Your Name Here!");
            string userName = Console.ReadLine();
            bool result = userName.All(Char.IsLetter);
            if (result){
                Console.WriteLine("Welcome " + userName);
            }else
	        {
             Console.WriteLine("Invaild Name. Please try again");
	        }

        }

        public static void calculate()
        {
            answer = Math.Pow(numBase, numExpon);
            Console.WriteLine("The answer is: " + answer);
            Console.Read();

        }

        public static void returnName()
        {
            int i = 0;
            
            while(i < answer)
            {
                Console.WriteLine();
                i++;
            }

        }

    }
}
