using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main(string[] args)
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a second empty slide
        presentation.Slides.AddEmptySlide(presentation.LayoutSlides[0]);

        // Add a comment author
        Aspose.Slides.ICommentAuthor author = presentation.CommentAuthors.AddAuthor("John Doe", "JD");

        // Set comment position
        System.Drawing.PointF position = new System.Drawing.PointF(0.2f, 0.2f);

        // Add comment to first slide
        author.Comments.AddComment("First slide comment", presentation.Slides[0], position, System.DateTime.Now);

        // Add comment to second slide
        author.Comments.AddComment("Second slide comment", presentation.Slides[1], position, System.DateTime.Now);

        // Save presentation in PPT format
        presentation.Save("CommentsPresentation.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
    }
}