using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab35
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        private string val = "val";
        private ListItem[] sex;
        private ListItemCollection DDL;
        private RadioButtonList RB;
        private DateTime DT;

        public string Surname
        {
            get{return this.TextBox1.Text;}
            set{this.TextBox1.Text = value;}
        }
        public string Name
        {
            get { return this.TextBox2.Text; }
            set { this.TextBox2.Text = value; }
        }
        public string FatherName
        {
            get { return this.TextBox3.Text; }
            set { this.TextBox3.Text = value; }
        }
        public DateTime Date
        {
            get { return DT; }
            set { DT = value; }
        }
        public ListItemCollection Sex
        {
            get { return RB.Items; }
            set { RB.Items.Add(val); }
        }
        public ListItemCollection Faculty
        {
            get { return DDL; }
            set {  }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void UserControl_PreRender(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
          
        }

    }
}