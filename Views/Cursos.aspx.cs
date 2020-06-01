using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Views
{
    public partial class Cursos : System.Web.UI.Page
    {
        private NCursos cur = new NCursos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrarCursos();
            }
        }
        public void mostrarCursos()
        {
            dataTable.DataSource = cur.obtenerCursosIdEmp(Request.QueryString["cod"].ToString());
            dataTable.DataBind();
        }
        public void clear()
        {
            txt_cargo.Text = txt_fechaf.Text = txt_fechai.Text = txt_nombre.Text = "";
        }
        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            cur.eliminarCursos(int.Parse(hf_ContactoId.Value.ToString()));
            panelagregar.Visible = false;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
            mostrarCursos();
            clear();
        }

        protected void close_Click(object sender, EventArgs e)
        {
            clear();
            panelagregar.Visible = false;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            if (btn_agregar.Text == "Agregar")
            {
                cur.ingresarCursos(txt_nombre.Text, txt_cargo.Text, txt_fechai.Text, txt_fechaf.Text, Request.QueryString["cod"].ToString());
            }
            else
            {
                cur.modificarCursos(txt_nombre.Text, txt_cargo.Text, txt_fechai.Text, txt_fechaf.Text, hf_ContactoId.Value.ToString());
            }
            panelagregar.Visible = false;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
            mostrarCursos();
            clear();
        }

        protected void show_Click(object sender, EventArgs e)
        {
            clear();
            panelagregar.Visible = true;
            btn_agregar.Text = "Agregar";
            btn_eliminar.Visible = false;
        }

        protected void lnk_ver_Click(object sender, EventArgs e)
        {
            int contID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            DataTable dt = new DataTable();
            dt = cur.obtenerCursosId(contID);
            hf_ContactoId.Value = contID.ToString();
            txt_nombre.Text = dt.Rows[0]["nombre"].ToString();
            txt_cargo.Text = dt.Rows[0]["empresa"].ToString();
            DateTime fechaI = Convert.ToDateTime(dt.Rows[0]["fecha_inicio"].ToString());
            txt_fechai.Text = String.Format("{0:yyyy-MM-dd}", fechaI);
            DateTime fechaF = Convert.ToDateTime(dt.Rows[0]["fecha_fin"].ToString());
            txt_fechaf.Text = String.Format("{0:yyyy-MM-dd}", fechaF);
            panelagregar.Visible = true;
            btn_agregar.Text = "Actualizar";
            btn_eliminar.Visible = true;
        }
    }
}