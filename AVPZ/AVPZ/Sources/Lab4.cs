using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AVPZ.Sources
{
    class Lab4
    {
        public float a { get; set; }
        public float b { get; set; }
        public float q { get; set; }

        public float x1 { get; set; }
        public float x2 { get; set; }
        public float x12 { get; set; }

        private float getUserValues(float a, float b, float q)
        {
            return (float)pow(b, 2) - (4 * a * q);
        }

        public float getX1(float discriminant)
        {
            return (float)(-b + sqrt(discriminant)) / (2 * a);
        }

        public float getX2(float discriminant)
        {
            return (float)(-b - sqrt(discriminant)) / (2 * a);
        }

        public float getX12()
        {
            return (float)(-b / (2 * a));
        }

        public void calculate()
        {
            float discriminant = getUserValues(a, b, q);
            
            if(discriminant == 0)
            {
                x12 = getX12();
		    }
		    else if(discriminant > 0)
		    {
                x1 = getX1(discriminant);
                x2 = getX2(discriminant);
		    }
		    else
		    {
                throw new Exception("Root are imaginary");
		    }
        }

        //overriding math functions
        private double pow(double number, float power)
        {
            return Math.Pow(number, power);
        }
        
        private double sqrt(double number)
        {
            return Math.Sqrt(number);
        }
    }
}
