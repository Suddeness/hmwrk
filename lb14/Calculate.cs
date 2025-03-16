using System;
using System.Collections.Generic;

namespace draw
{
    internal class Calculate
    {
        static public Dictionary<double,string> CalculateF(double? xmn, double? xmx, double? dxs)
        {
            double xmin = Convert.ToDouble(xmn);double xmax = Convert.ToDouble(xmx);double dx = Convert.ToDouble(dxs);
            Dictionary<double,string> results = new Dictionary<double,string>();
            for (double x = xmin; x <= xmax; x += dx)
            {
                string res;
                double cos = Math.Cos(2 * x);
                double sin = Math.Sin(1 * x);               
                if (cos <= 0) { res = $"Cos(2*{x}) <= 0"; }
                else if (sin <= 0) { res = $"Sin(1*{x}) <= 0"; }
                else
                {
                    res = (Math.Pow(cos, 1.0 / 3) + Math.Sqrt(sin)).ToString();                  
                }
                results[x] = res;
            }
            return results;
        }
    }
}
