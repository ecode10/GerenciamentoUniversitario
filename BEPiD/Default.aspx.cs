using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie currentUserCookie = HttpContext.Current.Request.Cookies["BEPiDUCB.Site"];
            //HttpContext.Current.Response.Cookies.Remove("BEPiDUCB.Site");
            //currentUserCookie.Expires = DateTime.Now.AddDays(-10);
            //currentUserCookie.Value = null;
            //HttpContext.Current.Response.SetCookie(currentUserCookie);

            Session.RemoveAll();
            Session.Abandon();

            //Response.Redirect("http://bepid.azurewebsites.net/pagina");
        }
    }
}