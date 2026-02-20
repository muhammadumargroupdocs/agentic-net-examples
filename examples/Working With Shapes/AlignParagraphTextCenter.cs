using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Add first rectangle shape with a text frame
        Aspose.Slides.IAutoShape shape1 = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 300, 100);
        shape1.AddTextFrame("First paragraph text");

        // Add second rectangle shape with a text frame
        Aspose.Slides.IAutoShape shape2 = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 200, 300, 100);
        shape2.AddTextFrame("Second paragraph text");

        // Retrieve text frames from the shapes
        Aspose.Slides.ITextFrame tf1 = shape1.TextFrame;
        Aspose.Slides.ITextFrame tf2 = shape2.TextFrame;

        // Get the first paragraph of each text frame
        Aspose.Slides.IParagraph para1 = tf1.Paragraphs[0];
        Aspose.Slides.IParagraph para2 = tf2.Paragraphs[0];

        // Align paragraph text to the center
        para1.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Center;
        para2.ParagraphFormat.Alignment = Aspose.Slides.TextAlignment.Center;

        // Save the presentation
        pres.Save("AlignedParagraphs.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}