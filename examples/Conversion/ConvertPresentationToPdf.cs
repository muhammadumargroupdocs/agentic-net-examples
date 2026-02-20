using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPT or PPTX file
        string inputPath = "example.pptx";
        // Path where the PDF will be saved
        string outputPath = "example.pdf";

        // Load the presentation from the specified file
        using (Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath))
        {
            // Convert and save the presentation as PDF
            pres.Save(outputPath, SaveFormat.Pdf);
        }
    }
}