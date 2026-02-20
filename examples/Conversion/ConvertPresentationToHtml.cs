using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create HTML export options
        Aspose.Slides.Export.HtmlOptions htmlOpt = new Aspose.Slides.Export.HtmlOptions();

        // Set a simple document formatter (slides one below another)
        htmlOpt.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateDocumentFormatter("Document", true);

        // Configure notes layout options (optional)
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;
        htmlOpt.SlidesLayoutOptions = notesOptions;

        // Save the presentation as HTML
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOpt);

        // Release resources
        presentation.Dispose();
    }
}