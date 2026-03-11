using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.MathText;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a math shape to the first slide
        Aspose.Slides.IAutoShape mathShape = presentation.Slides[0].Shapes.AddMathShape(0, 0, 720, 150);

        // Retrieve the math paragraph from the shape
        Aspose.Slides.MathText.IMathParagraph mathParagraph = ((Aspose.Slides.MathText.MathPortion)mathShape.TextFrame.Paragraphs[0].Portions[0]).MathParagraph;

        // Create a fraction x / y
        Aspose.Slides.MathText.IMathElement fractionElement = new Aspose.Slides.MathText.MathematicalText("x").Divide("y");

        // Wrap the fraction in a math block and add to the paragraph
        Aspose.Slides.MathText.IMathBlock fractionBlock = new Aspose.Slides.MathText.MathBlock(fractionElement);
        mathParagraph.Add(fractionBlock);

        // Build a quadratic equation: c² = a² + b²
        Aspose.Slides.MathText.IMathBlock equationBlock = new Aspose.Slides.MathText.MathematicalText("c")
            .SetSuperscript("2")
            .Join("=")
            .Join(new Aspose.Slides.MathText.MathematicalText("a").SetSuperscript("2"))
            .Join("+")
            .Join(new Aspose.Slides.MathText.MathematicalText("b").SetSuperscript("2"));

        // Add the equation block to the paragraph
        mathParagraph.Add(equationBlock);

        // Save the presentation
        presentation.Save("MathEquation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}