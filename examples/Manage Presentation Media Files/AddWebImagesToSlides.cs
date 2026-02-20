using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Path to save the generated PPTX file
        string presentationPath = "output.pptx";

        // URLs of images to be added to the presentation
        string[] imageUrls = new string[]
        {
            "https://example.com/image1.jpg",
            "https://example.com/image2.png"
        };

        // Create a new presentation (contains one empty slide by default)
        Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

        // Reference to the first slide
        Aspose.Slides.ISlide slide = pres.Slides[0];

        // Initial position and size for picture frames
        int left = 10;
        int top = 10;
        int width = 300;
        int height = 200;

        // Iterate over each image URL, download it, and add to the slide
        foreach (string url in imageUrls)
        {
            // Download image data from the web
            WebClient client = new WebClient();
            byte[] imageData = client.DownloadData(url);
            client.Dispose();

            // Add the image to the presentation's image collection
            Aspose.Slides.IPPImage img = pres.Images.AddImage(imageData);

            // Insert the image as a picture frame on the slide
            slide.Shapes.AddPictureFrame(Aspose.Slides.ShapeType.Rectangle, left, top, width, height, img);

            // Update vertical position for the next image
            top += height + 10;
        }

        // Save the presentation to a PPTX file
        pres.Save(presentationPath, Aspose.Slides.Export.SaveFormat.Pptx);

        // Release resources
        pres.Dispose();
    }
}