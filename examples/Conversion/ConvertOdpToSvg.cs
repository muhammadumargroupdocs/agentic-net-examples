using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the ODP presentation
        Presentation presentation = new Presentation("input.odp");

        // Convert each slide to an SVG file
        for (int index = 0; index < presentation.Slides.Count; index++)
        {
            ISlide slide = presentation.Slides[index];
            string svgFileName = $"slide_{index + 1}.svg";

            using (FileStream fileStream = File.Create(svgFileName))
            {
                slide.WriteAsSvg(fileStream);
            }
        }

        // Save the presentation (no modifications) before exiting
        presentation.Save("output.odp", SaveFormat.Odp);
    }
}