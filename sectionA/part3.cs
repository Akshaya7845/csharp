//type conversion 
using System;

namespace TypeConversionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int smallNumber = 100;
            float bigNumber = smallNumber;
            Console.WriteLine("implicit conversion (int to float): " + bigNumber);  

            // explicit conversion
            float decimalValue = 123.45f;
            int intValue = (int)decimalValue; 
            Console.WriteLine("explicit conversion (float to int): " + intValue);  

            //as keyword
            object obj1 = "Hello World";
            string str1 = obj1 as string;
            if (str1 != null)
            {
                Console.WriteLine("using 'as' keyword: " + str1);
            }

            object obj2 = 123;
            string str2 = obj2 as string;
            if (str2 == null)
            {
                Console.WriteLine("using 'as' keyword: conversion failed, returned null");
            }

            //is keyword
            object obj3 = "I am a string";
            if (obj3 is string)
            {
                Console.WriteLine("using 'is' keyword: obj3 is a string");
            }

            // convert class
            string numberText = "456";
            int convertedNumber = Convert.ToInt32(numberText);
            Console.WriteLine("convert class (string to int): " + convertedNumber); 
            //invalid string exception handling
            try
            {
                string invalid = "abc";
                int invalidConversion = Convert.ToInt32(invalid);
                Console.WriteLine(invalidConversion);
            }
            catch (FormatException)
            {
                Console.WriteLine("convert class: cannot convert 'abc' to int ");
            }
            Console.WriteLine("\npress any key to exit");
            Console.ReadKey();
        }
    }
}
