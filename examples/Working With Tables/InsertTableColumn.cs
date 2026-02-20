using System;

namespace TableColumnInsertExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Assume the first shape on the slide is a table
            Aspose.Slides.ITable table = slide.Shapes[0] as Aspose.Slides.ITable;

            if (table != null)
            {
                // Use the first column as a template for the new column
                Aspose.Slides.IColumn templateColumn = table.Columns[0];

                // Insert a new column at index 1 (second position)
                table.Columns.InsertClone(1, templateColumn, true);
            }

            // Save the modified presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}