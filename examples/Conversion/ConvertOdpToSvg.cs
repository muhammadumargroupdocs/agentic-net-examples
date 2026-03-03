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
        using (Presentation presentation = new Presentation(inputPath))
        {
            // Save the presentation before exiting (as required)
            presentation.Save("saved_output.odp", SaveFormat.Odp);

            // Iterate through all slides and export each as SVG
            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                ISlide slide = presentation.Slides[i];
                string svgPath = Path.Combine(outputFolder, $"slide_{i + 1}.svg");

                using (FileStream fileStream = File.Create(svgPath))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }
        }
    }
}