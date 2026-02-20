using System;
using Aspose.Slides;

class Program
{
    static void Main(string[] args)
    {
        // Input PPTX file path
        string inputPath = "input.pptx";
        // Output PDF file path
        string outputPath = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Convert and save as PDF
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);
    }
}