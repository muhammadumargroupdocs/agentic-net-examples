using System;
using System.IO;
using Aspose.Slides;
using Aspose.Slides.Export;
using Aspose.Slides.DOM.Ole;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new presentation
            Aspose.Slides.Presentation pres = new Aspose.Slides.Presentation();

            // Paths to the source Excel file and the icon image
            System.String sourceFilePath = "sample.xlsx";
            System.String iconFilePath = "icon.png";

            // Get the first slide
            Aspose.Slides.ISlide slide = pres.Slides[0];

            // Read the Excel file bytes
            System.Byte[] excelBytes = System.IO.File.ReadAllBytes(sourceFilePath);

            // Create OLE embedded data info for the Excel file
            Aspose.Slides.IOleEmbeddedDataInfo dataInfo = new OleEmbeddedDataInfo(excelBytes, ".xlsx");

            // Add an OLE object frame to the slide
            Aspose.Slides.IOleObjectFrame oleObject = slide.Shapes.AddOleObjectFrame(50, 50, 200, 200, dataInfo);

            // Display the OLE object as an icon
            oleObject.IsObjectIcon = true;

            // Read the icon image bytes and create a memory stream
            System.Byte[] iconBytes = System.IO.File.ReadAllBytes(iconFilePath);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(iconBytes);

            // Add the icon image to the presentation
            Aspose.Slides.IPPImage image = pres.Images.AddImage(Aspose.Slides.Images.FromStream(ms));

            // Set the substitute picture for the OLE object icon
            oleObject.SubstitutePictureFormat.Picture.Image = image;

            // Set a title for the OLE object icon
            oleObject.SubstitutePictureTitle = "Excel Document";

            // Save the presentation
            pres.Save("output.pptx", Aspose.Slides.Export.SaveFormat.Pptx);
        }
    }
}