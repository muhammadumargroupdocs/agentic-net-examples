using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Path to the input presentation
        string inputPath = "input.pptx";
        // Path to the output presentation
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Retrieve the first shape as a table
        Aspose.Slides.ITable table = slide.Shapes[0] as Aspose.Slides.ITable;
        if (table == null)
        {
            Console.WriteLine("No table found on the first slide.");
            return;
        }

        // Delete the second row (index 1)
        table.Rows.RemoveAt(1, false);

        // Delete the third column (index 2)
        table.Columns.RemoveAt(2, false);

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}