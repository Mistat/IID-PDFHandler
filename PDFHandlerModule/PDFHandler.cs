using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace PDFHandlerModule
{
    public class PDFHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
        public void ProcessRequest(HttpContext context)
        {
            var url = context.Request.CurrentExecutionFilePath;

            if (string.IsNullOrEmpty(url))
            {
                return;
            }

            var res = HttpContext.Current.Response;
            res.ClearContent();
            res.ClearHeaders();
            res.AddHeader("Content-Disposition", string.Format("filename={0}", url));
            res.AddHeader("Content-Type", "application/pdf");
            res.WriteFile(url);
            res.End();

        }
    }
}

