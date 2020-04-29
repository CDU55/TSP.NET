using System;
using System.Collections.Generic;
using Grpc.Net.Client;
using GrpcServer;

namespace gRPCClient
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new PostCommentService.PostCommentServiceClient(channel);
            PostDTOCollenction posts = client.GetAllPosts(new EmptyMessage());
            foreach (var post in posts.Posts)
            {
                Console.WriteLine($"ID:{0}\nDOMAIN:{1}\nDESCRIPTION:{2}\n\n", post.PostId, post.Description, post.Domain);
            }
        }
    }
}
