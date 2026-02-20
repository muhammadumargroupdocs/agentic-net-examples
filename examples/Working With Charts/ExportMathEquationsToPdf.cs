using System;
using Aspose.Slides;
using Aspose.Slides.MathText;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a math shape
        Aspose.Slides.IAutoShape mathShape = slide.Shapes.AddMathShape(50f, 50f, 400f, 100f);

        // Get the first paragraph and add a MathPortion
        Aspose.Slides.IParagraph paragraph = mathShape.TextFrame.Paragraphs[0];
        Aspose.Slides.MathText.MathPortion mathPortion = new Aspose.Slides.MathText.MathPortion();
        paragraph.Portions.Add(mathPortion);

        // Set a mathematical equation
        mathPortion.Text = "x = \\frac{-b \\pm \\sqrt{b^2-4ac}}{2a}";

        // Save the presentation as PDF
        string outputPath = "MathEquation.pdf";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pdf);
    }
}