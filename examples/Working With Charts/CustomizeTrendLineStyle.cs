using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a clustered column chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(Aspose.Slides.Charts.ChartType.ClusteredColumn, 50, 50, 500, 400);

        // Add an exponential trend line and hide its equation and R-squared value
        Aspose.Slides.Charts.ITrendline expTrendline = chart.ChartData.Series[0].TrendLines.Add(Aspose.Slides.Charts.TrendlineType.Exponential);
        expTrendline.DisplayEquation = false;
        expTrendline.DisplayRSquaredValue = false;

        // Add a linear trend line and set its line color to red
        Aspose.Slides.Charts.ITrendline linearTrendline = chart.ChartData.Series[0].TrendLines.Add(Aspose.Slides.Charts.TrendlineType.Linear);
        linearTrendline.Format.Line.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        linearTrendline.Format.Line.FillFormat.SolidFillColor.Color = Color.Red;

        // Add a logarithmic trend line with custom overriding text
        Aspose.Slides.Charts.ITrendline logTrendline = chart.ChartData.Series[0].TrendLines.Add(Aspose.Slides.Charts.TrendlineType.Logarithmic);
        logTrendline.AddTextFrameForOverriding("Log Trend");

        // Add a moving average trend line with period and name
        Aspose.Slides.Charts.ITrendline maTrendline = chart.ChartData.Series[0].TrendLines.Add(Aspose.Slides.Charts.TrendlineType.MovingAverage);
        maTrendline.Period = 3;
        maTrendline.TrendlineName = "MA3";

        // Add a polynomial trend line with order and forward extension
        Aspose.Slides.Charts.ITrendline polyTrendline = chart.ChartData.Series[0].TrendLines.Add(Aspose.Slides.Charts.TrendlineType.Polynomial);
        polyTrendline.Order = 2;
        polyTrendline.Forward = 1.0;

        // Add a power trend line with backward extension
        Aspose.Slides.Charts.ITrendline powerTrendline = chart.ChartData.Series[0].TrendLines.Add(Aspose.Slides.Charts.TrendlineType.Power);
        powerTrendline.Backward = 0.5;

        // Save the presentation
        presentation.Save("TrendLineDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}