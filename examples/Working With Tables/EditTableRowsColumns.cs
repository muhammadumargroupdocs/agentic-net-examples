using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace TableRowColumnManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Define column widths and row heights
            double[] colWidths = new double[] { 100, 100, 100 };
            double[] rowHeights = new double[] { 50, 50, 50 };

            // Add a table to the slide
            Aspose.Slides.ITable table = slide.Shapes.AddTable(50, 50, colWidths, rowHeights);

            // Remove the second row (index 1) without affecting the table layout
            table.Rows.RemoveAt(1, false);

            // Remove the third column (index 2) without affecting the table layout
            table.Columns.RemoveAt(2, false);

            // Save the presentation
            pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}