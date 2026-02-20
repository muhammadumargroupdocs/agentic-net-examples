using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace RenderSlidesToSvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source presentation
            string inputPath = "input.pptx";

            // Format string for output SVG files (1‑based index)
            string outputFormat = "slide_{0}.svg";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Iterate through all slides and export each as SVG
            for (int index = 0; index < pres.Slides.Count; index++)
            {
                // Get the current slide
                Aspose.Slides.ISlide slide = pres.Slides[index];

                // Build the output file name
                string outputPath = string.Format(outputFormat, index + 1);

                // Write the slide as SVG to a file
                using (FileStream fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    slide.WriteAsSvg(fs);
                }
            }

            // Save the presentation (required by authoring rules)
            pres.Save("output.pptx", SaveFormat.Pptx);
        }
    }
}