using System;

class Program
{
    static void Main()
    {
        // Input PowerPoint file and output HTML file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create HTML export options
        Aspose.Slides.Export.HtmlOptions htmlOpt = new Aspose.Slides.Export.HtmlOptions();

        // Use a simple document formatter (no CSS, no slide titles)
        htmlOpt.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateDocumentFormatter("", false);

        // Configure notes layout options (optional)
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;

        // Assign notes layout options to HTML options
        htmlOpt.SlidesLayoutOptions = notesOptions;

        // Save the presentation as HTML
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOpt);

        // Release resources
        presentation.Dispose();
    }
}