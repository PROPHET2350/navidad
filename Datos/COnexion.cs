using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Conexion
    {
        SqlConnection cone = new SqlConnection(@"Data Source=LAPTOP-7B96PMVA\SQLEXPRESS;Initial Catalog=navidad;Integrated Security=True");
        public SqlConnection conectar()
        {
            if (cone.State == ConnectionState.Closed)
                cone.Open();
            return cone;
        }
        public SqlConnection desconectar()
        {
            if (cone.State == ConnectionState.Open)
                cone.Close();
            return cone;
        }
    }
}
