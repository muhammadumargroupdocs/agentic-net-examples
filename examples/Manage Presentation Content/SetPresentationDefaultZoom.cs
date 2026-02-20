using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Set default zoom value (percentage) for slide view and notes view
        presentation.ViewProperties.SlideViewProperties.Scale = 150;
        presentation.ViewProperties.NotesViewProperties.Scale = 150;

        // Save the presentation in PPTX format
        string outputPath = "DefaultZoom.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}