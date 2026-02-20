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
            // Use the first row as a template and insert a new row after it
            Aspose.Slides.IRow templateRow = table.Rows[0];
            // Insert a clone of the template row at index 1 (second position)
            table.Rows.InsertClone(1, templateRow, false);
        }

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}