using Aspose.Slides;
using Aspose.Slides.MathText;
using Aspose.Slides.Export;
using System;

namespace MathEquationDemo
{
    class Program
    {
        static void Main()
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a math shape to the first slide
            Aspose.Slides.IAutoShape mathShape = presentation.Slides[0].Shapes.AddMathShape(0, 0, 500, 50);

            // Retrieve the math paragraph from the shape
            Aspose.Slides.MathText.IMathParagraph mathParagraph = ((Aspose.Slides.MathText.MathPortion)mathShape.TextFrame.Paragraphs[0].Portions[0]).MathParagraph;

            // Build a math block: a = b + c
            Aspose.Slides.MathText.IMathBlock mathBlock = new Aspose.Slides.MathText.MathematicalText("a")
                .Join("=")
                .Join(new Aspose.Slides.MathText.MathematicalText("b"))
                .Join("+")
                .Join(new Aspose.Slides.MathText.MathematicalText("c"));

            // Add the block to the paragraph
            mathParagraph.Add(mathBlock);

            // Export the equation to LaTeX
            string latex = mathParagraph.ToLatex();

            // Output LaTeX string
            Console.WriteLine("LaTeX: " + latex);

            // Save the presentation
            presentation.Save("MathEquation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}