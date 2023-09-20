using Crud_Produto.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Produto.Dao
{
    public class ProductDao
        
    {
        SqlCommand com;
        int  rows = 0;
        Conexao conexao = new Conexao();
        string Query { get; set; } 
        public bool insertProduct(Product product)
        {
            Query = "use Bancoproduto INSERT INTO Product(Id,Name, Quantity, Price,Description) VALUES (@Id,@Name,@Quantity,@Price,@Description);";
            var conector = this.conexao.conectar();
            if(conector != null)
            {
                this.com = new SqlCommand(Query, conector);
                com.Parameters.AddWithValue("@Id", product.Id);
                com.Parameters.AddWithValue("@Name", product.Name);
                com.Parameters.AddWithValue("@Quantity", product.Quantity);
                com.Parameters.AddWithValue("@Price", product.Price);
                com.Parameters.AddWithValue("@Description", product.Description);

                rows = com.ExecuteNonQuery();
                return (rows > 0) ? true : false;
            }
            else
            {
                return false;
            }
            
        }

        public bool UpdateProduct(Product product)
        {
            Query = "use Bancoproduto UPDATE Product set Name =@Name ,Quantity=@Quantity, Price=@Price ,Description= @Description where Id=@Id ;";
            var conector = this.conexao.conectar();
            if (conector != null)
            {
                this.com = new SqlCommand(Query, conector);
                com.Parameters.AddWithValue("@Id", product.Id);
                com.Parameters.AddWithValue("@Name", product.Name);
                com.Parameters.AddWithValue("@Quantity", product.Quantity);
                com.Parameters.AddWithValue("@Price", product.Price);
                com.Parameters.AddWithValue("@Description", product.Description);

                rows = com.ExecuteNonQuery();
                return (rows > 0) ? true : false;
            }
            else
            {
                return false;
            }

        }
        public bool DeleteProduct(Product product)
        {
            Query = "use bancoproduto Delete from Product where Id=@ProductId";
            var conector = this.conexao.conectar();
            if (conector != null)
            {
                this.com = new SqlCommand(Query, conector);
                com.Parameters.AddWithValue("@ProductId", product.Id);
                rows = com.ExecuteNonQuery();
                return (rows > 0) ? true : false;
            }
            else
            {
                return false;
            }
        }

        public System.Data.DataTable GetProducts()
        {
            var dataTable = new DataTable();
            Query = "use BancoProduto Select Id,Name,Quantity,Price from Product;";
            var conector = this.conexao.conectar();
            if (conector != null)
            {
                this.com = new SqlCommand(Query, conector);
                SqlDataAdapter adapter = new SqlDataAdapter(this.com);
                adapter.Fill(dataTable);
                return dataTable;
            }
            else
            {
                return null;
            }
        }

    }
}
