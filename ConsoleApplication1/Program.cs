using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Tester
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new B().GetTs<Tester>().First();
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }

    public class A
    {
        public virtual IEnumerable<T> GetTs<T>()
            where T : new()
        {
            return new T[] { new T() };
        }
    }

    public class B : A
    {
        public override IEnumerable<T> GetTs<T>()
        {
            foreach (var t in base.GetTs<T>())
            {
                yield return t;
            }
        }
    } 

}
