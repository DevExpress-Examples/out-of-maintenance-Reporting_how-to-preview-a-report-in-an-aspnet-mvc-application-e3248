﻿Imports Microsoft.VisualBasic
Imports System.Web.Mvc
' ...

Namespace DevExpressMvcApplication1.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!"

			' Add the report to a view data.
			ViewData("Report") = New DevExpressMvcApplication1.Reports.XtraReport1()

			Return View()
		End Function

		Public Function DocumentViewerPartial() As ActionResult
			ViewData("Report") = New DevExpressMvcApplication1.Reports.XtraReport1()
			Return PartialView("DocumentViewerPartial")
		End Function

		Public Function ExportDocumentViewer() As ActionResult
			Return DevExpress.Web.Mvc.DocumentViewerExtension.ExportTo(New DevExpressMvcApplication1.Reports.XtraReport1())
		End Function

	End Class
End Namespace
