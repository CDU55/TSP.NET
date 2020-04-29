using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using PostComment;

namespace GrpcServer
{
    public class Service : PostCommentService.PostCommentServiceBase
    {
        private readonly ModelPostCommentContainer dbContext;

        public Service()
        {
            this.dbContext = ModelPostCommentContainer.getContext();
        }
        public override Task<CommentDTO> AddComment(CommentAndPostId request, ServerCallContext context)
        {
            var post = dbContext.Posts.FirstOrDefault(p => p.PostId == request.PostId);
            Comment comm = new Comment()
            {
                CommentId = request.Comment.CommentId,
                Text = request.Comment.Text,
                PostPostId = post.PostId,
                Post = post
            };
            post.Comments.Add(comm);
            dbContext.Comments.Add(comm);
            dbContext.SaveChanges();
            return Task.FromResult(Converter.ToCommentDto(comm));
        }

        public override Task<BoolReply> DeleteComment(ObjectIdRequest request, ServerCallContext context)
        {
            bool found = false;
            var comm = dbContext.Comments.FirstOrDefault(c => c.CommentId == request.Id);
            if (comm != null)
            {
                found = true;
                comm.Post.Comments.Remove(comm);
                dbContext.Comments.Remove(comm);
                dbContext.SaveChanges();
            }

            return Task.FromResult(new BoolReply() { Reply = found });
        }

        public override Task<BoolReply> DeletePost(ObjectIdRequest request, ServerCallContext context)
        {
            bool found = false;
            var post = dbContext.Posts.FirstOrDefault(p => p.PostId == request.Id);
            if (post != null)
            {
                found = true;
                foreach (var comm in post.Comments)
                {
                    dbContext.Comments.Remove(comm);
                }

                dbContext.Posts.Remove(post);
                dbContext.SaveChanges();
            }

            return Task.FromResult(new BoolReply() { Reply = found });
        }

        public override Task<CommentDTOCollection> GetAllPostRelateComments(ObjectIdRequest request, ServerCallContext context)
        {
            CommentDTOCollection comments = new CommentDTOCollection();
            var post = dbContext.Posts.FirstOrDefault(p => p.PostId == request.Id);
            if (post != null)
            {
                foreach (var comm in post.Comments)
                {
                    comments.Comments.Add(Converter.ToCommentDto(comm));
                }
            }
            return Task.FromResult(comments);

        }

        public override Task<PostDTOCollenction> GetAllPosts(EmptyMessage request, ServerCallContext context)
        {
            PostDTOCollenction posts = new PostDTOCollenction();
            foreach (var post in dbContext.Posts.ToList())
            {
                posts.Posts.Add(Converter.ToPostDto(post));
            }

            return Task.FromResult(posts);
        }

        public override Task<CommentDTO> GetCommentById(ObjectIdRequest request, ServerCallContext context)
        {
            var comm = dbContext.Comments.FirstOrDefault(c => c.CommentId == request.Id);
            return Task.FromResult(Converter.ToCommentDto(comm));

        }

        public override Task<PostDTO> GetPostById(ObjectIdRequest request, ServerCallContext context)
        {
            var post = dbContext.Posts.FirstOrDefault(p => p.PostId == request.Id);
            return Task.FromResult(Converter.ToPostDto(post));

        }

        public override Task<PostDTO> GetPostByTitle(StringRequest request, ServerCallContext context)
        {
            var post = dbContext.Posts.FirstOrDefault(p => p.Description == request.StringParam);
            return Task.FromResult(Converter.ToPostDto(post));
        }

        public override Task<CommentDTO> SubmitComment(CommentDTO request, ServerCallContext context)
        {
            Comment comm = new Comment() { Text = request.Text };
            var post = dbContext.Posts.FirstOrDefault(p => p.PostId == request.PostId);
            comm.Post = post;
            comm.PostPostId = post.PostId;
            post.Comments.Add(comm);
            dbContext.SaveChanges();
            return Task.FromResult(Converter.ToCommentDto(comm));
        }

        public override Task<PostDTO> SubmitPost(PostDTO request, ServerCallContext context)
        {
            Post post = new Post() { Description = request.Description, Domain = request.Domain };
            dbContext.Posts.Add(post);
            dbContext.SaveChanges();
            return Task.FromResult(Converter.ToPostDto(post));
        }

        public override Task<CommentDTO> UpdateComment(UpdateCommentMessage request, ServerCallContext context)
        {
            var comm = dbContext.Comments.FirstOrDefault(c => c.CommentId == request.Old.CommentId);
            comm.Text = request.New.Text;
            var post = dbContext.Posts.FirstOrDefault(p => p.PostId == request.New.PostId);
            comm.Post.Comments.Remove(comm);
            post.Comments.Add(comm);
            comm.PostPostId = post.PostId;
            comm.Post = post;
            return Task.FromResult(Converter.ToCommentDto(comm));
        }

        public override Task<PostDTO> UpdatePost(PostDTO request, ServerCallContext context)
        {
            var post = dbContext.Posts.FirstOrDefault(p => p.PostId == request.PostId);
            post.Description = request.Description;
            post.Domain = request.Domain;
            dbContext.SaveChanges();
            return Task.FromResult(Converter.ToPostDto(post));
        }
    }
}
