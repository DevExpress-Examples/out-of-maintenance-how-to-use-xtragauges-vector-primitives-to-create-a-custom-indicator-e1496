using System;
using System.Web;
using DevExpress.Web.ASPxGauges.Base;
using DevExpress.Web.ASPxGauges.Gauges;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.XtraGauges.Core.Base;
using System.Drawing;

namespace CustomIndicator {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            IStateIndicatorGauge sGauge = ASPxGaugeControl1.Gauges[0] as IStateIndicatorGauge;
            IndicatorStateWeb plusState = sGauge.Indicators["RoadwayMarkers"].States["NoWay"] as IndicatorStateWeb;
            CreateCustomIndicator(plusState.Shape as ComplexShape);
        }

        void CreateCustomIndicator(ComplexShape rootShape) {
            rootShape.Collection.Clear(); //remove old shapes
            EllipseShape el = new EllipseShape(new RectangleF2D(0, 0, 100, 100)); //ellipse
            BoxShape box = new BoxShape(new RectangleF2D(20, 40, 60, 20)); //horz box

            box.BeginUpdate();
            box.Appearance.ContentBrush = new SolidBrushObject(Color.White);
            box.Name = "horz";
            box.EndUpdate();

            el.BeginUpdate();
            el.Name = "el";
            el.Appearance.ContentBrush = new SolidBrushObject(Color.Red);
            el.EndUpdate();

            rootShape.AddRange(new BaseShape[] { el, box });
        }
    }
}