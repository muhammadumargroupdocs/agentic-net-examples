using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: ConvertToPdf <input-ppt-or-pptx> <output-pdf>");
                return;
            }

            string inputPath = args[0];
            string outputPath = args[1];

            using (Presentation presentation = new Presentation(inputPath))
            {
                presentation.Save(outputPath, SaveFormat.Pdf);
            }

            Console.WriteLine("Conversion completed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}