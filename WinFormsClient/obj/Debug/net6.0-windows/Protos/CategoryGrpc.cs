// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Category.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace WinFormsClient {
  public static partial class CategoriesSevices
  {
    static readonly string __ServiceName = "CategoriesSevices";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WinFormsClient.Category> __Marshaller_Category = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WinFormsClient.Category.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WinFormsClient.ResponseSesult> __Marshaller_ResponseSesult = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WinFormsClient.ResponseSesult.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WinFormsClient.CategoryId> __Marshaller_CategoryId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WinFormsClient.CategoryId.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WinFormsClient.CategoryEmpty> __Marshaller_CategoryEmpty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WinFormsClient.CategoryEmpty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WinFormsClient.ListCategory> __Marshaller_ListCategory = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WinFormsClient.ListCategory.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WinFormsClient.Category, global::WinFormsClient.ResponseSesult> __Method_Create = new grpc::Method<global::WinFormsClient.Category, global::WinFormsClient.ResponseSesult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_Category,
        __Marshaller_ResponseSesult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WinFormsClient.CategoryId, global::WinFormsClient.CategoryEmpty> __Method_Delete = new grpc::Method<global::WinFormsClient.CategoryId, global::WinFormsClient.CategoryEmpty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_CategoryId,
        __Marshaller_CategoryEmpty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WinFormsClient.CategoryEmpty, global::WinFormsClient.ListCategory> __Method_GetAll = new grpc::Method<global::WinFormsClient.CategoryEmpty, global::WinFormsClient.ListCategory>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_CategoryEmpty,
        __Marshaller_ListCategory);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WinFormsClient.CategoryId, global::WinFormsClient.ResponseSesult> __Method_GetCategoryById = new grpc::Method<global::WinFormsClient.CategoryId, global::WinFormsClient.ResponseSesult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCategoryById",
        __Marshaller_CategoryId,
        __Marshaller_ResponseSesult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WinFormsClient.Category, global::WinFormsClient.ResponseSesult> __Method_Update = new grpc::Method<global::WinFormsClient.Category, global::WinFormsClient.ResponseSesult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_Category,
        __Marshaller_ResponseSesult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::WinFormsClient.CategoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for CategoriesSevices</summary>
    public partial class CategoriesSevicesClient : grpc::ClientBase<CategoriesSevicesClient>
    {
      /// <summary>Creates a new client for CategoriesSevices</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CategoriesSevicesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CategoriesSevices that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CategoriesSevicesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CategoriesSevicesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CategoriesSevicesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.ResponseSesult Create(global::WinFormsClient.Category request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.ResponseSesult Create(global::WinFormsClient.Category request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.ResponseSesult> CreateAsync(global::WinFormsClient.Category request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.ResponseSesult> CreateAsync(global::WinFormsClient.Category request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.CategoryEmpty Delete(global::WinFormsClient.CategoryId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.CategoryEmpty Delete(global::WinFormsClient.CategoryId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.CategoryEmpty> DeleteAsync(global::WinFormsClient.CategoryId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.CategoryEmpty> DeleteAsync(global::WinFormsClient.CategoryId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.ListCategory GetAll(global::WinFormsClient.CategoryEmpty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.ListCategory GetAll(global::WinFormsClient.CategoryEmpty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.ListCategory> GetAllAsync(global::WinFormsClient.CategoryEmpty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.ListCategory> GetAllAsync(global::WinFormsClient.CategoryEmpty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.ResponseSesult GetCategoryById(global::WinFormsClient.CategoryId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCategoryById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.ResponseSesult GetCategoryById(global::WinFormsClient.CategoryId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCategoryById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.ResponseSesult> GetCategoryByIdAsync(global::WinFormsClient.CategoryId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCategoryByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.ResponseSesult> GetCategoryByIdAsync(global::WinFormsClient.CategoryId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCategoryById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.ResponseSesult Update(global::WinFormsClient.Category request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::WinFormsClient.ResponseSesult Update(global::WinFormsClient.Category request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.ResponseSesult> UpdateAsync(global::WinFormsClient.Category request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::WinFormsClient.ResponseSesult> UpdateAsync(global::WinFormsClient.Category request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CategoriesSevicesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CategoriesSevicesClient(configuration);
      }
    }

  }
}
#endregion
