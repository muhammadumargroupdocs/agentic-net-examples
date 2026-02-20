using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Determine input PPTX path
        string inputPath;
        if (args.Length > 0 && !String.IsNullOrEmpty(args[0]))
        {
            inputPath = args[0];
        }
        else
        {
            inputPath = "sample.pptx"; // fallback path
        }

        // Prepare output directory for SVG files
        string directory = Path.GetDirectoryName(inputPath);
        string filenameWithoutExt = Path.GetFileNameWithoutExtension(inputPath);
        string outputDir = Path.Combine(directory ?? String.Empty, filenameWithoutExt + "_svg");
        Directory.CreateDirectory(outputDir);

        // Load presentation
        using (Presentation presentation = new Presentation(inputPath))
        {
            int slideNumber = 0;
            foreach (ISlide slide in presentation.Slides)
            {
                slideNumber++;
                // Build SVG file name
                string svgFilePath = Path.Combine(outputDir, $"slide_{slideNumber}.svg");

                // Save each slide as SVG
                using (FileStream fileStream = new FileStream(svgFilePath, FileMode.Create, FileAccess.Write))
                {
                    SVGOptions svgOptions = new SVGOptions();
                    slide.WriteAsSvg(fileStream, svgOptions);
                }
            }

            // Save presentation before exiting (as required)
            presentation.Save(inputPath, SaveFormat.Pptx);
        }
    }
}