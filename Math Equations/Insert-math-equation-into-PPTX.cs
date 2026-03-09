using Aspose.Slides;
using Aspose.Slides.MathText;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a math shape to the first slide
        Aspose.Slides.IAutoShape mathShape = presentation.Slides[0].Shapes.AddMathShape(0, 0, 720, 150);

        // Get the math paragraph from the shape
        Aspose.Slides.MathText.IMathParagraph mathParagraph = ((Aspose.Slides.MathText.MathPortion)mathShape.TextFrame.Paragraphs[0].Portions[0]).MathParagraph;

        // Create a fraction x/y
        Aspose.Slides.MathText.MathematicalText numerator = new Aspose.Slides.MathText.MathematicalText("x");
        Aspose.Slides.MathText.MathematicalText denominator = new Aspose.Slides.MathText.MathematicalText("y");
        Aspose.Slides.MathText.IMathElement fraction = numerator.Divide(denominator);

        // Add the fraction as a math block
        Aspose.Slides.MathText.MathBlock fractionBlock = new Aspose.Slides.MathText.MathBlock(fraction);
        mathParagraph.Add(fractionBlock);

        // Create the rest of the equation: = c² = a² + b²
        Aspose.Slides.MathText.MathBlock equationBlock = new Aspose.Slides.MathText.MathBlock();

        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("="));

        Aspose.Slides.MathText.MathematicalText c = new Aspose.Slides.MathText.MathematicalText("c");
        c.SetSuperscript("2");
        equationBlock.Add(c);

        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("="));

        Aspose.Slides.MathText.MathematicalText a = new Aspose.Slides.MathText.MathematicalText("a");
        a.SetSuperscript("2");
        equationBlock.Add(a);

        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("+"));

        Aspose.Slides.MathText.MathematicalText b = new Aspose.Slides.MathText.MathematicalText("b");
        b.SetSuperscript("2");
        equationBlock.Add(b);

        mathParagraph.Add(equationBlock);

        // Save the presentation
        presentation.Save("MathEquation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}