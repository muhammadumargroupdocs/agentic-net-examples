using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source presentation
        string sourcePath = "input.pptx";
        // Directory to store SVG files
        string outputDir = "output";

        // Ensure the output directory exists
        Directory.CreateDirectory(outputDir);

        // Load the presentation
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(sourcePath))
        {
            // Iterate through all slides and save each as SVG
            for (int i = 0; i < pres.Slides.Count; i++)
            {
                Aspose.Slides.ISlide slide = pres.Slides[i];
                string svgPath = Path.Combine(outputDir, $"slide_{i + 1}.svg");
                using (FileStream fs = File.Create(svgPath))
                {
                    slide.WriteAsSvg(fs);
                }
            }

            // Save the presentation before exiting
            pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}