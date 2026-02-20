using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ExportSlideToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output directory
            string outputDir = Path.Combine(Environment.CurrentDirectory, "Output");
            if (!Directory.Exists(outputDir))
                Directory.CreateDirectory(outputDir);

            // Path to the source PPTX file
            string sourcePath = Path.Combine(Environment.CurrentDirectory, "sample.pptx");

            // Path for the resulting PDF file
            string outputPath = Path.Combine(outputDir, "slide.pdf");

            // Load the presentation
            Presentation presentation = new Presentation(sourcePath);

            // Create PDF export options (optional, can be customized)
            PdfOptions pdfOptions = new PdfOptions();

            // Save the presentation (or specific slide) as PDF
            presentation.Save(outputPath, SaveFormat.Pdf, pdfOptions);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}