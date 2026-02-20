using System;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle auto shape
        Aspose.Slides.IAutoShape shape = presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 100, false);

        // Add a text frame and clear default portions
        shape.AddTextFrame("");
        shape.TextFrame.Paragraphs[0].Portions.Clear();

        // Create an existing portion and add it to the paragraph
        Aspose.Slides.IPortion existingPortion = new Aspose.Slides.Portion("Existing text");
        shape.TextFrame.Paragraphs[0].Portions.Add(existingPortion);

        // Insert a new portion into the existing paragraph at index 1
        Aspose.Slides.IPortion newPortion = new Aspose.Slides.Portion("Inserted text");
        shape.TextFrame.Paragraphs[0].Portions.Insert(1, newPortion);

        // Save the presentation
        string outPath = "InsertPortion.pptx";
        presentation.Save(outPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}