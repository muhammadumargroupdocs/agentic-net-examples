using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace ConvertToTiffWithNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input PowerPoint file path
            System.String inputPath = "input.pptx";
            // Output TIFF file path
            System.String outputPath = "output.tiff";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Create TIFF options
            Aspose.Slides.Export.TiffOptions tiffOptions = new Aspose.Slides.Export.TiffOptions();

            // Configure notes layout options to include notes at the bottom
            Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
            notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;

            // Assign notes layout options to TIFF options
            tiffOptions.SlidesLayoutOptions = notesOptions;

            // Save the presentation as a multi-page TIFF with notes
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff, tiffOptions);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}