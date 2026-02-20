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
        double[] cols = new double[] { 100, 100, 100, 100 };
        double[] rows = new double[] { 50, 50, 50, 50 };
        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);
        // Set background color of the first cell
        Aspose.Slides.ICell cell = table[0, 0];
        cell.CellFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        cell.CellFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Yellow;
        // Save the presentation
        presentation.Save("SetCellBackgroundColor.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}