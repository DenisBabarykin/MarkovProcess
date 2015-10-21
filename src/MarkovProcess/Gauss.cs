using System;

namespace GaussNS
{
    public class Gauss
    {
        public Gauss(double[,] a, double[] b, int size)
        {
            ta = new double[size, size];
            tb = new double[size];
            tx = new double[size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                    ta[i, j] = a[i, j];
                tb[i] = b[i];
            }
            ts = size;
        }

        //------------------------------------------------------------------------

        public bool Solve()
        {
            // прямой ход
            int permutations = 0;
            for (int i = 0; i < ts - 1; i++)
            {
                // меняем текущую строку с той, у которой диагональный
                // элемент ненулевой и наибольший
                int imax = i;
                for (int j = i; j < ts; j++)
                {
                    if ((ta[j, i] > ta[imax, i]) && (ta[j, i] != 0))
                        imax = j;
                }
                if (imax != i)
                {
                    double tmp;
                    for (int t = 0; t < ts; t++)
                    {
                        tmp = ta[imax, t];
                        ta[imax, t] = ta[i, t];
                        ta[i, t] = tmp;
                    }
                    tmp = tb[imax];
                    tb[imax] = tb[i];
                    tb[i] = tmp;

                    permutations++;
                }

                // теперь прямой ход по данной строке
                for (int k = i + 1; k < ts; k++)
                {
                    if (ta[i, i] == 0)
                        return false;
                    double divider = ta[k, i] / ta[i, i];
                    for (int l = i; l < ts; l++)
                    {
                        ta[k, l] = ta[k, l] - ta[i, l] * divider;
                    }
                    tb[k] = tb[k] - tb[i] * divider;
                }
            }

            double mult = (permutations % 2 == 0 ? 1 : -1);
            for (int i = 0; i < ts; i++)
                mult *= ta[i, i];
            det = mult;

            // все, прямой ход сделан, теперь идем обратно
            for (int i = ts - 1; i >= 0; i--)
            {
                for (int j = i + 1; j < ts; j++)
                    tb[i] -= tx[j] * ta[i, j];
                if (ta[i, i] == 0)
                    return false;
                tx[i] = tb[i] / ta[i, i];
            }

            return true;
        }
        //------------------------------------------------------------------------

        public double GetX(int index)
        {
            if (index >= 0 && index < ts)
                return tx[index];
            else
                return 0;
        }
        //------------------------------------------------------------------------

        public double GetDeterm()
        {
            return det;
        }
        //------------------------------------------------------------------------

        private double[,] ta;
        private double[] tb;
        private double[] tx;
        private int ts;
        private double det;
    }
}