using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovProcess
{
    public class Compare
    {
        public static double EPS = 0.001;

        public static bool Equal(double num1, double num2)
        {
            if (Math.Abs(num1 - num2) < EPS)
                return true;
            else
                return false;
        }

        public static bool Equal(double[] array1, double[] array2)
        {
            if (array1.Length != array2.Length)
                throw new Exception("Размеры массивов для сравнения не совпадают.");

            for (int i = 0; i < array1.Length; ++i)
                if (!Equal(array1[i], array2[i]))
                    return false;

            return true;
        }
    }
}
