using System;

class Program
{
    static void Main(string[] args)
    {
        // Verify that input and output file paths are provided
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: ConvertToPdf <input-ppt-or-pptx> <output-pdf>");
            return;
        }

        var inputPath = args[0];
        var outputPath = args[1];

        // Load the presentation (PPT or PPTX) using Aspose.Slides
        using (var presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Save the presentation as PDF
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);
        }

        Console.WriteLine("Conversion completed successfully.");
    }
}