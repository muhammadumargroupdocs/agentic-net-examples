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

        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Define column widths and row heights
        double[] cols = new double[] { 100, 100, 100 };
        double[] rows = new double[] { 50, 50, 50 };

        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);

        // Apply borders to all cells
        foreach (Aspose.Slides.IRow rowItem in table.Rows)
        {
            foreach (Aspose.Slides.ICell cell in rowItem)
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

        // Merge cells across rows (first two rows in first column)
        table.MergeCells(table[0, 0], table[1, 0], false);
        // Merge cells across rows (first two rows in second column)
        table.MergeCells(table[0, 1], table[1, 1], false);

        // Set text for the merged cell
        table[0, 0].TextFrame.Text = "Merged Cell";

        // Save the presentation
        presentation.Save("MergedCells.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}