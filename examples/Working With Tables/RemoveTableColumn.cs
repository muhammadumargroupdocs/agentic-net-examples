using System;

namespace RemoveTableColumnExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define output file path
            string outputPath = "RemovedColumn.pptx";

            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Access the first slide
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Define column widths and row heights for the table
            double[] colWidths = new double[] { 150, 150, 150 };
            double[] rowHeights = new double[] { 100, 100, 100 };

            // Add a table to the slide
            Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, colWidths, rowHeights);

            // Remove the second column (index 1) without affecting the table layout
            table.Columns.RemoveAt(1, false);

            // Save the presentation
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}