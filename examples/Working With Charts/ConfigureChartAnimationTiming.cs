using System;

class Program
{
    static void Main()
    {
        // Input and output file paths
        System.String inputPath = "input.pptx";
        System.String outputPath = "output.pptx";

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Get the first slide and the first shape (assumed to be a chart)
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        Aspose.Slides.IShape shape = slide.Shapes[0];
        Aspose.Slides.Charts.IChart chart = shape as Aspose.Slides.Charts.IChart;
        if (chart == null)
            return;

        // Add an initial fade effect to the chart
        slide.Timeline.MainSequence.AddEffect(
            chart,
            Aspose.Slides.Animation.EffectType.Fade,
            Aspose.Slides.Animation.EffectSubtype.None,
            Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);

        // Animate each series in the chart
        System.Int32 seriesCount = chart.ChartData.Series.Count;
        for (System.Int32 s = 0; s < seriesCount; s++)
        {
            ((Aspose.Slides.Animation.Sequence)slide.Timeline.MainSequence).AddEffect(
                chart,
                Aspose.Slides.Animation.EffectChartMajorGroupingType.BySeries,
                s,
                Aspose.Slides.Animation.EffectType.Appear,
                Aspose.Slides.Animation.EffectSubtype.None,
                Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);
        }

        // Configure timing for each effect in the main sequence
        Aspose.Slides.Animation.ISequence mainSeq = (Aspose.Slides.Animation.Sequence)slide.Timeline.MainSequence;
        for (System.Int32 i = 0; i < mainSeq.Count; i++)
        {
            Aspose.Slides.Animation.IEffect effect = mainSeq[i];
            effect.Timing.Duration = 2.0f;          // Set duration to 2 seconds
            effect.Timing.RepeatCount = 1;          // Play once
            effect.Timing.AutoReverse = false;      // No auto-reverse
        }

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}