using System.Web.Mvc;
// ...

namespace DevExpressMvcApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";

            // Add the report to a view data.
            ViewData["Report"] = new DevExpressMvcApplication1.Reports.XtraReport1();

            return View();
        }

        public ActionResult DocumentViewerPartial() {
            ViewData["Report"] = new DevExpressMvcApplication1.Reports.XtraReport1();
            return PartialView("DocumentViewerPartial");
        }

        public ActionResult ExportDocumentViewer() {
            return DevExpress.Web.Mvc.DocumentViewerExtension.ExportTo(new DevExpressMvcApplication1.Reports.XtraReport1());
        }

    }
}
