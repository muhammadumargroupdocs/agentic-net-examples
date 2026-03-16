using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        try
        {
            // Path to the source PPTX file
            string sourcePath = "input.pptx";

            // Directory to store rendered PNG images
            string outputFolder = "RenderedSlides";
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
            {
                // Iterate through all slides
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    // Get the current slide
                    Aspose.Slides.ISlide slide = presentation.Slides[index];

                    // Render the slide to a raster image (full scale)
                    using (Aspose.Slides.IImage slideImage = slide.GetImage(1f, 1f))
                    {
                        // Build the output file name
                        string outputPath = Path.Combine(outputFolder, $"slide_{index + 1}.png");

                        // Save the image as PNG
                        slideImage.Save(outputPath, Aspose.Slides.ImageFormat.Png);
                    }
                }

                // Save the (potentially unchanged) presentation before exiting
                presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
        catch (Exception ex)
        {
            // Output any errors that occur during processing
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}