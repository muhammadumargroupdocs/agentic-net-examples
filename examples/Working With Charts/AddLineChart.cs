class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a line chart to the first slide
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.Line, 50, 50, 500, 400);

        // Add an exponential trendline to the first series
        Aspose.Slides.Charts.ITrendline trendlineExp = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Exponential);
        trendlineExp.DisplayEquation = false;
        trendlineExp.DisplayRSquaredValue = false;

        // Add a linear trendline and set its line color to red
        Aspose.Slides.Charts.ITrendline trendlineLin = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Linear);
        trendlineLin.Format.Line.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        trendlineLin.Format.Line.FillFormat.SolidFillColor.Color = System.Drawing.Color.Red;

        // Add a logarithmic trendline and override its label text
        Aspose.Slides.Charts.ITrendline trendlineLog = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Logarithmic);
        trendlineLog.AddTextFrameForOverriding("Log Trendline");

        // Add a moving average trendline with a period of 3 and a custom name
        Aspose.Slides.Charts.ITrendline trendlineMA = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.MovingAverage);
        trendlineMA.Period = 3;
        trendlineMA.TrendlineName = "MA 3";

        // Add a polynomial trendline of order 2 and extend it forward by 1 category
        Aspose.Slides.Charts.ITrendline trendlinePoly = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Polynomial);
        trendlinePoly.Order = 2;
        trendlinePoly.Forward = 1;

        // Add a power trendline and extend it backward by 1 category
        Aspose.Slides.Charts.ITrendline trendlinePower = chart.ChartData.Series[0].TrendLines.Add(
            Aspose.Slides.Charts.TrendlineType.Power);
        trendlinePower.Backward = 1;

        // Save the presentation
        presentation.Save("LineChartWithTrendlines.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}