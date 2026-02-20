using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

namespace DataMarkersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paths for output presentation and marker images
            string outputPath = "DataMarkers.pptx";
            string imagePath1 = "marker1.png";
            string imagePath2 = "marker2.png";

            // Create a new presentation
            Presentation presentation = new Presentation();

            // Get the first slide
            ISlide slide = presentation.Slides[0];

            // Add a line chart with markers
            IChart chart = slide.Shapes.AddChart(ChartType.LineWithMarkers, 0, 0, 400, 400);

            // Access the chart's workbook
            int defaultWorksheetIndex = 0;
            IChartDataWorkbook workbook = chart.ChartData.ChartDataWorkbook;

            // Clear any default series and add a new one
            chart.ChartData.Series.Clear();
            chart.ChartData.Series.Add(workbook.GetCell(defaultWorksheetIndex, 1, 1, "Series 1"), chart.Type);

            // Load marker images and add them to the presentation's image collection
            IImage img1 = Aspose.Slides.Images.FromFile(imagePath1);
            IPPImage imgx1 = presentation.Images.AddImage(img1);
            IImage img2 = Aspose.Slides.Images.FromFile(imagePath2);
            IPPImage imgx2 = presentation.Images.AddImage(img2);

            // Get the created series
            IChartSeries series = chart.ChartData.Series[0];

            // Add data points with picture markers
            IChartDataPoint point1 = series.DataPoints.AddDataPointForLineSeries(workbook.GetCell(defaultWorksheetIndex, 1, 1, 10));
            point1.Marker.Format.Fill.FillType = Aspose.Slides.FillType.Picture;
            point1.Marker.Format.Fill.PictureFillFormat.Picture.Image = imgx1;

            IChartDataPoint point2 = series.DataPoints.AddDataPointForLineSeries(workbook.GetCell(defaultWorksheetIndex, 2, 1, 20));
            point2.Marker.Format.Fill.FillType = Aspose.Slides.FillType.Picture;
            point2.Marker.Format.Fill.PictureFillFormat.Picture.Image = imgx2;

            IChartDataPoint point3 = series.DataPoints.AddDataPointForLineSeries(workbook.GetCell(defaultWorksheetIndex, 3, 1, 30));
            point3.Marker.Format.Fill.FillType = Aspose.Slides.FillType.Picture;
            point3.Marker.Format.Fill.PictureFillFormat.Picture.Image = imgx1;

            IChartDataPoint point4 = series.DataPoints.AddDataPointForLineSeries(workbook.GetCell(defaultWorksheetIndex, 4, 1, 40));
            point4.Marker.Format.Fill.FillType = Aspose.Slides.FillType.Picture;
            point4.Marker.Format.Fill.PictureFillFormat.Picture.Image = imgx2;

            // Set marker size for the series
            series.Marker.Size = 10;

            // Save the presentation
            presentation.Save(outputPath, SaveFormat.Pptx);
        }
    }
}