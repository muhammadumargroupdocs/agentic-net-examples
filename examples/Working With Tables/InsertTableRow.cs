using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Path to the source presentation
        string dataDir = "data/";
        string inputFile = dataDir + "input.pptx";
        string outputFile = dataDir + "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputFile);

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
            // Index at which the new row will be inserted
            int insertIndex = 1; // example: insert after the first row

            // Use an existing row as a template for the new row
            Aspose.Slides.IRow templateRow = table.Rows[0];

            // Insert a clone of the template row at the specified index
            table.Rows.InsertClone(insertIndex, templateRow, false);
        }

        // Save the modified presentation
        presentation.Save(outputFile, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}