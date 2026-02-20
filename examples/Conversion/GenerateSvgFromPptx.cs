using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PPTX file
        string sourcePath = "input.pptx";
        // Folder where SVG files will be saved
        string outputFolder = "output_svg";

        // Ensure the output directory exists
        Directory.CreateDirectory(outputFolder);

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(sourcePath);

        // Export each slide to an individual SVG file
        for (int i = 0; i < pres.Slides.Count; i++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[i];
            string svgFilePath = Path.Combine(outputFolder, $"slide_{i + 1}.svg");
            using (FileStream fs = new FileStream(svgFilePath, FileMode.Create, FileAccess.Write))
            {
                slide.WriteAsSvg(fs);
            }
        }

        // Save the presentation (no modifications made) before exiting
        pres.Save(sourcePath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}