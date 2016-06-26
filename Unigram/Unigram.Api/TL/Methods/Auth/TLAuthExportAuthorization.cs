// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Auth
{
	/// <summary>
	/// RCP method auth.exportAuthorization
	/// </summary>
	public partial class TLAuthExportAuthorization : TLObject
	{
		public Int32 DCId { get; set; }

		public TLAuthExportAuthorization() { }
		public TLAuthExportAuthorization(TLBinaryReader from, TLType type = TLType.AuthExportAuthorization)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.AuthExportAuthorization; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.AuthExportAuthorization)
		{
			DCId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xE5BFFFCD);
			to.Write(DCId);
		}
	}
}