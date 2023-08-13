using CalcJun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcJun.Class
{
    class Plus : IOperation
    {
        public string Name => "+";

        public float Execute(float a, float b)
        {
            return a + b;
        }
    }
}
