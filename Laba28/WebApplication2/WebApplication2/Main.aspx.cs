using System;
using System.IO;
using System.Net;

namespace WebApplication2
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GetButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:81/q.kvv" + "?ParmA=" + txt1.Text + "&ParmB=" + txt2.Text);
                rq.Method = "GET";
                HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
                StreamReader rdr = new StreamReader(rs.GetResponseStream());
                Response.Write(rdr.ReadToEnd());
            }
            catch (WebException we)
            {
                Response.Write(we.Status);
                Response.Write("<br />" + we.Message);
                Response.Write("<br />" + we.TargetSite);
                Response.Write("<br />" + we.Source);

            }
        }

        protected void PostButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:81/q.kvv" + "?ParmA=" + txt1.Text + "&ParmB=" + txt2.Text);
            
            rq.Method = "POST";
            rq.MaximumResponseHeadersLength = 100;
            rq.ContentLength = 0;
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }

        protected void PutButton_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:81/q.kvv" + "?ParmA=" + txt1.Text + "&ParmB=" + txt2.Text);

            rq.Method = "PUT";
            rq.MaximumResponseHeadersLength = 100;
            rq.ContentLength = 0;
            HttpWebResponse rs = (HttpWebResponse)rq.GetResponse();
            StreamReader rdr = new StreamReader(rs.GetResponseStream());
            Response.Write(rdr.ReadToEnd());
        }
        
        
       
    }
}