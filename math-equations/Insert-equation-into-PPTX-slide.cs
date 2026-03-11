using System;
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
        Aspose.Slides.IAutoShape mathShape = presentation.Slides[0].Shapes.AddMathShape(0, 0, 720, 150);

        // Retrieve the math paragraph from the shape
        Aspose.Slides.MathText.IMathParagraph mathParagraph = ((Aspose.Slides.MathText.MathPortion)mathShape.TextFrame.Paragraphs[0].Portions[0]).MathParagraph;

        // Create a fraction x / y
        Aspose.Slides.MathText.IMathElement fraction = new Aspose.Slides.MathText.MathematicalText("x").Divide("y");

        // Add the fraction as a MathBlock
        Aspose.Slides.MathText.MathBlock fractionBlock = new Aspose.Slides.MathText.MathBlock();
        fractionBlock.Add(fraction);
        mathParagraph.Add(fractionBlock);

        // Create a more complex equation: c^2 = a^2 + b^2
        Aspose.Slides.MathText.MathBlock equationBlock = new Aspose.Slides.MathText.MathBlock();
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("c"));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("^"));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("2"));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("="));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("a"));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("^"));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("2"));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("+"));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("b"));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("^"));
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText("2"));
        mathParagraph.Add(equationBlock);

        // Save the presentation
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}