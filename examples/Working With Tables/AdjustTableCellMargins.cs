using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        // Define column widths and row heights
        double[] cols = new double[] { 150, 150, 150, 150 };
        double[] rows = new double[] { 100, 100, 100, 100 };
        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);
        // Adjust margins for each cell in the table
        foreach (Aspose.Slides.IRow row in table.Rows)
        {
            foreach (Aspose.Slides.ICell cell in row)
            {
                cell.MarginTop = 5;
                cell.MarginBottom = 5;
                cell.MarginLeft = 5;
                cell.MarginRight = 5;
            }
        }
        // Save the presentation
        presentation.Save("AdjustedMargins.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}