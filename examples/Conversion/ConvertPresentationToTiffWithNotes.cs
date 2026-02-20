using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Input presentation file (PPT or PPTX)
        string inputPath = "input.pptx";
        // Output TIFF file with notes
        string outputPath = "output.tiff";

        // Load the presentation
        Presentation presentation = new Presentation(inputPath);

        // Set up TIFF export options
        TiffOptions tiffOptions = new TiffOptions();

        // Configure notes layout options to include notes at the bottom
        NotesCommentsLayoutingOptions notesOptions = new NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = NotesPositions.BottomFull;

        // Apply notes layout options to TIFF options
        tiffOptions.SlidesLayoutOptions = notesOptions;

        // Save the presentation as a multi-page TIFF with notes
        presentation.Save(outputPath, SaveFormat.Tiff, tiffOptions);

        // Clean up
        presentation.Dispose();
    }
}