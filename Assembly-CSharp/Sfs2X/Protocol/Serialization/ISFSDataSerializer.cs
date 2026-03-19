using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sfs2X.Entities.Data;
using Sfs2X.Util;

namespace Sfs2X.Protocol.Serialization
{
	// Token: 0x02000A62 RID: 2658
	[Token(Token = "0x2000A62")]
	public interface ISFSDataSerializer
	{
		// Token: 0x060064D0 RID: 25808
		[Token(Token = "0x60064D0")]
		ByteArray Object2Binary(ISFSObject obj, ByteArray buffer);

		// Token: 0x060064D1 RID: 25809
		[Token(Token = "0x60064D1")]
		ByteArray Array2Binary(ISFSArray array, ByteArray buffer);

		// Token: 0x060064D2 RID: 25810
		[Token(Token = "0x60064D2")]
		ISFSObject Binary2Object(ByteArray data);

		// Token: 0x060064D3 RID: 25811
		[Token(Token = "0x60064D3")]
		ISFSArray Binary2Array(ByteArray data);

		// Token: 0x060064D4 RID: 25812
		[Token(Token = "0x60064D4")]
		string Object2Json(Dictionary<string, object> map);

		// Token: 0x060064D5 RID: 25813
		[Token(Token = "0x60064D5")]
		string Array2Json(List<object> list);

		// Token: 0x060064D6 RID: 25814
		[Token(Token = "0x60064D6")]
		ISFSObject Json2Object(string jsonStr);

		// Token: 0x060064D7 RID: 25815
		[Token(Token = "0x60064D7")]
		ISFSArray Json2Array(string jsonStr);
	}
}
