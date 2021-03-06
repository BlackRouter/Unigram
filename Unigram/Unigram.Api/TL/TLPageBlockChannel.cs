// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockChannel : TLPageBlockBase 
	{
		public TLChatBase Channel { get; set; }

		public TLPageBlockChannel() { }
		public TLPageBlockChannel(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockChannel; } }

		public override void Read(TLBinaryReader from)
		{
			Channel = TLFactory.Read<TLChatBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xEF1751B5);
			to.WriteObject(Channel);
		}
	}
}