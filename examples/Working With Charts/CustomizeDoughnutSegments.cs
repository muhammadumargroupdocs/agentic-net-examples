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

        // Access the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a doughnut chart to the slide (position and size in points)
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Doughnut,
            50, 50, 400, 400);

        // Set the doughnut hole size (percentage of the plot area, 0-90)
        chart.ChartData.Series[0].ParentSeriesGroup.DoughnutHoleSize = 50; // 50%

        // Customize a specific segment: explode the first data point
        chart.ChartData.Series[0].DataPoints[0].Explosion = 20; // 20% explosion

        // Save the presentation to a PPTX file
        pres.Save("CustomDoughnutChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}