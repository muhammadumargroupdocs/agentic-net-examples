using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input PPT file path
        string inputPath = (args.Length > 0 && !String.IsNullOrEmpty(args[0])) ? args[0] : "input.ppt";

        // Directory where SVG files will be saved
        string outputDir = Path.GetDirectoryName(inputPath);
        string fileNameWithoutExt = Path.GetFileNameWithoutExtension(inputPath);

        // Load presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Iterate through each slide and save as SVG
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                string svgPath = Path.Combine(outputDir, fileNameWithoutExt + "_slide_" + slide.SlideNumber + ".svg");
                using (FileStream fs = new FileStream(svgPath, FileMode.Create))
                {
                    slide.WriteAsSvg(fs);
                }
            }

            // Save presentation before exiting (optional, keeps original format)
            presentation.Save(inputPath, SaveFormat.Pptx);
        }
    }
}