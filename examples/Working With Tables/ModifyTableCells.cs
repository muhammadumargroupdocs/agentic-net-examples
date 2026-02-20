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
        double[] columnWidths = new double[] { 150, 150, 150, 150 };
        double[] rowHeights = new double[] { 100, 100, 100, 100, 90 };
        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, columnWidths, rowHeights);
        // Set borders for all cells
        foreach (Aspose.Slides.IRow rowItem in table.Rows)
        {
            foreach (Aspose.Slides.ICell cell in rowItem)
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
        // Modify margins of a specific cell (row 0, column 0)
        table[0, 0].MarginTop = 5;
        table[0, 0].MarginBottom = 5;
        table[0, 0].MarginLeft = 5;
        table[0, 0].MarginRight = 5;
        // Add text to the same cell
        table[0, 0].TextFrame.Text = "Hello Aspose!";
        // Add an image inside the same cell
        Aspose.Slides.IImage image = Aspose.Slides.Images.FromFile("sample.jpg");
        Aspose.Slides.IPPImage pptImage = presentation.Images.AddImage(image);
        table[0, 0].CellFormat.FillFormat.FillType = Aspose.Slides.FillType.Picture;
        table[0, 0].CellFormat.FillFormat.PictureFillFormat.PictureFillMode = Aspose.Slides.PictureFillMode.Stretch;
        table[0, 0].CellFormat.FillFormat.PictureFillFormat.Picture.Image = pptImage;
        // Save the presentation
        presentation.Save("ModifiedTable.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}