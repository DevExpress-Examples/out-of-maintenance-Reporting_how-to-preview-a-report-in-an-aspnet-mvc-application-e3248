using System.Web;
using System.Web.Mvc;
using ReportInMvcApplication.Reports;

namespace ReportInMvcApplication.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View(new XtraReport1());
        }
    }
}