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

    /// <summary>Client for ProductsServices</summary>
    public partial class ProductsServicesClient : grpc::ClientBase<ProductsServicesClient>
    {
      /// <summary>Creates a new client for ProductsServices</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductsServicesClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductsServices that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductsServicesClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductsServicesClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductsServicesClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NTQTRAINING_PRJ.Protos.Product Create(global::NTQTRAINING_PRJ.Protos.Product request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NTQTRAINING_PRJ.Protos.Product Create(global::NTQTRAINING_PRJ.Protos.Product request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NTQTRAINING_PRJ.Protos.Product> CreateAsync(global::NTQTRAINING_PRJ.Protos.Product request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NTQTRAINING_PRJ.Protos.Product> CreateAsync(global::NTQTRAINING_PRJ.Protos.Product request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NTQTRAINING_PRJ.Protos.ProductEmpty Delete(global::NTQTRAINING_PRJ.Protos.ProductId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NTQTRAINING_PRJ.Protos.ProductEmpty Delete(global::NTQTRAINING_PRJ.Protos.ProductId request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NTQTRAINING_PRJ.Protos.ProductEmpty> DeleteAsync(global::NTQTRAINING_PRJ.Protos.ProductId request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NTQTRAINING_PRJ.Protos.ProductEmpty> DeleteAsync(global::NTQTRAINING_PRJ.Protos.ProductId request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NTQTRAINING_PRJ.Protos.ListProduct GetAll(global::NTQTRAINING_PRJ.Protos.ProductEmpty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NTQTRAINING_PRJ.Protos.ListProduct GetAll(global::NTQTRAINING_PRJ.Protos.ProductEmpty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NTQTRAINING_PRJ.Protos.ListProduct> GetAllAsync(global::NTQTRAINING_PRJ.Protos.ProductEmpty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NTQTRAINING_PRJ.Protos.ListProduct> GetAllAsync(global::NTQTRAINING_PRJ.Protos.ProductEmpty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NTQTRAINING_PRJ.Protos.Product Update(global::NTQTRAINING_PRJ.Protos.Product request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::NTQTRAINING_PRJ.Protos.Product Update(global::NTQTRAINING_PRJ.Protos.Product request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NTQTRAINING_PRJ.Protos.Product> UpdateAsync(global::NTQTRAINING_PRJ.Protos.Product request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::NTQTRAINING_PRJ.Protos.Product> UpdateAsync(global::NTQTRAINING_PRJ.Protos.Product request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProductsServicesClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductsServicesClient(configuration);
      }
    }

  }
}
#endregion