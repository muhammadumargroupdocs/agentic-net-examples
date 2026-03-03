using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input PowerPoint file (PPT or PPTX)
        string inputPath = "input.pptx";
        // Output TIFF file with notes
        string outputPath = "output.tiff";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Configure TIFF options to include notes
        Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();
        Aspose.Slides.Export.NotesCommentsLayoutingOptions notesLayout = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
        notesLayout.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;
        tiffOptions.SlidesLayoutOptions = notesLayout;

        // Save as multi-page TIFF with notes
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);

        // Clean up
        presentation.Dispose();
    }
}