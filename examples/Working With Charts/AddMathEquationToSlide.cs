using System;
using Aspose.Slides;
using Aspose.Slides.MathText;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a math shape to the first slide
        Aspose.Slides.IAutoShape mathShape = (Aspose.Slides.IAutoShape)presentation.Slides[0].Shapes.AddMathShape(50, 50, 400, 100);

        // Get the first paragraph's math portion and its MathParagraph
        Aspose.Slides.MathText.MathPortion mathPortion = new Aspose.Slides.MathText.MathPortion();
        mathShape.TextFrame.Paragraphs[0].Portions.Add(mathPortion);
        Aspose.Slides.MathText.IMathParagraph mathParagraph = mathPortion.MathParagraph;

        // Create mathematical text elements for the equation x² + y² = z²
        Aspose.Slides.MathText.IMathematicalText xText = new Aspose.Slides.MathText.MathematicalText("x");
        xText.SetSuperscript(new Aspose.Slides.MathText.MathematicalText("2"));

        Aspose.Slides.MathText.IMathematicalText yText = new Aspose.Slides.MathText.MathematicalText("y");
        yText.SetSuperscript(new Aspose.Slides.MathText.MathematicalText("2"));

        Aspose.Slides.MathText.IMathematicalText zText = new Aspose.Slides.MathText.MathematicalText("z");
        zText.SetSuperscript(new Aspose.Slides.MathText.MathematicalText("2"));

        // Build the equation using a MathBlock
        Aspose.Slides.MathText.MathBlock equationBlock = new Aspose.Slides.MathText.MathBlock();
        equationBlock.Add(xText);
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText(" + "));
        equationBlock.Add(yText);
        equationBlock.Add(new Aspose.Slides.MathText.MathematicalText(" = "));
        equationBlock.Add(zText);

        // Add the equation block to the MathParagraph
        mathParagraph.Add(equationBlock);

        // Save the presentation
        presentation.Save("MathEquation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}