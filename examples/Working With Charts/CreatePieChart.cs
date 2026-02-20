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

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a pie chart to the slide (position and size are in points)
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(Aspose.Slides.Charts.ChartType.Pie, 50, 50, 400, 400);

        // Access the first series of the chart
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

        // Explode the second slice (index 1) by 20%
        series.DataPoints[1].Explosion = 20;

        // Save the presentation to a PPTX file
        presentation.Save("PieChartCustomSlice.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}