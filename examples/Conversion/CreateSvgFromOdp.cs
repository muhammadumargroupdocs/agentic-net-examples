using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the ODP presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.odp");

        // Convert each slide to an SVG file
        for (int index = 0; index < presentation.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[index];
            string svgFileName = $"slide_{index + 1}.svg";

            using (FileStream fileStream = File.Create(svgFileName))
            {
                slide.WriteAsSvg(fileStream);
            }
        }

        // Save the presentation before exiting
        presentation.Save("output.odp", Aspose.Slides.Export.SaveFormat.Odp);
    }
}