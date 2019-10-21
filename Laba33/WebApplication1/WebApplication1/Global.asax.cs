using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            string rc = base.GetVaryByCustomString(context, custom);
            string p = null;
            if (custom.Equals("kvv"))
            {
                if ((p = (string)this.Request["kvvchache"]) != null) rc = p;
                
            }
            return rc;
        }
    }
}