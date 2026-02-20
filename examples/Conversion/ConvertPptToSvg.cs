using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Determine input presentation path
        string inputPath;
        if (args.Length > 0 && !string.IsNullOrEmpty(args[0]))
        {
            inputPath = args[0];
        }
        else
        {
            inputPath = "sample.pptx"; // default input file
        }

        // Define output SVG file name pattern
        string formatString = "slide_{0}.svg";

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

        // Save presentation before exit (optional)
        string outputPath = Path.Combine(Path.GetDirectoryName(inputPath) ?? "", Path.GetFileNameWithoutExtension(inputPath) + "_saved.pptx");
        pres.Save(outputPath, SaveFormat.Pptx);
        pres.Dispose();
    }
}