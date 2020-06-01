using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace Views
{
    public partial class Demograficos_empleados : System.Web.UI.Page
    {
        private NEmpleado emp = new NEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrar_info();
            }
        }
        public void mostrar_info()
        {
            DataTable dt = new DataTable();
            dt = emp.obtener_info_id_emp(Request.QueryString["cod"].ToString());

            if (dt.Rows.Count > 0)
            {
                btn_agregar.Text = "Actualizar";
                hf_ContactoId.Value = dt.Rows[0]["id_datos_emp"].ToString();
                txt_canton.Text = dt.Rows[0]["canton"].ToString();
                txt_estado.Text = dt.Rows[0]["estado_civil"].ToString();
                txt_provincia.Text = dt.Rows[0]["provincia"].ToString();
                txt_sexo.Text = dt.Rows[0]["sexo"].ToString();
                txt_ubicacion.Text = dt.Rows[0]["ubicacion"].ToString();
                txt_canton.Text = dt.Rows[0]["canton"].ToString();
            }
        }
        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empleados.aspx");
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Text == "Agregar")
            {
                emp.ingresar_empleado_info(txt_ubicacion.Text, txt_sexo.Text, txt_estado.Text, Request.QueryString["cod"].ToString(), txt_canton.Text, txt_provincia.Text);
            }
            else
            {
                emp.modificar_empleado_info(txt_ubicacion.Text, txt_sexo.Text, txt_estado.Text, txt_canton.Text, txt_provincia.Text, Request.QueryString["cod"].ToString());
            }
            mostrar_info();
            btn_agregar.Text = "Actualizar";
        }
    }
}