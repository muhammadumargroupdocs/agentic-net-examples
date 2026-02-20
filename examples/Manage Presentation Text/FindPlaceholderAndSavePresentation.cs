using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Util;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputFile = "input.pptx";
        string outputFile = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile);

        // Iterate through all slides
        for (int slideIndex = 0; slideIndex < presentation.Slides.Count; slideIndex++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[slideIndex];

            // Find placeholders of type CenteredTitle on the current slide
            foreach (Aspose.Slides.IShape placeholder in Aspose.Slides.Util.SlideUtil.FindShapesByPlaceholderType(slide, Aspose.Slides.PlaceholderType.CenteredTitle))
            {
                // If the placeholder is an AutoShape, modify its text
                if (placeholder is Aspose.Slides.IAutoShape)
                {
                    ((Aspose.Slides.IAutoShape)placeholder).TextFrame.Text = "Updated Title";
                }
            }
        }

        // Save the modified presentation as PPTX
        presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}