﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps operations = new MathOps(); // create new instance of class MathOps to use methods

            int finalResult = operations.Add(2); // passing int through math method
            Console.WriteLine("The result of 2 added to 250 equals: " + finalResult);
            Console.ReadLine();

            finalResult = operations.Mult(2.2); // passing double through math method
            Console.WriteLine("The result of 2.2 multiplied by 2.25 equals (rounded): " + finalResult);
            Console.ReadLine();

            int result2 = operations.Divide("20"); // passing string through math method
            Console.WriteLine("The result of string \"20\" divided by 2 equals: " + result2);
            Console.ReadLine();

        }
    }

    public class MathOps
    {
        public int Add(int number) //create method requiring one int parameter
        {
            return number + 250; //do calculation when called
        }

        public int Mult(double number) //create method requiring one double parameter
        {
            int result = Convert.ToInt32(number * 2.25);
            return result;//do calculation when called
        }

        public int Divide(string myString) //create method requiring one string parameter
        {
            int newInt = Convert.ToInt32(myString); // convert string to int
            int result = newInt / 2; // perform math
            return result;//do calculation when called
        }
    }

}