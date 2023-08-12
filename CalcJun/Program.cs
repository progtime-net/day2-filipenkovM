using CalcJun.Interfaces;

namespace CalcJun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.InputAndCalculate();
        }
    }

    class Calculator : ICalculator
    {
        Plus plus = new Plus();
        Minus minus = new Minus();
        Division division = new Division();
        Multiplication multiplication = new Multiplication();

        public float ExecuteOperation(string operation, float a, float b)
        {
            if (operation == plus.Name)
            {
                return plus.Execute(a, b);
            }
            else if (operation == minus.Name)
            {
                return minus.Execute(a, b);
            }
            else if (operation == multiplication.Name)
            {
                return multiplication.Execute(a, b);
            }
            else if (operation == division.Name)
            {
                return division.Execute(a, b);
            }
            else
            {
                throw new Exception();
                return 4;
            }
        }

        public void InputAndCalculate()
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(ExecuteOperation(input[1], float.Parse(input[0]), float.Parse(input[2])));
        }
    }

    class Plus : IOperation
    {
        public string Name => "+";

        public float Execute(float a, float b)
        {
            return a + b;
        }
    }

    class Minus : IOperation
    {
        public string Name => "-";

        public float Execute(float a, float b)
        {
            return a - b;
        }
    }

    class Division : IOperation
    {
        public string Name => "/";

        public float Execute(float a, float b)
        {
            return (float)a / (float)b;
        }
    }

    class Multiplication : IOperation
    {
        public string Name => "*";

        public float Execute(float a, float b)
        {
            return (float)a * (float)b;
        }
    }
}