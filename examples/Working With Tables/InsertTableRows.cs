using System;

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

        // Set header text for the first row
        table[0, 0].TextFrame.Text = "Header 1";
        table[0, 1].TextFrame.Text = "Header 2";
        table[0, 2].TextFrame.Text = "Header 3";

        // Insert a new row at position 1 (after the header) by cloning an existing row
        Aspose.Slides.IRow templateRow = table.Rows[1]; // use the second row as a template
        table.Rows.InsertClone(1, templateRow, true);

        // Set text for the newly inserted row
        table[1, 0].TextFrame.Text = "New Row Cell 1";
        table[1, 1].TextFrame.Text = "New Row Cell 2";
        table[1, 2].TextFrame.Text = "New Row Cell 3";

        // Save the presentation
        string outputPath = "InsertRowDemo.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}