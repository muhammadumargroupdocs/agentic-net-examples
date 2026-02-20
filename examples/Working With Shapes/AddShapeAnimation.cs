using System;
using Aspose.Slides;
using Aspose.Slides.Animation;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a rectangle shape to the first slide
        Aspose.Slides.IShape shape = presentation.Slides[0].Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 100, 100, 200, 100);

        // Add a faded zoom effect to the shape
        Aspose.Slides.Animation.IEffect effect = presentation.Slides[0].Timeline.MainSequence.AddEffect(
            shape,
            Aspose.Slides.Animation.EffectType.FadedZoom,
            Aspose.Slides.Animation.EffectSubtype.ObjectCenter,
            Aspose.Slides.Animation.EffectTriggerType.OnClick);

        // Configure timing: duration 2 seconds, repeat 3 times, auto-reverse enabled
        effect.Timing.Duration = 2.0f;
        effect.Timing.RepeatCount = 3;
        effect.Timing.AutoReverse = true;

        // Save the presentation to a file
        string outputPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "AnimatedShape.pptx");
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}