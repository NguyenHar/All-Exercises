﻿using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Grand Circus Exercises list!");
        while (true)
        {
            Console.WriteLine("Please select an exercise: (1-21) ");
            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 1:
                    Exercise_1();
                    break;
                case 2:
                    Exercise_2();
                    break;
                case 3:
                    Exercise_3();
                    break;
                case 4:
                    Exercise_4();
                    break;
                case 5: 
                    Exercise_5();
                    break;
                case 6:
                    Exercise_6();
                    break;
                case 7:
                    Exercise_7();
                    break;
                case 8:
                    Exercise_8();
                    break;
                case 9:
                    Exercise_9();
                    break;
                case 10:
                    Exercise_10();
                    break;
                case 11:
                    Exercise_11();
                    break;
                case 12:
                    Exercise_12();
                    break;
                case 13:
                    Exercise_13();
                    break;
                case 14:
                    Exercise_14();
                    break;
                case 15:
                    Exercise_15();
                    break;
                case 16:
                    Exercise_16();
                    break;
                case 17:
                    Exercise_17();
                    break;
                case 18:
                    Exercise_18();
                    break;
                case 19:
                    Exercise_19();
                    break;
                case 20:
                    Exercise_20();
                    break;
                case 21:
                    Exercise_21();
                    break;
                case 22:
                    Exercise_22();
                    break;
                case 23:
                    Exercise_23();
                    break;



                default:
                    Exercise_1();
                    break;
            }


            Console.WriteLine();
            Console.Write("Continue to another exercise? y/n: ");
            if (Console.ReadLine() == "n")
                break;
        }
        Console.WriteLine("Goodbye!");
    }

    static void Exercise_1()
    {
        Console.Write("Exercise 1 selected, please enter some text: ");
        Console.WriteLine($"{Console.ReadLine()}");
    }
    static void Exercise_2()
    {
        Console.Write("Exercise 2 selected, please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"{++number}");
    }
    static void Exercise_3()
    {
        Console.Write("Exercise 3 selected, please enter a number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"{0.5m + number}");
    }
    static void Exercise_4()
    {
        Console.Write("Exercise 4 selected, please enter two numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter a second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Addition result: {num1+num2}");
    }
    static void Exercise_5() 
    {
        Console.Write("Exercise 4 selected, please enter two numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter a second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiplication result: {num1 * num2}");
    }
    static void Exercise_6()
    {
        string prompt = "";
        do
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Would you like to continue (y/n)?");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_7()
    {
        string prompt = "";
        Console.WriteLine("Exercise 7 selected. Running exercise 1 in a loop");
        do
        {
            Exercise_1();
            Console.WriteLine("Would you like to continue (y/n)?");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_8() 
    {
        string prompt = "";
        Console.WriteLine("Exercise 8 selected, running exercises 2-5 in a loop");
        do
        {
            Exercise_2();
            Exercise_3();
            Exercise_4();
            Exercise_5();
            Console.WriteLine("Would you like to continue (y/n)?");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_9() 
    {
        Console.WriteLine("Exercise 9 selected. ");
        string prompt2 = "";
        do
        {
            Console.Write("Please select a language (English/Dutch/German/Spanish): ");
            string prompt = Console.ReadLine();
            switch (prompt)
            {
                case "English":
                    Console.WriteLine("Hello World!");
                    break;
                case "Dutch":
                    Console.WriteLine("Hallo Wereld!");
                    break;
                case "German":
                    Console.WriteLine("Hallo Welt!");
                    break;
                case "Spanish":
                    Console.WriteLine("Hola Mundo!");
                    break;
                default:
                    Console.WriteLine("Unknown language inputted");
                    break;
            }
            Console.Write("Would you like to continue (y/n)? ");
            prompt2 = Console.ReadLine();
        } while (prompt2 == "y");
    }
    static void Exercise_10()
    {
        Console.Write("Exercise 10 selected. ");
        string prompt = "";
        do
        {
            Console.WriteLine("Enter your height in inches: ");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(number >= 54 ? "Great, you can ride the Raptor!" : $"Sorry, you cannot ride the Raptor. you need {54 - number} more inches.");
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_11()
    {
        Console.WriteLine("Exercise 11 selected.");
        string prompt = "";
        do
        {
            for (int i=0; i<=9; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_12()
    {
        Console.WriteLine("Execise 12 selected.");
        string prompt = "";
        do
        {
            for (int i = 9; i>=0 ; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_13()
    {
        Console.Write("Exercise 13 selected. ");
        string prompt = "";

        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            for (int i = value; i >= 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_14()
    {
        Console.Write("Exercise 14 selected. ");
        string prompt = "";

        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            for (int i=1; i <= value; i++)
            {
                Console.Write($"{i * i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_15()
    {
        Console.Write("Exercise 15 selected. ");
        string prompt = "";

        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            for (int i = 1; i <= value; i++)
            {
                Console.Write($"{i * i * i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_16()
    {
        Console.WriteLine("Exercise 16 selected.");
        string triangle = "";

        for (int i = 0; i < 10; i++)
        {
            triangle += "*";
            Console.WriteLine(triangle);
        }
    }
    static void Exercise_17()
    {
        Console.WriteLine("Exercise 17 selected.");
        int height = 10;
        for (int i = 1; i <= height; i++)
        {
            for (int j = height - i; j > 0; j--)
                Console.Write(" ");
            for (int k = 1; k <= i; k++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }
    static void Exercise_18() 
    {
        Console.Write("Exercise 18 selected. ");
        string prompt = "";
        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= value; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");    
    }
    static void Exercise_19()
    {
        Console.Write("Exercise 18 selected. ");
        string prompt = "";
        do
        {
            Console.Write("Enter a number: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int value2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = value1; i <= value2; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of all numbers from {value1} to {value2} is {sum}");
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_20()
    {
        Console.Write("Exercise 20 selected. ");
        string prompt = "";
        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            int product = 1;
            for (int i = 0; i < 3; i++)
            {
                product *= (value - i);
            }
            Console.WriteLine($"The product of {value}, {value - 1}, {value - 2} is {product}");
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_21()
    {
        Console.WriteLine("Exercise 21 selected. ");
        string prompt = "";
        string prompt2 = "";
        do
        {
            string outputString = "";
            do
            {
                Console.Write("Enter a word: ");
                outputString += Console.ReadLine() + " ";
                Console.Write("Would you like to enter another word (y/n)?");
                prompt2 = Console.ReadLine();
            } while (prompt2 == "y");
            Console.WriteLine(outputString);
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_22() { }
    static void Exercise_23() { }
    static void Exercise_24() { }
    static void Exercise_25() { }
    static void Exercise_26() { }
    static void Exercise_27() { }
    static void Exercise_28() { }
    static void Exercise_29() { }
    static void Exercise_30() { }
    static void Exercise_31() { }
    static void Exercise_32() { }
    static void Exercise_33() { }
    static void Exercise_34() { }
    static void Exercise_35() { }
    static void Exercise_36() { }
    static void Exercise_37() { }
    static void Exercise_38() { }
    static void Exercise_39() { }
    static void Exercise_40() { }
    static void Exercise_41() { }
    static void Exercise_42() { }
    static void Exercise_43() { }
    static void Exercise_44() { }
    static void Exercise_45() { }
    static void Exercise_46() { }
    static void Exercise_47() { }
    static void Exercise_48() { }
    static void Exercise_49() { }
    static void Exercise_50() { }
    static void Exercise_51() { }
    static void Exercise_52() { }
    static void Exercise_53() { }
    static void Exercise_54() { }
    static void Exercise_55() { }
    static void Exercise_56() { }
    static void Exercise_57() { }
    static void Exercise_58() { }
    static void Exercise_59() { }
    static void Exercise_60() { }
    static void Exercise_61() { }
    static void Exercise_62() { }
    static void Exercise_63() { }
    static void Exercise_64() { }
    static void Exercise_65() { }
    static void Exercise_66() { }
    static void Exercise_67() { }
    static void Exercise_68() { }
    static void Exercise_69() { }
    static void Exercise_70() { }
    static void Exercise_71() { }
}