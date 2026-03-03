using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Load the presentation from a file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Convert each slide to an SVG file
        int slideCount = presentation.Slides.Count;
        for (int i = 0; i < slideCount; i++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[i];
            string svgFileName = $"slide_{i + 1}.svg";
            using (FileStream svgStream = File.Create(svgFileName))
            {
                slide.WriteAsSvg(svgStream);
            }
        }

        // Save the presentation before exiting
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}