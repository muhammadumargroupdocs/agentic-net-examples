using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input PPTX file path
        string inputPath = "input.pptx";
        // Directory where SVG files will be saved
        string outputDir = "output";

        // Ensure the output directory exists
        Directory.CreateDirectory(outputDir);

        // Load the presentation
        Presentation pres = new Presentation(inputPath);

        // Iterate through each slide and save as SVG
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            ISlide slide = pres.Slides[i];
            string svgPath = Path.Combine(outputDir, $"slide_{i + 1}.svg");
            using (FileStream fs = new FileStream(svgPath, FileMode.Create))
            {
                slide.WriteAsSvg(fs);
            }
        }

        // Save the presentation before exiting (as required)
        string savedPath = "output.pptx";
        pres.Save(savedPath, SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}