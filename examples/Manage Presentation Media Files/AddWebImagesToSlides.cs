using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // URL of the image to download
            string imageUrl = "https://example.com/image.jpg";
            // Output PPTX file path
            string outputPath = "output.pptx";

            // Download image data from the web
            System.Net.WebClient webClient = new System.Net.WebClient();
            byte[] imageData = webClient.DownloadData(imageUrl);
            webClient.Dispose();

            // Create a new presentation
            Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

            // Add the downloaded image to the presentation's image collection
            Aspose.Slides.IPPImage pptImage = presentation.Images.AddImage(imageData);

            // Get the first slide
            Aspose.Slides.ISlide slide = presentation.Slides[0];

            // Add a picture frame with the downloaded image
            slide.Shapes.AddPictureFrame(Aspose.Slides.ShapeType.Rectangle, 50, 150, 400, 300, pptImage);

            // Add a heading shape (title) to the slide
            Aspose.Slides.IAutoShape headingShape = (Aspose.Slides.IAutoShape)slide.Shapes.AddAutoShape(Aspose.Slides.ShapeType.Rectangle, 50, 50, 400, 50);
            headingShape.TextFrame.Text = "Sample Heading";

            // Save the presentation as PPTX
            presentation.Save(outputPath, Aspose.Slides.Export.SaveFormat.Pptx);
            presentation.Dispose();
        }
    }
}