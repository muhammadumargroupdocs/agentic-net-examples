using System;
using System.IO;
using Aspose.Slides;

class Program
{
    static void Main(string[] args)
    {
        // Determine input file path
        string inputPath;
        if (args.Length > 0 && !String.IsNullOrEmpty(args[0]))
        {
            inputPath = args[0];
        }
        else
        {
            inputPath = "sample.odp";
        }

        // Prepare output directory for SVG files
        string outputDirectory = Path.Combine(Path.GetDirectoryName(inputPath) ?? "", Path.GetFileNameWithoutExtension(inputPath) + "_svg");
        Directory.CreateDirectory(outputDirectory);

        // Load ODP presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Iterate through each slide and save as SVG
            foreach (Aspose.Slides.ISlide slide in presentation.Slides)
            {
                string svgPath = Path.Combine(outputDirectory, $"slide_{slide.SlideNumber}.svg");
                using (FileStream stream = new FileStream(svgPath, FileMode.Create, FileAccess.Write))
                {
                    slide.WriteAsSvg(stream);
                }
            }

            // Save presentation before exit (required by authoring rules)
            presentation.Save(inputPath, Aspose.Slides.Export.SaveFormat.Odp);
        }
    }
}