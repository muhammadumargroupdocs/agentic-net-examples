using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Load the PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Export each slide to an individual SVG file
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[i];
            string svgFileName = $"slide_{i + 1}.svg";

            using (FileStream svgStream = new FileStream(svgFileName, FileMode.Create))
            {
                // Write the slide content as SVG
                slide.WriteAsSvg(svgStream);
            }
        }

        // Save the presentation (PPTX) before exiting
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}