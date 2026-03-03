using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Load the source presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx"))
        {
            // Convert each slide to an individual SVG file
            for (int index = 0; index < presentation.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[index];
                string svgFileName = $"slide_{index + 1}.svg";

                using (FileStream svgStream = File.Create(svgFileName))
                {
                    slide.WriteAsSvg(svgStream);
                }
            }

            // Save the (unchanged) presentation before exiting
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}