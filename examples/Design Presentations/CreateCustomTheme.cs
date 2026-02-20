using System;
using Aspose.Slides;

namespace DesignPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Access the first master slide
            Aspose.Slides.IMasterSlide masterSlide = presentation.Masters[0];

            // Get the master theme manager from the master slide
            Aspose.Slides.Theme.IMasterThemeManager masterThemeManager = masterSlide.ThemeManager;

            // Enable overriding the master theme
            masterThemeManager.IsOverrideThemeEnabled = true;

            // Retrieve the current master theme (read-only) and set a custom name
            Aspose.Slides.Theme.IMasterTheme masterTheme = presentation.MasterTheme;
            masterTheme.Name = "CustomTheme";

            // Save the presentation
            string outputPath = "CustomThemePresentation.pptx";
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}