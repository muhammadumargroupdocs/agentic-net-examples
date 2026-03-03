using System;

class Program
{
    static void Main()
    {
        var inputPath = "input.pptx";
        var outputPath = "output.ppt";

        var presentation = new Aspose.Slides.Presentation(inputPath);
        var options = new Aspose.Slides.Export.PptOptions();

        presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Ppt, options);
        presentation.Dispose();
    }
}