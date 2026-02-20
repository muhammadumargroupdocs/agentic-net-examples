using System;

class Program
{
    static void Main()
    {
        // Input PowerPoint file and output HTML file paths
        System.String inputPath = "sample.pptx";
        System.String outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create HTML export options
        Aspose.Slides.Export.HtmlOptions htmlOpt = new Aspose.Slides.Export.HtmlOptions();
        // Use a simple document formatter (slides one below another)
        htmlOpt.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateDocumentFormatter("template.html", false);

        // Configure notes layout to include speaker notes at the bottom
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;

        // Assign the notes layout options to the HTML options
        htmlOpt.SlidesLayoutOptions = notesOptions;

        // Save the presentation as HTML with notes
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOpt);

        // Clean up
        presentation.Dispose();
    }
}