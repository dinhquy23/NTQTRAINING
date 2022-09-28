// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Product.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace NTQTRAINING_PRJ.Protos {
  public static partial class ProductsServices
  {
    static readonly string __ServiceName = "ProductsServices";

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
    static readonly grpc::Marshaller<global::NTQTRAINING_PRJ.Protos.Product> __Marshaller_Product = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NTQTRAINING_PRJ.Protos.Product.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::NTQTRAINING_PRJ.Protos.ProductId> __Marshaller_ProductId = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NTQTRAINING_PRJ.Protos.ProductId.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::NTQTRAINING_PRJ.Protos.ProductEmpty> __Marshaller_ProductEmpty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NTQTRAINING_PRJ.Protos.ProductEmpty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::NTQTRAINING_PRJ.Protos.ListProduct> __Marshaller_ListProduct = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::NTQTRAINING_PRJ.Protos.ListProduct.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NTQTRAINING_PRJ.Protos.Product, global::NTQTRAINING_PRJ.Protos.Product> __Method_Create = new grpc::Method<global::NTQTRAINING_PRJ.Protos.Product, global::NTQTRAINING_PRJ.Protos.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_Product,
        __Marshaller_Product);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NTQTRAINING_PRJ.Protos.ProductId, global::NTQTRAINING_PRJ.Protos.ProductEmpty> __Method_Delete = new grpc::Method<global::NTQTRAINING_PRJ.Protos.ProductId, global::NTQTRAINING_PRJ.Protos.ProductEmpty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_ProductId,
        __Marshaller_ProductEmpty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NTQTRAINING_PRJ.Protos.ProductEmpty, global::NTQTRAINING_PRJ.Protos.ListProduct> __Method_GetAll = new grpc::Method<global::NTQTRAINING_PRJ.Protos.ProductEmpty, global::NTQTRAINING_PRJ.Protos.ListProduct>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_ProductEmpty,
        __Marshaller_ListProduct);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::NTQTRAINING_PRJ.Protos.Product, global::NTQTRAINING_PRJ.Protos.Product> __Method_Update = new grpc::Method<global::NTQTRAINING_PRJ.Protos.Product, global::NTQTRAINING_PRJ.Protos.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_Product,
        __Marshaller_Product);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::NTQTRAINING_PRJ.Protos.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductsServices</summary>
    [grpc::BindServiceMethod(typeof(ProductsServices), "BindService")]
    public abstract partial class ProductsServicesBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::NTQTRAINING_PRJ.Protos.Product> Create(global::NTQTRAINING_PRJ.Protos.Product request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::NTQTRAINING_PRJ.Protos.ProductEmpty> Delete(global::NTQTRAINING_PRJ.Protos.ProductId request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::NTQTRAINING_PRJ.Protos.ListProduct> GetAll(global::NTQTRAINING_PRJ.Protos.ProductEmpty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::NTQTRAINING_PRJ.Protos.Product> Update(global::NTQTRAINING_PRJ.Protos.Product request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductsServicesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Create, serviceImpl.Create)
          .AddMethod(__Method_Delete, serviceImpl.Delete)
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_Update, serviceImpl.Update).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductsServicesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Create, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NTQTRAINING_PRJ.Protos.Product, global::NTQTRAINING_PRJ.Protos.Product>(serviceImpl.Create));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NTQTRAINING_PRJ.Protos.ProductId, global::NTQTRAINING_PRJ.Protos.ProductEmpty>(serviceImpl.Delete));
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NTQTRAINING_PRJ.Protos.ProductEmpty, global::NTQTRAINING_PRJ.Protos.ListProduct>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_Update, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::NTQTRAINING_PRJ.Protos.Product, global::NTQTRAINING_PRJ.Protos.Product>(serviceImpl.Update));
    }

  }
}
#endregion