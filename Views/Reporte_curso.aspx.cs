using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
namespace Views
{
    public partial class Reporte_curso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ReportViewer1.LocalReport.Refresh();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReportParameter p = new ReportParameter("nombre",DropDownList1.Text);
            ReportViewer1.LocalReport.SetParameters(p);
            ReportViewer1.LocalReport.Refresh();
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            ReportParameter p = new ReportParameter("nombre", DropDownList1.Text);
            ReportViewer1.LocalReport.SetParameters(p);
            ReportViewer1.LocalReport.Refresh();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}