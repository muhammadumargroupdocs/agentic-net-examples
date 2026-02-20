using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides;

namespace WrapTextExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output directory
            string outDir = "Output";
            if (!Directory.Exists(outDir))
                Directory.CreateDirectory(outDir);

            // Create a new presentation
            Presentation presentation = new Presentation();

            // Access the first slide
            ISlide slide = presentation.Slides[0];

            // Add a rectangle auto shape with a text frame
            IAutoShape autoShape = slide.Shapes.AddAutoShape(
                ShapeType.Rectangle,
                50,   // X position
                50,   // Y position
                400,  // Width
                200   // Height
            );

            // Add long text to demonstrate wrapping
            autoShape.AddTextFrame("This is a long piece of text that should automatically wrap within the text frame boundaries to illustrate the wrap text feature in Aspose.Slides.");

            // Get the text frame and enable text wrapping
            ITextFrame textFrame = autoShape.TextFrame;
            textFrame.TextFrameFormat.WrapText = Aspose.Slides.NullableBool.True;

            // Save the presentation as PPTX
            presentation.Save(Path.Combine(outDir, "WrappedText.pptx"), SaveFormat.Pptx);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}