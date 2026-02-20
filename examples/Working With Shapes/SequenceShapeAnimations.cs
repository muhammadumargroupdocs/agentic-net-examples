using System;

namespace AsposeSlidesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add a rectangle shape to the first slide
            Aspose.Slides.IAutoShape rectangle = presentation.Slides[0].Shapes.AddAutoShape(
                Aspose.Slides.ShapeType.Rectangle, 100, 100, 300, 150);

            // Get the main animation sequence of the slide
            Aspose.Slides.Animation.ISequence mainSequence = presentation.Slides[0].Timeline.MainSequence;

            // Add first animation effect: Appear on click
            Aspose.Slides.Animation.IEffect appearEffect = mainSequence.AddEffect(
                rectangle,
                Aspose.Slides.Animation.EffectType.Appear,
                Aspose.Slides.Animation.EffectSubtype.None,
                Aspose.Slides.Animation.EffectTriggerType.OnClick);

            // Add second animation effect: Fade after previous
            Aspose.Slides.Animation.IEffect fadeEffect = mainSequence.AddEffect(
                rectangle,
                Aspose.Slides.Animation.EffectType.Fade,
                Aspose.Slides.Animation.EffectSubtype.None,
                Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);

            // Add third animation effect: Fly after previous
            Aspose.Slides.Animation.IEffect flyEffect = mainSequence.AddEffect(
                rectangle,
                Aspose.Slides.Animation.EffectType.Fly,
                Aspose.Slides.Animation.EffectSubtype.None,
                Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);

            // Save the presentation
            presentation.Save("MultipleAnimationsOnShape.pptx", Aspose.Slides.Export.SaveFormat.Pptx);

            // Dispose the presentation object
            presentation.Dispose();
        }
    }
}