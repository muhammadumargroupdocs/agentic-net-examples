using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define directories and file paths
        string dataDir = "Data";
        string sourcePath = Path.Combine(dataDir, "source.pptx");
        string destPath = Path.Combine(dataDir, "merged.pptx");

        // Load the source presentation
        Aspose.Slides.Presentation sourcePres = new Aspose.Slides.Presentation(sourcePath);

        // Create a new presentation to import slides into
        Aspose.Slides.Presentation targetPres = new Aspose.Slides.Presentation();

        // Import all slides from the source presentation
        foreach (Aspose.Slides.ISlide srcSlide in sourcePres.Slides)
        {
            targetPres.Slides.AddClone(srcSlide);
        }

        // Add notes to the first slide of the target presentation
        Aspose.Slides.INotesSlideManager notesMgr = targetPres.Slides[0].NotesSlideManager;
        Aspose.Slides.INotesSlide notesSlide = notesMgr.AddNotesSlide();
        notesSlide.NotesTextFrame.Text = "Imported slide notes";

        // Save the merged presentation
        targetPres.Save(destPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        sourcePres.Dispose();
        targetPres.Dispose();
    }
}