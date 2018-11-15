using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;


namespace BEPiD2016
{
    public partial class Edital : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"].Equals("comunicado"))
            {
                var pdfPath = "http://www.bepiducb.com.br/Editais/comunicado-bepid.pdf";

                if (pdfPath.IndexOf(".pdf") > 1)
                {
                    WebClient client = new WebClient();
                    Byte[] buffer = client.DownloadData(pdfPath);
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-length", buffer.Length.ToString());
                    Response.BinaryWrite(buffer);
                }
                else
                {
                    Response.Redirect("index.html");
                }
            }
            else if (Request.Params["id"].Equals("desenvolvedor"))
            {
                var pdfPath = "http://www.bepiducb.com.br/Editais/Normas-para-Bolsa-de-Capacitacao-Developer.pdf";

                if (pdfPath.IndexOf(".pdf") > 1)
                {
                    WebClient client = new WebClient();
                    Byte[] buffer = client.DownloadData(pdfPath);
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-length", buffer.Length.ToString());
                    Response.BinaryWrite(buffer);
                }
                else
                {
                    Response.Redirect("index.html");
                }
            }
            else if (Request.Params["id"].Equals("designer"))
            {
                var pdfPath = "http://www.bepiducb.com.br/Editais/Normas-para-Bolsa-de-Capacitacao-Designer.pdf";

                if (pdfPath.IndexOf(".pdf") > 1)
                {
                    WebClient client = new WebClient();
                    Byte[] buffer = client.DownloadData(pdfPath);
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-length", buffer.Length.ToString());
                    Response.BinaryWrite(buffer);
                }
                else
                {
                    Response.Redirect("index.html");
                }
            }

            else
            {
                Response.Redirect("index.html");
            }
        }
    }
}