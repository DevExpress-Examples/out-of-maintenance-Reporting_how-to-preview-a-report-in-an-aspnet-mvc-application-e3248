Imports System.Web
Imports System.Web.Mvc
Imports ReportInMvcApplication.Reports

Namespace ReportInMvcApplication.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View(New XtraReport1())
        End Function
    End Class
End Namespace