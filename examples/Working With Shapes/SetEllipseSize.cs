using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Ensure output directory exists
        string outputDir = "Output";
        if (!System.IO.Directory.Exists(outputDir))
            System.IO.Directory.CreateDirectory(outputDir);

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add an ellipse shape with initial size
        Aspose.Slides.IShape ellipse = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Ellipse, 100, 100, 200, 150);

        // Set the desired size of the ellipse
        ellipse.Width = 300;   // width in points
        ellipse.Height = 200;  // height in points

        // Save the presentation
        string outputPath = System.IO.Path.Combine(outputDir, "EllipseSize.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}