using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string dataDir = "Data/";
        string inputFile = dataDir + "InputPresentation.pptx";
        string outputFile = dataDir + "OutputPresentation.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile);

        // Add notes to the first slide
        Aspose.Slides.INotesSlideManager notesManager = presentation.Slides[0].NotesSlideManager;
        Aspose.Slides.INotesSlide notesSlide = notesManager.AddNotesSlide();
        notesSlide.NotesTextFrame.Text = "These are speaker notes for the first slide.";

        // Remove notes from the second slide if it exists
        if (presentation.Slides.Count > 1)
        {
            Aspose.Slides.INotesSlideManager notesManager2 = presentation.Slides[1].NotesSlideManager;
            notesManager2.RemoveNotesSlide();
        }

        // Save the modified presentation in PPT format
        presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Ppt);

        // Clean up resources
        presentation.Dispose();
    }
}