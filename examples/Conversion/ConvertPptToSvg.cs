using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        var inputPath = "input.pptx";
        using (var presentation = new Aspose.Slides.Presentation(inputPath))
        {
            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                var slide = presentation.Slides[i];
                var svgPath = $"slide_{i + 1}.svg";
                using (var fileStream = File.Create(svgPath))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }

            // Save the presentation before exiting
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}