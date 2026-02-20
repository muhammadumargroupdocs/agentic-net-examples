using System;
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
        double[] cols = new double[] { 100, 100, 100 };
        double[] rows = new double[] { 50, 50, 50 };
        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);
        // Populate cells with sample text
        foreach (Aspose.Slides.IRow row in table.Rows)
        {
            foreach (Aspose.Slides.ICell cell in row)
            {
                Aspose.Slides.ITextFrame tf = cell.TextFrame;
                tf.Text = "R" + cell.FirstRowIndex + "C" + cell.FirstColumnIndex;
                tf.Paragraphs[0].Portions[0].PortionFormat.FontHeight = 12;
                tf.Paragraphs[0].ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.None;
            }
        }

        // Apply font style, size, and color to all cell text
        Aspose.Slides.PortionFormat portionFormat = new Aspose.Slides.PortionFormat();
        portionFormat.FontHeight = 14; // Font size
        portionFormat.FontBold = Aspose.Slides.NullableBool.True; // Bold style
        portionFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid; // Solid fill for color
        portionFormat.FillFormat.SolidFillColor.Color = Color.DarkGreen; // Font color
        table.SetTextFormat(portionFormat);

        // Save the presentation
        presentation.Save("FormattedTable.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}