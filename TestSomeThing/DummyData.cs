namespace TestSomeThing
{
    public class DummyData
    {
        public static Post Post()
        {
            return new Post
            {
                Id = 1,
                Content = "Post 1"
            };
        }

        public static List<Comment> Comments()
        {
            return new List<Comment>
            {
                 new Comment()
                 {
                     Id = 1,
                     Content = "Comment 1 for Post 1",
                     PostId = 1
                 },
                 new Comment()
                 {
                     Id = 2,
                     Content = "Comment 2 for Post 1",
                     PostId = 1
                 }
            };
        }

        public static List<Reply> Replies()
        {
            return new List<Reply>
            {
                new Reply()
                {
                    Id = 1,
                    Name = "Reply 1",
                    Content = "Reply 1 for comment 1",
                    ParentReplyId = null,
                    CommentId = 1 ,
                    ReplyLevel = null
                },
                new Reply()
                {
                    Id = 2,
                    Name = "Reply 2",
                    Content = "Reply 1 for reply 1",
                    ParentReplyId = 1,
                    CommentId = 1 ,
                    ReplyLevel = 1
                },
                new Reply()
                {
                    Id = 3,
                    Name = "Reply 3",
                    Content = "Reply 1 for reply 2",
                    ParentReplyId = 2,
                    CommentId = 1 ,
                    ReplyLevel = 2
                },
                new Reply()
                {
                    Id = 4,
                    Name = "Reply 4",
                    Content = "Reply 1 for reply 3",
                    ParentReplyId = 3,
                    CommentId = 1 ,
                    ReplyLevel = 3
                },
                new Reply()
                {
                    Id = 5,
                    Name = "Reply 5",
                    Content = "Reply 1 for reply 4",
                    ParentReplyId = 4,
                    CommentId = 1 ,
                    ReplyLevel = 4
                },
                new Reply()
                {
                    Id = 6,
                    Name = "Reply 6",
                    Content = "Reply 2 for reply 2",
                    ParentReplyId = 2,
                    CommentId = 1 ,
                    ReplyLevel = 2
                }
            };
        }
    }
}
