using System;

namespace WorkingWithChartsCreateMathEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a math shape to the first slide
            Aspose.Slides.IAutoShape mathShape = (Aspose.Slides.IAutoShape)presentation.Slides[0].Shapes.AddMathShape(50f, 50f, 400f, 100f);

            // Get the first paragraph of the shape's text frame
            Aspose.Slides.IParagraph paragraph = mathShape.TextFrame.Paragraphs[0];

            // Create a MathPortion and add it to the paragraph
            Aspose.Slides.MathText.MathPortion mathPortion = new Aspose.Slides.MathText.MathPortion();
            paragraph.Portions.Add(mathPortion);

            // Get the MathParagraph associated with the MathPortion
            Aspose.Slides.MathText.IMathParagraph mathParagraph = mathPortion.MathParagraph;

            // Build the equation x² + y² = z²
            Aspose.Slides.MathText.MathBlock equationBlock = new Aspose.Slides.MathText.MathBlock();

            // x²
            Aspose.Slides.MathText.IMathElement xSup2 = new Aspose.Slides.MathText.MathematicalText("x").SetSuperscript("2");
            equationBlock.Add(xSup2);

            // " + "
            equationBlock.Add(new Aspose.Slides.MathText.MathematicalText(" + "));

            // y²
            Aspose.Slides.MathText.IMathElement ySup2 = new Aspose.Slides.MathText.MathematicalText("y").SetSuperscript("2");
            equationBlock.Add(ySup2);

            // " = "
            equationBlock.Add(new Aspose.Slides.MathText.MathematicalText(" = "));

            // z²
            Aspose.Slides.MathText.IMathElement zSup2 = new Aspose.Slides.MathText.MathematicalText("z").SetSuperscript("2");
            equationBlock.Add(zSup2);

            // Add the equation block to the math paragraph
            mathParagraph.Add(equationBlock);

            // Save the presentation
            presentation.Save("MathEquation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}