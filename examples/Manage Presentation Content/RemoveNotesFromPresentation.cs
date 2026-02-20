using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the folder containing the presentation
        string dataDir = "C:\\Data\\";
        // Input presentation file (PPTX)
        string inputFile = "input.pptx";
        // Output presentation file after removing notes
        string outputFile = "output_without_notes.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(dataDir + inputFile);

        // Remove notes from each slide
        for (int index = 0; index < presentation.Slides.Count; index++)
        {
            Aspose.Slides.INotesSlideManager notesManager = presentation.Slides[index].NotesSlideManager;
            notesManager.RemoveNotesSlide();
        }

        // Save the modified presentation
        presentation.Save(dataDir + outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
        // Dispose the presentation object
        presentation.Dispose();
    }
}