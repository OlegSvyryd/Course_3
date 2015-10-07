using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AVPZ.Sources
{
    class FunctionImpl : AVPZ.Sources.Lab5.Function
    {

        public double getValue(double arg)
        {
            return pow(arg, 3) + 2 * arg - 11;
        }

        //overriding math functions
        private double pow(double number, float power)
        {
            return Math.Pow(number, power);
        }
    }
}
