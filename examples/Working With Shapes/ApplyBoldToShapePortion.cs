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

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 400, 100);

        // Add text to the shape
        shape.AddTextFrame("Hello Aspose!");

        // Get the first portion of the text
        Aspose.Slides.IPortion portion = shape.TextFrame.Paragraphs[0].Portions[0];

        // Apply bold styling to the portion
        portion.PortionFormat.FontBold = Aspose.Slides.NullableBool.True;

        // Save the presentation
        presentation.Save("BoldPortion.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}