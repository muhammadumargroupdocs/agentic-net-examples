using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle auto shape with a text frame
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100);
        shape.AddTextFrame("First\tSecond\tThird");

        // Get the first paragraph of the text frame
        Aspose.Slides.IParagraph paragraph = shape.TextFrame.Paragraphs[0];

        // Add a tab stop at position 100 points, left aligned
        paragraph.ParagraphFormat.Tabs.Add(new Aspose.Slides.Tab(100.0, Aspose.Slides.TabAlignment.Left));

        // Save the presentation as PPTX
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}