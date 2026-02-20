using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.tiff";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create TIFF options
        Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();

        // Create notes layout options and set notes position
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;

        // Assign notes layout options to TIFF options
        tiffOptions.SlidesLayoutOptions = notesOptions;

        // Save the presentation as TIFF with notes
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);

        // Dispose the presentation
        presentation.Dispose();
    }
}