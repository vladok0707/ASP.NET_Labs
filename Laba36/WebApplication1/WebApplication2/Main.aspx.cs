using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Main : System.Web.UI.Page
    {
        WebServices.WebService1SoapClient client;
        protected void Page_Load(object sender, EventArgs e)
        {
            client = new WebServices.WebService1SoapClient();
        }

        protected void OnButtonClickAddition(object sender, EventArgs e)
        {
            int numberX = int.Parse(numberXTextBox.Text);
            int numberY = int.Parse(numberYTextBox.Text);
            webServiceResul.Text = client.Add(numberX, numberY).ToString();
        }
        protected void OnButtonClickSubmition(object sender, EventArgs e)
        {
            int numberX = int.Parse(numberXTextBox.Text);
            int numberY = int.Parse(numberYTextBox.Text);
            webServiceResul.Text = client.Sub(numberX, numberY).ToString();
        }
        protected void OnButtonClickMultiplication(object sender, EventArgs e)
        {
            int numberX = int.Parse(numberXTextBox.Text);
            int numberY = int.Parse(numberYTextBox.Text);
            webServiceResul.Text = client.Mult(numberX, numberY).ToString();
        }
    }
}