using System;
using System.IO;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Presentation pres = new Presentation();

            // Add a rectangle shape to the first slide
            IAutoShape shape = pres.Slides[0].Shapes.AddAutoShape(ShapeType.Rectangle, 50, 50, 200, 100);

            // Set the shape's fill to a solid red color
            shape.FillFormat.FillType = FillType.Solid;
            shape.FillFormat.SolidFillColor.Color = Color.Red;

            // Get the effective fill format (includes inheritance)
            IFillFormatEffectiveData effectiveFill = shape.FillFormat.GetEffective();

            // Retrieve effective fill type
            FillType effectiveFillType = effectiveFill.FillType;

            // Retrieve effective solid fill color (if applicable)
            Color effectiveColor = effectiveFill.SolidFillColor;

            // Output the effective fill information
            Console.WriteLine("Effective Fill Type: " + effectiveFillType);
            Console.WriteLine("Effective Solid Fill Color: " + effectiveColor);

            // Save the presentation before exiting
            string outPath = Path.Combine(Directory.GetCurrentDirectory(), "EffectiveFill.pptx");
            pres.Save(outPath, SaveFormat.Pptx);

            // Clean up
            pres.Dispose();
        }
    }
}