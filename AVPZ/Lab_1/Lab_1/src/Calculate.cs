using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1.src
{
    public class Calculate
    {
        public const float T = 20.86f;

        //getters and setters
        public double inputValue { get; set; }
        public float a { get; set; }
        public byte w { get; set; }
        public double c { get; set; }

        private double calculateC(double a, byte w)
        {
            return cos(w * T) + exp(-a * T);
        }
        
        private double function(float a, byte w, double c, double arg)
        {
            return (pow(arg, 2) - arg * exp(-a * T)) / (pow(arg, 2) - 2 * arg * exp(-a * T) * c);
        }

        public void initializeVariables()
        {
            a = 0.015f;
            w = 20;

            c = calculateC(a, w);
        }

        /**
         * @return result of function
         */
        public double calculateInput()
        {
            return function(a, w, c, inputValue);
        }


        //overriding math functions
        private double pow(double number, float power)
        {
            return Math.Pow(number, power);
        }

        private double cos(double arg)
        {
            return Math.Cos(arg);
        }

        private double exp(double arg)
        {
            return Math.Exp(arg);
        }
    }
}
