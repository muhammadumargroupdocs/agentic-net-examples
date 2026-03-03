using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Verify command line arguments: input file and output folder
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: ConvertToSvg <input.pptx> <outputFolder>");
            return;
        }

        string inputPath = args[0];
        string outputFolder = args[1];

        // Create output directory if it does not exist
        if (!Directory.Exists(outputFolder))
        {
            Directory.CreateDirectory(outputFolder);
        }

        // Load the PowerPoint presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Iterate through each slide and save it as an SVG file
            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                ISlide slide = presentation.Slides[i];
                string svgFilePath = Path.Combine(outputFolder, $"slide_{i + 1}.svg");
                using (FileStream fileStream = File.Create(svgFilePath))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }

            // Save the presentation before exiting (optional, ensures any changes are persisted)
            presentation.Save(inputPath, SaveFormat.Pptx);
        }
    }
}