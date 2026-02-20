using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Load the presentation from a file
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation("input.pptx");

        // Iterate through all slides in the presentation
        for (int slideIndex = 0; slideIndex < presentation.Slides.Count; slideIndex++)
        {
            Aspose.Slides.ISlide slide = presentation.Slides[slideIndex];

            // Iterate through all shapes on the slide
            for (int shapeIndex = 0; shapeIndex < slide.Shapes.Count; shapeIndex++)
            {
                Aspose.Slides.IShape shape = slide.Shapes[shapeIndex];

                // Check if the shape is a table
                Aspose.Slides.ITable table = shape as Aspose.Slides.ITable;
                if (table != null)
                {
                    // Iterate through each row in the table
                    foreach (Aspose.Slides.IRow row in table.Rows)
                    {
                        // Iterate through each cell in the row
                        foreach (Aspose.Slides.ICell cell in row)
                        {
                            // Read the text from the cell's text frame
                            string cellText = cell.TextFrame.Text;

                            // Output the cell text with its position
                            Console.WriteLine("Slide {0}, Cell [{1},{2}]: {3}",
                                slideIndex + 1,
                                cell.FirstRowIndex,
                                cell.FirstColumnIndex,
                                cellText);
                        }
                    }
                }
            }
        }

        // Save the presentation (required by authoring rules)
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}