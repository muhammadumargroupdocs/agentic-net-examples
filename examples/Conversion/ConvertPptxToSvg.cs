using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        string inputPath = "input.pptx";

        // Directory where SVG files will be saved
        string outputDir = "output_svg";
        Directory.CreateDirectory(outputDir);

        // Load the presentation
        Presentation presentation = new Presentation(inputPath);

        // Convert each slide to an SVG file
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            ISlide slide = presentation.Slides[i];
            string svgPath = Path.Combine(outputDir, $"slide_{i + 1}.svg");
            using (FileStream fileStream = File.Create(svgPath))
            {
                slide.WriteAsSvg(fileStream);
            }
        }

        // Save the presentation before exiting (optional)
        presentation.Save("output.pptx", SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}