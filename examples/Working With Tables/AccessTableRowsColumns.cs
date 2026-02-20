using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Access the first table on the first slide
        Aspose.Slides.ITable table = presentation.Slides[0].Shapes[0] as Aspose.Slides.ITable;
        if (table == null)
        {
            Console.WriteLine("No table found on the first slide.");
            presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
            return;
        }

        // Iterate through rows and columns
        int rowIndex = 0;
        foreach (Aspose.Slides.IRow row in table.Rows)
        {
            int columnIndex = 0;
            foreach (Aspose.Slides.ICell cell in row)
            {
                // Output cell text
                string cellText = cell.TextFrame.Text;
                Console.WriteLine("Row {0}, Column {1}: {2}", rowIndex, columnIndex, cellText);
                columnIndex++;
            }
            rowIndex++;
        }

        // Save the presentation
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}