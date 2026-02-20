using System;
using Aspose.Slides;
using Aspose.Slides.MathText;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a math shape to the first slide
        Aspose.Slides.IShape mathShape = presentation.Slides[0].Shapes.AddMathShape(50f, 50f, 400f, 100f);

        // Get the first paragraph of the shape's text frame
        Aspose.Slides.IParagraph paragraph = ((Aspose.Slides.IAutoShape)mathShape).TextFrame.Paragraphs[0];

        // Create a MathPortion and set its text to a mathematical equation
        Aspose.Slides.MathText.MathPortion mathPortion = new Aspose.Slides.MathText.MathPortion();
        mathPortion.Text = "x^2 + y^2 = z^2";

        // Add the MathPortion to the paragraph
        paragraph.Portions.Add(mathPortion);

        // Save the presentation as PDF
        presentation.Save("MathEquation.pdf", Aspose.Slides.Export.SaveFormat.Pdf);
    }
}