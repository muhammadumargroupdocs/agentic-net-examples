using System;

class Program
{
    static void Main(string[] args)
    {
        int scaleX = 2;
        int scaleY = scaleX;
        System.String inputPath = "input.pptx";
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation(inputPath);
        foreach (Aspose.Slides.ISlide slide in presentation.Slides)
        {
            using (Aspose.Slides.IImage thumbnail = slide.GetImage(scaleX, scaleY))
            {
                System.String imageFileName = System.String.Format("Slide_{0}.jpg", slide.SlideNumber);
                thumbnail.Save(imageFileName, Aspose.Slides.ImageFormat.Jpeg);
            }
        }
        presentation.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
    }
}