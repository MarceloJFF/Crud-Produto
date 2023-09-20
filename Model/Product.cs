using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Produto.Model
{
    public class Product
    {
        public int Id { get; set; }
        //no máximo 100
        public string Name { get; set; }
        //no máximo 300
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; } = 0;
         
        public Product(int id) {
            this.Id = id;
        }
        public Product(int id, string name, int quantity,double price, string description) {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.Description = description;
        }
    
    }

}
