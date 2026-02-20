using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PowerPoint file
        string inputPath = "input.pptx";

        // Output folder for SVG files
        string outputFolder = "output";
        Directory.CreateDirectory(outputFolder);

        // Format string for SVG file names (slide numbers start from 1)
        string formatString = Path.Combine(outputFolder, "slide_{0}.svg");

        // Load the presentation
        Presentation pres = new Presentation(inputPath);

        // Export each slide to an SVG file using a FileStream
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            ISlide slide = pres.Slides[index];
            using (FileStream stream = new FileStream(string.Format(formatString, index + 1), FileMode.Create, FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Save the presentation before exiting (optional, here saved as PPTX)
        string savedPath = Path.Combine(outputFolder, "saved.pptx");
        pres.Save(savedPath, SaveFormat.Pptx);

        // Clean up
        pres.Dispose();
    }
}