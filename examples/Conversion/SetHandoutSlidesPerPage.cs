using System;

class Program
{
    static void Main()
    {
        // Input PPTX file path
        System.String inputPath = "input.pptx";
        // Output PDF file path (handout with specified slides per page)
        System.String outputPath = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Create PDF options and set handout layout (4 slides per page, horizontal)
        Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();
        pdfOptions.SlidesLayoutOptions = new Aspose.Slides.Export.HandoutLayoutingOptions
        {
            Handout = Aspose.Slides.Export.HandoutType.Handouts4Horizontal
        };

        // Save the presentation as a PDF handout
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

        // Release resources
        pres.Dispose();
    }
}