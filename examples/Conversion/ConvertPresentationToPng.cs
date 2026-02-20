using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPresentationToPng
{
    class Program
    {
        static void Main()
        {
            // Custom dimensions for the exported PNG images
            int width = 800;
            int height = 600;

            // Path to the source PowerPoint presentation
            string inputPath = "input.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Iterate through each slide and export it as a PNG image with the specified dimensions
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                // Get the slide image with custom width and height
                using (Aspose.Slides.IImage slideImage = slide.GetImage(width, height))
                {
                    // Build the output file name for the current slide
                    string imageFileName = string.Format("slide_{0}.png", slide.SlideNumber);

                    // Save the image in PNG format
                    slideImage.Save(imageFileName, Aspose.Slides.ImageFormat.Png);
                }
            }

            // Save the presentation (required by authoring rules) before exiting
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}