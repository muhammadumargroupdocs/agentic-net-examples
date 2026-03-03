using System;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Load the PowerPoint presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create PDF export options
        Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
        pdfOptions.JpegQuality = 90; // Set JPEG quality
        pdfOptions.SaveMetafilesAsPng = true; // Convert metafiles to PNG
        pdfOptions.TextCompression = Aspose.Slides.Export.PdfTextCompression.Flate; // Compress text
        pdfOptions.Compliance = Aspose.Slides.Export.PdfCompliance.Pdf15; // Set PDF compliance level

        // Save the presentation as PDF with the custom options
        presentation.Save("output.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

        // Release resources
        presentation.Dispose();
    }
}