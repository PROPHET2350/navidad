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
    public partial class Sign_in : System.Web.UI.Page
    {
        private NEmpleado emp = new NEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string fallo = "a";
            if (int.Parse(contador.Value.ToString())<=2)
            {
                if (emp.validarExistencia(inputEmail.Text))
                {
                    if (emp.validarlogueo(inputEmail.Text, inputPassword.Text))
                    {
                        Response.Redirect("Empleados.aspx");
                    }
                    else
                    {
                        Panel1.Visible = true;
                        Label1.Text = "Usuario/contraseña incorrecta le quedan "+(3-int.Parse(contador.Value.ToString()))+" intentos";
                        fallo = "f";
                    }
                    if (fallo.Equals("f"))
                    {
                        contador.Value = (int.Parse(contador.Value.ToString()) + 1).ToString();
                    }
                }
                else
                {
                    Panel1.Visible = true;
                    Label1.Text = "No existe una cuenta con ese email";
                }
            }
            else
            {
                inputEmail.Enabled = false;
                inputPassword.Enabled = false;
                btn_login.Enabled = false;
                Panel1.Visible = true;
                Label1.Text = "Su sesion ha sido bloqueada";
            }
        }
    }
}