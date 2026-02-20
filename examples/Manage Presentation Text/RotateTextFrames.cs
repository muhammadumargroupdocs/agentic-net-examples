using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a clustered column chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50, 50, 500, 400);

        // Access the first series and enable value labels
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];
        series.Labels.DefaultDataLabelFormat.ShowValue = true;

        // Set custom rotation angle for the data label text
        series.Labels.DefaultDataLabelFormat.TextFormat.TextBlockFormat.RotationAngle = 45f;

        // Add a chart title and set its custom rotation angle
        chart.HasTitle = true;
        chart.ChartTitle.AddTextFrameForOverriding("Custom Rotated Title")
            .TextFrameFormat.RotationAngle = 45f;

        // Save the presentation as PPTX
        presentation.Save("CustomRotation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}