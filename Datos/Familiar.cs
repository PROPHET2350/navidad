using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Familiar
    {
        private Conexion cone = new Conexion();

        public DataTable obtenerFamiliaresIdEmp(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_familiar_id_emp", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlda.Fill(dt);
            cone.desconectar();
            return dt;
        }
        public DataTable obtenerFId(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_familiar_id", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlda.Fill(dt);
            return dt;
        }
        public DataTable obtener_info(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_demograficos_fam", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlda.Fill(dt);
            return dt;
        }
        public void ingresarFamiliar(string nombre, string apellido, string mail, string telefono, int id_empleado)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "ingresar_familiar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@id_empleado", id_empleado);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void ingresar_familiar_info(string sexo, string estado_civil, int id_familiar, string provincia, string canton)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "ingresar_demograficos_fam";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
            cmd.Parameters.AddWithValue("@id_familiar", id_familiar);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            cmd.Parameters.AddWithValue("@canton", canton);

            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void modificar_familiar_info(string sexo, string estado_civil, string provincia, string canton, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "modificar_demograficos_fam";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            cmd.Parameters.AddWithValue("@canton", canton);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void modificarFamiliar(string nombre, string apellido, string mail, string telefono, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "modificar_familiar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminarFamiliar(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_familiar";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminar_familiar_info(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_demograficos_fam";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminar_familiar_info_emp(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_demograficos_fam_emp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminar_familiar_emp(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_familiar_emp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
    }
}
