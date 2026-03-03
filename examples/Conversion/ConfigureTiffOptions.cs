using System;

class Program
{
    static void Main()
    {
        // Load the presentation from a file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create TIFF export options
        Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();

        // Configure notes layouting options
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomTruncated; // place notes at the bottom (truncated)

        // Assign the notes layouting options to the TIFF options
        tiffOptions.SlidesLayoutOptions = notesOptions;

        // Save the presentation as a TIFF file using the configured options
        presentation.Save("output.tiff", Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);
    }
}