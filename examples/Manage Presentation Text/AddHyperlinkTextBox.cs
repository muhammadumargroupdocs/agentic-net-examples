using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle auto shape as a text box
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 50);

        // Add text to the shape
        shape.AddTextFrame("Click here to visit Aspose");

        // Set hyperlink on the first portion
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.HyperlinkClick = new Aspose.Slides.Hyperlink("https://www.aspose.com");

        // Save the presentation
        presentation.Save("TextBoxWithHyperlink.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}