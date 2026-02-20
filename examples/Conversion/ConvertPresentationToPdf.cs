using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create PDF options and include hidden slides
        Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
        pdfOptions.ShowHiddenSlides = true;

        // Save the presentation as PDF with hidden slides included
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

        // Dispose the presentation object
        presentation.Dispose();
    }
}