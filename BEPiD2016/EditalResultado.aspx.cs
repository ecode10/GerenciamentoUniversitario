using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEPiD2016
{
    public partial class EditalResultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"].Equals("primeira"))
            {
                var pdfPath = "https://s3.amazonaws.com/BEPiD/editalresultado/lista-1.pdf";

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
            //resultado final developer
            else if (Request.Params["id"].Equals("resultadofinaldeveloper"))
            {
                var pdfPath = "https://s3.amazonaws.com/BEPiD/editalresultado/Desenvolvedores-2017.pdf";

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
            //resultado final designer
            else if (Request.Params["id"].Equals("resultadofinaldesigner"))
            {
                var pdfPath = "https://s3.amazonaws.com/BEPiD/editalresultado/Designers-2017.pdf";

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
            //designers
            else if (Request.Params["id"].Equals("designers2etapa"))
            {
                var pdfPath = "https://s3.amazonaws.com/BEPiD/editalresultado/Entrevista_designers_2_turno.pdf";

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

            else if (Request.Params["id"].Equals("designers"))
            {
                var pdfPath = "https://s3.amazonaws.com/BEPiD/editalresultado/entrevista-designers.pdf";

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
            //segudna etapa 
            else if (Request.Params["id"].Equals("segundaetapadeveloper"))
            {
                var pdfPath = "https://s3.amazonaws.com/BEPiD/editalresultado/Segunda-etapa-developer.pdf";

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

            else if (Request.Params["id"].Equals("segunda"))
            {
                var pdfPath = "https://s3.amazonaws.com/BEPiD/editalresultado/lista-2.pdf";

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
            else if (Request.Params["id"].Equals("terceira"))
            {
                var pdfPath = "https://s3.amazonaws.com/BEPiD/editalresultado/lista-3.pdf";

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
            else if (Request.Params["id"].Equals("entrevista"))
            {
                var pdfPath = "https://s3.amazonaws.com/BEPiD/editalresultado/entrevista-2017.pdf";

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