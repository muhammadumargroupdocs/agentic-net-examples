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
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Define column widths and row heights
        double[] cols = new double[] { 100, 100, 100, 100 };
        double[] rows = new double[] { 50, 50, 50, 50 };

        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);

        // Access and set text in specific cells
        table[0, 0].TextFrame.Text = "Header 1";
        table[0, 1].TextFrame.Text = "Header 2";
        table[1, 0].TextFrame.Text = "Row1 Col1";
        table[1, 1].TextFrame.Text = "Row1 Col2";

        // Optional: set borders for all cells
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
        presentation.Save("AccessCellContent.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}