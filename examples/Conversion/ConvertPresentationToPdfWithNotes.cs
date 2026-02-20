using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pdf";

        // Load the presentation
        Aspose.Slides.Presentation __presentation = new Aspose.Slides.Presentation(inputPath);

        // Initialize PDF options
        Aspose.Slides.Export.PdfOptions __pdfOptions = new Aspose.Slides.Export.PdfOptions();

        // Set notes layout options
        Aspose.Slides.Export.NotesCommentsLayoutingOptions __notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        __notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;
        __pdfOptions.SlidesLayoutOptions = __notesOptions;

        // Save presentation to PDF with notes
        __presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, __pdfOptions);

        // Clean up
        __presentation.Dispose();
    }
}