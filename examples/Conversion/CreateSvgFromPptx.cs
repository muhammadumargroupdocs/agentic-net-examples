using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PPTX file
        var presentationPath = "input.pptx";

        // Load the presentation
        using (var presentation = new Aspose.Slides.Presentation(presentationPath))
        {
            // Convert each slide to an SVG file
            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                var slide = presentation.Slides[i];
                var svgFilePath = $"slide_{i + 1}.svg";

                using (var fileStream = System.IO.File.Create(svgFilePath))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }

            // Save the presentation (no modifications made)
            presentation.Save(presentationPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}