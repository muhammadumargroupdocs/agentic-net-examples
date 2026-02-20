using System;

class Program
{
    static void Main()
    {
        // Input PowerPoint file path
        System.String inputPath = "input.pptx";
        // Output PDF file path
        System.String outputPath = "output.pdf";

        // Load presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create PDF options
        Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();

        // Configure notes layout options to include notes at the bottom
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;
        pdfOptions.SlidesLayoutOptions = notesOptions;

        // Save presentation as PDF with notes
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

        // Release resources
        presentation.Dispose();
    }
}