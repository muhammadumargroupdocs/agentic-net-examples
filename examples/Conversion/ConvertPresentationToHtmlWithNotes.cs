using System;

class Program
{
    static void Main(string[] args)
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Set HTML export options
        Aspose.Slides.Export.HtmlOptions htmlOpt = new Aspose.Slides.Export.HtmlOptions();
        // Use a simple document formatter (slides one below another)
        htmlOpt.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateDocumentFormatter("document.html", false);

        // Configure notes layout options (notes at the bottom)
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;

        // Apply notes layout options to HTML export
        htmlOpt.SlidesLayoutOptions = notesOptions;

        // Save the presentation as HTML with speaker notes
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOpt);

        // Dispose the presentation object
        presentation.Dispose();
    }
}