using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PowerPoint file
        string inputPath = "input.pptx";
        // Output PDF file
        string outputPath = "output.pdf";

        // Load the presentation
        Presentation pres = new Presentation(inputPath);

        // Create PDF options and set custom properties
        PdfOptions pdfOptions = new PdfOptions();
        pdfOptions.ShowHiddenSlides = true; // include hidden slides in the PDF

        // Save the presentation as PDF with the specified options
        pres.Save(outputPath, SaveFormat.Pdf, pdfOptions);

        // Dispose the presentation object
        pres.Dispose();
    }
}