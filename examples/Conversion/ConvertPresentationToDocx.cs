using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PowerPoint file (PPTX)
        System.String inputPath = "input.pptx";
        // Desired output file (DOCX) - Aspose.Slides does not support DOCX directly.
        // As an alternative, you can save to a supported format such as PDF.
        System.String outputPdfPath = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Save to PDF (a supported format)
        presentation.Save(outputPdfPath, Aspose.Slides.Export.SaveFormat.Pdf);

        // Dispose the presentation object
        presentation.Dispose();
    }
}