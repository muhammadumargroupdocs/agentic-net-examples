using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

namespace ErrorBarsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Add a scatter chart with smooth lines
            Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.ScatterWithSmoothLines,
                50f,   // X position
                50f,   // Y position
                500f,  // Width
                400f   // Height
            );

            // Access the first series of the chart
            Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

            // Configure X error bars
            series.ErrorBarsXFormat.Type = Aspose.Slides.Charts.ErrorBarType.Plus;
            series.ErrorBarsXFormat.Value = 0.5f; // Fixed length

            // Configure Y error bars
            series.ErrorBarsYFormat.Type = Aspose.Slides.Charts.ErrorBarType.Both;
            series.ErrorBarsYFormat.Value = 0.3f; // Fixed length

            // Save the presentation
            pres.Save("ErrorBarsOverview.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}