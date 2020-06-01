using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Negocio
{
    public class NEmpleado
    {
        private Empleados emp = new Empleados();
        private Cursos cur = new Cursos();
        private Departamentos dep = new Departamentos();
        private Familiar fam = new Familiar();

        public bool validarExistencia(string mail)
        {
            return emp.existencia(mail);
        }
        public bool validarlogueo(string mail, string pass)
        {
            return emp.logueo(mail, pass);
        }
        public DataTable obtenerEmpleados()
        {
            DataTable dt = new DataTable();
            dt = emp.obtenerEmpleados();
            return dt;
        }
        public void ingresar_empleado_info(string ubicacion, string sexo, string estado_civil, string id_empleado, string canton, string provincia)
        {
            emp.ingresar_empleado_info(ubicacion, sexo, estado_civil, int.Parse(id_empleado), canton, provincia);
        }
        public void modificar_empleado_info(string ubicacion, string sexo, string estado_civil, string canton, string provincia, string id)
        {
            emp.modificar_empleado_info(ubicacion, sexo, estado_civil, canton, provincia, int.Parse(id));
        }
        public DataTable obtener_info_id_emp(string id)
        {
            DataTable dt = new DataTable();
            dt = emp.obtener_info_By_Id_emp(int.Parse(id));
            return dt;
        }
        public DataTable obtenerEmpleadosById(int id)
        {
            DataTable dt = new DataTable();
            dt = emp.obtenerEmpleadosById(id);
            return dt;
        }
        public bool ingresarEmpleado(string nombre, string apellido, string cedula, string mail, string telefono, string pass)
        {
            int[] a = new int[10];
            int[] b = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int[] c = new int[9];
            int suma = 0, mod, r;
            if (cedula.Length == 10)
            {
                for (int i = 1; i <= cedula.Length; i++)
                {
                    a[i - 1] = int.Parse(cedula.ToString().Substring(i - 1, 1));
                }
                for (int i = 0; i <= 8; i++)
                {
                    c[i] = a[i] * b[i];
                    if (c[i] > 9)
                    {
                        c[i] = c[i] - 9;
                    }
                    suma = suma + c[i];
                }
                mod = suma % 10;
                if (mod == 0)
                {
                    byte[] encryted = System.Text.Encoding.Unicode.GetBytes(pass);
                    string passE = Convert.ToBase64String(encryted);
                    emp.ingresarEmpleado(nombre, apellido, cedula, mail, telefono, passE);
                    return true;
                }
                else
                {
                    r = 10 - mod;
                }
                if (r == a[9])
                {
                    byte[] encryted = System.Text.Encoding.Unicode.GetBytes(pass);
                    string passE = Convert.ToBase64String(encryted);
                    emp.ingresarEmpleado(nombre, apellido, cedula, mail, telefono, passE);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



        }
        public bool modificarEmpleado(string nombre, string apellido, string cedula, string mail, string telefono, int id)
        {
            int[] a = new int[10];
            int[] b = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int[] c = new int[9];
            int suma = 0, mod, r;
            if (cedula.Length == 10)
            {
                for (int i = 1; i <= cedula.Length; i++)
                {
                    a[i - 1] = int.Parse(cedula.ToString().Substring(i - 1, 1));
                }
                for (int i = 0; i <= 8; i++)
                {
                    c[i] = a[i] * b[i];
                    if (c[i] > 9)
                    {
                        c[i] = c[i] - 9;
                    }
                    suma = suma + c[i];
                }
                mod = suma % 10;
                if (mod == 0)
                {
                    emp.modificarEmpleado(nombre, apellido, cedula, mail, telefono, id);
                    return true;
                }
                else
                {
                    r = 10 - mod;
                }
                if (r == a[9])
                {
                    emp.modificarEmpleado(nombre, apellido, cedula, mail, telefono, id);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public void eliminarEmpleado(int id)
        {
            cur.eliminar_cursos_emp(id);
            fam.eliminar_familiar_info_emp(id);
            fam.eliminar_familiar_emp(id);
            dep.eliminar_departamento_emp(id);
            emp.eliminar_empleado_info(id);
            emp.eliminar_empleado(id);
        }
    }
}
