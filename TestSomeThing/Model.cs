namespace TestSomeThing
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";
    }

    public class Post
    {
        public int Id { get; set; }

        public string Content { get; set; } = "";
    }

    public class Comment
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public string Content { get; set; } = "";

        public virtual List<Reply>? Replies { get; set; }
    }

    public class Reply
    {
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public int CommentId { get; set; }

        public string Content { get; set; } = "";

        public int? ParentReplyId { get; set; }

        public int? ReplyLevel { get; set; }
    }

    public class ReplyRequest
    {
        public string Content { get; set; } = "";

        public int? ReplyId { get; set; }
    }

    public class DataResponse
    {
        public int PostId { get; set; }

        public List<Comment>? Comments { get; set; }
    }
}

