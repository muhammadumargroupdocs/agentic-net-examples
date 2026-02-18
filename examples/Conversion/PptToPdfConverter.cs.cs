using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Define input and output file paths
        string currentDirectory = Directory.GetCurrentDirectory();
        string inputPptPath = Path.Combine(currentDirectory, "sample.ppt");
        string inputPptxPath = Path.Combine(currentDirectory, "sample.pptx");
        string outputPdfFromPpt = Path.Combine(currentDirectory, "sample_from_ppt.pdf");
        string outputPdfFromPptx = Path.Combine(currentDirectory, "sample_from_pptx.pdf");

        // Load PPT file and convert to PDF
        Presentation presentationPpt = new Presentation(inputPptPath);
        presentationPpt.Save(outputPdfFromPpt, SaveFormat.Pdf);
        presentationPpt.Dispose();

        // Load PPTX file and convert to PDF
        Presentation presentationPptx = new Presentation(inputPptxPath);
        presentationPptx.Save(outputPdfFromPptx, SaveFormat.Pdf);
        presentationPptx.Dispose();
    }
}