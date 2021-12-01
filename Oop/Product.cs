using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csdemo01.Oop
{
    public class Product
    {
        private string name;
        private int price, qoh;

        static int taxrate = 10;

        public Product(string name, int price, int qoh) {
            this.name = name;
            this.price = price;
            this.qoh = qoh;
        }

        public void Purchase(int qty)
        {
            this.qoh += qty;
        }

        public void Sell(int qty)
        {
            this.qoh -= qty;
        }

        public int getStock()
        {
            return qoh;
        }

        public int getPrice()
        {
            return price;
        }
        public float getNetPrice()
        {
            return price + price * taxrate / 100;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 0)
                    this.name = value;
            }
        }

        public int getTaxrate()
        {
            return taxrate;
        }

        public void Print()
        {
            Console.WriteLine($"ProductName- {this.name}; Price-{this.price}; Available Quantity-{qoh}");
        }

    }


    public class testProduct
    {

        static void Main(string[] args)
        {
            var p1 = new Product("Dell Laptop", 50000, 4);
            p1.Print();
            Product p2 = new Product("Reading Table", 3000, 20);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.getNetPrice());
            Console.WriteLine(p2.getPrice());

            p1.Sell(2);
            p1.Name = "Dell Latitude Laptop";
            Console.WriteLine(p1.Name +"    -   " + p1.getStock());

        }

    }
}
