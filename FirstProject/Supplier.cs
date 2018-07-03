using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Supplier
    {
        readonly int id;
        public int Id { get { return id; } }

        readonly string name;

        public string Name { get { return name; } }

        public Supplier() { }

        public Supplier(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public static List<Supplier> GetProducts()
        {
            return new List<Supplier>
            {
                new Supplier(id: 1, name: "Supplier1"),
                new Supplier(id: 2, name: "Supplier2")
            };
        }

        public override string ToString()
        {
            return String.Format("{0}. {1}", id, name);
        }
    }
}