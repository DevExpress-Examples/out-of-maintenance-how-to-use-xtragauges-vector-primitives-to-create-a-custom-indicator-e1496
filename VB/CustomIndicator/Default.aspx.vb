Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports DevExpress.Web.ASPxGauges.Base
Imports DevExpress.Web.ASPxGauges.Gauges
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.XtraGauges.Core.Base
Imports System.Drawing

Namespace CustomIndicator
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim sGauge As IStateIndicatorGauge = TryCast(ASPxGaugeControl1.Gauges(0), IStateIndicatorGauge)
			Dim plusState As IndicatorStateWeb = TryCast(sGauge.Indicators("RoadwayMarkers").States("NoWay"), IndicatorStateWeb)
			CreateCustomIndicator(TryCast(plusState.Shape, ComplexShape))
		End Sub

		Private Sub CreateCustomIndicator(ByVal rootShape As ComplexShape)
			rootShape.Collection.Clear() 'remove old shapes
			Dim el As New EllipseShape(New RectangleF2D(0, 0, 100, 100)) 'ellipse
			Dim box As New BoxShape(New RectangleF2D(20, 40, 60, 20)) 'horz box

			box.BeginUpdate()
			box.Appearance.ContentBrush = New SolidBrushObject(Color.White)
			box.Name = "horz"
			box.EndUpdate()

			el.BeginUpdate()
			el.Name = "el"
			el.Appearance.ContentBrush = New SolidBrushObject(Color.Red)
			el.EndUpdate()

			rootShape.AddRange(New BaseShape() { el, box })
		End Sub
	End Class
End Namespace