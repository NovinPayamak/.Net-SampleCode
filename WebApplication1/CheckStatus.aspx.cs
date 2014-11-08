using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NovinPayamakServiceReference.SMSBoxImplementationServicePortTypeClient service = new NovinPayamakServiceReference.SMSBoxImplementationServicePortTypeClient();
            NovinPayamakServiceReference.Auth Auth = new NovinPayamakServiceReference.Auth();
            Auth.number = "30006320";
            Auth.pass = "test";
            string Info = "";
            int status = service.MessageStatus(Auth, 12345, out Info);
            Response.Write("Status Code: " + status.ToString() + "<br>" + "Info: " + Info);
        }
    }
}