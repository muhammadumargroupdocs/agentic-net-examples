using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            string inputPath = "input.pptx";

            // Output directory for SVG files
            string outputDir = "output";
            Directory.CreateDirectory(outputDir);

            // Load the presentation
            Presentation pres = new Presentation(inputPath);

            // Create SVG conversion options
            SVGOptions svgOptions = new SVGOptions();

            // Convert each slide to SVG using the options
            for (int i = 0; i < pres.Slides.Count; i++)
            {
                string svgPath = Path.Combine(outputDir, $"slide_{i}.svg");
                using (FileStream fs = new FileStream(svgPath, FileMode.Create, FileAccess.Write))
                {
                    pres.Slides[i].WriteAsSvg(fs, svgOptions);
                }
            }

            // Save the presentation (required before exit)
            pres.Save("output.pptx", SaveFormat.Pptx);
            pres.Dispose();
        }
    }
}