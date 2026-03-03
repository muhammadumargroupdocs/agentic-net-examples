using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source ODP file
        string inputPath = "input.odp";

        // Folder where SVG files will be saved
        string outputFolder = "output_svgs";
        Directory.CreateDirectory(outputFolder);

        // Load the ODP presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Iterate through all slides and save each as an SVG file
            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[i];
                string svgPath = Path.Combine(outputFolder, $"slide_{i + 1}.svg");

                using (FileStream fileStream = File.Create(svgPath))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }

            // Save the presentation before exiting (as required)
            presentation.Save("saved_output.odp", Aspose.Slides.Export.SaveFormat.Odp);
        }
    }
}