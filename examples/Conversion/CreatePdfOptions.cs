using System;

class Program
{
    static void Main()
    {
        // Load the PPTX presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");
        
        // Instantiate PdfOptions for conversion
        Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
        // Example: set JPEG quality (optional)
        pdfOptions.JpegQuality = 90;
        
        // Save the presentation as PDF using the options
        presentation.Save("output.pdf", Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
        
        // Dispose the presentation object
        presentation.Dispose();
    }
}