using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product[] procucts = new Product[]{
                  new Product("咖啡漾", 220),
                  new CPU("Intel Core i7 9770", 10000, 4),
                  new CPU("Intel Core i3 4330", 5000, 4)
            };

            foreach (Product product in procucts)
                Console.WriteLine(product);

            double TotalPrice = 0.0;
            //foreach (Product product in procucts)
            //    TotalPrice += product.Price;
            foreach (var product in procucts)
                TotalPrice += product.Price;
            Console.WriteLine("總價:{0}", TotalPrice);

            object[] objects = new object[]{
                  new Product("咖啡漾", 220),
                  new CPU("Intel Core i7 9770", 10000, 4),
                  new CPU("Intel Core i3 4330", 5000, 4)
            };

            foreach (var product in objects)
                TotalPrice += (product as Product).Price;
            Console.WriteLine("總價:{0}", TotalPrice);

            ArrayList list = new ArrayList();
            list.Add(new Product("咖啡漾", 220));
            list.Add(new CPU("Intel Core i7 9770", 10000, 4));
            list.Add(50);
            foreach (var product in list)
            {
                if (product is Product) //確保加入的資料型別是正確的
                    TotalPrice += (product as Product).Price;
            }
            Console.WriteLine("總價:{0}", TotalPrice);

            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product("咖啡漾", 220));
            ProductList.Add(new CPU("Intel Core i7 9770", 10000, 4));
            foreach (var product in ProductList)
                TotalPrice += product.Price;
            Console.WriteLine("總價:{0}", TotalPrice);

            //Product book = new Product("咖啡漾", 220);
            ////Product IntelI79770 = new CPU("Intel Core i7 9770", 10000, 4);

            //Product CPU1 = new CPU("Intel Core i7 9770", 10000, 4); //向上轉型、裝箱

            //// Console.WriteLine(book);
            ////Console.WriteLine(IntelI79770);
            //book.Method1();
            //CPU1.Method1();
            //book.Method2();
            //CPU1.Method2();
            //(CPU1 as CPU).Method2();
            //CPU CPU2 = new CPU("Intel Core i7 9770", 10000, 4);
            //CPU2.Method1();
            //CPU2.Method2();
            //CPU CPU3 = CPU1 as CPU; //向下轉型、拆箱
            //Console.WriteLine(CPU1.DiscountPrice);
            //Console.WriteLine(CPU2.DiscountPrice);
            //Console.WriteLine(CPU3.DiscountPrice);
        }
    }
}