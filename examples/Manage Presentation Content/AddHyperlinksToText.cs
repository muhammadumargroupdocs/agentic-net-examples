using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle shape to the first slide
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 50, false);

        // Add text to the shape
        shape.AddTextFrame("Click here to visit OpenAI");

        // Assign an external hyperlink to the text
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.HyperlinkClick = new Aspose.Slides.Hyperlink("https://www.openai.com");
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.HyperlinkClick.Tooltip = "OpenAI website";

        // Save the presentation in PPT format
        presentation.Save("HyperlinkDemo.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
    }
}