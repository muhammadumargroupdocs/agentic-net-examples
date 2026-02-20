using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Define initial column widths and row heights
        double[] columnWidths = new double[] { 100, 100, 100 };
        double[] rowHeights = new double[] { 50, 50, 50 };

        // Add a table to the slide
        Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, columnWidths, rowHeights);

        // Clone the first column and insert it as a new fourth column
        Aspose.Slides.IColumn templateColumn = table.Columns[0];
        table.Columns.InsertClone(3, templateColumn, false);

        // Set the width of the newly added column
        table.Columns[3].Width = 120;

        // Save the presentation
        presentation.Save("AddColumnsExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}