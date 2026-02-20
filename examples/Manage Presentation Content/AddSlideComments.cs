using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add a second empty slide
        presentation.Slides.AddEmptySlide(presentation.LayoutSlides[0]);

        // Add a comment author
        Aspose.Slides.ICommentAuthor author = presentation.CommentAuthors.AddAuthor("John Doe", "JD");

        // Define comment position
        System.Drawing.PointF position = new System.Drawing.PointF(0.2f, 0.2f);

        // Add comments to first and second slides
        author.Comments.AddComment("First slide comment", presentation.Slides[0], position, DateTime.Now);
        author.Comments.AddComment("Second slide comment", presentation.Slides[1], position, DateTime.Now);

        // Retrieve comments from first slide for this author
        Aspose.Slides.ISlide slide0 = presentation.Slides[0];
        Aspose.Slides.IComment[] slide0Comments = slide0.GetSlideComments(author);

        // Retrieve comments from second slide (all authors)
        Aspose.Slides.ISlide slide1 = presentation.Slides[1];
        Aspose.Slides.IComment[] slide1Comments = slide1.GetSlideComments(null);

        // Save the presentation in PPT format
        presentation.Save("CommentsPresentation.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
    }
}