using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source PowerPoint file
            string sourcePath = "PowerPoint.pptx";

            // Load the presentation
            Presentation presentation = new Presentation(sourcePath);

            // Create PDF export options
            PdfOptions pdfOptions = new PdfOptions();

            // Set password protection for the PDF
            pdfOptions.Password = "password";

            // Set access permissions (allow printing)
            pdfOptions.AccessPermissions = PdfAccessPermissions.PrintDocument | PdfAccessPermissions.HighQualityPrint;

            // Save the presentation as a password‑protected PDF
            presentation.Save("PowerPoint-protected.pdf", SaveFormat.Pdf, pdfOptions);

            // Save the presentation itself before exiting (as required by authoring rules)
            presentation.Save("PowerPoint-saved.pptx", SaveFormat.Pptx);

            // Clean up resources
            presentation.Dispose();
        }
    }
}