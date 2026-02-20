using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the existing presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Access the notes slide manager for the first slide
            Aspose.Slides.INotesSlideManager notesManager = presentation.Slides[0].NotesSlideManager;

            // Add a notes slide (creates one if it does not exist)
            Aspose.Slides.INotesSlide notesSlide = notesManager.AddNotesSlide();

            // Set the text of the notes slide
            notesSlide.NotesTextFrame.Text = "Your Notes";

            // Save the modified presentation as PPTX
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

            // Clean up resources
            presentation.Dispose();
        }
    }
}