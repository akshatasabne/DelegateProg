using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProg
{
    public delegate int MyDelegate(int a, int b);
    public class Calculation
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int Sub(int p,int q)
        {
            return p - q;
        }
    }
    public delegate void MyDelegate1(int a, string b, double c);
    public class Test
    {
        public void AcceptDetails(int a, string b, double c)
        {
            Console.WriteLine($"{a}--{b}--{c}");
        }
    }
}
