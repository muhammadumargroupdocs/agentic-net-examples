using System;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();
        // Get the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];
        // Add a rectangle shape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 400, 200);
        // Set solid fill color
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.FillFormat.SolidFillColor.Color = System.Drawing.Color.FromArgb(255, 0, 128, 255);
        // Enable outer shadow effect
        shape.EffectFormat.EnableOuterShadowEffect();
        shape.EffectFormat.OuterShadowEffect.BlurRadius = 5.0;
        shape.EffectFormat.OuterShadowEffect.Direction = 45;
        shape.EffectFormat.OuterShadowEffect.Distance = 10.0;
        shape.EffectFormat.OuterShadowEffect.ShadowColor.Color = System.Drawing.Color.FromArgb(128, 0, 0, 0);
        // Set line format
        shape.LineFormat.Width = 3;
        shape.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.LineFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.FromArgb(255, 255, 0, 0);
        // Save the presentation
        pres.Save("ShapeFormatting.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}