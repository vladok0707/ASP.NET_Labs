using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Web : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            float x, y, z;
            if (
                Single.TryParse(this.TextBox1.Text, out x)
                &&
                Single.TryParse(this.TextBox2.Text, out y)
                )
            {

                z = x + y;
                this.TextBox3.Text = z.ToString();
            }
            else throw new ApplicationException("Error");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

            this.TextBox4.Text = this.CheckBoxList1.SelectedItem.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.TextBox5.Text = this.RadioButtonList1.SelectedItem.Text;
        }
        protected void ScriptManager1_AsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            this.ScriptManager1.AsyncPostBackErrorMessage = "My error";
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            float x, y, z;
            if (
                Single.TryParse(this.TextBox1.Text, out x)
                &&
                Single.TryParse(this.TextBox2.Text, out y)
                )
            {

                z = x + y;
                this.TextBox3.Text = z.ToString();
            }
            else throw new ApplicationException("Error");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(15));
            this.TextBox9.Text = this.TextBox8.Text;
        }
    }
}