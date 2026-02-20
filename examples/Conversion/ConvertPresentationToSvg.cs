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
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Export each slide as an SVG file
        foreach (Aspose.Slides.ISlide slide in presentation.Slides)
        {
            string svgFilePath = Path.Combine(outputDir, "slide_" + slide.SlideNumber + ".svg");
            using (FileStream fileStream = new FileStream(svgFilePath, FileMode.Create))
            {
                Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions();
                slide.WriteAsSvg(fileStream, svgOptions);
            }
        }

        // Save the presentation before exiting (optional)
        string savedPresentationPath = "saved_output.pptx";
        presentation.Save(savedPresentationPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}