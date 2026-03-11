using Aspose.Slides;
using Aspose.Slides.MathText;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Presentation presentation = new Presentation();

        // Get the first slide
        ISlide slide = presentation.Slides[0];

        // Add a rectangle shape to hold the math text
        IAutoShape shape = (IAutoShape)slide.Shapes.AddAutoShape(ShapeType.Rectangle, 50, 50, 400, 100);
        shape.AddTextFrame("");

        // Create a base math element
        IMathElement baseElement = new MathematicalText("E");

        // Apply superscript to the base element
        IMathSuperscriptElement superscript = baseElement.SetSuperscript("=mc^2");

        // Create another base element for subscript example
        IMathElement baseElement2 = new MathematicalText("H");

        // Apply subscript to the second base element
        IMathSubscriptElement subscript = baseElement2.SetSubscript("2O");

        // Set the superscript text in the first paragraph
        shape.TextFrame.Paragraphs[0].Portions[0].PortionFormat.FontHeight = 24;
        shape.TextFrame.Paragraphs[0].Portions[0].Text = superscript.ToString();

        // Add a new paragraph for the subscript text
        shape.TextFrame.Paragraphs.Add(new Paragraph());
        shape.TextFrame.Paragraphs[1].Portions[0].Text = subscript.ToString();

        // Save the presentation
        presentation.Save("SubSuperscriptExample.pptx", SaveFormat.Pptx);
    }
}