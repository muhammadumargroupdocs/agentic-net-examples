using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Specify default regular font for the presentation
        Aspose.Slides.LoadOptions loadOptions = new Aspose.Slides.LoadOptions();
        loadOptions.DefaultRegularFont = "Arial";

        // Create a new presentation with the specified load options
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(loadOptions);

        // Add a rectangle shape with a text frame to demonstrate the default font
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100, false);
        shape.AddTextFrame("Sample text using the default font.");

        // Save the presentation
        presentation.Save("DefaultFontPresentation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}