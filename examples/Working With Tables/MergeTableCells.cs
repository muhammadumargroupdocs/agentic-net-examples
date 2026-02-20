using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

namespace TableMergeExample
{
    class Program
    {
        static void Main(string[] args)
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

            // Set border style for all cells
            foreach (Aspose.Slides.IRow row in table.Rows)
            {
                foreach (Aspose.Slides.ICell cell in row)
                {
                    cell.CellFormat.BorderTop.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                    cell.CellFormat.BorderTop.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
                    cell.CellFormat.BorderTop.Width = 1.0;

                    cell.CellFormat.BorderBottom.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                    cell.CellFormat.BorderBottom.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
                    cell.CellFormat.BorderBottom.Width = 1.0;

                    cell.CellFormat.BorderLeft.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                    cell.CellFormat.BorderLeft.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
                    cell.CellFormat.BorderLeft.Width = 1.0;

                    cell.CellFormat.BorderRight.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                    cell.CellFormat.BorderRight.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
                    cell.CellFormat.BorderRight.Width = 1.0;
                }
            }

            // Merge cells vertically in the first two columns
            table.MergeCells(table[0, 0], table[1, 0], false);
            table.MergeCells(table[0, 1], table[1, 1], false);

            // Save the presentation
            presentation.Save("MergedTable.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}