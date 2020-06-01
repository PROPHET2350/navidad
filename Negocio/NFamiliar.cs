using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class NFamiliar
    {
        private Familiar fam = new Familiar();
        public DataTable obtenerFamiliaresIdEmp(string id)
        {
            DataTable dt = new DataTable();
            dt = fam.obtenerFamiliaresIdEmp(int.Parse(id));
            return dt;
        }
        public DataTable obtenerFamiliaresId(int id)
        {
            DataTable dt = new DataTable();
            dt = fam.obtenerFId(id);
            return dt;
        }
        public DataTable obtener_info(string id)
        {
            DataTable dt = new DataTable();
            dt = fam.obtener_info(int.Parse(id));
            return dt;
        }
        public void ingresarFamiliar(string nombre, string apellido, string mail, string telefono, string id_empleado)
        {
            fam.ingresarFamiliar(nombre, apellido, mail, telefono, int.Parse(id_empleado));
        }
        public void ingresar_familiar_info(string sexo, string estado_civil, string id_familiar, string provincia, string canton)
        {
            fam.ingresar_familiar_info(sexo, estado_civil, int.Parse(id_familiar), provincia, canton);
        }
        public void modificar_familiar_info(string sexo, string estado_civil, string provincia, string canton, string id)
        {
            fam.modificar_familiar_info(sexo, estado_civil, provincia, canton, int.Parse(id));
        }
        public void modificarFamiliar(string nombre, string apellido, string mail, string telefono, int id)
        {
            fam.modificarFamiliar(nombre, apellido, mail, telefono, id);
        }
        public void eliminarFamiliar(string id)
        {
            fam.eliminar_familiar_info(int.Parse(id));
            fam.eliminarFamiliar(int.Parse(id));
        }
    }
}
