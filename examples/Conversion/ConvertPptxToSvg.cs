using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main(string[] args)
    {
        // Determine input PPTX file path
        string inputPath;
        if (args.Length > 0 && !string.IsNullOrEmpty(args[0]))
        {
            inputPath = args[0];
        }
        else
        {
            inputPath = "presentation.pptx";
        }

        // Define output SVG file name pattern
        string formatString = "slide_{0}.svg";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Export each slide to an individual SVG file
        for (int index = 0; index < pres.Slides.Count; index++)
        {
            Aspose.Slides.ISlide slide = pres.Slides[index];
            using (FileStream stream = new FileStream(string.Format(formatString, index + 1), FileMode.Create, FileAccess.Write))
            {
                slide.WriteAsSvg(stream);
            }
        }

        // Clean up resources
        pres.Dispose();
    }
}