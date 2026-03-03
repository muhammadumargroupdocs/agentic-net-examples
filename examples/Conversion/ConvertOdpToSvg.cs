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

        // Load the ODP presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Convert each slide to an SVG file
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[i];
            string svgPath = $"slide_{i + 1}.svg";

            using (FileStream fileStream = File.Create(svgPath))
            {
                slide.WriteAsSvg(fileStream);
            }
        }

        // Save the presentation before exiting (optional re-save)
        presentation.Save("output.odp", Aspose.Slides.Export.SaveFormat.Odp);

        // Release resources
        presentation.Dispose();
    }
}