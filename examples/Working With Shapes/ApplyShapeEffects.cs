using System;
using Aspose.Slides;
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

        // Add an ellipse shape to the slide
        Aspose.Slides.IAutoShape shape = slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Ellipse, 100, 100, 200, 150);

        // Set solid fill and line colors
        shape.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.FillFormat.SolidFillColor.Color = Color.Blue;
        shape.LineFormat.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        shape.LineFormat.FillFormat.SolidFillColor.Color = Color.Black;
        shape.LineFormat.Width = 2.0;

        // Apply 3D rotation and lighting
        shape.ThreeDFormat.Depth = 5.0;
        shape.ThreeDFormat.Camera.SetRotation(30.0f, 20.0f, 0.0f);
        shape.ThreeDFormat.Camera.CameraType = Aspose.Slides.CameraPresetType.OrthographicFront;
        shape.ThreeDFormat.LightRig.LightType = Aspose.Slides.LightRigPresetType.ThreePt;
        shape.ThreeDFormat.LightRig.Direction = Aspose.Slides.LightingDirection.Top;

        // Enable and configure reflection effect
        shape.EffectFormat.EnableReflectionEffect();
        shape.EffectFormat.ReflectionEffect.BlurRadius = 5.0;
        shape.EffectFormat.ReflectionEffect.Distance = 10.0;
        shape.EffectFormat.ReflectionEffect.Direction = 0.0f;

        // Enable and configure soft edge effect
        shape.EffectFormat.EnableSoftEdgeEffect();
        shape.EffectFormat.SoftEdgeEffect.Radius = 8.0;

        // Save the presentation
        presentation.Save("ShapeEffects.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}