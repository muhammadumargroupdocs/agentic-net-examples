using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();
        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];
        // Define column widths and row heights
        double[] cols = new double[] { 100, 100, 100 };
        double[] rows = new double[] { 50, 30, 30, 30 };
        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);
        // Set text for each cell in the table
        foreach (Aspose.Slides.IRow row in table.Rows)
        {
            foreach (Aspose.Slides.ICell cell in row)
            {
                Aspose.Slides.ITextFrame tf = cell.TextFrame;
                tf.Text = "R" + cell.FirstRowIndex.ToString() + "C" + cell.FirstColumnIndex.ToString();
                tf.Paragraphs[0].Portions[0].PortionFormat.FontHeight = 12;
                tf.Paragraphs[0].ParagraphFormat.Bullet.Type = Aspose.Slides.BulletType.None;
            }
        }
        // Save the presentation
        pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}