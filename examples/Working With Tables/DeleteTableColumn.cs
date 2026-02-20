using System;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace TableColumnRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input and output file paths
            string inputPath = "input.pptx";
            string outputPath = "output.pptx";

            // Index of the slide containing the table (0‑based)
            int slideIndex = 0;

            // Index of the column to remove (0‑based)
            int columnIndex = 1;

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputPath);

            // Get the target slide
            Aspose.Slides.ISlide slide = pres.Slides[slideIndex];

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

            // Remove the specified column if a table was found
            if (table != null)
            {
                table.Columns.RemoveAt(columnIndex, false);
            }

            // Save the modified presentation
            pres.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}