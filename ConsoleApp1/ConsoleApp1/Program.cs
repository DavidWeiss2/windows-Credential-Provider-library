using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] isa = { 1, 2, 3, 4, 5, 6, 7 };
            copy(i => true);
        }

        private static void copy(Predicate<int> p) => throw new NotImplementedException();
    }
}
