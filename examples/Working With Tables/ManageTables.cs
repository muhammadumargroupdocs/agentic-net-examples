using System;
using System.Drawing;
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
        double[] cols = new double[] { 100, 150, 200, 250 };
        double[] rows = new double[] { 50, 60, 70, 80 };

        // Add a table to the slide at position (50, 50)
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);

        // Set border style for each cell
        foreach (Aspose.Slides.IRow row in table.Rows)
        {
            foreach (Aspose.Slides.ICell cell in row)
            {
                // Top border
                cell.CellFormat.BorderTop.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderTop.FillFormat.SolidFillColor.Color = Color.Black;
                cell.CellFormat.BorderTop.Width = 1.0;

                // Bottom border
                cell.CellFormat.BorderBottom.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderBottom.FillFormat.SolidFillColor.Color = Color.Black;
                cell.CellFormat.BorderBottom.Width = 1.0;

                // Left border
                cell.CellFormat.BorderLeft.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderLeft.FillFormat.SolidFillColor.Color = Color.Black;
                cell.CellFormat.BorderLeft.Width = 1.0;

                // Right border
                cell.CellFormat.BorderRight.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderRight.FillFormat.SolidFillColor.Color = Color.Black;
                cell.CellFormat.BorderRight.Width = 1.0;
            }
        }

        // Save the presentation
        string outputPath = "ManagedTable.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}