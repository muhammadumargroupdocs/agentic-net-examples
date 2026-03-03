using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Paths for input PPTX and output HTML
        string inputPath = "input.pptx";
        string outputPath = "output.html";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Add a modern comment to the first slide
        Aspose.Slides.ICommentAuthor author = presentation.CommentAuthors.AddAuthor("John Doe", "JD");
        Aspose.Slides.IModernComment comment = author.Comments.AddModernComment(
            "This is a modern comment.",
            presentation.Slides[0],
            null,
            new PointF(100f, 100f),
            DateTime.Now);

        // Prepare HTML export options
        Aspose.Slides.Export.HtmlOptions htmlOpt = new Aspose.Slides.Export.HtmlOptions();
        htmlOpt.HtmlFormatter = Aspose.Slides.Export.HtmlFormatter.CreateDocumentFormatter("", false);
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;
        htmlOpt.SlidesLayoutOptions = notesOptions;

        // Save the presentation as HTML (comments are included)
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOpt);

        // Clean up
        presentation.Dispose();
    }
}