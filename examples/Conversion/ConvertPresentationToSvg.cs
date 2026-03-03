using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PowerPoint file
        string sourcePath = "input.pptx";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
        {
            // Iterate through each slide in the presentation
            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                // Get the current slide
                Aspose.Slides.ISlide slide = presentation.Slides[i];

                // Define the output SVG file name
                string svgPath = $"slide_{i + 1}.svg";

                // Save the slide as an SVG file
                using (FileStream fileStream = File.Create(svgPath))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }

            // Save the presentation before exiting (no modifications made)
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}