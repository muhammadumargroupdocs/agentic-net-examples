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

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a pie chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Pie, // Chart type
            50,   // X position
            50,   // Y position
            400,  // Width
            400   // Height
        );

        // Access the first series of the chart
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

        // Explode the first slice of the pie chart
        series.DataPoints[0].Explosion = 30; // Explosion distance as a percentage of the pie diameter

        // Save the presentation
        pres.Save("ExplodedPieChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}