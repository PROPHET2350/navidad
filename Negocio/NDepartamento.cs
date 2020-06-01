using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class NDepartamento
    {
        private Departamentos dep = new Departamentos();
        public DataTable obtenerDepartamentosIdEmp(string id)
        {
            DataTable dt = new DataTable();
            dt = dep.obtenerDepartamentosIdEmp(int.Parse(id));
            return dt;
        }
        public DataTable obtenerDepartamentosId(int id)
        {
            DataTable dt = new DataTable();
            dt = dep.obtenerDepartamentosId(id);
            return dt;
        }
        public void ingresarDepartamento(string nombre, string cargo, string id_empleado)
        {
            dep.ingresarDepartamento(nombre, cargo, int.Parse(id_empleado));
        }
        public void modificarDepartamento(string nombre, string cargo, string id)
        {
            dep.modificarDepartamento(nombre, cargo, int.Parse(id));
        }
        public void eliminarDepartamento(int id)
        {
            dep.eliminarDepartamento(id);
        }
    }
}
