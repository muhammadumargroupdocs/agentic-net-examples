using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.MathText;

class Program
{
    static void Main()
    {
        // Output file path
        string outputPath = "MathEquation.tiff";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a math shape to the first slide
        Aspose.Slides.IAutoShape mathShape = presentation.Slides[0].Shapes.AddMathShape(50f, 50f, 400f, 100f);

        // Get the first paragraph of the math shape
        Aspose.Slides.IParagraph paragraph = mathShape.TextFrame.Paragraphs[0];

        // Create a MathPortion with a mathematical equation
        Aspose.Slides.MathText.MathPortion mathPortion = new Aspose.Slides.MathText.MathPortion();
        mathPortion.Text = "E=mc^2";

        // Add the MathPortion to the paragraph
        paragraph.Portions.Add(mathPortion);

        // Save the presentation as a multi-page TIFF image
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Tiff);
    }
}