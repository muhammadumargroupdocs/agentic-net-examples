using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Path to the source ODP file
        string sourceFile = "input.odp";

        // Load the ODP presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourceFile))
        {
            // Iterate through each slide in the presentation
            for (int index = 0; index < presentation.Slides.Count; index++)
            {
                // Get the current slide
                Aspose.Slides.ISlide slide = presentation.Slides[index];

                // Define the output SVG file name
                string svgFile = $"slide_{index + 1}.svg";

                // Create a file stream for the SVG output
                using (FileStream svgStream = File.Create(svgFile))
                {
                    // Write the slide content as SVG to the stream
                    slide.WriteAsSvg(svgStream);
                }
            }

            // Save the presentation (optional, ensures any changes are persisted)
            presentation.Save("output.odp", Aspose.Slides.Export.SaveFormat.Odp);
        }
    }
}