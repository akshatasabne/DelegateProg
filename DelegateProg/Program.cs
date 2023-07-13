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
            //Calculation c= new Calculation();
            //MyDelegate d1=new MyDelegate(c.Add);
            //Console.WriteLine(d1.Invoke(4,5));
            //MyDelegate d2= new MyDelegate(c.Sub);
            //Console.WriteLine(d2.Invoke(8,4));

            //Test t = new Test();
            //MyDelegate1 d3 = new MyDelegate1(t.AcceptDetails);
            //d3.Invoke(1,"ak",50);

            MulticastDelegatepro multicast=new MulticastDelegatepro();
            MyDelegate d = new MyDelegate(multicast.Add);
            d+= new MyDelegate(multicast.Sub);

            Delegate[] del= d.GetInvocationList();
            foreach(Delegate item in del)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(20,30));
            }

        }
    }
}
