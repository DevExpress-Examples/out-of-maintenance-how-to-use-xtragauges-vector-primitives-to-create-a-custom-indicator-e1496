<%@ Page Language="C#" AutoEventWireup="true" Codebehind="Default.aspx.cs" Inherits="CustomIndicator._Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxGauges.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges.Linear" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges.Circular" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges.State" TagPrefix="dxg" %>
<%@ Register Assembly="DevExpress.Web.ASPxGauges.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGauges.Gauges.Digital" TagPrefix="dxg" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dxg:ASPxGaugeControl ID="ASPxGaugeControl1" runat="server" BackColor="White" Height="260px"
                Value="0" Width="260px">
                <Gauges>
                    <dxg:StateIndicatorGauge Name="Gauge0" Bounds="0, 0, 260, 260">
                        <Indicators>
                            <dxg:StateIndicatorComponent Name="RoadwayMarkers" StateIndex="0" Center="124, 124">
                                <States>
                                    <dxg:IndicatorStateWeb Name="NoWay" />
                                </States>
                            </dxg:StateIndicatorComponent>
                        </Indicators>
                    </dxg:StateIndicatorGauge>
                </Gauges>
            </dxg:ASPxGaugeControl>
        </div>
    </form>
</body>
</html>
