using System;
using System.Collections;
using Il2CppDummyDll;
using Sfs2X.Util;

namespace Sfs2X.Entities.Data
{
	// Token: 0x02000A71 RID: 2673
	[Token(Token = "0x2000A71")]
	public interface ISFSArray : ICollection, IEnumerable
	{
		// Token: 0x06006548 RID: 25928
		[Token(Token = "0x6006548")]
		bool Contains(object obj);

		// Token: 0x06006549 RID: 25929
		[Token(Token = "0x6006549")]
		object GetElementAt(int index);

		// Token: 0x0600654A RID: 25930
		[Token(Token = "0x600654A")]
		SFSDataWrapper GetWrappedElementAt(int index);

		// Token: 0x0600654B RID: 25931
		[Token(Token = "0x600654B")]
		object RemoveElementAt(int index);

		// Token: 0x0600654C RID: 25932
		[Token(Token = "0x600654C")]
		int Size();

		// Token: 0x0600654D RID: 25933
		[Token(Token = "0x600654D")]
		ByteArray ToBinary();

		// Token: 0x0600654E RID: 25934
		[Token(Token = "0x600654E")]
		string ToJson();

		// Token: 0x0600654F RID: 25935
		[Token(Token = "0x600654F")]
		string GetDump(bool format);

		// Token: 0x06006550 RID: 25936
		[Token(Token = "0x6006550")]
		string GetDump();

		// Token: 0x06006551 RID: 25937
		[Token(Token = "0x6006551")]
		string GetHexDump();

		// Token: 0x06006552 RID: 25938
		[Token(Token = "0x6006552")]
		void AddNull();

		// Token: 0x06006553 RID: 25939
		[Token(Token = "0x6006553")]
		void AddBool(bool val);

		// Token: 0x06006554 RID: 25940
		[Token(Token = "0x6006554")]
		void AddByte(byte val);

		// Token: 0x06006555 RID: 25941
		[Token(Token = "0x6006555")]
		void AddShort(short val);

		// Token: 0x06006556 RID: 25942
		[Token(Token = "0x6006556")]
		void AddInt(int val);

		// Token: 0x06006557 RID: 25943
		[Token(Token = "0x6006557")]
		void AddLong(long val);

		// Token: 0x06006558 RID: 25944
		[Token(Token = "0x6006558")]
		void AddFloat(float val);

		// Token: 0x06006559 RID: 25945
		[Token(Token = "0x6006559")]
		void AddDouble(double val);

		// Token: 0x0600655A RID: 25946
		[Token(Token = "0x600655A")]
		void AddUtfString(string val);

		// Token: 0x0600655B RID: 25947
		[Token(Token = "0x600655B")]
		void AddText(string val);

		// Token: 0x0600655C RID: 25948
		[Token(Token = "0x600655C")]
		void AddBoolArray(bool[] val);

		// Token: 0x0600655D RID: 25949
		[Token(Token = "0x600655D")]
		void AddByteArray(ByteArray val);

		// Token: 0x0600655E RID: 25950
		[Token(Token = "0x600655E")]
		void AddShortArray(short[] val);

		// Token: 0x0600655F RID: 25951
		[Token(Token = "0x600655F")]
		void AddIntArray(int[] val);

		// Token: 0x06006560 RID: 25952
		[Token(Token = "0x6006560")]
		void AddLongArray(long[] val);

		// Token: 0x06006561 RID: 25953
		[Token(Token = "0x6006561")]
		void AddFloatArray(float[] val);

		// Token: 0x06006562 RID: 25954
		[Token(Token = "0x6006562")]
		void AddDoubleArray(double[] val);

		// Token: 0x06006563 RID: 25955
		[Token(Token = "0x6006563")]
		void AddUtfStringArray(string[] val);

		// Token: 0x06006564 RID: 25956
		[Token(Token = "0x6006564")]
		void AddSFSArray(ISFSArray val);

		// Token: 0x06006565 RID: 25957
		[Token(Token = "0x6006565")]
		void AddSFSObject(ISFSObject val);

		// Token: 0x06006566 RID: 25958
		[Token(Token = "0x6006566")]
		void AddClass(object val);

		// Token: 0x06006567 RID: 25959
		[Token(Token = "0x6006567")]
		void Add(SFSDataWrapper val);

		// Token: 0x06006568 RID: 25960
		[Token(Token = "0x6006568")]
		bool IsNull(int index);

		// Token: 0x06006569 RID: 25961
		[Token(Token = "0x6006569")]
		bool GetBool(int index);

		// Token: 0x0600656A RID: 25962
		[Token(Token = "0x600656A")]
		byte GetByte(int index);

		// Token: 0x0600656B RID: 25963
		[Token(Token = "0x600656B")]
		short GetShort(int index);

		// Token: 0x0600656C RID: 25964
		[Token(Token = "0x600656C")]
		int GetInt(int index);

		// Token: 0x0600656D RID: 25965
		[Token(Token = "0x600656D")]
		long GetLong(int index);

		// Token: 0x0600656E RID: 25966
		[Token(Token = "0x600656E")]
		float GetFloat(int index);

		// Token: 0x0600656F RID: 25967
		[Token(Token = "0x600656F")]
		double GetDouble(int index);

		// Token: 0x06006570 RID: 25968
		[Token(Token = "0x6006570")]
		string GetUtfString(int index);

		// Token: 0x06006571 RID: 25969
		[Token(Token = "0x6006571")]
		string GetText(int index);

		// Token: 0x06006572 RID: 25970
		[Token(Token = "0x6006572")]
		bool[] GetBoolArray(int index);

		// Token: 0x06006573 RID: 25971
		[Token(Token = "0x6006573")]
		ByteArray GetByteArray(int index);

		// Token: 0x06006574 RID: 25972
		[Token(Token = "0x6006574")]
		short[] GetShortArray(int index);

		// Token: 0x06006575 RID: 25973
		[Token(Token = "0x6006575")]
		int[] GetIntArray(int index);

		// Token: 0x06006576 RID: 25974
		[Token(Token = "0x6006576")]
		long[] GetLongArray(int index);

		// Token: 0x06006577 RID: 25975
		[Token(Token = "0x6006577")]
		float[] GetFloatArray(int index);

		// Token: 0x06006578 RID: 25976
		[Token(Token = "0x6006578")]
		double[] GetDoubleArray(int index);

		// Token: 0x06006579 RID: 25977
		[Token(Token = "0x6006579")]
		string[] GetUtfStringArray(int index);

		// Token: 0x0600657A RID: 25978
		[Token(Token = "0x600657A")]
		ISFSArray GetSFSArray(int index);

		// Token: 0x0600657B RID: 25979
		[Token(Token = "0x600657B")]
		ISFSObject GetSFSObject(int index);

		// Token: 0x0600657C RID: 25980
		[Token(Token = "0x600657C")]
		object GetClass(int index);
	}
}
