using System;

namespace PresentationTextShrink
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Iterate through all slides and shapes
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                foreach (Aspose.Slides.IShape shape in slide.Shapes)
                {
                    // Process only AutoShape objects that contain a TextFrame
                    if (shape is Aspose.Slides.IAutoShape)
                    {
                        Aspose.Slides.IAutoShape autoShape = (Aspose.Slides.IAutoShape)shape;
                        if (autoShape.TextFrame != null)
                        {
                            // Enable normal autofit to shrink text on overflow
                            autoShape.TextFrame.TextFrameFormat.AutofitType = Aspose.Slides.TextAutofitType.Normal;
                        }
                    }
                }
            }

            // Save the modified presentation as PPTX
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}