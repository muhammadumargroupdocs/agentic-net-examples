using System;

namespace Example
{
    class Program
    {
        static void Main()
        {
            // Input PPTX file path
            string inputPath = "input.pptx";
            // Output PDF file path
            string outputPath = "output.pdf";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create PDF export options
            Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();

            // Configure notes layout to include notes in the PDF
            Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
            notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;

            // Assign the notes layout options to the PDF options
            pdfOptions.SlidesLayoutOptions = notesOptions;

            // Save the presentation as PDF with notes
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

            // Release resources
            presentation.Dispose();
        }
    }
}