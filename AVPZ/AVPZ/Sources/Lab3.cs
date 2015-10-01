using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AVPZ.Sources
{
    class Lab3
    {
        private const float INIT = -4.8f;
        private const float STEP = 0.1f;
        private const float A = 3.2f;
        private const byte AMOUNT_ITERATIONS = 7;

        private double c(double f)
        {
            return (pow(f, (A + 1)) + pow(f, (A - 1))) / abs(A + f);
        }

        private int calculateLastValue()
        {
            float xk = INIT + (AMOUNT_ITERATIONS - 1);
            float deltaX = INIT + (AMOUNT_ITERATIONS - 1) * STEP;
            return (int)abs((xk - INIT) / deltaX) + 1;
        }

        public string result()
        {
            int last = calculateLastValue();
            string resultRows = null;
            for (float i = INIT; i < last; i += STEP)
            {
                resultRows += "x = " + i + ", c = " + c(i) + "\n";
            }
            return resultRows;
        }

        //overriding math functions
        private double pow(double number, float power)
        {
            return Math.Pow(number, power);
        }

        private double abs(double arg)
        {
            return Math.Abs(arg);
        }
    }
}
