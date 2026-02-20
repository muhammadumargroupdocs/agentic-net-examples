using System;
using System.Drawing;
using Aspose.Slides;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get reference to the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Set slide background to solid blue color
            slide.Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
            slide.Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
            slide.Background.FillFormat.SolidFillColor.Color = System.Drawing.Color.Blue;

            // Define column widths and row heights for the table
            double[] columnWidths = new double[] { 150, 150, 150 };
            double[] rowHeights = new double[] { 50, 50, 50, 50 };

            // Add a table to the slide
            Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 150, columnWidths, rowHeights);

            // (Optional) Set a simple style for the table cells
            foreach (Aspose.Slides.IRow tableRow in table.Rows)
            {
                foreach (Aspose.Slides.ICell cell in tableRow)
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

            // Save the presentation
            presentation.Save("TableWithBackground.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}