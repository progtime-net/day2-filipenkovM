using CalcJun.Interfaces;
using CalcJun.Class;

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
}