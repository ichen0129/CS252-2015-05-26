using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Product
    {
        public double Price { get; set; }

        public string Name { get; set; }

        public Product(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public virtual double DiscountPrice
        {
            get { return Price * 1.0; }
        }

        //public double DiscountPrice
        // {
        //    get { return Price * 1.0; }
        // }

        public override string ToString()
        {
            return string.Format("產品名稱:{0}, 價格{1}, 折扣後價格:{2}", this.Name, this.Price, this.DiscountPrice);
        }

        public virtual void Method1()
        {
            Console.WriteLine("Product Method 1");
        }

        public void Method2()
        {
            Console.WriteLine("Product Method 2");
        }
    }
}