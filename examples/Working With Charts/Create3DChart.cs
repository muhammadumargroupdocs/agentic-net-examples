using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a 3D clustered column chart to the first slide
            Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.ClusteredColumn3D, 50, 50, 400, 300);

            // Set 3D rotation properties
            chart.Rotation3D.RotationX = 20; // Rotate around X-axis
            chart.Rotation3D.RotationY = 30; // Rotate around Y-axis
            chart.Rotation3D.DepthPercents = 200; // Depth as percentage of width
            chart.Rotation3D.HeightPercents = 100; // Height as percentage of width

            // Save the presentation
            presentation.Save("3DChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}