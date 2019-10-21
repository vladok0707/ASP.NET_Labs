using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class T1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label1.Text += DateTime.Now.ToString() + "<br />";
        }

        private static string GetDate(HttpContext context)
        {
            return "<b>" + DateTime.Now.ToString() + "</b>";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}