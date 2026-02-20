using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source ODP file
        string inputPath = "input.odp";

        // Directory where SVG files will be saved
        string outputDir = "output";
        Directory.CreateDirectory(outputDir);

        // Load the ODP presentation
        Presentation pres = new Presentation(inputPath);

        // Iterate through each slide and export it as SVG
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            ISlide slide = pres.Slides[i];
            string svgFilePath = Path.Combine(outputDir, $"slide_{i + 1}.svg");
            using (FileStream fs = new FileStream(svgFilePath, FileMode.Create))
            {
                slide.WriteAsSvg(fs, new SVGOptions());
            }
        }

        // Save the presentation (required before exit)
        string savedPath = "saved_output.odp";
        pres.Save(savedPath, SaveFormat.Odp);

        // Clean up resources
        pres.Dispose();
    }
}