using System;
using System.IO;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Input PPTX file path (can be passed as a command‑line argument)
            string inputPath = "input.pptx";
            if (args.Length > 0)
            {
                inputPath = args[0];
            }

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Scaling factors to increase rasterization resolution
                float scaleX = 2f;
                float scaleY = 2f;

                // Iterate through all slides and render each to a PNG image
                for (int i = 0; i < presentation.Slides.Count; i++)
                {
                    Aspose.Slides.ISlide slide = presentation.Slides[i];
                    Aspose.Slides.IImage image = slide.GetImage(scaleX, scaleY);
                    string outputFile = $"slide_{i + 1}.png";

                    // Save the rasterized image as PNG
                    image.Save(outputFile, Aspose.Slides.ImageFormat.Png);
                    image.Dispose();
                }

                // Save the (unchanged) presentation before exiting
                presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}