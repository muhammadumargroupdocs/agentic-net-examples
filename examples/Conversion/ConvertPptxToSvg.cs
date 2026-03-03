using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlideToSvgConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PPTX file
            string inputPath = "input.pptx";

            // Directory where SVG files will be saved
            string outputDirectory = "output";
            Directory.CreateDirectory(outputDirectory);

            // Load the presentation from the specified file
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Iterate through all slides in the presentation
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    // Get the current slide
                    Aspose.Slides.ISlide slide = presentation.Slides[index];

                    // Build the SVG file name for the current slide (1‑based index)
                    string svgFilePath = Path.Combine(outputDirectory, $"slide_{index + 1}.svg");

                    // Create a file stream for the SVG output and write the slide as SVG
                    using (FileStream svgStream = File.Create(svgFilePath))
                    {
                        slide.WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation (required before exiting)
                presentation.Save("saved_output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}