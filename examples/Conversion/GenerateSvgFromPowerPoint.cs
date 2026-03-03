using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Load the PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Convert each slide to an SVG file
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[i];
            string svgFileName = $"slide_{i + 1}.svg";
            using (FileStream fileStream = File.Create(svgFileName))
            {
                slide.WriteAsSvg(fileStream);
            }
        }

        // Save the presentation (required before exiting)
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}