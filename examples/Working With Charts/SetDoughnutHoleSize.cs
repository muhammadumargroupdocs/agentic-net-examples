using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add a doughnut chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Doughnut,
            50,   // X position
            50,   // Y position
            400,  // Width
            400   // Height
        );

        // Set the doughnut hole size (percentage of plot area)
        chart.ChartData.Series[0].ParentSeriesGroup.DoughnutHoleSize = (byte)50;

        // Save the presentation
        pres.Save("DoughnutHole.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}