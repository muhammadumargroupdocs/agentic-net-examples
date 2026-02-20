using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;

namespace ChartDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Presentation pres = new Presentation();

            // Get the first slide
            ISlide slide = pres.Slides[0];

            // -------------------- Treemap Chart --------------------
            IChart treemapChart = slide.Shapes.AddChart(ChartType.Treemap, 50, 50, 500, 400);
            treemapChart.ChartData.Categories.Clear();
            treemapChart.ChartData.Series.Clear();

            IChartDataWorkbook wb = treemapChart.ChartData.ChartDataWorkbook;
            wb.Clear(0); // clear existing data

            // Add categories (leaves) with grouping levels
            IChartCategory leaf = treemapChart.ChartData.Categories.Add(wb.GetCell(0, "C1", "Leaf1"));
            leaf.GroupingLevels.SetGroupingItem(0, "Stem1");
            leaf.GroupingLevels.SetGroupingItem(1, "Branch1");

            treemapChart.ChartData.Categories.Add(wb.GetCell(0, "C2", "Leaf2"));
            leaf = treemapChart.ChartData.Categories.Add(wb.GetCell(0, "C3", "Leaf3"));
            leaf.GroupingLevels.SetGroupingItem(0, "Stem2");
            leaf.GroupingLevels.SetGroupingItem(1, "Branch2");
            treemapChart.ChartData.Categories.Add(wb.GetCell(0, "C4", "Leaf4"));

            // Add series and data points
            IChartSeries treemapSeries = treemapChart.ChartData.Series.Add(ChartType.Treemap);
            treemapSeries.Labels.DefaultDataLabelFormat.ShowCategoryName = true;
            treemapSeries.DataPoints.AddDataPointForTreemapSeries(wb.GetCell(0, "D1", 10));
            treemapSeries.DataPoints.AddDataPointForTreemapSeries(wb.GetCell(0, "D2", 20));
            treemapSeries.DataPoints.AddDataPointForTreemapSeries(wb.GetCell(0, "D3", 30));
            treemapSeries.DataPoints.AddDataPointForTreemapSeries(wb.GetCell(0, "D4", 40));
            treemapSeries.ParentLabelLayout = ParentLabelLayoutType.Overlapping;

            // -------------------- Sunburst Chart --------------------
            IChart sunburstChart = slide.Shapes.AddChart(ChartType.Sunburst, 50, 500, 500, 400);
            sunburstChart.ChartData.Categories.Clear();
            sunburstChart.ChartData.Series.Clear();

            IChartDataWorkbook wbSun = sunburstChart.ChartData.ChartDataWorkbook;
            wbSun.Clear(0);

            // Add categories (leaves) with grouping levels
            IChartCategory sunLeaf = sunburstChart.ChartData.Categories.Add(wbSun.GetCell(0, "C1", "Sector1"));
            sunLeaf.GroupingLevels.SetGroupingItem(0, "Root");
            sunLeaf.GroupingLevels.SetGroupingItem(1, "Level1");

            sunburstChart.ChartData.Categories.Add(wbSun.GetCell(0, "C2", "Sector2"));
            sunLeaf = sunburstChart.ChartData.Categories.Add(wbSun.GetCell(0, "C3", "Sector3"));
            sunLeaf.GroupingLevels.SetGroupingItem(0, "Root");
            sunLeaf.GroupingLevels.SetGroupingItem(1, "Level2");
            sunburstChart.ChartData.Categories.Add(wbSun.GetCell(0, "C4", "Sector4"));

            // Add series and data points
            IChartSeries sunburstSeries = sunburstChart.ChartData.Series.Add(ChartType.Sunburst);
            sunburstSeries.Labels.DefaultDataLabelFormat.ShowCategoryName = true;
            sunburstSeries.DataPoints.AddDataPointForSunburstSeries(wbSun.GetCell(0, "D1", 15));
            sunburstSeries.DataPoints.AddDataPointForSunburstSeries(wbSun.GetCell(0, "D2", 25));
            sunburstSeries.DataPoints.AddDataPointForSunburstSeries(wbSun.GetCell(0, "D3", 35));
            sunburstSeries.DataPoints.AddDataPointForSunburstSeries(wbSun.GetCell(0, "D4", 45));

            // Save the presentation
            pres.Save("TreemapSunburstDemo.pptx", SaveFormat.Pptx);
        }
    }
}