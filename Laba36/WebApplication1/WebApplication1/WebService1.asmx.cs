using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://kvv.by/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        int x = 0;
        [WebMethod(EnableSession = true)]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod(EnableSession =true)]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(EnableSession = true)]
        public int Sub(int x, int y)
        {
            return x - y;
        }

        [WebMethod(EnableSession = true)]
        public int Mult(int x, int y)
        {
            return x * y;
        }

        [WebMethod(EnableSession = true)]
        public void SetX(int x)
        {
            this.Session["x"] = x;
        }
        [WebMethod(EnableSession = true)]
        public int GetX(int x)
        {
            int rc = 777;
            if (this.Session["x"] != null) rc = (int)this.Session["x"];
            return rc;
        }
        [WebMethod(EnableSession = true)]
        public int AddX(int x)
        {
            int rc = 777;
            if (this.Session["x"] != null) rc = (int)this.Session["x"] +x;
            return rc;
        }
    }
}
