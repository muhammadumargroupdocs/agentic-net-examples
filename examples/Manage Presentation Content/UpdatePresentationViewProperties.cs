using System;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Define data directory and file paths
        string dataDir = "Data\\";
        string inputPath = dataDir + "input.pptx";
        string outputPath = dataDir + "output.ppt";

        // Load the existing presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Update view properties
        // Set grid spacing (points)
        presentation.ViewProperties.GridSpacing = 10.0f;

        // Set the last view mode to Slide Master view
        presentation.ViewProperties.LastView = Aspose.Slides.ViewType.SlideMasterView;

        // Modify normal view properties
        presentation.ViewProperties.NormalViewProperties.HorizontalBarState = Aspose.Slides.SplitterBarStateType.Restored;
        presentation.ViewProperties.NormalViewProperties.VerticalBarState = Aspose.Slides.SplitterBarStateType.Maximized;
        presentation.ViewProperties.NormalViewProperties.ShowOutlineIcons = true;

        // Save the presentation in PPT format
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt);

        // Dispose the presentation object
        presentation.Dispose();
    }
}