using System;

namespace SlidesConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file path
            string inputPath = "input.pptx";
            // Output PDF file path
            string outputPath = "output.pdf";

            // Load presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create PDF options
            Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();

            // Set notes layout options to include speaker notes at bottom
            Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
            notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;

            // Assign notes layout options to PDF options
            pdfOptions.SlidesLayoutOptions = notesOptions;

            // Save presentation as PDF preserving notes
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

            // Dispose presentation
            presentation.Dispose();
        }
    }
}