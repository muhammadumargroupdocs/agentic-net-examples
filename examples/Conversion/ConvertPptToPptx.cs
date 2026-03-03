using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertPptToPptx
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.ppt";
            string outputPath = "output.pptx";

            // Create PPTX save options using the factory
            SaveOptionsFactory optionsFactory = new SaveOptionsFactory();
            IPptxOptions pptxOptions = optionsFactory.CreatePptxOptions();

            // Load the PPT presentation
            using (Presentation presentation = new Presentation(inputPath))
            {
                // Save the presentation as PPTX with the created options
                presentation.Save(outputPath, SaveFormat.Pptx, pptxOptions);
            }

            // Indicate completion
            Console.WriteLine("Conversion completed.");
        }
    }
}