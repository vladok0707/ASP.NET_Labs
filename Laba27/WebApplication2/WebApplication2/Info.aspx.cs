using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Write("<br> Символическое имя машины: " + System.Environment.MachineName);
            this.Response.Write("<br> Версия ОС: " + System.Environment.OSVersion);
            this.Response.Write("<br> Объем памяти: " + System.Environment.WorkingSet);
            this.Response.Write("<br> Версия ASP.NET: " + System.Environment.Version.ToString());
            this.Response.Write("<br> IP: " + HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"]);
            this.Response.Write("<br> Запрос: " + (Request.IsLocal? "локальный" : "не локлаьный"));
            this.Response.Write("<br> Запрос: " + (Request.IsSecureConnection ? "защищенный" : "не защищенный"));


        }
    }
}