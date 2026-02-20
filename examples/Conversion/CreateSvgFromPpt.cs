using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PPTX file
        string inputPath = "input.pptx";
        // Directory where SVG files will be saved
        string outputDir = "output_svg";

        // Ensure the output directory exists
        if (!Directory.Exists(outputDir))
        {
            Directory.CreateDirectory(outputDir);
        }

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Iterate through each slide and export it as SVG
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            // Access slide by index
            Aspose.Slides.ISlide slide = pres.Slides[i];

            // Define SVG file path for the current slide
            string svgPath = Path.Combine(outputDir, $"slide_{i + 1}.svg");

            // Export the slide to SVG using default options
            using (FileStream fs = new FileStream(svgPath, FileMode.Create))
            {
                Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions();
                slide.WriteAsSvg(fs, svgOptions);
            }
        }

        // Save the presentation (optional) before exiting
        pres.Save("saved_output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}