using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Negocio;

namespace Views
{
    public partial class Departamentos : System.Web.UI.Page
    {
        private NDepartamento dep = new NDepartamento();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrarDepartamento();
            }
        }
        public void mostrarDepartamento()
        {
            dataTable.DataSource = dep.obtenerDepartamentosIdEmp(Request.QueryString["cod"].ToString());
            dataTable.DataBind();
        }
        public void clearTextBox()
        {
            txt_cargo.Text = txt_nombre.Text = "";
        }
        protected void lnk_ver_Click(object sender, EventArgs e)
        {
            int contID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            DataTable dt = new DataTable();
            dt = dep.obtenerDepartamentosId(contID);
            hf_ContactoId.Value = contID.ToString();
            txt_nombre.Text = dt.Rows[0]["nombre"].ToString();
            txt_cargo.Text = dt.Rows[0]["cargo"].ToString();
            panelagregar.Visible = true;
            btn_agregar.Text = "Actualizar";
            btn_eliminar.Visible = true;
        }

        protected void show_Click(object sender, EventArgs e)
        {
            clearTextBox();
            panelagregar.Visible = true;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            dep.eliminarDepartamento(int.Parse(hf_ContactoId.Value.ToString()));
            panelagregar.Visible = false;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
            mostrarDepartamento();
            clearTextBox();
        }

        protected void close_Click(object sender, EventArgs e)
        {
            panelagregar.Visible = false;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
            clearTextBox();
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Text == "Agregar")
            {
                dep.ingresarDepartamento(txt_nombre.Text, txt_cargo.Text, Request.QueryString["cod"].ToString());
            }
            else
            {
                dep.modificarDepartamento(txt_nombre.Text, txt_cargo.Text, hf_ContactoId.Value.ToString());
            }
            panelagregar.Visible = false;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
            clearTextBox();
            mostrarDepartamento();
        }
    }
}