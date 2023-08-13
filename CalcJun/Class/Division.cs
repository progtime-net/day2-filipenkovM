using CalcJun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcJun.Class
{
    class Division : IOperation
    {
        public string Name => "/";

        public float Execute(float a, float b)
        {
            return (float)a / (float)b;
        }
    }
}
