using System;

namespace AsposeSlidesTiffWithNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path to the source presentation
            string sourcePath = "input.pptx";
            // Path for the output TIFF file
            string tiffPath = "output.tiff";
            // Path to save the (unchanged) presentation before exiting
            string savedPath = "saved_output.pptx";

            // Load the presentation
            using (Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(sourcePath))
            {
                // Create TIFF export options
                Aspose.Slides.Export.TiffOptions options = new Aspose.Slides.Export.TiffOptions();
                // Set compression (optional)
                options.CompressionType = Aspose.Slides.Export.TiffCompressionTypes.Default;

                // Configure notes layout to include notes on each page
                Aspose.Slides.Export.NotesCommentsLayoutingOptions notesOptions = new Aspose.Slides.Export.NotesCommentsLayoutingOptions();
                notesOptions.NotesPosition = Aspose.Slides.Export.NotesPositions.BottomFull;
                options.SlidesLayoutOptions = notesOptions;

                // Save the presentation as a multi‑page TIFF with notes
                presentation.Save(tiffPath, Aspose.Slides.Export.SaveFormat.Tiff, options);

                // Save the original presentation before exiting (required by authoring rules)
                presentation.Save(savedPath, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}