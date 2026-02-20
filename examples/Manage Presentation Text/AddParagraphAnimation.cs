using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        string inputPath = "input.pptx";
        string outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Get the first shape assuming it is an AutoShape with a text frame
        Aspose.Slides.IAutoShape autoShape = slide.Shapes[0] as Aspose.Slides.IAutoShape;
        if (autoShape == null || autoShape.TextFrame == null)
        {
            // Save and exit if no suitable shape is found
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            return;
        }

        // Access the main animation sequence of the slide
        Aspose.Slides.Animation.ISequence mainSequence = slide.Timeline.MainSequence;

        // Add a Fly‑Left effect on click to each paragraph in the text frame
        for (int i = 0; i < autoShape.TextFrame.Paragraphs.Count; i++)
        {
            Aspose.Slides.IParagraph paragraph = autoShape.TextFrame.Paragraphs[i];
            Aspose.Slides.Animation.IEffect paragraphEffect = mainSequence.AddEffect(
                paragraph,
                Aspose.Slides.Animation.EffectType.Fly,
                Aspose.Slides.Animation.EffectSubtype.Left,
                Aspose.Slides.Animation.EffectTriggerType.OnClick);
            // Optional: set a trigger delay of half a second
            paragraphEffect.Timing.TriggerDelayTime = 0.5f;
        }

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}