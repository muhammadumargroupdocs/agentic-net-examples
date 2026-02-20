using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100, false);

        // Add a text frame to the shape
        shape.AddTextFrame("");

        // Get the first paragraph of the text frame
        Aspose.Slides.IParagraph paragraph = shape.TextFrame.Paragraphs[0];

        // Create a new portion and add it to the paragraph
        Aspose.Slides.IPortion portion = new Aspose.Slides.Portion("Initial text");
        paragraph.Portions.Add(portion);

        // Set the portion text to a specific value
        portion.Text = "Hello, Aspose.Slides!";

        // Save the presentation
        presentation.Save("SetPortionText.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}