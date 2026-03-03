using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the source PPTX file
        System.String inputPath = "input.pptx";
        // Output file name pattern for PNG images
        System.String outputPattern = "slide_{0}.png";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Iterate through all slides
        for (System.Int32 index = 0; index < presentation.Slides.Count; index++)
        {
            // Get the current slide
            Aspose.Slides.ISlide slide = presentation.Slides[index];

            // Render the slide to an image
            using (Aspose.Slides.IImage image = slide.GetImage())
            {
                // Build the output file name
                System.String outputPath = System.String.Format(outputPattern, index);
                // Save the image as PNG
                image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
            }
        }

        // Save (dispose) the presentation before exiting
        presentation.Dispose();
    }
}