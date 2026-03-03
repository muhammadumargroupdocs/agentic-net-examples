using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Verify command‑line arguments
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: <input.pptx> <output folder>");
            return;
        }

        string inputPath = args[0];
        string outputFolder = args[1];

        // Ensure the output directory exists
        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
        }

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Convert each slide to an SVG file
            for (int index = 0; index < presentation.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[index];
                string svgFilePath = Path.Combine(outputFolder, $"slide_{index + 1}.svg");
                using (FileStream fileStream = File.Create(svgFilePath))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }

            // Save the presentation before exiting (no modifications made)
            presentation.Save(inputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}