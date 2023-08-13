using CalcJun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcJun.Class
{
    class Calculator : ICalculator
    {
        IOperation[] operations = new IOperation[4];
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
}
