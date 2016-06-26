// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods
{
	/// <summary>
	/// RCP method invokeWithLayer
	/// </summary>
	public partial class TLInvokeWithLayer : TLObject
	{
		public Int32 Layer { get; set; }
		public TLObject Query { get; set; }

		public TLInvokeWithLayer() { }
		public TLInvokeWithLayer(TLBinaryReader from, TLType type = TLType.InvokeWithLayer)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.InvokeWithLayer; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.InvokeWithLayer)
		{
			Layer = from.ReadInt32();
			Query = TLFactory.Read<TLObject>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xDA9B0D0D);
			to.Write(Layer);
			to.WriteObject(Query);
		}
	}
}