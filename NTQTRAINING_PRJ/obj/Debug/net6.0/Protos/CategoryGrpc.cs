// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Category.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace NTQTRAINING_PRJ.Protos {
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
    static readonly grpc::Marshaller<global::NTQTRAINING_PRJ.Protos.Category> __Marshaller_Category = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NTQTRAINING_PRJ.Protos.Category.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::NTQTRAINING_PRJ.Protos.ResponseSesult> __Marshaller_ResponseSesult = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NTQTRAINING_PRJ.Protos.ResponseSesult.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::NTQTRAINING_PRJ.Protos.CategoryId> __Marshaller_CategoryId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NTQTRAINING_PRJ.Protos.CategoryId.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::NTQTRAINING_PRJ.Protos.CategoryEmpty> __Marshaller_CategoryEmpty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NTQTRAINING_PRJ.Protos.CategoryEmpty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::NTQTRAINING_PRJ.Protos.ListCategory> __Marshaller_ListCategory = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NTQTRAINING_PRJ.Protos.ListCategory.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NTQTRAINING_PRJ.Protos.Category, global::NTQTRAINING_PRJ.Protos.ResponseSesult> __Method_Create = new grpc::Method<global::NTQTRAINING_PRJ.Protos.Category, global::NTQTRAINING_PRJ.Protos.ResponseSesult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_Category,
        __Marshaller_ResponseSesult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NTQTRAINING_PRJ.Protos.CategoryId, global::NTQTRAINING_PRJ.Protos.ResponseSesult> __Method_Delete = new grpc::Method<global::NTQTRAINING_PRJ.Protos.CategoryId, global::NTQTRAINING_PRJ.Protos.ResponseSesult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_CategoryId,
        __Marshaller_ResponseSesult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NTQTRAINING_PRJ.Protos.CategoryEmpty, global::NTQTRAINING_PRJ.Protos.ListCategory> __Method_GetAll = new grpc::Method<global::NTQTRAINING_PRJ.Protos.CategoryEmpty, global::NTQTRAINING_PRJ.Protos.ListCategory>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_CategoryEmpty,
        __Marshaller_ListCategory);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NTQTRAINING_PRJ.Protos.CategoryId, global::NTQTRAINING_PRJ.Protos.ResponseSesult> __Method_GetCategoryById = new grpc::Method<global::NTQTRAINING_PRJ.Protos.CategoryId, global::NTQTRAINING_PRJ.Protos.ResponseSesult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCategoryById",
        __Marshaller_CategoryId,
        __Marshaller_ResponseSesult);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NTQTRAINING_PRJ.Protos.Category, global::NTQTRAINING_PRJ.Protos.ResponseSesult> __Method_Update = new grpc::Method<global::NTQTRAINING_PRJ.Protos.Category, global::NTQTRAINING_PRJ.Protos.ResponseSesult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_Category,
        __Marshaller_ResponseSesult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::NTQTRAINING_PRJ.Protos.CategoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CategoriesSevices</summary>
    [grpc::BindServiceMethod(typeof(CategoriesSevices), "BindService")]
    public abstract partial class CategoriesSevicesBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::NTQTRAINING_PRJ.Protos.ResponseSesult> Create(global::NTQTRAINING_PRJ.Protos.Category request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::NTQTRAINING_PRJ.Protos.ResponseSesult> Delete(global::NTQTRAINING_PRJ.Protos.CategoryId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::NTQTRAINING_PRJ.Protos.ListCategory> GetAll(global::NTQTRAINING_PRJ.Protos.CategoryEmpty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::NTQTRAINING_PRJ.Protos.ResponseSesult> GetCategoryById(global::NTQTRAINING_PRJ.Protos.CategoryId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::NTQTRAINING_PRJ.Protos.ResponseSesult> Update(global::NTQTRAINING_PRJ.Protos.Category request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CategoriesSevicesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Create, serviceImpl.Create)
          .AddMethod(__Method_Delete, serviceImpl.Delete)
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_GetCategoryById, serviceImpl.GetCategoryById)
          .AddMethod(__Method_Update, serviceImpl.Update).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CategoriesSevicesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Create, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NTQTRAINING_PRJ.Protos.Category, global::NTQTRAINING_PRJ.Protos.ResponseSesult>(serviceImpl.Create));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NTQTRAINING_PRJ.Protos.CategoryId, global::NTQTRAINING_PRJ.Protos.ResponseSesult>(serviceImpl.Delete));
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NTQTRAINING_PRJ.Protos.CategoryEmpty, global::NTQTRAINING_PRJ.Protos.ListCategory>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_GetCategoryById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NTQTRAINING_PRJ.Protos.CategoryId, global::NTQTRAINING_PRJ.Protos.ResponseSesult>(serviceImpl.GetCategoryById));
      serviceBinder.AddMethod(__Method_Update, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NTQTRAINING_PRJ.Protos.Category, global::NTQTRAINING_PRJ.Protos.ResponseSesult>(serviceImpl.Update));
    }

  }
}
#endregion
