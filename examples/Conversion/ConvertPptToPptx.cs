using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input PPT file path (default if not provided)
        string inputPath = args.Length > 0 ? args[0] : "sample.ppt";
        // Output PPTX file path (default if not provided)
        string outputPath = args.Length > 1 ? args[1] : "sample_converted.pptx";

        // Load the existing PPT presentation
        using (Presentation presentation = new Presentation(inputPath))
        {
            // Create PPTX save options using the factory
            SaveOptionsFactory optionsFactory = new SaveOptionsFactory();
            IPptxOptions pptxOptions = optionsFactory.CreatePptxOptions();

            // Save the presentation in PPTX format
            presentation.Save(outputPath, SaveFormat.Pptx, pptxOptions);
        }

        // Indicate completion
        Console.WriteLine("Conversion completed: " + outputPath);
    }
}