﻿using System;
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
            //userNumericalInput("base number.");//Trevor
            //userNumericalInput("exponent number.");
            //calculate();//Tyler
            //returnName(); //Sarah
        }

        public static int userNumericalInput(string s)
        {
            int n = 0;

            console.writeline("please enter the " + s);
            console.readline();

            return n;
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

        public static void returnName()
        {


        }

        public static void calculate()
        {


        }



    }
}
