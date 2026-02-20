using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add an AutoShape to the first slide
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle,
            50f,
            50f,
            300f,
            100f,
            false);

        // Add text to the shape
        shape.AddTextFrame("Click Here");

        // Set mutable hyperlink on the first portion
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.HyperlinkClick = new Aspose.Slides.Hyperlink("https://example.com");
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.HyperlinkClick.Tooltip = "Example Tooltip";
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.FontHeight = 20f;

        // Save the presentation in PPT format
        presentation.Save("MutableHyperlink.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
    }
}