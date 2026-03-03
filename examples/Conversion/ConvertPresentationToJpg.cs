using System;
using System.IO;
using Aspose.Slides;
using System.Drawing.Imaging;

namespace PowerPointToJpg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PPTX file
            string inputPath = "input.pptx";

            // Directory where JPG images will be saved
            string outputDirectory = "output";
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Iterate through all slides
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    // Get the current slide
                    Aspose.Slides.ISlide slide = presentation.Slides[index];

                    // Render the slide to an image at full scale
                    using (Aspose.Slides.IImage image = slide.GetImage(1f, 1f))
                    {
                        // Build the output file name
                        string outputPath = Path.Combine(outputDirectory, $"Slide_{slide.SlideNumber}.jpg");

                        // Save the image as JPEG
                        image.Save(outputPath, ImageFormat.Jpeg);
                    }
                }

                // Save the presentation before exiting (as required)
                presentation.Save("saved_output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}