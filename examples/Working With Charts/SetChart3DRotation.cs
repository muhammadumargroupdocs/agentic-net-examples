using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a 3D stacked column chart
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.StackedColumn3D, 0, 0, 500, 500);

        // Set 3D rotation properties
        chart.Rotation3D.RightAngleAxes = false;
        chart.Rotation3D.RotationX = (sbyte)20;      // X-axis rotation
        chart.Rotation3D.RotationY = (ushort)30;    // Y-axis rotation
        chart.Rotation3D.DepthPercents = (ushort)150; // Depth percentage

        // Save the presentation
        presentation.Save("3DRotationChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}