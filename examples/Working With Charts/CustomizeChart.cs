using System;
using System.Drawing;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a clustered column chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn,
            50, 50, 500, 400);

        // Customize chart border and enable rounded corners
        chart.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        chart.LineFormat.FillFormat.SolidFillColor.Color = Color.Black;
        chart.LineFormat.Style = Aspose.Slides.LineStyle.Single;
        chart.HasRoundedCorners = true;

        // Change fill color of the first data point in the first series
        Aspose.Slides.Charts.IChartDataPoint point = chart.ChartData.Series[0].DataPoints[0];
        point.Format.Fill.FillType = Aspose.Slides.FillType.Solid;
        point.Format.Fill.SolidFillColor.Color = Color.Blue;

        // Apply 3‑D effect to the chart
        chart.ThreeDFormat.Depth = 30;
        chart.ThreeDFormat.ContourWidth = 2;

        // Save the presentation
        presentation.Save("CustomChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}