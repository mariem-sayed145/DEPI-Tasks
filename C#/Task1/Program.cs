
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Write a program that allows the user to enter a number then print it. 
            
            Console.Write("Enter your number: "); 
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered the number: {number}");
            

            // 2- Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen
            
            string str = "123abs";
            try
            {
                int result = int.Parse(str);
                Console.WriteLine($"Converted number: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error: The string '{str}' contains non-numeric characters and cannot be converted to an integer.");
            }

            //run : Error: The string '123abs' contains non-numeric characters and cannot be converted to an integer.
            

            // 3- Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            double num1 = 5.5 ;
            double num2 = 2.2;
            double result = num1 + num2;
            Console.WriteLine($"The result of adding {num1} and {num2} is: {result}");
            //The result of adding 5.5 and 2.2 is: 7.7
            

            // 4- Write C# program that Extract a substring from a given string
          
            string str = "Hello, World!";
            string substring = str.Substring(4,5);
            Console.WriteLine($"Extracted substring: {substring}");
            


            // 5- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            
            int x = 10 ;
            int y = x ;
            y = 20 ; 
            Console.WriteLine($"Value of x: {x}"); // Output: Value of x: 10
            Console.WriteLine($"Value of y: {y}"); // Output: Value of y: 20
            


            // 6- Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            
            int[] arr1 = { 10, 20, 30 };

            int[] arr2 = arr1;

            arr2[0] = 100;

            Console.WriteLine(arr1[0]); //100
            Console.WriteLine(arr2[0]); //100
            


            // 7- Write C# program that take two string variables and print them as one variable 

            string str1 = "Hello";
            string str2 = "World";  
            string combined = str1 + " " + str2;
            Console.WriteLine($"Combined string: {combined}"); // Output: Combined string: Hello World
        }
    }
}
