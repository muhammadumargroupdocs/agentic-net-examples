using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input presentation path
        string inputPath = "input.pptx";

        // Output folder for SVG files
        string outputFolder = "output";
        Directory.CreateDirectory(outputFolder);

        // Format string for SVG file names
        string formatString = Path.Combine(outputFolder, "slide_{0}.svg");

        // Load presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Convert each slide to SVG
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (FileStream stream = new FileStream(string.Format(formatString, index + 1), FileMode.Create, FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Save presentation before exit
        string savedPath = Path.Combine(outputFolder, "saved.pptx");
        pres.Save(savedPath, Aspose.Slides.Export.SaveFormat.Pptx);
        pres.Dispose();
    }
}