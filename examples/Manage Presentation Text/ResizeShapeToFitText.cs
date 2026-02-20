using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ResizeShapeToFitText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Get the first slide
            ISlide slide = presentation.Slides[0];

            // Assume the first shape on the slide is an AutoShape
            IAutoShape shape = (IAutoShape)slide.Shapes[0];

            // Set the text of the shape
            shape.TextFrame.Text = "This is a long text that should cause the shape to resize automatically.";

            // Enable shape autofit so the shape resizes to fit the text
            shape.TextFrame.TextFrameFormat.AutofitType = TextAutofitType.Shape;

            // Save the modified presentation
            presentation.Save(outputPath, SaveFormat.Pptx);

            // Clean up
            presentation.Dispose();
        }
    }
}