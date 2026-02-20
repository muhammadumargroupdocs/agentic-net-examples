using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle auto shape to the first slide
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100, false);

        // Add an empty text frame to the shape
        shape.AddTextFrame("");

        // Remove the default portion
        shape.TextFrame.Paragraphs[0].Portions.Clear();

        // Create two portions with custom text
        Aspose.Slides.IPortion portion0 = new Aspose.Slides.Portion("Hello");
        Aspose.Slides.IPortion portion1 = new Aspose.Slides.Portion("World");

        // Add the portions to the paragraph
        shape.TextFrame.Paragraphs[0].Portions.Add(portion0);
        shape.TextFrame.Paragraphs[0].Portions.Add(portion1);

        // Set font heights at presentation, paragraph, and portion levels
        presentation.DefaultTextStyle.GetLevel(0).DefaultPortionFormat.FontHeight = 20f;
        shape.TextFrame.Paragraphs[0].ParagraphFormat.DefaultPortionFormat.FontHeight = 18f;
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.FontHeight = 16f;
        shape.TextFrame.Paragraphs[0].Portions[1].PortionFormat.FontHeight = 14f;

        // Save the presentation
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}