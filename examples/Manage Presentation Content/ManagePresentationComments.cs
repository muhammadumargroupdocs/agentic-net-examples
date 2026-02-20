using System;
using System.Drawing;
using Aspose.Slides;
using Aspose.Slides.Export;

class Program
{
    static void Main()
    {
        // Create a new presentation
        Aspose.Slides.Presentation presentation = new Aspose.Slides.Presentation();

        // Add first comment author
        Aspose.Slides.ICommentAuthor author1 = presentation.CommentAuthors.AddAuthor("Alice", "AL");
        // Add a top-level comment by author1 on the first slide
        Aspose.Slides.IComment comment1 = author1.Comments.AddComment(
            "First comment",
            presentation.Slides[0],
            new System.Drawing.PointF(0.2f, 0.2f),
            System.DateTime.Now);

        // Add second comment author
        Aspose.Slides.ICommentAuthor author2 = presentation.CommentAuthors.AddAuthor("Bob", "BO");
        // Add a reply comment by author2 on the first slide
        Aspose.Slides.IComment comment2 = author2.Comments.AddComment(
            "Reply to first comment",
            presentation.Slides[0],
            new System.Drawing.PointF(0.3f, 0.3f),
            System.DateTime.Now);
        // Set parent comment to create a reply relationship
        comment2.ParentComment = comment1;

        // Add another top-level comment by author1
        Aspose.Slides.IComment comment3 = author1.Comments.AddComment(
            "Another top-level comment",
            presentation.Slides[0],
            new System.Drawing.PointF(0.4f, 0.4f),
            System.DateTime.Now);
        // Add a reply to the second top-level comment by author2
        Aspose.Slides.IComment comment4 = author2.Comments.AddComment(
            "Reply to another comment",
            presentation.Slides[0],
            new System.Drawing.PointF(0.5f, 0.5f),
            System.DateTime.Now);
        comment4.ParentComment = comment3;

        // Save the presentation in PPT format
        presentation.Save("CommentsPresentation.ppt", Aspose.Slides.Export.SaveFormat.Ppt);
        // Dispose the presentation object
        presentation.Dispose();
    }
}