using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

namespace CustomizeChartMarker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a line chart with markers
            Aspose.Slides.Charts.IChart chart = slide.Shapes.AddChart(
                Aspose.Slides.Charts.ChartType.LineWithMarkers, 0, 0, 400, 400);

            // Workbook for chart data
            int defaultWorksheetIndex = 0;
            Aspose.Slides.Charts.IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

            // Clear any default series and add a new one
            chart.ChartData.Series.Clear();
            chart.ChartData.Series.Add(
                workbook.GetCell(defaultWorksheetIndex, 1, 1, "Series 1"), chart.Type);

            // Load images to be used as marker fills
            Aspose.Slides.IImage img1 = Aspose.Slides.Images.FromFile("image1.png");
            Aspose.Slides.IPPImage imgx1 = presentation.Images.AddImage(img1);
            Aspose.Slides.IImage img2 = Aspose.Slides.Images.FromFile("image2.png");
            Aspose.Slides.IPPImage imgx2 = presentation.Images.AddImage(img2);

            // Get the series reference
            Aspose.Slides.Charts.IChartSeries series = chart.ChartData.Series[0];

            // First data point with first image as marker fill
            Aspose.Slides.Charts.IChartDataPoint point1 = series.DataPoints.AddDataPointForLineSeries(
                workbook.GetCell(defaultWorksheetIndex, 1, 1, 10));
            point1.Marker.Format.Fill.FillType = Aspose.Slides.FillType.Picture;
            point1.Marker.Format.Fill.PictureFillFormat.Picture.Image = imgx1;

            // Second data point with second image as marker fill
            Aspose.Slides.Charts.IChartDataPoint point2 = series.DataPoints.AddDataPointForLineSeries(
                workbook.GetCell(defaultWorksheetIndex, 2, 1, 20));
            point2.Marker.Format.Fill.FillType = Aspose.Slides.FillType.Picture;
            point2.Marker.Format.Fill.PictureFillFormat.Picture.Image = imgx2;

            // Third data point with first image again
            Aspose.Slides.Charts.IChartDataPoint point3 = series.DataPoints.AddDataPointForLineSeries(
                workbook.GetCell(defaultWorksheetIndex, 3, 1, 30));
            point3.Marker.Format.Fill.FillType = Aspose.Slides.FillType.Picture;
            point3.Marker.Format.Fill.PictureFillFormat.Picture.Image = imgx1;

            // Fourth data point with second image again
            Aspose.Slides.Charts.IChartDataPoint point4 = series.DataPoints.AddDataPointForLineSeries(
                workbook.GetCell(defaultWorksheetIndex, 4, 1, 40));
            point4.Marker.Format.Fill.FillType = Aspose.Slides.FillType.Picture;
            point4.Marker.Format.Fill.PictureFillFormat.Picture.Image = imgx2;

            // Set marker size for the series
            series.Marker.Size = 12; // size in points

            // Save the presentation
            presentation.Save("CustomizedMarkerChart.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}