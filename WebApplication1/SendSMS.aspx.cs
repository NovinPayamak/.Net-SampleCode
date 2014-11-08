using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NovinPayamakServiceReference.SMSBoxImplementationServicePortTypeClient service = new NovinPayamakServiceReference.SMSBoxImplementationServicePortTypeClient();
            NovinPayamakServiceReference.Auth Auth = new NovinPayamakServiceReference.Auth();
            Auth.number = "30006320";
            Auth.pass = "test";
            NovinPayamakServiceReference.ArrayOfString Recipients = new NovinPayamakServiceReference.ArrayOfString();
            Recipients.Add("09121111111");
            Recipients.Add("09122222222");
            NovinPayamakServiceReference.ArrayOfString Messages = new NovinPayamakServiceReference.ArrayOfString();
            Messages.Add("تست ارسال");
            int MessageId = 0;
            int MessageCount = 0;
            int status = service.Send(Auth, Recipients, Messages, false, out MessageId, out MessageCount);
            Response.Write("Status Code: " + status.ToString() + "<br>" + "Batch Id: " + MessageId.ToString());
        }
    }
}