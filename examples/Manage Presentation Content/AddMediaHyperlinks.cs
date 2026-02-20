using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle shape
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 50);

        // Add text to the shape
        shape.AddTextFrame("Visit Example");

        // Set hyperlink on the text portion
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.HyperlinkClick = new Aspose.Slides.Hyperlink("https://www.example.com");

        // Save the presentation in PPT format
        presentation.Save("output.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
    }
}