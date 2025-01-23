using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tgs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int b = 5; int c = a + b; int d = a - b; int e = a * b; int f = a / b;
            bool lb, lk, lbs, lks, smd, tsm;

            lk = c < e;
            lb = c > e;
            lks = d <= f;
            lbs = d >= f;
            smd = c == e;
            tsm = d != f;


            Console.WriteLine("c = lebih kecil dari e adalah :{0}", lk);
            Console.WriteLine("c = lebih besar dari e adalah :{0}", lb);
            Console.WriteLine("d = lebih kecil sama dengan f adalah :{0}", lks);
            Console.WriteLine("c = lebih besar sama dengan f adalah :{0}", lbs);
            Console.WriteLine("c = sama dengan e adalah :{0}", smd);
            Console.WriteLine("d = tidak sama dengan f adalah :{0}", tsm);

        }
    }
}
