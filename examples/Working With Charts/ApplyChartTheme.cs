using System;
using Aspose.Slides;
using Aspose.Slides.Charts;
using Aspose.Slides.Export;
using Aspose.Slides.Theme;

class Program
{
    static void Main()
    {
        // Create a new presentation.
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a clustered column chart to the first slide.
        Aspose.Slides.Charts.IChart chart = presentation.Slides[0].Shapes.AddChart(
            Aspose.Slides.Charts.ChartType.ClusteredColumn, 50f, 50f, 600f, 400f);

        // Access the chart's theme manager.
        Aspose.Slides.Theme.IOverrideThemeManager themeManager = chart.ThemeManager;

        // Get the overriding theme object.
        Aspose.Slides.Theme.IOverrideTheme overrideTheme = themeManager.OverrideTheme;

        // Initialize the color scheme to enable overriding.
        overrideTheme.InitColorScheme();

        // Example: change the first accent color (optional).
        // overrideTheme.ColorScheme.Accent1.Color = System.Drawing.Color.Red;

        // Save the presentation.
        string outputPath = "ApplyChartTheme.pptx";
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
    }
}