using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesSvgExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PowerPoint file
            string sourcePath = "input.pptx";

            // Load the presentation
            using (Presentation pres = new Presentation(sourcePath))
            {
                // Iterate through all slides and save each as an SVG file
                for (int i = 0; i < pres.Slides.Count; i++)
                {
                    ISlide slide = pres.Slides[i];
                    string svgFileName = $"slide_{i + 1}.svg";

                    // Create a file stream for the SVG output
                    using (FileStream svgStream = File.Create(svgFileName))
                    {
                        // Write the slide content as SVG
                        slide.WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation (required before exiting)
                pres.Save("output.pptx", SaveFormat.Pptx);
            }
        }
    }
}