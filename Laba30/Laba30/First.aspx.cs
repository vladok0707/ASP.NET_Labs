using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Laba30
{
    public partial class First : System.Web.UI.Page
    {
        HtmlTable t = new HtmlTable();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                t.EnableViewState = true;
            }
                t.Border = 1;
                t.CellPadding = 3;
                t.CellSpacing = 3;
                t.Align = "center";
                t.BorderColor = "red";
                HtmlTableRow r;
                HtmlTableCell c;
                r = new HtmlTableRow();
                c = new HtmlTableCell(); c.InnerHtml = "Html Control"; r.Cells.Add(c);
                c = new HtmlTableCell(); c.InnerHtml = "onserverclick"; r.Cells.Add(c);
                c = new HtmlTableCell(); c.InnerHtml = "onserverchange"; r.Cells.Add(c);
                t.Rows.Add(r);
           /* HtmlTableRow r;
            HtmlTableCell c;
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = "reset"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "no"; r.Cells.Add(c);
            c = new HtmlTableCell(); c.InnerHtml = "no"; r.Cells.Add(c);
            t.Rows.Add(r);*/
            this.Controls.Add(t);
        }

        protected void Res(object sender, System.EventArgs args)
        {
            HtmlTableRow r;
            HtmlTableCell c;
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = ((Control)sender).GetType().ToString(); r.Cells.Add(c);
            if ((new HtmlInputReset()).GetType().Equals(sender.GetType()))
                {
                c = new HtmlTableCell();  c.InnerHtml = "Yes"; r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "NO"; r.Cells.Add(c);
                }
            
            t.Rows.Add(r);
            
        }
        protected void But(object sender, System.EventArgs args)
        {
            HtmlTableRow r;
            HtmlTableCell c;
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = ((Control)sender).GetType().ToString(); r.Cells.Add(c);
            if ((new HtmlInputButton()).GetType().Equals(sender.GetType()))
            {
                c = new HtmlTableCell();  c.InnerHtml = "Yes"; r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "NO"; r.Cells.Add(c);
            }
            
            t.Rows.Add(r);
        }
        protected void Sub(object sender, System.EventArgs args)
        {
            HtmlTableRow r;
            HtmlTableCell c;
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = ((Control)sender).GetType().ToString(); r.Cells.Add(c);
            if ((new HtmlInputSubmit()).GetType().Equals(sender.GetType()))
            {
                c = new HtmlTableCell();  c.InnerHtml = "Yes"; r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "NO"; r.Cells.Add(c);
            }
            t.Rows.Add(r);
        }

        protected void Common_onserverchange(object sender, System.EventArgs e)
        {
            HtmlTableRow r= new HtmlTableRow();
            HtmlTableCell c;
            
            if ((new HtmlInputText()).GetType().Equals(sender.GetType())){
                c = new HtmlTableCell();  c.InnerHtml = ((Control)sender).GetType().ToString(); r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "No"; r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "YES"; r.Cells.Add(c);
            }
            else if ((new HtmlInputPassword()).GetType().Equals(sender.GetType()))
            {
                c = new HtmlTableCell();  c.InnerHtml = ((Control)sender).GetType().ToString(); r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "No"; r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "YES"; r.Cells.Add(c);
            }
            else if ((new HtmlInputRadioButton()).GetType().Equals(sender.GetType()))
            {
                c = new HtmlTableCell();  c.InnerHtml = ((Control)sender).GetType().ToString(); r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "No"; r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "YES"; r.Cells.Add(c);
            }
            else if ((new HtmlSelect()).GetType().Equals(sender.GetType()))
            {
                c = new HtmlTableCell();  c.InnerHtml = ((Control)sender).GetType().ToString(); r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "No"; r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "YES"; r.Cells.Add(c);
            }
            else if ((new HtmlTextArea()).GetType().Equals(sender.GetType()))
            {
                c = new HtmlTableCell();  c.InnerHtml = ((Control)sender).GetType().ToString(); r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "No"; r.Cells.Add(c);
                c = new HtmlTableCell();  c.InnerHtml = "YES"; r.Cells.Add(c);
            }
            t.Rows.Add(r);
        }
        protected void File(object sender, System.EventArgs args)
        {
            HtmlTableRow r;
            HtmlTableCell c;
            r = new HtmlTableRow();
            c = new HtmlTableCell(); c.InnerHtml = ((Control)sender).GetType().ToString(); r.Cells.Add(c);
            if ((new HtmlInputFile()).GetType().Equals(sender.GetType()))
            {
                c = new HtmlTableCell(); c.InnerHtml = "Yes"; r.Cells.Add(c);
                c = new HtmlTableCell(); c.InnerHtml = "NO"; r.Cells.Add(c);
            }
            t.Rows.Add(r);
        }

    }
}