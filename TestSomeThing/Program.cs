using Newtonsoft.Json;
using TestSomeThing;

var postFunc = DummyData.Post;
var post = postFunc.Invoke();
var comments = DummyData.Comments();
var replies = DummyData.Replies();
var request = new ReplyRequest
{
    Content = "Reply 3 for reply 2",
    ReplyId = 2
};

if (request.ReplyId is not null)
{
    var replyByReplyId = new Reply();
    var commentId = 0;
    var replyLevel = 0;
    var replyId = request.ReplyId;

    while (replyId is not null)
    {
        replyByReplyId = replies.FirstOrDefault(r => r.Id == replyId);

        if (replyByReplyId is not null)
        {
            commentId = replyByReplyId.CommentId;
            replyLevel++;

            if (!replyByReplyId.ParentReplyId.HasValue)
                break;

            replyId = replyByReplyId.ParentReplyId;
        }
        else
        {
            replyId = null;
        }
    }

    if (replyLevel > 0)
    {
        var lastReplies = replies
            .OrderByDescending(x => x.Id)
            .First();

        var newId = lastReplies.Id + 1;

        var reply = new Reply()
        {
            Id = newId,
            Name = "Reply " + newId,
            Content = request.Content,
            ParentReplyId = request.ReplyId,
            CommentId = commentId,
            ReplyLevel = replyLevel
        };

        replies.Add(reply);

        var repliesOrder = replies
            .OrderBy(r => r.ReplyLevel)
            .ThenBy(r => r.Id);

        foreach (var replyItem in repliesOrder)
            Console.WriteLine($"Reply = {JsonConvert.SerializeObject(replyItem)}");
    }
}

var commentResponeses = comments
    .Where(c => c.PostId == post.Id)
    .ToList();

if (commentResponeses is not null && commentResponeses.Any())
{
    var commentIds = commentResponeses
        .Select(x => x.Id)
        .ToList();

    var repliesByComentIds = replies
        .Where(x => commentIds.Contains(x.CommentId))
        .ToList();

    foreach (var item in commentResponeses)
    {
        var repliesByComentId = repliesByComentIds
            .FindAll(x => x.CommentId == item.Id);

        item.Replies = repliesByComentId;
    }
}

var response = new DataResponse
{
    PostId = post.Id,
    Comments = commentResponeses ?? new List<Comment>(),
};

Console.WriteLine("");
Console.WriteLine($"Response = {JsonConvert.SerializeObject(response)}");
Console.ReadLine();