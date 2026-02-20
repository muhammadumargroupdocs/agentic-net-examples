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

        // Add a line chart with markers to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.LineWithMarkers,
            0,    // X position
            0,    // Y position
            400,  // Width
            400   // Height
        );

        // Set marker size for the first series
        chart.ChartData.Series[0].Marker.Size = 10;

        // Set marker style for the first series
        chart.ChartData.Series[0].Marker.Symbol = Aspose.Slides.Charts.MarkerStyleType.Circle;

        // Save the presentation
        pres.Save("MarkerChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}