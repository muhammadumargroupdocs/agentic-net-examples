using System;
using Aspose.Slides;
using Aspose.Slides.Animation;
using Aspose.Slides.Export;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a rectangle auto shape to the first slide
            Aspose.Slides.IAutoShape rectangleShape = (Aspose.Slides.IAutoShape)presentation.Slides[0].Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 150);
            rectangleShape.TextFrame.Text = "Animated Text";

            // Add an appearance animation effect to the shape
            Aspose.Slides.Animation.IEffect appearEffect = presentation.Slides[0].Timeline.MainSequence.AddEffect(
                rectangleShape,
                Aspose.Slides.Animation.EffectType.Appear,
                Aspose.Slides.Animation.EffectSubtype.None,
                Aspose.Slides.Animation.EffectTriggerType.OnClick);

            // Set the start delay of the animation (in seconds)
            appearEffect.Timing.TriggerDelayTime = 2.0f;

            // Save the presentation
            presentation.Save("SetAnimationStartDelay.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}