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

        public ActionResult ReportViewerPartial() {
            ViewData["Report"] = new DevExpressMvcApplication1.Reports.XtraReport1();
            return PartialView("ReportViewerPartial");
        }

        public ActionResult ExportReportViewerPartial() {
            return DevExpress.Web.Mvc.ReportViewerExtension.ExportTo(new DevExpressMvcApplication1.Reports.XtraReport1());
        }

    }
}
