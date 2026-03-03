using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace PresentationConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input PPTX file path
            string inputFilePath = "example.pptx";

            // Define output ODP file path
            string outputFilePath = "example.odp";

            // Load the PPTX presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFilePath))
            {
                // Save the presentation in ODP format
                presentation.Save(outputFilePath, Aspose.Slides.Export.SaveFormat.Odp);
            }

            // Indicate completion
            Console.WriteLine("Conversion completed successfully.");
        }
    }
}