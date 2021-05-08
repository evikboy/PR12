using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR12
{
    class Program
    {
        static int Main(string[] args)
        {
            double Z, x, k, xmin, xmax, dx, xn;
            double A, B, C;
            StreamReader sr = new StreamReader("C:\\Users\\Ez\\source\\repos\\PR12\\input.txt");
            StreamWriter sw = new StreamWriter("C:\\Users\\Ez\\source\\repos\\PR12\\output.txt");
            k = Convert.ToDouble(sr.ReadLine());
            xmin = Convert.ToDouble(sr.ReadLine());
            xmax = Convert.ToDouble(sr.ReadLine());
            dx = Convert.ToDouble(sr.ReadLine());
            sr.Close();

            Console.WriteLine("k = {0}\nxmin = {1}\nxmax = {2}\ndx = {3}\n", k,xmin,xmax,dx);
            sw.WriteLine("k = {0}\nxmin = {1}\nxmax = {2}\ndx = {3}\n", k, xmin, xmax, dx);
            if (xmin > xmax)
            {
                Console.WriteLine("Wrong boundaries");
                if (dx == 0 || dx < 0)
                {
                    Console.WriteLine("Wrong dx");
                }
                return 0;
            }

            for (xn = xmin; xn <= xmax; xn +=dx)
            {
                x = xn;
                A = 1 / Math.Tan(k * x);
                B = Math.Cos(k * x);
                C = Math.Log(Math.Sin(k * x));
                if (A > 0 && C != 0 && Math.Sin(k * x) > 0)
                {
                    Z = Math.Pow(A, 1.0 / 3.0) + B / C;
                    Console.WriteLine("When x = {0}, Z = {1}",x, Z);
                    sw.WriteLine("When x = {0}, Z = {1}", x, Z);
                }
                else
                {
                    Console.WriteLine("Can't be calculated when x = {0}", x);
                    sw.WriteLine("Can't be calculated when x = {0}", x);
                }
            }
            sw.Close();
            return 0;
        }
    }
}
