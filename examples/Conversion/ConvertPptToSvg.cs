using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PPTtoSVG
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PowerPoint file
            string sourcePath = "input.pptx";

            // Load the presentation
            using (Presentation presentation = new Presentation(sourcePath))
            {
                // Iterate through all slides
                for (int index = 0; index < presentation.Slides.Count; index++)
                {
                    // Get the current slide
                    ISlide slide = presentation.Slides[index];

                    // Define the SVG output file name
                    string svgPath = $"slide_{index + 1}.svg";

                    // Create a file stream for the SVG file
                    using (FileStream svgStream = File.Create(svgPath))
                    {
                        // Write the slide as SVG
                        slide.WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation before exiting (optional, but required by rules)
                presentation.Save("output.pptx", SaveFormat.Pptx);
            }
        }
    }
}