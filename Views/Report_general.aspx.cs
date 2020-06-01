using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Views
{
    public partial class Report_general : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ReportViewer1.LocalReport.Refresh();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ReportParameter p = new ReportParameter("cedula", TextBox1.Text);
            ReportViewer1.LocalReport.SetParameters(p);
            ReportViewer1.LocalReport.Refresh();
        }
    }
}