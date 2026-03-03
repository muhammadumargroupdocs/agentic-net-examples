using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace SlideConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check for required arguments: input PPT file and output ODP file
            if (args == null || args.Length < 2)
            {
                Console.WriteLine("Usage: SlideConversion <input-ppt-file> <output-odp-file>");
                return;
            }

            string inputPath = args[0];
            string outputPath = args[1];

            // Load the presentation from the specified PPT file
            using (Presentation presentation = new Presentation(inputPath))
            {
                // Save the presentation in ODP format
                presentation.Save(outputPath, SaveFormat.Odp);
            }

            Console.WriteLine("Conversion completed successfully.");
        }
    }
}