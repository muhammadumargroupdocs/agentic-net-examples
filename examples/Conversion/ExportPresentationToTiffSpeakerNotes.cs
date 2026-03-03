using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the source presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Create TIFF export options
        Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();

        // Configure notes layout to include speaker notes
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;

        // Assign the notes layout options to the TIFF options
        tiffOptions.SlidesLayoutOptions = notesOptions;

        // Save the presentation as a multi‑page TIFF with notes
        presentation.Save("output.tiff", Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);

        // Clean up resources
        presentation.Dispose();
    }
}