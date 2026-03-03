using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PowerPointToSvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PowerPoint file
            string inputPath = "input.pptx";

            // Directory to store the generated SVG files
            string outputDirectory = "output_svgs";
            Directory.CreateDirectory(outputDirectory);

            // Load the presentation
            using (Presentation presentation = new Presentation(inputPath))
            {
                // Iterate through all slides and save each as SVG
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    ISlide slide = presentation.Slides[index];
                    string svgFilePath = Path.Combine(outputDirectory, $"slide_{index + 1}.svg");
                    using (Stream fileStream = File.Create(svgFilePath))
                    {
                        slide.WriteAsSvg(fileStream);
                    }
                }

                // Save the presentation before exiting (optional copy)
                presentation.Save("output.pptx", SaveFormat.Pptx);
            }
        }
    }
}