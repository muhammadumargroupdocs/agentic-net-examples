using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.MathText;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a mathematical shape to the first slide
        Aspose.Slides.IAutoShape mathShape = presentation.Slides[0].Shapes.AddMathShape(0f, 0f, 720f, 150f);

        // Retrieve the math paragraph from the shape
        Aspose.Slides.MathText.IMathParagraph mathParagraph = ((Aspose.Slides.MathText.MathPortion)mathShape.TextFrame.Paragraphs[0].Portions[0]).MathParagraph;

        // Create a fraction x / y and add it as a math block
        Aspose.Slides.MathText.IMathElement fraction = new Aspose.Slides.MathText.MathematicalText("x").Divide("y");
        mathParagraph.Add(new Aspose.Slides.MathText.MathBlock(fraction));

        // Create the expression c² = a² + b² and add it as a math block
        Aspose.Slides.MathText.IMathBlock expressionBlock = new Aspose.Slides.MathText.MathBlock(
            new Aspose.Slides.MathText.MathematicalText("c").SetSuperscript("2")
        ).Join("=").Join(
            new Aspose.Slides.MathText.MathematicalText("a").SetSuperscript("2")
        ).Join(
            "+"
        ).Join(
            new Aspose.Slides.MathText.MathematicalText("b").SetSuperscript("2")
        );
        mathParagraph.Add(expressionBlock);

        // Save the presentation to a PPTX file
        presentation.Save("MathEquation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}