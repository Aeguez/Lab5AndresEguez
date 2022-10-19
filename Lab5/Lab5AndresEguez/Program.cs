using System;

class Program
{
    static void printCat()
    {
        Console.WriteLine(" /\\__/\\ ");
        Console.WriteLine("| O  O |");
        Console.WriteLine("| > * <|");
        Console.WriteLine(" \\____/ "); ;
    }

    static void Main(String[] args)
    {
        bool done = false;
        int num1 = 0;
        int num2 = 0;

        while (!done)
        {
            Console.WriteLine();
            Console.WriteLine("Which operation you want to perform?");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Substraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Cat");
            Console.WriteLine("6: Exit");

            Console.Write("Your choice: ");
            int opCode = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (opCode >= 1 && opCode <= 4)
            {
                num1 = GetInt();
                num2 = GetInt();
            }

            switch (opCode)
            {
                case 1:
                    Console.WriteLine(num1 + " + " + num2 + " = " + add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine(num1 + " - " + num2 + " = " + subtract(num1, num2));
                    break;
                case 3:
                    Console.WriteLine(num1 + " * " + num2 + " = " + multiply(num1, num2));
                    break;
                case 4:
                    Console.WriteLine(num1 + " / " + num2 + " = " + divide(num1, num2));
                    break;
                case 5:
                    printCat();
                    break;
                case 6:
                    Console.WriteLine("Good bye!");
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static int GetInt()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        return number;
    }

    static string GetString()
    {
        Console.WriteLine("Hey! Please insert something: ");
        string userInput = Console.ReadLine();
        return userInput;
    }

    static int add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    static int multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    static double divide(int num1, int num2)
    {
        double result = num1 * 1.0 / num2 * 1.0;
        return result;
    }
    char a='a';
}

