using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Produto.Dao
{
    public class Conexao
    {
        public string myConn { get; set; }
        SqlConnection con;
        SqlCommand cmd;
        public Conexao()
        {
            
        }

        public SqlConnection conectar()

        {
            try
            {
                this.myConn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                this.con = new SqlConnection(this.myConn);
                con.Open();
                return con;
            }
            catch
            {
                return null;
            }
     

        }
    }
}
