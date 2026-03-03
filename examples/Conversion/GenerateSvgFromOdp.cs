using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source ODP file
        var sourcePath = "input.odp";

        // Load the ODP presentation
        using (var presentation = new Aspose.Slides.Presentation(sourcePath))
        {
            // Iterate through each slide and export as SVG
            for (int index = 0; index < presentation.Slides.Count; index++)
            {
                var slide = presentation.Slides[index];
                var svgPath = $"slide_{index + 1}.svg";

                using (var svgStream = File.Create(svgPath))
                {
                    // Write the slide content to the SVG file
                    slide.WriteAsSvg(svgStream);
                }
            }

            // Save the (unchanged) presentation before exiting
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}