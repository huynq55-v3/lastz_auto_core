using System;
using Il2CppDummyDll;
using Sfs2X.Util;

namespace Sfs2X.Entities.Data
{
	// Token: 0x02000A72 RID: 2674
	[Token(Token = "0x2000A72")]
	public interface ISFSObject
	{
		// Token: 0x0600657D RID: 25981
		[Token(Token = "0x600657D")]
		bool IsNull(string key);

		// Token: 0x0600657E RID: 25982
		[Token(Token = "0x600657E")]
		bool ContainsKey(string key);

		// Token: 0x0600657F RID: 25983
		[Token(Token = "0x600657F")]
		void RemoveElement(string key);

		// Token: 0x06006580 RID: 25984
		[Token(Token = "0x6006580")]
		string[] GetKeys();

		// Token: 0x06006581 RID: 25985
		[Token(Token = "0x6006581")]
		void Traverse(Action<string, SFSDataWrapper> action);

		// Token: 0x06006582 RID: 25986
		[Token(Token = "0x6006582")]
		int Size();

		// Token: 0x06006583 RID: 25987
		[Token(Token = "0x6006583")]
		ByteArray ToBinary();

		// Token: 0x06006584 RID: 25988
		[Token(Token = "0x6006584")]
		ByteArray ToBinary(ByteArray dst);

		// Token: 0x06006585 RID: 25989
		[Token(Token = "0x6006585")]
		string ToJson();

		// Token: 0x06006586 RID: 25990
		[Token(Token = "0x6006586")]
		string GetDump(bool format);

		// Token: 0x06006587 RID: 25991
		[Token(Token = "0x6006587")]
		string GetDump();

		// Token: 0x06006588 RID: 25992
		[Token(Token = "0x6006588")]
		string GetHexDump();

		// Token: 0x06006589 RID: 25993
		[Token(Token = "0x6006589")]
		SFSDataWrapper GetData(string key);

		// Token: 0x0600658A RID: 25994
		[Token(Token = "0x600658A")]
		bool GetBool(string key);

		// Token: 0x0600658B RID: 25995
		[Token(Token = "0x600658B")]
		byte GetByte(string key);

		// Token: 0x0600658C RID: 25996
		[Token(Token = "0x600658C")]
		short GetShort(string key);

		// Token: 0x0600658D RID: 25997
		[Token(Token = "0x600658D")]
		int GetInt(string key);

		// Token: 0x0600658E RID: 25998
		[Token(Token = "0x600658E")]
		long GetLong(string key);

		// Token: 0x0600658F RID: 25999
		[Token(Token = "0x600658F")]
		float GetFloat(string key);

		// Token: 0x06006590 RID: 26000
		[Token(Token = "0x6006590")]
		double GetDouble(string key);

		// Token: 0x06006591 RID: 26001
		[Token(Token = "0x6006591")]
		string GetUtfString(string key);

		// Token: 0x06006592 RID: 26002
		[Token(Token = "0x6006592")]
		string GetText(string key);

		// Token: 0x06006593 RID: 26003
		[Token(Token = "0x6006593")]
		bool[] GetBoolArray(string key);

		// Token: 0x06006594 RID: 26004
		[Token(Token = "0x6006594")]
		ByteArray GetByteArray(string key);

		// Token: 0x06006595 RID: 26005
		[Token(Token = "0x6006595")]
		short[] GetShortArray(string key);

		// Token: 0x06006596 RID: 26006
		[Token(Token = "0x6006596")]
		int[] GetIntArray(string key);

		// Token: 0x06006597 RID: 26007
		[Token(Token = "0x6006597")]
		long[] GetLongArray(string key);

		// Token: 0x06006598 RID: 26008
		[Token(Token = "0x6006598")]
		float[] GetFloatArray(string key);

		// Token: 0x06006599 RID: 26009
		[Token(Token = "0x6006599")]
		double[] GetDoubleArray(string key);

		// Token: 0x0600659A RID: 26010
		[Token(Token = "0x600659A")]
		string[] GetUtfStringArray(string key);

		// Token: 0x0600659B RID: 26011
		[Token(Token = "0x600659B")]
		ISFSArray GetSFSArray(string key);

		// Token: 0x0600659C RID: 26012
		[Token(Token = "0x600659C")]
		ISFSObject GetSFSObject(string key);

		// Token: 0x0600659D RID: 26013
		[Token(Token = "0x600659D")]
		object GetClass(string key);

		// Token: 0x0600659E RID: 26014
		[Token(Token = "0x600659E")]
		void PutNull(string key);

		// Token: 0x0600659F RID: 26015
		[Token(Token = "0x600659F")]
		void PutBool(string key, bool val);

		// Token: 0x060065A0 RID: 26016
		[Token(Token = "0x60065A0")]
		void PutByte(string key, byte val);

		// Token: 0x060065A1 RID: 26017
		[Token(Token = "0x60065A1")]
		void PutShort(string key, short val);

		// Token: 0x060065A2 RID: 26018
		[Token(Token = "0x60065A2")]
		void PutInt(string key, int val);

		// Token: 0x060065A3 RID: 26019
		[Token(Token = "0x60065A3")]
		void PutLong(string key, long val);

		// Token: 0x060065A4 RID: 26020
		[Token(Token = "0x60065A4")]
		void PutFloat(string key, float val);

		// Token: 0x060065A5 RID: 26021
		[Token(Token = "0x60065A5")]
		void PutDouble(string key, double val);

		// Token: 0x060065A6 RID: 26022
		[Token(Token = "0x60065A6")]
		void PutUtfString(string key, string val);

		// Token: 0x060065A7 RID: 26023
		[Token(Token = "0x60065A7")]
		void PutText(string key, string val);

		// Token: 0x060065A8 RID: 26024
		[Token(Token = "0x60065A8")]
		void PutBoolArray(string key, bool[] val);

		// Token: 0x060065A9 RID: 26025
		[Token(Token = "0x60065A9")]
		void PutByteArray(string key, ByteArray val);

		// Token: 0x060065AA RID: 26026
		[Token(Token = "0x60065AA")]
		void PutShortArray(string key, short[] val);

		// Token: 0x060065AB RID: 26027
		[Token(Token = "0x60065AB")]
		void PutIntArray(string key, int[] val);

		// Token: 0x060065AC RID: 26028
		[Token(Token = "0x60065AC")]
		void PutLongArray(string key, long[] val);

		// Token: 0x060065AD RID: 26029
		[Token(Token = "0x60065AD")]
		void PutFloatArray(string key, float[] val);

		// Token: 0x060065AE RID: 26030
		[Token(Token = "0x60065AE")]
		void PutDoubleArray(string key, double[] val);

		// Token: 0x060065AF RID: 26031
		[Token(Token = "0x60065AF")]
		void PutUtfStringArray(string key, string[] val);

		// Token: 0x060065B0 RID: 26032
		[Token(Token = "0x60065B0")]
		void PutSFSArray(string key, ISFSArray val);

		// Token: 0x060065B1 RID: 26033
		[Token(Token = "0x60065B1")]
		void PutSFSObject(string key, ISFSObject val);

		// Token: 0x060065B2 RID: 26034
		[Token(Token = "0x60065B2")]
		void PutClass(string key, object val);

		// Token: 0x060065B3 RID: 26035
		[Token(Token = "0x60065B3")]
		void Put(string key, SFSDataWrapper val);
	}
}
