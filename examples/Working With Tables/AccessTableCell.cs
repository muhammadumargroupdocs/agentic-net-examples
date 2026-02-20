using System;
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
        double[] cols = new double[] { 100, 100, 100 };
        double[] rows = new double[] { 50, 30, 30, 30, 30 };
        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);
        // Populate each cell with its coordinates
        foreach (Aspose.Slides.IRow rowItem in table.Rows)
        {
            foreach (Aspose.Slides.ICell cellItem in rowItem)
            {
                Aspose.Slides.ITextFrame tf = cellItem.TextFrame;
                tf.Text = "R" + cellItem.FirstRowIndex.ToString() + "C" + cellItem.FirstColumnIndex.ToString();
                tf.Paragraphs[0].Portions[0].PortionFormat.FontHeight = 10;
                tf.Paragraphs[0].ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.None;
            }
        }
        // Access a specific cell by row and column index (row 2, column 1)
        Aspose.Slides.ICell specificCell = table[2, 1];
        // Modify the text of the accessed cell
        specificCell.TextFrame.Text = "Target Cell";
        // Save the presentation
        presentation.Save("AccessCell.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}