using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Define column widths and initial row heights
        double[] cols = new double[] { 150, 150, 150 };
        double[] rows = new double[] { 50, 50 };

        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, cols, rows);

        // Clone the first row and add it as a new row at the bottom of the table
        Aspose.Slides.IRow templateRow = table.Rows[0];
        table.Rows.AddClone(templateRow, false);

        // Get the newly added row (last row in the collection)
        Aspose.Slides.IRow newRow = table.Rows[table.Rows.Count - 1];

        // Populate cells of the new row with sample text
        for (int i = 0; i < table.Columns.Count; i++)
        {
            Aspose.Slides.ICell cell = newRow[i];
            cell.TextFrame.Text = "New Row Cell " + i;
        }

        // Save the presentation
        presentation.Save("AddRowsTable.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}