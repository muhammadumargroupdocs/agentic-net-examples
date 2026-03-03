using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the PowerPoint presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation("input.pptx");

        // Convert each slide to an SVG file
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[i];
            string svgPath = $"slide_{i + 1}.svg";

            using (FileStream svgStream = File.Create(svgPath))
            {
                slide.WriteAsSvg(svgStream);
            }
        }

        // Save the presentation (required before exit)
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}