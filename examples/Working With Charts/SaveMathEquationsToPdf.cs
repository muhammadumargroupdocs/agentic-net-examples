using System;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a math shape to the first slide
        Aspose.Slides.IAutoShape mathShape = (Aspose.Slides.IAutoShape)presentation.Slides[0].Shapes.AddMathShape(0, 0, 400, 100);

        // Get the first paragraph of the math shape
        Aspose.Slides.IParagraph paragraph = mathShape.TextFrame.Paragraphs[0];

        // Create a MathPortion and add it to the paragraph
        Aspose.Slides.MathText.MathPortion mathPortion = new Aspose.Slides.MathText.MathPortion();
        paragraph.Portions.Add(mathPortion);

        // Set the mathematical equation text
        mathPortion.Text = "x^2 + y^2 = z^2";

        // Save the presentation as PDF
        presentation.Save("MathEquation.pdf", Aspose.Slides.Export.SaveFormat.Pdf);
    }
}