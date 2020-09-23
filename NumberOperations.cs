using System;

namespace NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0;
            string textResult = string.Empty;
            string textResult2 = string.Empty;
            if (op == "+" || op == "-" || op == "*")
            {
                switch (op)
                {
                    case "+": result = number1 + number2; break;
                    case "-": result = number1 - number2; break;
                    case "*": result = number1 * number2; break;
                }
                if(result%2 ==0)
                {
                    textResult = "even";
                }
                else
                {
                    textResult = "odd";
                }
                textResult2 =$"{number1} {op} {number2} = {result} - {textResult}";
            }
            else if(op =="/")
            {
                if(number2==0)
                {
                    textResult2 = $"Cannot divide {number1} by zero";
                }
                else
                {
                    result = number1 / number2;
                    textResult2 = $"{number1} / {number2} = {result:f2}";
                }
            }
            else if(op =="%")
            {
                if (number2 == 0)
                {
                    textResult2 = $"Cannot divide {number1} by zero";
                }
                else
                {
                    result = number1 % number2;
                    textResult2 = $"{number1} % {number2} = {result}";
                }
            }
            Console.WriteLine(textResult2);
        }
    }
}
