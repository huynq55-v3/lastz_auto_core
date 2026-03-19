using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sfs2X.Protocol.Serialization;
using Sfs2X.Util;

namespace Sfs2X.Entities.Data
{
	// Token: 0x02000A78 RID: 2680
	[Token(Token = "0x2000A78")]
	public class SFSObject : ISFSObject
	{
		// Token: 0x0600661D RID: 26141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600661D")]
		[Address(RVA = "0x2E0EEDC", Offset = "0x2E0EEDC", VA = "0x2E0EEDC")]
		public static SFSObject NewFromBinaryData(ByteArray ba)
		{
			return null;
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600661E")]
		[Address(RVA = "0x2E0EF8C", Offset = "0x2E0EF8C", VA = "0x2E0EF8C")]
		public static ISFSObject NewFromJsonData(string js)
		{
			return null;
		}

		// Token: 0x0600661F RID: 26143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600661F")]
		[Address(RVA = "0x2DFBC8C", Offset = "0x2DFBC8C", VA = "0x2DFBC8C")]
		public static SFSObject NewInstance()
		{
			return null;
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006620")]
		[Address(RVA = "0x2E0EFEC", Offset = "0x2E0EFEC", VA = "0x2E0EFEC")]
		public SFSObject()
		{
		}

		// Token: 0x06006621 RID: 26145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006621")]
		[Address(RVA = "0x2E0F0B0", Offset = "0x2E0F0B0", VA = "0x2E0F0B0")]
		private string Dump()
		{
			return null;
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006622")]
		private T GetValue<T>(string key)
		{
			return null;
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006623")]
		[Address(RVA = "0x2E0F758", Offset = "0x2E0F758", VA = "0x2E0F758", Slot = "16")]
		public SFSDataWrapper GetData(string key)
		{
			return null;
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x0004C500 File Offset: 0x0004A700
		[Token(Token = "0x6006624")]
		[Address(RVA = "0x2E0F7B0", Offset = "0x2E0F7B0", VA = "0x2E0F7B0", Slot = "4")]
		public bool IsNull(string key)
		{
			return default(bool);
		}

		// Token: 0x06006625 RID: 26149 RVA: 0x0004C518 File Offset: 0x0004A718
		[Token(Token = "0x6006625")]
		[Address(RVA = "0x2E0F8A8", Offset = "0x2E0F8A8", VA = "0x2E0F8A8", Slot = "59")]
		public virtual bool GetBool(string key)
		{
			return default(bool);
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x0004C530 File Offset: 0x0004A730
		[Token(Token = "0x6006626")]
		[Address(RVA = "0x2E0F934", Offset = "0x2E0F934", VA = "0x2E0F934", Slot = "60")]
		public virtual byte GetByte(string key)
		{
			return 0;
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x0004C548 File Offset: 0x0004A748
		[Token(Token = "0x6006627")]
		[Address(RVA = "0x2E0F9B8", Offset = "0x2E0F9B8", VA = "0x2E0F9B8", Slot = "61")]
		public virtual short GetShort(string key)
		{
			return 0;
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x0004C560 File Offset: 0x0004A760
		[Token(Token = "0x6006628")]
		[Address(RVA = "0x2E0FA3C", Offset = "0x2E0FA3C", VA = "0x2E0FA3C", Slot = "62")]
		public virtual int GetInt(string key)
		{
			return 0;
		}

		// Token: 0x06006629 RID: 26153 RVA: 0x0004C578 File Offset: 0x0004A778
		[Token(Token = "0x6006629")]
		[Address(RVA = "0x2E0FAC0", Offset = "0x2E0FAC0", VA = "0x2E0FAC0", Slot = "63")]
		public virtual long GetLong(string key)
		{
			return 0L;
		}

		// Token: 0x0600662A RID: 26154 RVA: 0x0004C590 File Offset: 0x0004A790
		[Token(Token = "0x600662A")]
		[Address(RVA = "0x2E0FB44", Offset = "0x2E0FB44", VA = "0x2E0FB44", Slot = "64")]
		public virtual float GetFloat(string key)
		{
			return 0f;
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x0004C5A8 File Offset: 0x0004A7A8
		[Token(Token = "0x600662B")]
		[Address(RVA = "0x2E0FB9C", Offset = "0x2E0FB9C", VA = "0x2E0FB9C", Slot = "65")]
		public virtual double GetDouble(string key)
		{
			return 0.0;
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600662C")]
		[Address(RVA = "0x2E0FBF4", Offset = "0x2E0FBF4", VA = "0x2E0FBF4", Slot = "66")]
		public virtual string GetUtfString(string key)
		{
			return null;
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600662D")]
		[Address(RVA = "0x2E0FC4C", Offset = "0x2E0FC4C", VA = "0x2E0FC4C", Slot = "67")]
		public virtual string GetText(string key)
		{
			return null;
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600662E")]
		[Address(RVA = "0x2E0FCA4", Offset = "0x2E0FCA4", VA = "0x2E0FCA4")]
		private ICollection GetArray(string key)
		{
			return null;
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600662F")]
		[Address(RVA = "0x2E0FCFC", Offset = "0x2E0FCFC", VA = "0x2E0FCFC", Slot = "68")]
		public virtual bool[] GetBoolArray(string key)
		{
			return null;
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006630")]
		[Address(RVA = "0x2E0FD70", Offset = "0x2E0FD70", VA = "0x2E0FD70", Slot = "69")]
		public virtual ByteArray GetByteArray(string key)
		{
			return null;
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006631")]
		[Address(RVA = "0x2E0FDC8", Offset = "0x2E0FDC8", VA = "0x2E0FDC8", Slot = "70")]
		public virtual short[] GetShortArray(string key)
		{
			return null;
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006632")]
		[Address(RVA = "0x2E0FE3C", Offset = "0x2E0FE3C", VA = "0x2E0FE3C", Slot = "71")]
		public virtual int[] GetIntArray(string key)
		{
			return null;
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006633")]
		[Address(RVA = "0x2E0FEB0", Offset = "0x2E0FEB0", VA = "0x2E0FEB0", Slot = "72")]
		public virtual long[] GetLongArray(string key)
		{
			return null;
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006634")]
		[Address(RVA = "0x2E0FF24", Offset = "0x2E0FF24", VA = "0x2E0FF24", Slot = "73")]
		public virtual float[] GetFloatArray(string key)
		{
			return null;
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006635")]
		[Address(RVA = "0x2E0FF98", Offset = "0x2E0FF98", VA = "0x2E0FF98", Slot = "74")]
		public virtual double[] GetDoubleArray(string key)
		{
			return null;
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006636")]
		[Address(RVA = "0x2E1000C", Offset = "0x2E1000C", VA = "0x2E1000C", Slot = "75")]
		public virtual string[] GetUtfStringArray(string key)
		{
			return null;
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006637")]
		[Address(RVA = "0x2E10080", Offset = "0x2E10080", VA = "0x2E10080", Slot = "76")]
		public virtual ISFSArray GetSFSArray(string key)
		{
			return null;
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006638")]
		[Address(RVA = "0x2E100D8", Offset = "0x2E100D8", VA = "0x2E100D8", Slot = "77")]
		public virtual ISFSObject GetSFSObject(string key)
		{
			return null;
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006639")]
		[Address(RVA = "0x2E10130", Offset = "0x2E10130", VA = "0x2E10130", Slot = "78")]
		public virtual object GetClass(string key)
		{
			return null;
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663A")]
		[Address(RVA = "0x2E101B0", Offset = "0x2E101B0", VA = "0x2E101B0", Slot = "37")]
		public void PutNull(string key)
		{
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663B")]
		[Address(RVA = "0x2E10248", Offset = "0x2E10248", VA = "0x2E10248", Slot = "38")]
		public void PutBool(string key, bool val)
		{
		}

		// Token: 0x0600663C RID: 26172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663C")]
		[Address(RVA = "0x2E102E4", Offset = "0x2E102E4", VA = "0x2E102E4", Slot = "39")]
		public void PutByte(string key, byte val)
		{
		}

		// Token: 0x0600663D RID: 26173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663D")]
		[Address(RVA = "0x2E10380", Offset = "0x2E10380", VA = "0x2E10380", Slot = "40")]
		public void PutShort(string key, short val)
		{
		}

		// Token: 0x0600663E RID: 26174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663E")]
		[Address(RVA = "0x2E1041C", Offset = "0x2E1041C", VA = "0x2E1041C", Slot = "41")]
		public void PutInt(string key, int val)
		{
		}

		// Token: 0x0600663F RID: 26175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663F")]
		[Address(RVA = "0x2E104B8", Offset = "0x2E104B8", VA = "0x2E104B8", Slot = "42")]
		public void PutLong(string key, long val)
		{
		}

		// Token: 0x06006640 RID: 26176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006640")]
		[Address(RVA = "0x2E10554", Offset = "0x2E10554", VA = "0x2E10554", Slot = "43")]
		public void PutFloat(string key, float val)
		{
		}

		// Token: 0x06006641 RID: 26177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006641")]
		[Address(RVA = "0x2E10628", Offset = "0x2E10628", VA = "0x2E10628", Slot = "44")]
		public void PutDouble(string key, double val)
		{
		}

		// Token: 0x06006642 RID: 26178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006642")]
		[Address(RVA = "0x2E106FC", Offset = "0x2E106FC", VA = "0x2E106FC", Slot = "45")]
		public void PutUtfString(string key, string val)
		{
		}

		// Token: 0x06006643 RID: 26179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006643")]
		[Address(RVA = "0x2E10798", Offset = "0x2E10798", VA = "0x2E10798", Slot = "46")]
		public void PutText(string key, string val)
		{
		}

		// Token: 0x06006644 RID: 26180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006644")]
		[Address(RVA = "0x2E10834", Offset = "0x2E10834", VA = "0x2E10834", Slot = "47")]
		public void PutBoolArray(string key, bool[] val)
		{
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006645")]
		[Address(RVA = "0x2E108D0", Offset = "0x2E108D0", VA = "0x2E108D0", Slot = "48")]
		public void PutByteArray(string key, ByteArray val)
		{
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006646")]
		[Address(RVA = "0x2E1096C", Offset = "0x2E1096C", VA = "0x2E1096C", Slot = "49")]
		public void PutShortArray(string key, short[] val)
		{
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006647")]
		[Address(RVA = "0x2E10A08", Offset = "0x2E10A08", VA = "0x2E10A08", Slot = "50")]
		public void PutIntArray(string key, int[] val)
		{
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006648")]
		[Address(RVA = "0x2E10AA4", Offset = "0x2E10AA4", VA = "0x2E10AA4", Slot = "51")]
		public void PutLongArray(string key, long[] val)
		{
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006649")]
		[Address(RVA = "0x2E10B40", Offset = "0x2E10B40", VA = "0x2E10B40", Slot = "52")]
		public void PutFloatArray(string key, float[] val)
		{
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664A")]
		[Address(RVA = "0x2E10BDC", Offset = "0x2E10BDC", VA = "0x2E10BDC", Slot = "53")]
		public void PutDoubleArray(string key, double[] val)
		{
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664B")]
		[Address(RVA = "0x2E10C78", Offset = "0x2E10C78", VA = "0x2E10C78", Slot = "54")]
		public void PutUtfStringArray(string key, string[] val)
		{
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664C")]
		[Address(RVA = "0x2E10D14", Offset = "0x2E10D14", VA = "0x2E10D14", Slot = "55")]
		public void PutSFSArray(string key, ISFSArray val)
		{
		}

		// Token: 0x0600664D RID: 26189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664D")]
		[Address(RVA = "0x2E10DB0", Offset = "0x2E10DB0", VA = "0x2E10DB0", Slot = "56")]
		public void PutSFSObject(string key, ISFSObject val)
		{
		}

		// Token: 0x0600664E RID: 26190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664E")]
		[Address(RVA = "0x2E10E4C", Offset = "0x2E10E4C", VA = "0x2E10E4C", Slot = "79")]
		public virtual void PutClass(string key, object val)
		{
		}

		// Token: 0x0600664F RID: 26191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600664F")]
		[Address(RVA = "0x2DFF2E4", Offset = "0x2DFF2E4", VA = "0x2DFF2E4", Slot = "58")]
		public void Put(string key, SFSDataWrapper val)
		{
		}

		// Token: 0x06006650 RID: 26192 RVA: 0x0004C5C0 File Offset: 0x0004A7C0
		[Token(Token = "0x6006650")]
		[Address(RVA = "0x2E0F850", Offset = "0x2E0F850", VA = "0x2E0F850", Slot = "5")]
		public bool ContainsKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06006651 RID: 26193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006651")]
		[Address(RVA = "0x2E0C994", Offset = "0x2E0C994", VA = "0x2E0C994", Slot = "13")]
		public string GetDump(bool format)
		{
			return null;
		}

		// Token: 0x06006652 RID: 26194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006652")]
		[Address(RVA = "0x2E10EE8", Offset = "0x2E10EE8", VA = "0x2E10EE8", Slot = "14")]
		public string GetDump()
		{
			return null;
		}

		// Token: 0x06006653 RID: 26195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006653")]
		[Address(RVA = "0x2E10EF0", Offset = "0x2E10EF0", VA = "0x2E10EF0", Slot = "15")]
		public string GetHexDump()
		{
			return null;
		}

		// Token: 0x06006654 RID: 26196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006654")]
		[Address(RVA = "0x2E11024", Offset = "0x2E11024", VA = "0x2E11024", Slot = "7")]
		public string[] GetKeys()
		{
			return null;
		}

		// Token: 0x06006655 RID: 26197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006655")]
		[Address(RVA = "0x2E11100", Offset = "0x2E11100", VA = "0x2E11100", Slot = "8")]
		public void Traverse(Action<string, SFSDataWrapper> action)
		{
		}

		// Token: 0x06006656 RID: 26198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006656")]
		[Address(RVA = "0x2E11274", Offset = "0x2E11274", VA = "0x2E11274", Slot = "6")]
		public void RemoveElement(string key)
		{
		}

		// Token: 0x06006657 RID: 26199 RVA: 0x0004C5D8 File Offset: 0x0004A7D8
		[Token(Token = "0x6006657")]
		[Address(RVA = "0x2E0F708", Offset = "0x2E0F708", VA = "0x2E0F708", Slot = "9")]
		public int Size()
		{
			return 0;
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006658")]
		[Address(RVA = "0x2E10F54", Offset = "0x2E10F54", VA = "0x2E10F54", Slot = "10")]
		public ByteArray ToBinary()
		{
			return null;
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006659")]
		[Address(RVA = "0x2E112CC", Offset = "0x2E112CC", VA = "0x2E112CC", Slot = "11")]
		public ByteArray ToBinary(ByteArray dst)
		{
			return null;
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600665A")]
		[Address(RVA = "0x2E11378", Offset = "0x2E11378", VA = "0x2E11378", Slot = "12")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x0600665B RID: 26203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600665B")]
		[Address(RVA = "0x2E1142C", Offset = "0x2E1142C", VA = "0x2E1142C")]
		private Dictionary<string, object> flatten()
		{
			return null;
		}

		// Token: 0x040028D6 RID: 10454
		[Token(Token = "0x40028D6")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, SFSDataWrapper> dataHolder;

		// Token: 0x040028D7 RID: 10455
		[Token(Token = "0x40028D7")]
		[FieldOffset(Offset = "0x18")]
		private ISFSDataSerializer serializer;
	}
}
