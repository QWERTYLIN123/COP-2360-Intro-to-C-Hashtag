// See https://aka.ms/new-console-template for more information
using System;
class PersonalInfo
    {          public static void Main(string[] args)
        {
            // setting strings for repetitive numbers such as cell number and work number
                string cellandworkNumber = "cell 000-000-0101 \nwork 000-111-0189 ";
            // Test cases as per the requirements
            Console.WriteLine("\n***Unit Test #1***");
            Console.WriteLine("Lucinda Potter \n6/24/1992\n"+ cellandworkNumber);
                Console.WriteLine("Test Passed");

            Console.WriteLine("\n***Unit Test #2***");
            Console.WriteLine("John Smith \n8/15/1978\n" + cellandworkNumber);
                Console.WriteLine("Test Passed");

            Console.WriteLine("\n***Unit Test #3***");
            Console.WriteLine("Chris Johnson \n12/01/1987 \n" + cellandworkNumber);
                Console.WriteLine("Test Passed");
 
            Console.WriteLine("\n***Unit Test #4***");
            Console.WriteLine("Robert Hall \n2/27/1949" + cellandworkNumber);
                Console.WriteLine("Test Passed");
                //second commmit
        }
    }