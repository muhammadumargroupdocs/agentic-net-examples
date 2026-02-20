using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PDF file path
        string pdfPath = "input.pdf";
        // Output PPTX file path
        string pptxPath = "output.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Import slides from the PDF document
        presentation.Slides.AddFromPdf(pdfPath);

        // Save the presentation in PPTX format
        presentation.Save(pptxPath, SaveFormat.Pptx);
    }
}