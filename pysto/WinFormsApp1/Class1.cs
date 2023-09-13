using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Count
    {
        public double GetResult(int n, int[] m)
        {
            double sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                sum += (m[i] + m[i + 1]) / 2.0;
            }
            sum /= (n-1);
            return sum;
        }    
    }
}
