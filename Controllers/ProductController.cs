using Crud_Produto.Dao;
using Crud_Produto.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Crud_Produto.Controllers
{
    public class ProductController
    {
        ProductDao productDao;
        public ProductController() { }
        public bool insertProduct(int id, string name,int quantity, double price , string description )
        {
            Product product = new Product(id, name, quantity,price,description); 
            productDao = new ProductDao();
            var StatuInsercao = productDao.insertProduct(product);
            return  StatuInsercao ?  true :  false;
        }
        public System.Data.DataTable getAllProducts()
        {
            productDao = new ProductDao();
            

            return productDao.GetProducts();
        }
        public bool UpdateProduct(int id,string name, int quantity, double price, string description)
        {
            Product product = new Product(id,name, quantity, price, description);
            productDao = new ProductDao();
            var StatusUpdate = productDao.UpdateProduct(product);
            return StatusUpdate ? true : false;
        }
        public bool DeleteProduct(int id)
        {
            Product product = new Product(id);

            productDao = new ProductDao();
            var StatusUpdate = productDao.DeleteProduct(product);
            return StatusUpdate ? true : false;
        }
    }
}
