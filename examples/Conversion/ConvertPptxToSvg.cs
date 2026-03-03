using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPTX file
        string inputPath = "input.pptx";
        // Directory where SVG files will be saved
        string outputDirectory = "output_svgs";

        // Ensure the output directory exists
        Directory.CreateDirectory(outputDirectory);

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Iterate through each slide and save as SVG
            for (int index = 0; index < presentation.Slides.Count; index++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[index];
                string svgFilePath = Path.Combine(outputDirectory, $"slide_{index + 1}.svg");
                using (FileStream fileStream = File.Create(svgFilePath))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }

            // Save the presentation before exiting (optional)
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}