using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5  
{
    internal class Program

    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(@"Available operations:
             
              - addition,      
              - subtraction,   
              - multiplication (write: mult),
              - division,      
              - exponentiation (write: exp),
              - root,          
              - sine,          
              - cosine         
              ");
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("If you want to enter an operation, you can do so with the symbol (only +, -, *, /) or with the words above . ");
            Console.ResetColor(); 

            Console.Write("\nEnter fuction: ");
            string fuction = Convert.ToString(Console.ReadLine());

            Exponentiation exp = new Exponentiation();
            Root root = new Root();
            Sin sin = new Sin();
            Cos cos = new Cos();
            Add add = new Add();
            Substr subsrt = new Substr();
            Mult mult = new Mult();
            Division division = new Division();

            switch (fuction)
            {
                case " addition ":
                    add.calculate(fuction);
                    break;
                case "+":
                    add.calculate(fuction);
                    break;
                case "subtraction":
                    subsrt.calculate(fuction);
                    break;
                case "-":
                    subsrt.calculate(fuction);
                    break;

                case "mult":
                    mult.calculate(fuction);
                    break;
                case "*":
                    mult.calculate(fuction);
                    break;
                case "division":
                    division.calculate(fuction);
                    break;
                case "/":
                    division.calculate(fuction);
                    break;
                case "exp":
                    exp.calculate(fuction);
                    break;
                case "root":
                    root.calculate(fuction);
                    break;
                case "sine":
                    sin.calculate(fuction);
                    break;
                case "cosine":
                    cos.calculate(fuction);
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("ERROR");
                    Console.ResetColor(); 
                    break;

            }

        }

        class Exponentiation: Program
        {
            
            public void calculate(string fuction)
            {
               

                    Console.Write("Enter number: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the degree: ");
                    int degree = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Result: {Math.Pow(number, degree)}");
                
            }
        }
        class Root : Program
        {
            public void calculate(string fuction)
            {
                Console.Write("Enter number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Result: {Math.Sqrt(number)}");
            }
        }
        class Sin : Program
        {
            public void calculate(string fuction)
            {
                Console.Write("Enter number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result: {Math.Sin(number)}");
            }
        }
         class Cos : Program
        {
            public void calculate(string fuction)
            {
                Console.Write("Enter number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result: {Math.Cos(number)}");
            }

        }
        class Add : Program
        {
           public void calculate(string fuction)
            {
                Console.Write("Enter the first number: ");
                int number_1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int number_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Result: {number_1} + {number_2} = {(number_1 + number_2)}");
            }
        }
         class Substr : Program
        {
            public void calculate(string fuction)
            {
                Console.WriteLine("Enter the first number: ");
                int number_1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int number_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Result: {number_1} - {number_2} = {(number_1 - number_2)}");
            }
        }
         class Mult : Program
        {
            public void calculate(string fuction)
            {
                Console.Write("Enter the first number: ");
                int number_1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int number_2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Result: {number_1} * {number_2} = {(number_1 * number_2)}");
            }
         } 
         class Division : Program
        {
            public void calculate(string fuction)
            {
                Console.Write("Enter the first number: ");
                int number_1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int number_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Result: {number_1} / {number_2} = {((float)number_1 / number_2)}");
            }
         }

    }

    
      
    
}

