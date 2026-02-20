using System;
using System.IO;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the input ODP file
        string inputPath = "input.odp";

        // Folder where SVG files will be saved
        string outputFolder = "output_svg";
        Directory.CreateDirectory(outputFolder);

        // Format string for SVG file names (slide numbers start from 1)
        string formatString = Path.Combine(outputFolder, "slide_{0}.svg");

        // Load the ODP presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Export each slide to an SVG file
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (FileStream stream = new FileStream(string.Format(formatString, index + 1), FileMode.Create, FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Save the presentation before exiting (optional, here saved as a new ODP file)
        string savedPath = "saved_output.odp";
        pres.Save(savedPath, SaveFormat.Odp);

        // Clean up resources
        pres.Dispose();
    }
}