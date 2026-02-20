using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Define input and output file paths
        string dataDir = Path.Combine(Environment.CurrentDirectory, "Data");
        string inputPath = Path.Combine(dataDir, "input.pptx");
        string outputPath = Path.Combine(dataDir, "output.pptx");

        // Load the presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);

        // Modify the first master slide's background to a solid forest green color
        presentation.Masters[0].Background.Type = Aspose.Slides.BackgroundType.OwnBackground;
        presentation.Masters[0].Background.FillFormat.FillType = Aspose.Slides.FillType.Solid;
        presentation.Masters[0].Background.FillFormat.SolidFillColor.Color = Color.ForestGreen;

        // Save the modified presentation
        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
        presentation.Dispose();
    }
}