using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class FirstForm : System.Web.UI.Page
    {
        protected void Page_Init()
        {
            label2.Text += "Init +";
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!Page.IsPostBack) {
                label2.Text += " Load[First] + ";
            }else
            {
                label2.Text += " Load + ";
            }
        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            label2.Text += " Prerender | ";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            label2.Text += " Unload ";
        }
        protected void Page_Disposed(object sender, EventArgs e)
        {
            label2.Text += " Disposed ";
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            label2.Text += " CLICK +";
            this.TextBox1.Text = "*" + this.TextBox1.Text + "*";
            string s = Request["__VIEWSTATE"];
            label1.Text = "[" + s.Length + "]" + "["+TextBox1.Text.Length+"]";
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text += " Check + ";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Info.aspx?");
        }
    }
}