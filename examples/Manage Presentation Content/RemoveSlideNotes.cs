class Program
{
    static void Main()
    {
        // Input and output PPTX file paths
        System.String inputPath = "RemoveNotesAtSpecificSlide.pptx";
        System.String outputPath = "RemoveNotesAtSpecificSlide_out.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the notes slide manager for the first slide (index 0)
        Aspose.Slides.INotesSlideManager mgr = presentation.Slides[0].NotesSlideManager;

        // Remove the notes slide from the specified slide
        mgr.RemoveNotesSlide();

        // Save the updated presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        presentation.Dispose();
    }
}