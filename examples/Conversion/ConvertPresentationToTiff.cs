using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input presentation file path
        System.String inputPath = "input.pptx";
        // Output TIFF file path
        System.String outputPath = "output.tiff";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Create TIFF options and set custom pixel format
        Aspose.Slides.Export.TiffOptions options = new Aspose.Slides.Export.TiffOptions();
        options.PixelFormat = Aspose.Slides.Export.ImagePixelFormat.Format8bppIndexed;

        // Create notes layout options and set notes position
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;

        // Assign notes layout options to TIFF options
        options.SlidesLayoutOptions = notesOptions;

        // Save the presentation as a multi-page TIFF image
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, options);

        // Clean up resources
        presentation.Dispose();
    }
}