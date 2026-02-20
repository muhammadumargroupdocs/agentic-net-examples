using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Define column widths and row heights
        double[] cols = new double[] { 100, 100, 100 };
        double[] rows = new double[] { 50, 50, 50 };

        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);

        // Apply a predefined table style
        table.StylePreset = Aspose.Slides.TableStylePreset.MediumStyle2Accent1;

        // Save the presentation
        presentation.Save("StyledTable.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}