// <auto-generated/>
using System;

namespace Telegram.Api.TL.LangPack.Methods
{
	/// <summary>
	/// RCP method langpack.getLanguages.
	/// Returns <see cref="Telegram.Api.TL.TLVector<TLLangPackLanguage>"/>
	/// </summary>
	public partial class TLLangPackGetLanguages : TLObject
	{
		public TLLangPackGetLanguages() { }
		public TLLangPackGetLanguages(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.LangPackGetLanguages; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x800FD57D);
		}
	}
}