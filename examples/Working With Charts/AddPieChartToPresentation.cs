using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Access the first slide (index 0)
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a pie chart to the slide at position (50,50) with size 400x400
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(Aspose.Slides.Charts.ChartType.Pie, 50, 50, 400, 400);

        // Get the first series of the chart
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

        // Explode the first slice of the pie chart (set explosion distance to 20%)
        series.DataPoints[0].Explosion = 20;

        // Save the presentation to a PPTX file
        pres.Save("CustomSlicePieChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}