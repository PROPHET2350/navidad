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
    public partial class Empleados : System.Web.UI.Page
    {
        private NEmpleado emp = new NEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dataTable.DataSource = emp.obtenerEmpleados();
                dataTable.DataBind();
            }
        }
        private void mostrarEmpleados()
        {
            dataTable.DataSource = emp.obtenerEmpleados();
            dataTable.DataBind();
        }
        protected void Grid(object o, GridViewRowEventArgs ev)
        {
            if (ev.Row.RowType == DataControlRowType.Header)
            {
                ev.Row.TableSection = TableRowSection.TableHeader;
            }
        }
        protected void lnk_ver_Click(object sender, EventArgs e)
        {
            int conId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            DataTable dt = new DataTable();
            dt = emp.obtenerEmpleadosById(conId);
            hf_ContactoId.Value = conId.ToString();
            txt_nombre.Text = dt.Rows[0]["nombre"].ToString();
            txt_apellido.Text = dt.Rows[0]["apellido"].ToString();
            txt_cedula.Text = dt.Rows[0]["cedula"].ToString();
            txt_telefono.Text = dt.Rows[0]["telefono"].ToString();
            txt_mail.Text = dt.Rows[0]["mail"].ToString();
            txt_pass.Visible = false;
            btn_agregar.Text = "Actualizar";
            btn_eliminar.Visible = true;
            panelagregar.Visible = true;
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            int conId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("familiares.aspx?cod=" + conId);
        }
        public void limpiar()
        {
            txt_apellido.Text = txt_cedula.Text = txt_mail.Text = txt_nombre.Text = txt_pass.Text = txt_telefono.Text = "";
        }
        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Text == "Agregar")
            {
                if (emp.ingresarEmpleado(txt_nombre.Text, txt_apellido.Text, txt_cedula.Text, txt_mail.Text, txt_telefono.Text, txt_pass.Text))
                {
                    panelagregar.Visible = false;
                    mostrarEmpleados();
                    limpiar();
                }
                else
                {
                    Response.Write("<script lang='JavaScript'>alert('Cedula incorrecta');</script>");
                }
            }
            else
            {
                if (emp.modificarEmpleado(txt_nombre.Text, txt_apellido.Text, txt_cedula.Text, txt_mail.Text, txt_telefono.Text, int.Parse(hf_ContactoId.Value.ToString())))
                {
                    panelagregar.Visible = false;
                    mostrarEmpleados();
                    limpiar();
                    txt_pass.Visible = true;
                }
                else
                {
                    Response.Write("<script lang='JavaScript'>alert('Cedula incorrecta');</script>");
                }
            }
        }

        protected void show_Click(object sender, EventArgs e)
        {
            btn_eliminar.Visible = false;
            btn_agregar.Text = "Agregar";
            panelagregar.Visible = true;
            txt_pass.Visible = true;
            limpiar();
        }

        protected void mostrar_Click(object sender, EventArgs e)
        {
            btn_eliminar.Visible = false;
            txt_pass.Visible = true;
            btn_agregar.Text = "Agregar";
            limpiar();
            panelagregar.Visible = false;

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {

            emp.eliminarEmpleado(int.Parse(hf_ContactoId.Value.ToString()));
            btn_eliminar.Visible = false;
            btn_agregar.Text = "Agregar";
            panelagregar.Visible = false;
            mostrarEmpleados();
            limpiar();
            txt_pass.Visible = true;
        }

        protected void btn_cursos_Click(object sender, EventArgs e)
        {
            int conId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("Departamentos.aspx?cod=" + conId);

        }

        protected void btn_dep_Click(object sender, EventArgs e)
        {
            int conId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("Cursos.aspx?cod=" + conId);
        }

        protected void btn_info_Click(object sender, EventArgs e)
        {
            int conId = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("Demograficos_empleados.aspx?cod=" + conId);
        }
    }
}