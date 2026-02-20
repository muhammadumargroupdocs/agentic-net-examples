using System;

class Program
{
    static void Main(string[] args)
    {
        // Input PowerPoint file path
        System.String inputFile = "input.pptx";
        // Output PDF file path
        System.String outputFile = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile);

        // Set PDF export options with password protection
        Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
        pdfOptions.Password = "myPassword";

        // Save the presentation as a password‑protected PDF
        presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

        // Clean up resources
        presentation.Dispose();
    }
}