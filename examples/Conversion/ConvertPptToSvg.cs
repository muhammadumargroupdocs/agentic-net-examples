using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the source PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Convert each slide to an individual SVG file
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[i];
            string svgFileName = $"slide_{i + 1}.svg";

            using (FileStream svgStream = File.Create(svgFileName))
            {
                // Write the current slide as SVG
                slide.WriteAsSvg(svgStream);
            }
        }

        // Save the presentation (required before exiting)
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}