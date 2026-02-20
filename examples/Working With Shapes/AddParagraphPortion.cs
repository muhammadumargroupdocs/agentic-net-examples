using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 400, 100, false);

        // Add an empty text frame to the shape
        shape.AddTextFrame("");

        // Get the first paragraph in the text frame
        Aspose.Slides.IParagraph paragraph = shape.TextFrame.Paragraphs[0];

        // Create a new portion with text
        Aspose.Slides.IPortion portion = new Aspose.Slides.Portion("Hello Aspose!");

        // Add the portion to the paragraph
        paragraph.Portions.Add(portion);

        // Apply character formatting to the portion
        portion.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;
        portion.PortionFormat.FontItalic = Aspose.Slides.NullableBool.True;
        portion.PortionFormat.FontHeight = 24;

        // Save the presentation
        string outPath = "Output.pptx";
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Dispose the presentation
        presentation.Dispose();
    }
}