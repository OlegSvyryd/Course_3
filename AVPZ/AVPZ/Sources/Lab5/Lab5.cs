using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AVPZ.Sources.Lab5;

namespace AVPZ.Sources.Lab5
{
    class Lab5
    {
        public static double getRoot(Function f, double from, double to, double precision)
        {
            // если значения функции на концах отрезка не разных знаков
            if (Math.Sign(f.getValue(from)) * Math.Sign(f.getValue(to)) > 0)
                throw new Exception("Values of func have not same char");

            double middle = (from + to) / 2;
            while (Math.Abs(f.getValue(middle)) > precision)
            {
                if (Math.Sign(f.getValue(from)) * Math.Sign(f.getValue(middle)) < 0)
                {
                    to = middle;
                }
                if (Math.Sign(f.getValue(middle)) * Math.Sign(f.getValue(to)) < 0)
                {
                    from = middle;
                }
                middle = (from + to) / 2;
            }
            return middle;
        }

        public double calculate()
        {
            Function f = new FunctionImpl();
            double from = 1;
            double to = 2;
            double precision = 0.001;
 
            return getRoot(f, from, to, precision);
        }
    }
}
