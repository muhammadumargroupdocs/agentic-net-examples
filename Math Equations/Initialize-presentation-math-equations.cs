using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.MathText;

namespace MathEquationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a math shape to the first slide
            Aspose.Slides.IAutoShape mathShape = presentation.Slides[0].Shapes.AddMathShape(0f, 0f, 500f, 50f);

            // Retrieve the math paragraph from the shape
            Aspose.Slides.MathText.IMathParagraph mathParagraph = ((Aspose.Slides.MathText.MathPortion)mathShape.TextFrame.Paragraphs[0].Portions[0]).MathParagraph;

            // Create a math block for the equation "c = a + b"
            Aspose.Slides.MathText.MathBlock mathBlock = new Aspose.Slides.MathText.MathBlock(new Aspose.Slides.MathText.MathematicalText("c"));
            // Build the equation using Join methods
            mathBlock = (Aspose.Slides.MathText.MathBlock)mathBlock
                .Join("=")
                .Join(new Aspose.Slides.MathText.MathematicalText("a"))
                .Join("+")
                .Join(new Aspose.Slides.MathText.MathematicalText("b"));

            // Add the constructed math block to the paragraph
            mathParagraph.Add(mathBlock);

            // Save the presentation
            presentation.Save("MathEquation.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}