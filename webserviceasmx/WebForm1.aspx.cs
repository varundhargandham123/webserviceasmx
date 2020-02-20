using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webserviceasmx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void add_Click(object sender, EventArgs e)
        {
            WebService1 webservice1 = new WebService1();
            Label1.Text = webservice1.Add(5, 10).ToString();
        }
        protected void sub_Click(object sender, EventArgs e)
        {
            WebService1 webservice1 = new WebService1();
            Label2.Text = webservice1.Sub(10, 5).ToString();
        }
    }
}