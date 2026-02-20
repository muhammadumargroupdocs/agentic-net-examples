using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Access the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a rectangle auto shape to hold text
            Aspose.Slides.IAutoShape rect = slide.Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle,
                50f,   // X position
                50f,   // Y position
                400f,  // Width
                200f   // Height
            );

            // Add a text frame with three paragraphs
            Aspose.Slides.ITextFrame textFrame = rect.AddTextFrame(
                "First paragraph.\r\nSecond paragraph.\r\nThird paragraph."
            );

            // Set autofit type for the text frame
            textFrame.TextFrameFormat.AutofitType = Aspose.Slides.TextAutofitType.Shape;

            // Set hanging indent (negative indent) for each paragraph
            Aspose.Slides.IParagraph para1 = textFrame.Paragraphs[0];
            para1.ParagraphFormat.Indent = -30f; // Hanging indent

            Aspose.Slides.IParagraph para2 = textFrame.Paragraphs[1];
            para2.ParagraphFormat.Indent = -30f; // Hanging indent

            Aspose.Slides.IParagraph para3 = textFrame.Paragraphs[2];
            para3.ParagraphFormat.Indent = -30f; // Hanging indent

            // Save the presentation as PPTX
            presentation.Save("HangingIndentDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}