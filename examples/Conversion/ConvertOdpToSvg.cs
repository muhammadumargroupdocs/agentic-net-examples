using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source ODP file
        string inputPath = "input.odp";
        // Directory where SVG files will be saved
        string outputDir = "output_svg";

        // Create output directory if it does not exist
        if (!Directory.Exists(outputDir))
        {
            Directory.CreateDirectory(outputDir);
        }

        // Load the ODP presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Convert each slide to an SVG file
            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[i];
                string svgPath = Path.Combine(outputDir, $"slide_{i + 1}.svg");
                using (Stream fileStream = File.Create(svgPath))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }

            // Save the presentation before exiting (no changes made)
            presentation.Save("saved_output.odp", Aspose.Slides.Export.SaveFormat.Odp);
        }
    }
}