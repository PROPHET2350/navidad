using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Negocio;

namespace Views
{
    public partial class Demograficos_familiares : System.Web.UI.Page
    {
        private NFamiliar fam = new NFamiliar();
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrar_info();
        }

        public void mostrar_info()
        {
            DataTable dt = new DataTable();
            dt = fam.obtener_info(Request.QueryString["cod"].ToString());
            if (dt.Rows.Count>0)
            {
                hf_ContactoId.Value = dt.Rows[0]["id_datos_fam"].ToString();
                txt_canton.Text = dt.Rows[0]["canton"].ToString();
                txt_estado.Text = dt.Rows[0]["estado_civil"].ToString();
                txt_provincia.Text = dt.Rows[0]["provincia"].ToString();
                txt_sexo.Text = dt.Rows[0]["sexo"].ToString();
                btn_agregar.Text = "Actualizar";
            }
        }
        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("familiares.aspx?cod=" +Request.QueryString["codB"].ToString());
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Text == "Agregar")
            {
                fam.ingresar_familiar_info(txt_sexo.Text,txt_estado.Text,Request.QueryString["cod"].ToString(),txt_provincia.Text,txt_canton.Text);
            }
            else
            {
                fam.modificar_familiar_info(txt_sexo.Text, txt_estado.Text, txt_provincia.Text, txt_canton.Text, hf_ContactoId.Value.ToString());
            }
            mostrar_info();

        }
    }
}