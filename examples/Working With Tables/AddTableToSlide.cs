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

        // Define column widths
        double[] cols = new double[] { 100, 100, 100, 100 };

        // Define row heights
        double[] rows = new double[] { 50, 50, 50, 50 };

        // Add a table to the slide at position (50,50)
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);

        // Apply solid black borders to each cell
        foreach (Aspose.Slides.IRow row in table.Rows)
        {
            foreach (Aspose.Slides.ICell cell in row)
            {
                cell.CellFormat.BorderTop.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderTop.FillFormat.SolidFillColor.Color = Color.Black;
                cell.CellFormat.BorderTop.Width = 1;

                cell.CellFormat.BorderBottom.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderBottom.FillFormat.SolidFillColor.Color = Color.Black;
                cell.CellFormat.BorderBottom.Width = 1;

                cell.CellFormat.BorderLeft.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderLeft.FillFormat.SolidFillColor.Color = Color.Black;
                cell.CellFormat.BorderLeft.Width = 1;

                cell.CellFormat.BorderRight.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderRight.FillFormat.SolidFillColor.Color = Color.Black;
                cell.CellFormat.BorderRight.Width = 1;
            }
        }

        // Save the presentation
        presentation.Save("TableExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}