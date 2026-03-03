using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source ODP file
        string sourcePath = "sample.odp";

        // Directory to store the generated SVG files
        string outputFolder = "SvgOutput";

        // Ensure the output directory exists
        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
        }

        // Load the ODP presentation
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(sourcePath))
        {
            // Iterate through each slide and save it as an SVG file
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[index];
                string svgFilePath = Path.Combine(outputFolder, $"slide_{index + 1}.svg");
                using (Stream svgStream = File.Create(svgFilePath))
                {
                    slide.WriteAsSvg(svgStream);
                }
            }

            // Save the presentation (required before exiting)
            pres.Save("converted.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}