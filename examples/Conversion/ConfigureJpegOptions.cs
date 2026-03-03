using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConfigureJpegOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PPTX file path
            string inputPath = "input.pptx";
            // Output PDF file path
            string outputPath = "output.pdf";

            // Load the presentation
            Presentation presentation = new Presentation(inputPath);

            // Create PDF options and set JPEG quality (0-100)
            PdfOptions pdfOptions = new PdfOptions();
            pdfOptions.JpegQuality = 80; // byte value

            // Save the presentation as PDF with the custom JPEG quality
            presentation.Save(outputPath, SaveFormat.Pdf, pdfOptions);

            // Dispose the presentation
            presentation.Dispose();
        }
    }
}