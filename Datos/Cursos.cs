using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Cursos
    {
        private Conexion cone = new Conexion();
        public DataTable obtenerCursosIdEmp(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_curso_id_emp", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlda.Fill(dt);
            cone.desconectar();
            return dt;
        }
        public DataTable obtenerCursosId(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_curso_id", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlda.Fill(dt);
            cone.desconectar();
            return dt;
        }
        public void ingresarCursos(string nombre, string empresa,DateTime fechaI, DateTime fechaF, int id_empleado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "ingresar_curso";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@empresa", empresa);
            cmd.Parameters.AddWithValue("@fecha_inicio", fechaI);
            cmd.Parameters.AddWithValue("@fecha_fin", fechaF);
            cmd.Parameters.AddWithValue("@id_empleado", id_empleado);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void modificarCursos(string nombre, string empresa, DateTime fechaI, DateTime fechaF, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "modificar_curso";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@empresa", empresa);
            cmd.Parameters.AddWithValue("@fecha_inicio", fechaI);
            cmd.Parameters.AddWithValue("@fecha_fin", fechaF);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminarCursos(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_curso";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminar_cursos_emp(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_curso_emp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
    }
}
