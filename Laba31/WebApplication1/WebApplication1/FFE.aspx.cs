using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FFE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            this.MultiView1.ActiveViewIndex = (this.MultiView1.ActiveViewIndex + 1) % 3;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = TextBox2.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label3.Text = TextBox3.Text;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (AdRotator1.KeywordFilter == "") AdRotator1.KeywordFilter = "b1";
            else if (AdRotator1.KeywordFilter == "b1") AdRotator1.KeywordFilter = "b2";
            else AdRotator1.KeywordFilter="";
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {

        }

        protected void Wizard1_ActiveStepChanged(object sender, EventArgs e)
        {
            if (Wizard1.ActiveStepIndex.Equals(4))
            {
                this.INFO.Text = F.Text + " " + I.Text + " " + R.Text + " " + Y.Text + " " + M.Text;
            }
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {

        }

        protected void TreeView1_TreeNodeCheckChanged(object sender, TreeNodeEventArgs e)
        {
            TreeNode tn = this.TreeView1.SelectedNode;
            this.Response.Write(tn.Value + (tn.Checked ? " установлен " : "сброшен"));
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            Menu mnu = (Menu)sender;
            Response.Write(mnu.SelectedItem.Text);
        }
    }
}