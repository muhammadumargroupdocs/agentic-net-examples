using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Load the PowerPoint presentation from a file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Iterate through each slide in the presentation
        for (int i = 0; i < presentation.Slides.Count; i++)
        {
            // Get the current slide
            Aspose.Slides.ISlide slide = presentation.Slides[i];

            // Define the output SVG file name
            string svgPath = $"slide_{i + 1}.svg";

            // Create a file stream for the SVG output
            using (FileStream svgStream = File.Create(svgPath))
            {
                // Save the slide as an SVG file
                slide.WriteAsSvg(svgStream);
            }
        }

        // Save the (potentially modified) presentation before exiting
        presentation.Save("output.pptx", SaveFormat.Pptx);

        // Release resources used by the presentation
        presentation.Dispose();
    }
}