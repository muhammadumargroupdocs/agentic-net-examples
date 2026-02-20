using System;
using Aspose.Slides;

namespace RenderSlideToBmp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            System.String inputPath = "input.pptx";
            // Output BMP file name pattern
            System.String outputPattern = "slide_{0}.bmp";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Get the first slide (index 0)
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Render the slide to an image
            using (Aspose.Slides.IImage image = slide.GetImage())
            {
                // Build the output file name using the slide number
                System.String outputPath = System.String.Format(outputPattern, slide.SlideNumber);
                // Save the image as BMP
                image.Save(outputPath, Aspose.Slides.ImageFormat.Bmp);
            }

            // Save the presentation before exiting (as required by authoring rules)
            pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}