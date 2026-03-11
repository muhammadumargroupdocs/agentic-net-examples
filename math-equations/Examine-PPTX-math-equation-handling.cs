using System;
using Aspose.Slides;
using Aspose.Slides.MathText;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        var presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        var slide = presentation.Slides[0];

        // Add a rectangle shape to host mathematical content
        var mathShape = slide.Shapes.AddMathShape(0, 0, 720, 150);

        // Retrieve the MathParagraph from the MathPortion
        var mathParagraph = ((MathPortion)mathShape.TextFrame.Paragraphs[0].Portions[0]).MathParagraph;

        // Build a fraction x/y and add it to the paragraph
        var fraction = new MathematicalText("x").Divide("y");
        mathParagraph.Add(new MathBlock(fraction));

        // Build a quadratic equation and add it to the paragraph
        var mathBlock = new MathematicalText("c")
            .SetSuperscript("2")
            .Join("=")
            .Join(new MathematicalText("a").SetSuperscript("2"))
            .Join("+")
            .Join(new MathematicalText("b").SetSuperscript("2"));
        mathParagraph.Add(mathBlock);

        // Output the equation in LaTeX format
        var latex = mathParagraph.ToLatex();
        Console.WriteLine(latex);

        // Save the presentation
        presentation.Save("math.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}