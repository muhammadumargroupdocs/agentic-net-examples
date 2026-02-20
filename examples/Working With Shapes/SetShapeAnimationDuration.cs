using System;
using Aspose.Slides;
using Aspose.Slides.Animation;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Add a rectangle shape to the first slide
        Aspose.Slides.IShape shp = pres.Slides[0].Shapes.AddAutoShape(
            Aspose.Slides.ShapeType.Rectangle,
            100, 100, 200, 100);

        // Add a fade animation effect to the shape
        Aspose.Slides.Animation.IEffect effect = pres.Slides[0].Timeline.MainSequence.AddEffect(
            shp,
            Aspose.Slides.Animation.EffectType.Fade,
            Aspose.Slides.Animation.EffectSubtype.None,
            Aspose.Slides.Animation.EffectTriggerType.OnClick);

        // Set the duration of the animation effect to 2 seconds
        effect.Timing.Duration = 2f;

        // Save the presentation before exiting
        pres.Save("SetShapeAnimationDuration.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}