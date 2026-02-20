using System;
using Aspose.Slides;

namespace DeleteTableColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define input and output file paths
            string dataDir = "C:\\Presentations\\";
            string inputFile = dataDir + "input.pptx";
            string outputFile = dataDir + "output.pptx";

            // Load the presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation(inputFile);

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

            // If a table is found, remove the second column (index 1)
            if (table != null)
            {
                // Remove column at index 1 without affecting the table layout
                table.Columns.RemoveAt(1, false);
            }

            // Save the modified presentation
            pres.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}