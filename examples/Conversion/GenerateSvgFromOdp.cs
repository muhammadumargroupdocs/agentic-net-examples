using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source ODP file
        string inputPath = "input.odp";
        // Folder where SVG files will be saved
        string outputFolder = "output_svg";

        // Create output directory if it does not exist
        Directory.CreateDirectory(outputFolder);

        // Load the ODP presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // SVG export options (default settings)
        Aspose.Slides.Export.SVGOptions svgOptions = new Aspose.Slides.Export.SVGOptions();

        // Export each slide as an individual SVG file
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[i];
            string svgPath = Path.Combine(outputFolder, $"slide_{i + 1}.svg");
            using (FileStream fs = new FileStream(svgPath, FileMode.Create))
            {
                slide.WriteAsSvg(fs, svgOptions);
            }
        }

        // Save the presentation (optional) before exiting
        string savedPath = "saved.pptx";
        pres.Save(savedPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}