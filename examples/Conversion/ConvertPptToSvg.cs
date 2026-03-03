using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Verify that a source file path is provided
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the path to a PPT or PPTX file.");
            return;
        }

        // Path to the input presentation
        string inputPath = args[0];

        // Load the presentation using Aspose.Slides
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Iterate through all slides and export each as an SVG file
            for (int i = 0; i < presentation.Slides.Count; i++)
            {
                Aspose.Slides.ISlide slide = presentation.Slides[i];
                string outputFile = Path.Combine(
                    Path.GetDirectoryName(inputPath),
                    Path.GetFileNameWithoutExtension(inputPath) + $"_slide_{i + 1}.svg");

                using (FileStream fileStream = File.Create(outputFile))
                {
                    slide.WriteAsSvg(fileStream);
                }
            }

            // Save the presentation (no modifications) before exiting
            string savedPath = Path.Combine(
                Path.GetDirectoryName(inputPath),
                Path.GetFileNameWithoutExtension(inputPath) + "_saved.pptx");

            presentation.Save(savedPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}