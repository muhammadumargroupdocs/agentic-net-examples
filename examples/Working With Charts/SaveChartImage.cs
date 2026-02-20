using System;

namespace ChartImageExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paths for the chart image and the presentation file
            string chartImagePath = "chart.png";
            string presentationPath = "output.pptx";

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a clustered column chart to the first slide
            Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.ClusteredColumn,
                50f, 50f, 500f, 400f);

            // Get the chart as an image
            Aspose.Slides.IImage image = chart.GetImage();

            // Save the chart image as PNG
            image.Save(chartImagePath, Aspose.Slides.ImageFormat.Png);

            // Save the presentation
            presentation.Save(presentationPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}