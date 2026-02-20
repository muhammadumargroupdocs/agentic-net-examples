using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPresentationToSvg
{
    class Program
    {
        static void Main()
        {
            // Input PowerPoint file path
            string inputPath = "input.pptx";

            // Output directory for SVG files
            string outputDirectory = "output_svg";

            // Ensure the output directory exists
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Iterate through each slide and save it as an SVG file
                for (int slideIndex = 0; slideIndex < presentation.Slides.Count; slideIndex++)
                {
                    // Construct the SVG file name
                    string svgFilePath = Path.Combine(outputDirectory, $"slide_{slideIndex + 1}.svg");

                    // Save the slide as SVG
                    using (FileStream svgStream = new FileStream(svgFilePath, FileMode.Create, FileAccess.Write))
                    {
                        presentation.Slides[slideIndex].WriteAsSvg(svgStream);
                    }
                }

                // Save the presentation (required before exit)
                string savedPresentationPath = Path.Combine(outputDirectory, "converted.pptx");
                presentation.Save(savedPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}