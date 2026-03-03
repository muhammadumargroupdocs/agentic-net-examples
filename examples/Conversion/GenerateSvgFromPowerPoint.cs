using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

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

        // Save the presentation (even if unchanged) before exiting
        presentation.Save("output.pptx", SaveFormat.Pptx);
        presentation.Dispose();
    }
}