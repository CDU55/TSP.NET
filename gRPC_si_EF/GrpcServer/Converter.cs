using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostComment;

namespace GrpcServer
{
    public static class Converter
    {
        public static PostDTO ToPostDto(Post post)
        {
            PostDTO result = new PostDTO();
            result.PostId = post.PostId;
            result.Description = post.Description;
            result.Domain = post.Domain;
            List<Int32> ids = new List<int>();
            foreach (var comm in post.Comments)
            {
                result.CommentsId.Add(comm.CommentId);
            }

            return result;
        }

        public static CommentDTO ToCommentDto(Comment comment)
        {
            CommentDTO result = new CommentDTO();
            result.CommentId = comment.CommentId;
            result.Text = comment.Text;
            if (comment.Post != null)
            {
                result.CommentId = comment.CommentId;
            }

            return result;
        }
    }
}
