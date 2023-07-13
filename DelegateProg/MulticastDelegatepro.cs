using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateProg
{
    public class MulticastDelegatepro
    {
        public delegate int MyDelegate(int a, int b);
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int p, int q)
        {
            return p - q;
        }
    }
}
