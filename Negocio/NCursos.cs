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
    public class NCursos
    {
        private Cursos cur = new Cursos();
        public DataTable obtenerCursosIdEmp(string id)
        {
            DataTable dt = new DataTable();
            dt = cur.obtenerCursosIdEmp(int.Parse(id));
            return dt;
        }
        public DataTable obtenerCursosId(int id)
        {
            DataTable dt = new DataTable();
            dt = cur.obtenerCursosId(id);
            return dt;
        }
        public void ingresarCursos(string nombre, string empresa, string fechai, string fechaf, string id_empleado)
        {
            cur.ingresarCursos(nombre, empresa, DateTime.Parse(fechai), DateTime.Parse(fechaf), int.Parse(id_empleado));
        }
        public void modificarCursos(string nombre, string empresa, string fechai, string fechaf, string id)
        {
            cur.modificarCursos(nombre, empresa, DateTime.Parse(fechai), DateTime.Parse(fechaf), int.Parse(id));
        }
        public void eliminarCursos(int id)
        {
            cur.eliminarCursos(id);
        }
    }
}
