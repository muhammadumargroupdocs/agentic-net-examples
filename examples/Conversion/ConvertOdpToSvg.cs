using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Input ODP file path
        string inputPath = "input.odp";

        // Output directory for SVG files
        string outputDir = "output_svg";

        // Create output directory if it does not exist
        Directory.CreateDirectory(outputDir);

        // Load the ODP presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Iterate through each slide and save it as an SVG file
        foreach (Aspose.Slides.ISlide slide in presentation.Slides)
        {
            string svgFileName = String.Format(Path.Combine(outputDir, "slide_{0}.svg"), slide.SlideNumber);
            using (FileStream fileStream = new FileStream(svgFileName, FileMode.Create))
            {
                // Write the slide content as SVG using default options
                slide.WriteAsSvg(fileStream);
            }
        }

        // Save the presentation (no modifications) before exiting
        presentation.Save(inputPath, Aspose.Slides.Export.SaveFormat.Odp);

        // Clean up resources
        presentation.Dispose();
    }
}