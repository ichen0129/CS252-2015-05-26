using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class CPU : Product
    {
        public int CoreNumber { get; set; }

        public CPU(string Name, double Price, int CoreNumber)
            : base(Name, Price)
        {
            this.CoreNumber = CoreNumber;
        }

        //new public double DiscountPrice
        //{
        //    get
        //    {
        //        return base.DiscountPrice * 0.95;
        //    }
        // }

        public override double DiscountPrice
        {
            get
            {
                return base.DiscountPrice * 0.95;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nCPU的核心數:{0}", this.CoreNumber);
        }

        public override void Method1()
        {
            Console.WriteLine("CPU Method 1");
        }

        new public void Method2()
        {
            Console.WriteLine("CPU Method 2");
        }
    }
}