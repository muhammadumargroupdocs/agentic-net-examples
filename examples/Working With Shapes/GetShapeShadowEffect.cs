using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.Effects;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        // Access the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        // Add a rectangle shape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 200, 100);
        // Enable and configure outer shadow
        shape.EffectFormat.EnableOuterShadowEffect();
        shape.EffectFormat.OuterShadowEffect.BlurRadius = 5.0;
        shape.EffectFormat.OuterShadowEffect.Direction = 45.0f;
        shape.EffectFormat.OuterShadowEffect.Distance = 10.0;
        shape.EffectFormat.OuterShadowEffect.ShadowColor.Color = System.Drawing.Color.FromArgb(128, 0, 0, 0);
        // Retrieve effective outer shadow data
        Aspose.Slides.Effects.IOuterShadow outerShadow = shape.EffectFormat.OuterShadowEffect;
        Aspose.Slides.Effects.IOuterShadowEffectiveData effectiveData = outerShadow.GetEffective();
        // Output effective shadow properties
        Console.WriteLine("Effective BlurRadius: " + effectiveData.BlurRadius);
        Console.WriteLine("Effective Direction: " + effectiveData.Direction);
        Console.WriteLine("Effective Distance: " + effectiveData.Distance);
        // Save the presentation
        presentation.Save("ShadowEffectExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}