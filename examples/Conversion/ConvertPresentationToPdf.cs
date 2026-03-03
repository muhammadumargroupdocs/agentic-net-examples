using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source PPT or PPTX file
        string inputPath = "input.pptx";
        // Path for the generated PDF file
        string outputPath = "output.pdf";

        // Load the presentation
        using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath))
        {
            // Configure advanced PDF export options
            Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
            pdfOptions.JpegQuality = 90;
            pdfOptions.SaveMetafilesAsPng = true;
            pdfOptions.TextCompression = Aspose.Slides.Export.PdfTextCompression.Flate;
            pdfOptions.Compliance = Aspose.Slides.Export.PdfCompliance.Pdf15;
            pdfOptions.ShowHiddenSlides = true;
            pdfOptions.Password = "secure";
            pdfOptions.AccessPermissions = Aspose.Slides.Export.PdfAccessPermissions.PrintDocument |
                                          Aspose.Slides.Export.PdfAccessPermissions.HighQualityPrint;

            // Save the presentation as PDF using the specified options
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);
        }
    }
}