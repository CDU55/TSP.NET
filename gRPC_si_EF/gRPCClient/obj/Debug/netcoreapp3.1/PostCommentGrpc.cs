// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/PostComment.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class PostCommentService
  {
    static readonly string __ServiceName = "PostCommentService";

    static readonly grpc::Marshaller<global::GrpcServer.ObjectIdRequest> __Marshaller_ObjectIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.ObjectIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.PostDTO> __Marshaller_PostDTO = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.PostDTO.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.StringRequest> __Marshaller_StringRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.StringRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.BoolReply> __Marshaller_BoolReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.BoolReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.EmptyMessage> __Marshaller_EmptyMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.EmptyMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.PostDTOCollenction> __Marshaller_PostDTOCollenction = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.PostDTOCollenction.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.CommentDTO> __Marshaller_CommentDTO = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.CommentDTO.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.CommentAndPostId> __Marshaller_CommentAndPostId = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.CommentAndPostId.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.UpdateCommentMessage> __Marshaller_UpdateCommentMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.UpdateCommentMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.CommentDTOCollection> __Marshaller_CommentDTOCollection = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.CommentDTOCollection.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.PostDTO> __Method_GetPostById = new grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.PostDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostById",
        __Marshaller_ObjectIdRequest,
        __Marshaller_PostDTO);

    static readonly grpc::Method<global::GrpcServer.StringRequest, global::GrpcServer.PostDTO> __Method_GetPostByTitle = new grpc::Method<global::GrpcServer.StringRequest, global::GrpcServer.PostDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPostByTitle",
        __Marshaller_StringRequest,
        __Marshaller_PostDTO);

    static readonly grpc::Method<global::GrpcServer.PostDTO, global::GrpcServer.PostDTO> __Method_SubmitPost = new grpc::Method<global::GrpcServer.PostDTO, global::GrpcServer.PostDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmitPost",
        __Marshaller_PostDTO,
        __Marshaller_PostDTO);

    static readonly grpc::Method<global::GrpcServer.PostDTO, global::GrpcServer.PostDTO> __Method_UpdatePost = new grpc::Method<global::GrpcServer.PostDTO, global::GrpcServer.PostDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePost",
        __Marshaller_PostDTO,
        __Marshaller_PostDTO);

    static readonly grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.BoolReply> __Method_DeletePost = new grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.BoolReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePost",
        __Marshaller_ObjectIdRequest,
        __Marshaller_BoolReply);

    static readonly grpc::Method<global::GrpcServer.EmptyMessage, global::GrpcServer.PostDTOCollenction> __Method_GetAllPosts = new grpc::Method<global::GrpcServer.EmptyMessage, global::GrpcServer.PostDTOCollenction>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPosts",
        __Marshaller_EmptyMessage,
        __Marshaller_PostDTOCollenction);

    static readonly grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.CommentDTO> __Method_GetCommentById = new grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.CommentDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCommentById",
        __Marshaller_ObjectIdRequest,
        __Marshaller_CommentDTO);

    static readonly grpc::Method<global::GrpcServer.CommentDTO, global::GrpcServer.CommentDTO> __Method_SubmitComment = new grpc::Method<global::GrpcServer.CommentDTO, global::GrpcServer.CommentDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmitComment",
        __Marshaller_CommentDTO,
        __Marshaller_CommentDTO);

    static readonly grpc::Method<global::GrpcServer.CommentAndPostId, global::GrpcServer.CommentDTO> __Method_AddComment = new grpc::Method<global::GrpcServer.CommentAndPostId, global::GrpcServer.CommentDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddComment",
        __Marshaller_CommentAndPostId,
        __Marshaller_CommentDTO);

    static readonly grpc::Method<global::GrpcServer.UpdateCommentMessage, global::GrpcServer.CommentDTO> __Method_UpdateComment = new grpc::Method<global::GrpcServer.UpdateCommentMessage, global::GrpcServer.CommentDTO>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateComment",
        __Marshaller_UpdateCommentMessage,
        __Marshaller_CommentDTO);

    static readonly grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.BoolReply> __Method_DeleteComment = new grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.BoolReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteComment",
        __Marshaller_ObjectIdRequest,
        __Marshaller_BoolReply);

    static readonly grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.CommentDTOCollection> __Method_GetAllPostRelateComments = new grpc::Method<global::GrpcServer.ObjectIdRequest, global::GrpcServer.CommentDTOCollection>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPostRelateComments",
        __Marshaller_ObjectIdRequest,
        __Marshaller_CommentDTOCollection);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.PostCommentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for PostCommentService</summary>
    public partial class PostCommentServiceClient : grpc::ClientBase<PostCommentServiceClient>
    {
      /// <summary>Creates a new client for PostCommentService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PostCommentServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PostCommentService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PostCommentServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PostCommentServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PostCommentServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServer.PostDTO GetPostById(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPostById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.PostDTO GetPostById(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPostById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTO> GetPostByIdAsync(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPostByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTO> GetPostByIdAsync(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPostById, null, options, request);
      }
      public virtual global::GrpcServer.PostDTO GetPostByTitle(global::GrpcServer.StringRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPostByTitle(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.PostDTO GetPostByTitle(global::GrpcServer.StringRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPostByTitle, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTO> GetPostByTitleAsync(global::GrpcServer.StringRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPostByTitleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTO> GetPostByTitleAsync(global::GrpcServer.StringRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPostByTitle, null, options, request);
      }
      public virtual global::GrpcServer.PostDTO SubmitPost(global::GrpcServer.PostDTO request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitPost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.PostDTO SubmitPost(global::GrpcServer.PostDTO request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitPost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTO> SubmitPostAsync(global::GrpcServer.PostDTO request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitPostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTO> SubmitPostAsync(global::GrpcServer.PostDTO request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitPost, null, options, request);
      }
      public virtual global::GrpcServer.PostDTO UpdatePost(global::GrpcServer.PostDTO request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.PostDTO UpdatePost(global::GrpcServer.PostDTO request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdatePost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTO> UpdatePostAsync(global::GrpcServer.PostDTO request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTO> UpdatePostAsync(global::GrpcServer.PostDTO request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdatePost, null, options, request);
      }
      public virtual global::GrpcServer.BoolReply DeletePost(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePost(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.BoolReply DeletePost(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeletePost, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.BoolReply> DeletePostAsync(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePostAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.BoolReply> DeletePostAsync(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeletePost, null, options, request);
      }
      public virtual global::GrpcServer.PostDTOCollenction GetAllPosts(global::GrpcServer.EmptyMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllPosts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.PostDTOCollenction GetAllPosts(global::GrpcServer.EmptyMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllPosts, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTOCollenction> GetAllPostsAsync(global::GrpcServer.EmptyMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllPostsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.PostDTOCollenction> GetAllPostsAsync(global::GrpcServer.EmptyMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllPosts, null, options, request);
      }
      public virtual global::GrpcServer.CommentDTO GetCommentById(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCommentById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.CommentDTO GetCommentById(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCommentById, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTO> GetCommentByIdAsync(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCommentByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTO> GetCommentByIdAsync(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCommentById, null, options, request);
      }
      public virtual global::GrpcServer.CommentDTO SubmitComment(global::GrpcServer.CommentDTO request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitComment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.CommentDTO SubmitComment(global::GrpcServer.CommentDTO request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SubmitComment, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTO> SubmitCommentAsync(global::GrpcServer.CommentDTO request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubmitCommentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTO> SubmitCommentAsync(global::GrpcServer.CommentDTO request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SubmitComment, null, options, request);
      }
      public virtual global::GrpcServer.CommentDTO AddComment(global::GrpcServer.CommentAndPostId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddComment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.CommentDTO AddComment(global::GrpcServer.CommentAndPostId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddComment, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTO> AddCommentAsync(global::GrpcServer.CommentAndPostId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddCommentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTO> AddCommentAsync(global::GrpcServer.CommentAndPostId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddComment, null, options, request);
      }
      public virtual global::GrpcServer.CommentDTO UpdateComment(global::GrpcServer.UpdateCommentMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateComment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.CommentDTO UpdateComment(global::GrpcServer.UpdateCommentMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateComment, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTO> UpdateCommentAsync(global::GrpcServer.UpdateCommentMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCommentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTO> UpdateCommentAsync(global::GrpcServer.UpdateCommentMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateComment, null, options, request);
      }
      public virtual global::GrpcServer.BoolReply DeleteComment(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteComment(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.BoolReply DeleteComment(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteComment, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.BoolReply> DeleteCommentAsync(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCommentAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.BoolReply> DeleteCommentAsync(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteComment, null, options, request);
      }
      public virtual global::GrpcServer.CommentDTOCollection GetAllPostRelateComments(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllPostRelateComments(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.CommentDTOCollection GetAllPostRelateComments(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllPostRelateComments, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTOCollection> GetAllPostRelateCommentsAsync(global::GrpcServer.ObjectIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllPostRelateCommentsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.CommentDTOCollection> GetAllPostRelateCommentsAsync(global::GrpcServer.ObjectIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllPostRelateComments, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PostCommentServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PostCommentServiceClient(configuration);
      }
    }

  }
}
#endregion
