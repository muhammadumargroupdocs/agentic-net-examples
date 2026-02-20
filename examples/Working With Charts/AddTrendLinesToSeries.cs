class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a clustered column chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 500f, 400f);

        // Add an exponential trend line to the first series
        Aspose.Slides.Charts.ITrendline expTrend = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Exponential);
        expTrend.DisplayEquation = false;
        expTrend.DisplayRSquaredValue = false;

        // Add a linear trend line and set its line color to red
        Aspose.Slides.Charts.ITrendline linearTrend = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Linear);
        linearTrend.Format.Line.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        linearTrend.Format.Line.FillFormat.SolidFillColor.Color = System.Drawing.Color.Red;

        // Add a logarithmic trend line with custom text
        Aspose.Slides.Charts.ITrendline logTrend = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Logarithmic);
        logTrend.AddTextFrameForOverriding("Log Trend");

        // Add a moving average trend line with period and name
        Aspose.Slides.Charts.ITrendline maTrend = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.MovingAverage);
        maTrend.Period = 3;
        maTrend.TrendlineName = "MA 3";

        // Add a polynomial trend line with order and forward value
        Aspose.Slides.Charts.ITrendline polyTrend = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Polynomial);
        polyTrend.Order = 2;
        polyTrend.Forward = 1.0;

        // Add a power trend line with backward value
        Aspose.Slides.Charts.ITrendline powerTrend = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Power);
        powerTrend.Backward = 0.5;

        // Save the presentation
        presentation.Save("TrendLinesDemo.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}