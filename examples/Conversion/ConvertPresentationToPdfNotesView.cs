namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file
            System.String inputPath = "input.pptx";
            // Output PDF file
            System.String outputPath = "output.pdf";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create PDF options
            Aspose.Slides.Export.PdfOptions pdfOptions = new Aspose.Slides.Export.PdfOptions();

            // Configure notes layout options
            Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
            notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;
            pdfOptions.SlidesLayoutOptions = notesOptions;

            // Save the presentation as PDF with notes slide view
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf, pdfOptions);

            // Clean up
            presentation.Dispose();
        }
    }
}