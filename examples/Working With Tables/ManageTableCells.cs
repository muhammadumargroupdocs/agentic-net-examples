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
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Define column widths and row heights
        double[] cols = new double[] { 100, 100, 100, 100 };
        double[] rows = new double[] { 50, 50, 50, 50 };

        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);

        // Apply border formatting to all cells
        foreach (Aspose.Slides.IRow row in table.Rows)
        {
            foreach (Aspose.Slides.ICell cell in row)
            {
                cell.CellFormat.BorderTop.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderTop.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
                cell.CellFormat.BorderTop.Width = 1;

                cell.CellFormat.BorderBottom.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderBottom.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
                cell.CellFormat.BorderBottom.Width = 1;

                cell.CellFormat.BorderLeft.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderLeft.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
                cell.CellFormat.BorderLeft.Width = 1;

                cell.CellFormat.BorderRight.FillFormat.FillType = Aspose.Slides.FillType.Solid;
                cell.CellFormat.BorderRight.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
                cell.CellFormat.BorderRight.Width = 1;
            }
        }

        // Merge a range of cells
        table.MergeCells(table[0, 0], table[1, 1], false);
        table[0, 0].TextFrame.Text = "Merged Cell";

        // Add an image inside a specific cell
        Aspose.Slides.IImage img = Aspose.Slides.Images.FromFile("sample.jpg");
        Aspose.Slides.IPPImage pptImg = presentation.Images.AddImage(img);
        table[2, 2].CellFormat.FillFormat.FillType = Aspose.Slides.FillType.Picture;
        table[2, 2].CellFormat.FillFormat.PictureFillFormat.PictureFillMode = Aspose.Slides.PictureFillMode.Stretch;
        table[2, 2].CellFormat.FillFormat.PictureFillFormat.Picture.Image = pptImg;

        // Save the presentation
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}