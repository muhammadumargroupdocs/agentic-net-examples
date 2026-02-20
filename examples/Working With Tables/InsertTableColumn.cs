using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Paths to the input and output presentations
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the existing presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Find the first table on the slide
        Aspose.Slides.ITable table = null;
        foreach (Aspose.Slides.IShape shape in slide.Shapes)
        {
            if (shape is Aspose.Slides.ITable)
            {
                table = (Aspose.Slides.ITable)shape;
                break;
            }
        }

        if (table != null)
        {
            // Use the first column as a template for the new column
            Aspose.Slides.IColumn templateColumn = table.Columns[0];

            // Index at which the new column will be inserted (e.g., after the first column)
            int insertIndex = 1;

            // Insert a clone of the template column at the specified index
            // The third parameter indicates whether to keep the original column's width
            table.Columns.InsertClone(insertIndex, templateColumn, true);
        }

        // Save the modified presentation
        pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Clean up resources
        pres.Dispose();
    }
}