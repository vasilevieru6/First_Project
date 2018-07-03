using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetProducts();

            foreach (Product p in products)
            {

                Console.WriteLine("Product", p.ToString());

            }

        }
    }

    class Product
    {
        readonly int id;
        public int Id { get { return id; } }

        readonly string name;

        public string Name { get { return name; } }

        public Product() { }

        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product(id: 1, name: "Andrei"),
                new Product(id: 2, name: "Alexandru")
            };
        }

        public override string ToString()
        {
            return String.Format("{0}. {1}", id, name);
        }
    }

}
