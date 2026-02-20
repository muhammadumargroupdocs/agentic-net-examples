using System;
using Aspose.Slides;
using Aspose.Slides.Animation;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Output file path
        string outputPath = "AnimatedChart.pptx";

        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Get the first slide
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Add a clustered column chart to the slide
        Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn,
            50f, 50f, 600f, 400f);

        // Prepare sample data for the chart
        Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;
        chart.ChartData.Categories.Clear();
        chart.ChartData.Series.Clear();

        chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 1, "Category 1"));
        chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 2, "Category 2"));
        chart.ChartData.Categories.Add(workbook.GetCell(0, 0, 3, "Category 3"));

        chart.ChartData.Series.Add(workbook.GetCell(0, 1, 0, "Series 1"), chart.Type);
        chart.ChartData.Series[0].DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 1, 20));
        chart.ChartData.Series[0].DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 2, 50));
        chart.ChartData.Series[0].DataPoints.AddDataPointForBarSeries(workbook.GetCell(0, 1, 3, 30));

        // Add a fade effect for the whole chart
        slide.Timeline.MainSequence.AddEffect(
            chart,
            Aspose.Slides.Animation.EffectType.Fade,
            Aspose.Slides.Animation.EffectSubtype.None,
            Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);

        // Animate each series individually
        int seriesCount = chart.ChartData.Series.Count;
        for (int s = 0; s < seriesCount; s++)
        {
            ((Aspose.Slides.Animation.Sequence)slide.Timeline.MainSequence).AddEffect(
                chart,
                Aspose.Slides.Animation.EffectChartMajorGroupingType.BySeries,
                s,
                Aspose.Slides.Animation.EffectType.Appear,
                Aspose.Slides.Animation.EffectSubtype.None,
                Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);
        }

        // Animate each data point within each series
        for (int s = 0; s < seriesCount; s++)
        {
            Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[s];
            int pointCount = series.DataPoints.Count;
            for (int p = 0; p < pointCount; p++)
            {
                ((Aspose.Slides.Animation.Sequence)slide.Timeline.MainSequence).AddEffect(
                    chart,
                    Aspose.Slides.Animation.EffectChartMinorGroupingType.ByElementInSeries,
                    s,
                    p,
                    Aspose.Slides.Animation.EffectType.Appear,
                    Aspose.Slides.Animation.EffectSubtype.None,
                    Aspose.Slides.Animation.EffectTriggerType.AfterPrevious);
            }
        }

        // Save the presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}