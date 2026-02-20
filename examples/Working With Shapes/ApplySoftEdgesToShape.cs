using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a rectangle shape to the slide
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 200, 100);

        // Enable soft edge effect
        shape.EffectFormat.EnableSoftEdgeEffect();

        // Set the radius of the soft edge blur
        shape.EffectFormat.SoftEdgeEffect.Radius = 5.0;

        // Save the presentation
        presentation.Save("SoftEdgeExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}