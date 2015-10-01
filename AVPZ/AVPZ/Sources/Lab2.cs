using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace AVPZ.Sources
{
    public class Lab2
    {
        private const float A = 2.876f;
        private const float B = 12.393f;

        //getters and setters
        public double beta { get; set; }

        private double calculateStatement1(double beta)
        {
            return pow(beta, (A + 1)) + exp(beta); 
        }

        private double calculateStatement2(double beta)
        {
            return (3 * (pow(beta, 2) - A)) / 0.1 * B;
        }

        private Boolean checkStatement1(double beta)
        {
            return ( (A < beta) && (beta <= (1.6 * A)) );
        }

        private Boolean checkStatement2(double beta)
        {
            return ( (B > beta) && (beta >= (2 * A)) );
        }

        /**
         * @return result of function
         */
        public double check()
        {
            if (checkStatement1(beta))
            {
                return calculateStatement1(beta);
            }
            else if (checkStatement2(beta))
            {
                return calculateStatement2(beta);
            }
            else
            {
                throw new Exception("Please enter values for testing(3.656 or 8.350)");
            }
        }


        //overriding math functions
        private double pow(double number, float power)
        {
            return Math.Pow(number, power);
        }

        private double exp(double arg)
        {
            return Math.Exp(arg);
        }
    }
}

