using System;
using Aspose.Slides;

namespace TableRowAccessExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            System.String inputPath = "input.pptx";
            System.String outputPath = "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

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

            // If a table is found, access a specific row (e.g., second row) and modify it
            if (table != null)
            {
                // Access the row at index 1 (second row)
                Aspose.Slides.IRow row = table.Rows[1];

                // Example modification: set minimal height of the row
                row.MinimalHeight = 30.0;
            }

            // Save the presentation
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}