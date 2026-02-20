using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ShapeParagraphExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Presentation presentation = new Presentation();

            // Access the first slide
            ISlide slide = presentation.Slides[0];

            // Add a rectangle auto shape
            IAutoShape shape = slide.Shapes.AddAutoShape(ShapeType.Rectangle, 50, 50, 400, 100);

            // Add a text frame to the shape
            shape.AddTextFrame("Initial text");

            // Get the text frame and its first paragraph
            ITextFrame textFrame = shape.TextFrame;
            IParagraph paragraph = textFrame.Paragraphs[0];

            // Set custom text for the paragraph
            paragraph.Text = "This is a custom paragraph string.";

            // Save the presentation
            presentation.Save("CustomParagraph.pptx", SaveFormat.Pptx);
        }
    }
}