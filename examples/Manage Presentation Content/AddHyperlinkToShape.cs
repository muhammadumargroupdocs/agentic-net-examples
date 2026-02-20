using System;

class Program
{
    static void Main(string[] args)
    {
        // Define output file path (PPT format)
        string outputPath = "output.ppt";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle shape to the slide
        Aspose.Slides.IAutoShape shape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 50);

        // Add text to the shape
        shape.AddTextFrame("Click here to visit Example.com");

        // Assign an external URL hyperlink to the shape
        shape.HyperlinkClick = new Aspose.Slides.Hyperlink("https://www.example.com");

        // Save the presentation in PPT format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Dispose the presentation object
        presentation.Dispose();
    }
}