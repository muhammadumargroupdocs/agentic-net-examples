using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertToSvg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file
            string inputPath = "input.pptx";

            // Output directory for SVG files
            string outputDir = "output";
            Directory.CreateDirectory(outputDir);

            // Load presentation
            using (Presentation pres = new Presentation(inputPath))
            {
                // Create SVG options (default settings)
                SVGOptions svgOptions = new SVGOptions();

                // Export each slide as a separate SVG file
                for (int i = 0; i < pres.Slides.Count; i++)
                {
                    string svgPath = Path.Combine(outputDir, $"slide_{i + 1}.svg");
                    using (FileStream fs = new FileStream(svgPath, FileMode.Create))
                    {
                        pres.Slides[i].WriteAsSvg(fs, svgOptions);
                    }
                }

                // Save the presentation before exiting (as required)
                string savedPresentationPath = Path.Combine(outputDir, "saved.pptx");
                pres.Save(savedPresentationPath, SaveFormat.Pptx);
            }
        }
    }
}