using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class Empleados
    {
        private Conexion cone = new Conexion();

        public bool existencia(string mail)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;
            cmd.Connection = cone.conectar();
            cmd.CommandText = "validar_empleado_existe";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mail", mail);
            leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                leer.Close();
                cone.desconectar();
                return true;
            }
            else
            {
                leer.Close();
                cone.desconectar();
                return false;
            }
            
        }
        public bool logueo(string mail, string pass)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;
            string passE = null;
            cmd.Connection = cone.conectar();
            cmd.CommandText = "validar_empleado_existe";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mail", mail);
            leer = cmd.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    passE = leer["pass"].ToString();
                }
                byte[] decryted = Convert.FromBase64String(passE);
                string result = System.Text.Encoding.Unicode.GetString(decryted);
                if (pass == result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                cone.desconectar();
                return false;
            }
        }
        public DataTable obtenerEmpleados()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_empleado", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.Fill(dt);
            return dt;
        }
        public DataTable obtenerEmpleadosById(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_empleado_id", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlda.Fill(dt);
            return dt;
        }
        public DataTable obtener_info_By_Id_emp(int id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter("obtener_demografico_emp_id_emp", cone.conectar());
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlda.SelectCommand.Parameters.AddWithValue("@id", id);
            sqlda.Fill(dt);
            return dt;
        }
        public void ingresarEmpleado(string nombre, string apellido, string cedula, string mail, string telefono, string pass)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "ingresar_empleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void ingresar_empleado_info(string ubicacion, string sexo, string estado_civil, int id_empleado, string canton, string provincia)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "insertar_demografico_emp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
            cmd.Parameters.AddWithValue("@id_empleado", id_empleado);
            cmd.Parameters.AddWithValue("@canton", canton);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void modificar_empleado_info(string ubicacion, string sexo, string estado_civil, string canton, string provincia, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "modificar_demografico_emp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ubicacion", ubicacion);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@estado_civil", estado_civil);
            cmd.Parameters.AddWithValue("@canton", canton);
            cmd.Parameters.AddWithValue("@provincia", provincia);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void modificarEmpleado(string nombre, string apellido, string cedula, string mail, string telefono,int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "modificar_empleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@cedula", cedula);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@telefono", telefono);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminar_empleado(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_empleado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
        public void eliminar_empleado_info(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.conectar();
            cmd.CommandText = "eliminar_datos_emp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cone.desconectar();
        }
    }
}
