using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.html";

        // Load the presentation from the input file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create HTML export options
        Aspose.Slides.Export.HtmlOptions htmlOptions = new Aspose.Slides.Export.HtmlOptions();

        // Configure notes layout to include speaker notes at the bottom
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;
        htmlOptions.SlidesLayoutOptions = notesOptions;

        // Save the presentation as HTML with notes
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Html, htmlOptions);

        // Release resources
        presentation.Dispose();
    }
}