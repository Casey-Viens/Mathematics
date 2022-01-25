using Mathematics;
using System;
using System.Collections.Generic;

namespace MathematicsConsole
{
    class Program
    {
        private static double _num1;
        private static double _num2;
        private static List<double> _nums = new List<double>();
        private static string _operand;
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            //foreach (var a in args)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();
            var math = new BasicMath();
            var advMath = new AdvMath();
            AreArgumentsValid(args);
            switch (_operand)
            {
                case "add":
                    Console.WriteLine($"{_num1} + {_num2} = {math.AddNumbers(_num1, _num2)}");
                    break;
                case "sub":
                    Console.WriteLine($"{_num1} - {_num2} = {math.SubtractNumbers(_num1, _num2)}");
                    break;
                case "mul":
                    Console.WriteLine($"{_num1} * {_num2} = {math.MultiplyNumbers(_num1, _num2)}");
                    break;
                case "div":
                    Console.WriteLine($"{_num1} / {_num2} = {math.DivideNumbers(_num1, _num2)}");
                    break;
                case "area":
                    Console.WriteLine($"{_num1} * {_num2} = {advMath.CalcArea(_num1, _num2)}");
                    break;
                case "average":
                    Console.WriteLine($"The average is = {advMath.CalcAvg(_nums)}");
                    break;
                case "square":
                    Console.WriteLine($"{_num1} ^ 2 = {advMath.SquareNumber(_num1)}");
                    break;
                case "pythagorean":
                    Console.WriteLine($"C = {advMath.PythagoreanTheorem(_num1, _num2)}");
                    break;
                default:
                    Console.WriteLine("The Operand you chose is not a valid option. Please Enter Add, Sub, Mul, or Div");
                    break;
            }
            
        }

        private static void AreArgumentsValid(string[] args)
        {
            _operand = args[1].ToLower();
            if(_operand == "square")
            {
                _num1 = Numparser(args[2]);
            }else if (_operand == "average")
            {
                for(int i = 2; i < args.Length; i++)
                {
                    _nums.Add(Numparser(args[i]));
                }
            }else if(args.Length == 4)
            {
                _num1 = Numparser(args[2]);
                _num2 = Numparser(args[3]);
            }
            else
            {
                Console.WriteLine($"Operation could not be complete");
                Environment.Exit(99);
            }
            Console.WriteLine("All arguments are valid");
            Console.ReadLine();
        }

        public static double Numparser(string arg)
        {
            double num;
            if (Double.TryParse(arg, out num))
            {
                return num;
            }
            else
            {
                Console.WriteLine($"Unable to parse {num}");
                Environment.Exit(99);
            }
            return 0;
        }
    }
}
