using System;

namespace ConvertToGif
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check for input file argument
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the path to a PPT or PPTX file.");
                return;
            }

            // Input presentation path
            string inputPath = args[0];

            // Determine output GIF path (same name with .gif extension)
            string outputPath = System.IO.Path.ChangeExtension(inputPath, ".gif");

            // Load the presentation and convert to GIF using default options
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
            {
                // Save as animated GIF
                presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Gif, new Aspose.Slides.Export.GifOptions());
            }

            Console.WriteLine($"Presentation converted to GIF: {outputPath}");
        }
    }
}