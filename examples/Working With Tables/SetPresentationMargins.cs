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
        double[] cols = new double[] { 150, 150, 150 };
        double[] rows = new double[] { 60, 60, 60 };

        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);

        // Set margins for each cell in the first column
        foreach (Aspose.Slides.IRow rowItem in table.Rows)
        {
            Aspose.Slides.ICell cell = rowItem[0];
            cell.MarginLeft = 5;
            cell.MarginRight = 5;
            cell.MarginTop = 2;
            cell.MarginBottom = 2;
        }

        // Save the presentation
        presentation.Save("TableMargins.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}