using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PowerPoint file
        string inputPath = "input.pptx";

        // Directory where SVG files will be saved
        string outputDir = "output_svg";

        // Create output directory if it does not exist
        if (!Directory.Exists(outputDir))
        {
            Directory.CreateDirectory(outputDir);
        }

        // Load the presentation
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath))
        {
            // Convert each slide to an SVG file
            for (int i = 0; i < pres.Slides.Count; i++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[i];
                string svgPath = Path.Combine(outputDir, $"slide_{i + 1}.svg");
                using (FileStream fs = new FileStream(svgPath, FileMode.Create, FileAccess.Write))
                {
                    slide.WriteAsSvg(fs);
                }
            }

            // Save the presentation (required by authoring rules)
            pres.Save("saved_output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}