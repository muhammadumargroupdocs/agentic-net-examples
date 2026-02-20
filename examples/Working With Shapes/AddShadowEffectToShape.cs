using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();
        // Access the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];
        // Add a rectangle shape to the slide
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 200, 100);
        // Apply solid fill to the shape
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.FillFormat.SolidFillColor.Color = Color.FromArgb(255, 0, 0, 255); // Blue fill
        // Enable outer shadow effect
        shape.EffectFormat.EnableOuterShadowEffect();
        // Configure shadow properties
        shape.EffectFormat.OuterShadowEffect.BlurRadius = 5.0;
        shape.EffectFormat.OuterShadowEffect.Direction = 45.0f;
        shape.EffectFormat.OuterShadowEffect.Distance = 3.0;
        shape.EffectFormat.OuterShadowEffect.ShadowColor.Color = Color.FromArgb(128, 0, 0, 0); // Semi‑transparent black
        // Save the presentation
        pres.Save("ShadowShape.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}