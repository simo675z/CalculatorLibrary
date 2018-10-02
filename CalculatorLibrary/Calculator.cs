using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        public static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }

        public static double Sum(double[] numbers)
        {
            int i;
            double summer = 0;
            for (i = 0; i < numbers.Length; i++)
            {
                summer = summer + numbers[i];
            }
            return summer;
        }

        public static double Minimum(double[] numbers)
        {
            int i;
            double min = 2000;
            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public static double Maximum(double[] numbers)
        {
            int i;
            double max = 0;
            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static double Average(double[] numbers)
        {
            int i;
            double summer = 0;
            double Arraylength = numbers.Length;
            double averagecontainer = 0;
            for (i = 0; i < numbers.Length; i++)
            {
                summer = summer + numbers[i];
            }

            averagecontainer = summer / Arraylength;

            return averagecontainer;
        }
    }
}
