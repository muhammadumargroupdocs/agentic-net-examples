class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a bubble chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Bubble,
            50f, 50f, 600f, 400f, true);

        // Get the first series of the chart
        Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

        // Configure X error bars
        Aspose.Slides.Charts.IErrorBarsFormat errorBarsX = series.ErrorBarsXFormat;
        errorBarsX.IsVisible = true;
        errorBarsX.ValueType = Aspose.Slides.Charts.ErrorBarValueType.Fixed;
        errorBarsX.Value = 0.5f;
        errorBarsX.Type = Aspose.Slides.Charts.ErrorBarType.Plus;
        errorBarsX.HasEndCap = true;

        // Configure Y error bars
        Aspose.Slides.Charts.IErrorBarsFormat errorBarsY = series.ErrorBarsYFormat;
        errorBarsY.IsVisible = true;
        errorBarsY.ValueType = Aspose.Slides.Charts.ErrorBarValueType.Percentage;
        errorBarsY.Value = 10;
        errorBarsY.Format.Line.Width = 2;

        // Save the presentation
        presentation.Save("ErrorBarsExample.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}