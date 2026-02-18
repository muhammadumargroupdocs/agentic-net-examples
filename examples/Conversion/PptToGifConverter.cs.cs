using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Convert PPT file to GIF
        System.String inputPathPpt = "example.ppt";
        System.String outputPathGifFromPpt = "example_from_ppt.gif";
        Aspose.Slides.Presentation presentationPpt = new Aspose.Slides.Presentation(inputPathPpt);
        Aspose.Slides.Export.GifOptions gifOptionsPpt = new Aspose.Slides.Export.GifOptions();
        gifOptionsPpt.FrameSize = new System.Drawing.Size(800, 600);
        gifOptionsPpt.DefaultDelay = 500;
        gifOptionsPpt.TransitionFps = 25;
        presentationPpt.Save(outputPathGifFromPpt, Aspose.Slides.Export.SaveFormat.Gif, gifOptionsPpt);
        presentationPpt.Dispose();

        // Convert PPTX file to GIF
        System.String inputPathPptx = "example.pptx";
        System.String outputPathGifFromPptx = "example_from_pptx.gif";
        Aspose.Slides.Presentation presentationPptx = new Aspose.Slides.Presentation(inputPathPptx);
        Aspose.Slides.Export.GifOptions gifOptionsPptx = new Aspose.Slides.Export.GifOptions();
        gifOptionsPptx.FrameSize = new System.Drawing.Size(800, 600);
        gifOptionsPptx.DefaultDelay = 500;
        gifOptionsPptx.TransitionFps = 25;
        presentationPptx.Save(outputPathGifFromPptx, Aspose.Slides.Export.SaveFormat.Gif, gifOptionsPptx);
        presentationPptx.Dispose();
    }
}