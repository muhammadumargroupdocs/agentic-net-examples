using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace Export3DShapesTextToPng
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Path to the source PPTX file
                string inputPath = "input.pptx";

                // Directory where PNG images will be saved
                string outputDir = "output";
                if (!Directory.Exists(outputDir))
                {
                    Directory.CreateDirectory(outputDir);
                }

                // Load the presentation
                using (Presentation pres = new Presentation(inputPath))
                {
                    // Define high‑resolution scaling factors
                    float scaleX = 2f;
                    float scaleY = 2f;

                    // Iterate through all slides
                    for (int i = 0; i < pres.Slides.Count; i++)
                    {
                        ISlide slide = pres.Slides[i];

                        // Render the slide (including 3D shapes and text) to a high‑resolution image
                        using (IImage image = slide.GetImage(scaleX, scaleY))
                        {
                            string outputPath = Path.Combine(outputDir, $"slide_{i + 1}.png");
                            image.Save(outputPath, Aspose.Slides.ImageFormat.Png);
                        }
                    }

                    // Save the presentation before exiting (optional, keeps original unchanged)
                    pres.Save("output.pptx", SaveFormat.Pptx);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}