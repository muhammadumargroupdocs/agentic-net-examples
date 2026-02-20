using System;
using Aspose.Slides;
using Aspose.Slides.Animation;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Paths
        string inputPath = "input.pptx";
        string outputPath = "output_animated.pptx";

        // Create presentation (using worksheets-example rule)
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(Aspose.Slides.Charts.ChartType.Pie, 50, 50, 400, 500);
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Animate chart (using animating-series-elements rule)
        Aspose.Slides.ISlide slide = presentation.Slides[0];
        Aspose.Slides.IShape shape = slide.Shapes[0];
        Aspose.Slides.Charts.IChart animChart = shape as Aspose.Slides.Charts.IChart;
        if (animChart == null)
            return;
        slide.Timeline.MainSequence.AddEffect(
            animChart,
            Aspose.Slides.Animation.EffectType.Fade,
            Aspose.Slides.Animation.EffectSubtype.None,
            Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);
        System.Int32 seriesCount = animChart.ChartData.Series.Count;
        for (System.Int32 s = 0; s < seriesCount; s++)
            ((Aspose.Slides.Animation.Sequence)slide.Timeline.MainSequence).AddEffect(
                animChart,
                Aspose.Slides.Animation.EffectChartMajorGroupingType.BySeries,
                s,
                Aspose.Slides.Animation.EffectType.Appear,
                Aspose.Slides.Animation.EffectSubtype.None,
                Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);
        for (System.Int32 s = 0; s < seriesCount; s++)
        {
            Aspose.Slides.Charts.IChartSeries series = animChart.ChartData.Series[s];
            System.Int32 pointCount = series.DataPoints.Count;
            for (System.Int32 p = 0; p < pointCount; p++)
                ((Aspose.Slides.Animation.Sequence)slide.Timeline.MainSequence).AddEffect(
                    animChart,
                    Aspose.Slides.Animation.EffectChartMinorGroupingType.ByElementInSeries,
                    s,
                    p,
                    Aspose.Slides.Animation.EffectType.Appear,
                    Aspose.Slides.Animation.EffectSubtype.None,
                    Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);
        }

        // Save the final animated presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}