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

            using (FileStream svgStream = File.Create(svgFileName))
            {
                // Save the current slide as SVG
                slide.WriteAsSvg(svgStream);
            }
        }

        // Save the presentation (required before exit)
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}