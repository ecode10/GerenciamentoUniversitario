using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin.bepiducb.com.br.Private
{
    public partial class Sair : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpCookie Session = new HttpCookie("BEPiDUCB.Site");
            //trinda dias para expirar
            //Session.Expires = DateTime.Now.AddDays(-1);

            //Response.AppendCookie(Session);
            //Response.Redirect("/Default");

            Session.RemoveAll();
            Session.Abandon();
            
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            this.ClearApplicationCache();

            Response.Redirect("/Default");
        }

        public void ClearApplicationCache()
        {
            List<string> keys = new List<string>();

            // retrieve application Cache enumerator
            IDictionaryEnumerator enumerator = Cache.GetEnumerator();

            // copy all keys that currently exist in Cache
            while (enumerator.MoveNext())
            {
                keys.Add(enumerator.Key.ToString());
            }

            // delete every key from cache
            for (int i = 0; i < keys.Count; i++)
            {
                Cache.Remove(keys[i]);
            }
        }
    }
}