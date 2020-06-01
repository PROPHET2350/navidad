using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Departamentos
    {
        private Conexion cone = new Conexion();
        public DataTable obtenerDepartamentosIdEmp(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_departamento_id_emp", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlda.Fill(dt);
            cone.desconectar();
            return dt;
        }
        public DataTable obtenerDepartamentosId(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_departamento_id", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlda.Fill(dt);
            cone.desconectar();
            return dt;
        }
        public void ingresarDepartamento(string nombre, string cargo, int id_empleado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "ingresar_departamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre",nombre);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@id_empleado", id_empleado);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void modificarDepartamento(string nombre, string cargo, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "modificar_departamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@cargo", cargo);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminarDepartamento(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_departamento";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminar_departamento_emp(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_departamento_emp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
    }
}
