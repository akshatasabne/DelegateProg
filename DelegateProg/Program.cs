using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProg
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculation c= new Calculation();
            MyDelegate d1=new MyDelegate(c.Add);
            Console.WriteLine(d1.Invoke(4,5));
            MyDelegate d2= new MyDelegate(c.Sub);
            Console.WriteLine(d2.Invoke(8,4));

            Test t = new Test();
            MyDelegate1 d3 = new MyDelegate1(t.AcceptDetails);
            d3.Invoke(1,"ak",50);

        }
    }
}
