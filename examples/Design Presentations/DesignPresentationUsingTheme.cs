using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Theme;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Access the first master slide
        Aspose.Slides.IMasterSlide masterSlide = presentation.Masters[0];

        // Get the master theme manager
        Aspose.Slides.Theme.IMasterThemeManager masterThemeManager = masterSlide.ThemeManager;

        // Enable overriding of the master theme
        masterThemeManager.IsOverrideThemeEnabled = true;

        // Access the overriding master theme (type IMasterTheme)
        Aspose.Slides.Theme.IMasterTheme masterOverrideTheme = masterThemeManager.OverrideTheme;

        // Change the name of the master theme
        masterOverrideTheme.Name = "CustomMasterTheme";

        // Access the first slide in the presentation
        Aspose.Slides.ISlide slide = presentation.Slides[0];

        // Get the slide's override theme manager
        Aspose.Slides.Theme.IOverrideThemeManager slideThemeManager = slide.ThemeManager;

        // Initialize override theme components for the slide
        slideThemeManager.OverrideTheme.InitColorScheme();
        slideThemeManager.OverrideTheme.InitFontScheme();

        // Modify a color in the slide's override color scheme
        slideThemeManager.OverrideTheme.ColorScheme.Accent1.Color = Color.Red;

        // Save the presentation before exiting
        presentation.Save("DesignPresentationUsingTheme.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}