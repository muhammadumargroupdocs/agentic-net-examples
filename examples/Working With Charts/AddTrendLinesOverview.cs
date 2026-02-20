using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a clustered column chart
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 500f, 400f);

        // Exponential trendline
        Aspose.Slides.Charts.ITrendline expTrendline = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Exponential);
        expTrendline.DisplayEquation = false;
        expTrendline.DisplayRSquaredValue = false;

        // Linear trendline with red line
        Aspose.Slides.Charts.ITrendline linearTrendline = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Linear);
        linearTrendline.Format.Line.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        linearTrendline.Format.Line.FillFormat.SolidFillColor.Color = Color.Red;

        // Logarithmic trendline with custom text
        Aspose.Slides.Charts.ITrendline logTrendline = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Logarithmic);
        logTrendline.AddTextFrameForOverriding("Logarithmic Trendline");

        // Moving average trendline
        Aspose.Slides.Charts.ITrendline maTrendline = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.MovingAverage);
        maTrendline.Period = 3;
        maTrendline.TrendlineName = "MA 3";

        // Polynomial trendline
        Aspose.Slides.Charts.ITrendline polyTrendline = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Polynomial);
        polyTrendline.Order = 2;
        polyTrendline.Forward = 1.0;

        // Power trendline
        Aspose.Slides.Charts.ITrendline powerTrendline = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Power);
        powerTrendline.Backward = 0.5;

        // Save the presentation
        presentation.Save("TrendLinesDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}