using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PowerPoint file
        string inputPath = "input.pptx";
        // Directory to store SVG files
        string outputDir = "output_svg";

        // Create output directory if it does not exist
        Directory.CreateDirectory(outputDir);

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Iterate through each slide and save it as an SVG file
            int slideIndex = 0;
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                string svgFilePath = Path.Combine(outputDir, "slide_" + slideIndex + ".svg");
                using (FileStream svgStream = new FileStream(svgFilePath, FileMode.Create))
                {
                    Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions();
                    slide.WriteAsSvg(svgStream, svgOptions);
                }
                slideIndex++;
            }

            // Save the presentation before exiting (optional)
            string savedPresentationPath = Path.Combine(outputDir, "presentation_saved.pptx");
            presentation.Save(savedPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}