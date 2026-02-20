using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input presentation file (can be .ppt or .pptx)
            string inputPath = "example.pptx";
            // Output PDF file
            string outputPath = "example.pdf";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Configure advanced PDF options
            Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
            pdfOptions.Compliance = Aspose.Slides.Export.PdfCompliance.PdfA1b; // Set PDF/A compliance
            pdfOptions.EmbedFullFonts = true;                                   // Embed full fonts
            pdfOptions.ShowHiddenSlides = true;                                 // Include hidden slides
            pdfOptions.BestImagesCompressionRatio = true;                      // Optimize image compression
            pdfOptions.DrawSlidesFrame = false;                                 // No frame around slides

            // Save the presentation as PDF with the specified options
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

            // Dispose the presentation object
            pres.Dispose();
        }
    }
}