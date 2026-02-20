using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle shape to the first slide
        Aspose.Slides.IShape shape = presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 200, 100);

        // Enable reflection effect on the shape
        shape.EffectFormat.EnableReflectionEffect();

        // Set reflection effect properties
        shape.EffectFormat.ReflectionEffect.BlurRadius = 5.0;
        shape.EffectFormat.ReflectionEffect.Distance = 2.0;
        shape.EffectFormat.ReflectionEffect.StartReflectionOpacity = 0.5f;
        shape.EffectFormat.ReflectionEffect.EndReflectionOpacity = 0.0f;

        // Save the presentation
        presentation.Save("ReflectionEffect.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}