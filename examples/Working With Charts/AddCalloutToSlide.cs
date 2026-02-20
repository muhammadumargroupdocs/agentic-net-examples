using System;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation (lifecycle rule)
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a callout shape (Callout1 is a valid ShapeType)
        Aspose.Slides.AutoShape callout = (Aspose.Slides.AutoShape)presentation.Slides[0].Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Callout1, 100f, 100f, 300f, 150f);

        // Set the callout text
        callout.TextFrame.Text = "Callout example";

        // Save the presentation before exiting (lifecycle rule)
        presentation.Save("AddCallout.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}