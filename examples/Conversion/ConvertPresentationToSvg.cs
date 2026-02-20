using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the source PowerPoint file
        string inputPath = "input.pptx";

        // Directory where SVG files will be saved
        string outputDirectory = "output_svg";

        // Create the output directory if it does not exist
        Directory.CreateDirectory(outputDirectory);

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Export each slide as an individual SVG file
        for (int index = 0; index < presentation.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[index];
            string svgFilePath = Path.Combine(outputDirectory, $"slide_{index + 1}.svg");

            using (FileStream fileStream = new FileStream(svgFilePath, FileMode.Create))
            {
                slide.WriteAsSvg(fileStream);
            }
        }

        // Save the (unchanged) presentation before exiting
        presentation.Save("converted.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}