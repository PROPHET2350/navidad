using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;
using System.Data.SqlClient;

namespace Views
{
    public partial class familiares : System.Web.UI.Page
    {
        private NFamiliar fam = new NFamiliar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrarFamiliar();
            }
        }
        public void mostrarFamiliar()
        {
            dataTable.DataSource = fam.obtenerFamiliaresIdEmp(Request.QueryString["cod"].ToString());
            dataTable.DataBind();
        }
        public void limpiar()
        {
            txt_apellido.Text = txt_mail.Text = txt_nombre.Text = txt_telefono.Text = "";
        }
        protected void test_Click(object sender, EventArgs e)
        {

        }

        protected void lnk_ver_Click(object sender, EventArgs e)
        {
            int conId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            DataTable dta = new DataTable();
            dta = fam.obtenerFamiliaresId(conId);
            hf_ContactoId.Value = conId.ToString();
            txt_nombre.Text = dta.Rows[0]["nombre"].ToString();
            txt_apellido.Text = dta.Rows[0]["apellido"].ToString();
            txt_telefono.Text = dta.Rows[0]["telefono"].ToString();
            txt_mail.Text = dta.Rows[0]["mail"].ToString();
            btn_agregar.Text = "Actualizar";
            btn_eliminar.Visible = true;
            panelagregar.Visible = true;
        }

        protected void show_Click(object sender, EventArgs e)
        {
            panelagregar.Visible = true;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            fam.eliminarFamiliar(hf_ContactoId.Value.ToString());
            mostrarFamiliar();
            panelagregar.Visible = false;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
            limpiar();
        }

        protected void close_Click(object sender, EventArgs e)
        {
            panelagregar.Visible = false;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Text == "Agregar")
            {
                fam.ingresarFamiliar(txt_nombre.Text, txt_apellido.Text, txt_mail.Text, txt_telefono.Text, Request.QueryString["cod"].ToString());
            }
            else
            {
                fam.modificarFamiliar(txt_nombre.Text, txt_apellido.Text, txt_mail.Text, txt_telefono.Text,int.Parse(hf_ContactoId.Value.ToString()));
            }
            mostrarFamiliar();
            panelagregar.Visible = false;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
            limpiar();
        }

        protected void show_Click1(object sender, EventArgs e)
        {
            panelagregar.Visible = true;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;

        }

        protected void btn_info_Click(object sender, EventArgs e)
        {
            int conId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("Demograficos_familiares.aspx?cod="+conId+"&codB="+ Request.QueryString["cod"].ToString());
        }

        protected void btn_info_Click1(object sender, EventArgs e)
        {
            int conId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("Demograficos_familiares.aspx?cod=" + conId +"&codB=" + Request.QueryString["cod"].ToString());
        }
    }
}