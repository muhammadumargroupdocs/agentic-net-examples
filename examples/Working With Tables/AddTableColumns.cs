using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace AddTableColumns
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
            double[] cols = new double[] { 100, 100, 100 };
            double[] rows = new double[] { 50, 50, 50 };

            // Add a table to the slide
            Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);

            // Apply border formatting to each cell
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

            // Add a new column by cloning the first column and inserting it at the end
            table.Columns.InsertClone(table.Columns.Count, table.Columns[0], false);

            // Optionally set the width of the newly added column
            table.Columns[table.Columns.Count - 1].Width = 100;

            // Save the presentation
            presentation.Save("AddColumns.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}