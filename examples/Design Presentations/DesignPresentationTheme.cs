using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Theme;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the master theme of the presentation
        Aspose.Slides.Theme.IMasterTheme masterTheme = presentation.MasterTheme;

        // Set a custom name for the theme
        masterTheme.Name = "Custom Theme";

        // Add a line shape to the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Line, 50, 150, 300, 0);

        // Save the presentation before exiting
        presentation.Save("ThemePresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}