using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a 3‑D clustered column chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn3D, 50, 50, 400, 300);

        // Apply 3‑D lighting related properties
        // Set the depth of the 3‑D shape
        chart.ThreeDFormat.Depth = 30;

        // Rotate the chart to give a better lighting view
        chart.Rotation3D.RotationX = 20; // tilt around X‑axis
        chart.Rotation3D.RotationY = 30; // tilt around Y‑axis

        // Save the presentation
        presentation.Save("3DChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}