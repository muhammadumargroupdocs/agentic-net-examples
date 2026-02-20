using System.Drawing;
using Aspose.Slides;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add an ellipse auto shape
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Ellipse,
            100f, 100f, 200f, 200f);

        // Fill the shape with solid red color
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.FillFormat.SolidFillColor.Color = System.Drawing.Color.Red;

        // Set a solid black line
        shape.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.LineFormat.FillFormat.SolidFillColor.Color = System.Drawing.Color.Black;
        shape.LineFormat.Width = 2.0F; // float literal

        // Apply 3‑D bevel and lighting effects
        shape.ThreeDFormat.Depth = 5.0;
        shape.ThreeDFormat.BevelTop.BevelType = Aspose.Slides.BevelPresetType.Circle;
        shape.ThreeDFormat.BevelTop.Height = 5.0;
        shape.ThreeDFormat.BevelTop.Width = 5.0;
        shape.ThreeDFormat.Camera.CameraType = Aspose.Slides.CameraPresetType.OrthographicFront;
        shape.ThreeDFormat.LightRig.LightType = Aspose.Slides.LightRigPresetType.ThreePt;
        shape.ThreeDFormat.LightRig.Direction = Aspose.Slides.LightingDirection.Top;

        // Apply an outer shadow effect
        shape.EffectFormat.EnableOuterShadowEffect();
        shape.EffectFormat.OuterShadowEffect.BlurRadius = 4.0;
        shape.EffectFormat.OuterShadowEffect.Direction = 45.0F; // float literal
        shape.EffectFormat.OuterShadowEffect.Distance = 3.0;
        shape.EffectFormat.OuterShadowEffect.ShadowColor.Color = System.Drawing.Color.FromArgb(0, 0, 0, 0);

        // Save the presentation
        presentation.Save("CombineShapeEffects.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}