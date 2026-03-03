using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Load the PowerPoint presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx"))
        {
            // Iterate through all slides and convert each to SVG
            for (int index = 0; index < presentation.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[index];
                string svgPath = $"slide_{index + 1}.svg";

                // Create a file stream for the SVG output
                using (FileStream svgStream = File.Create(svgPath))
                {
                    // Write the slide as SVG
                    slide.WriteAsSvg(svgStream);
                }
            }

            // Save the presentation before exiting
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}