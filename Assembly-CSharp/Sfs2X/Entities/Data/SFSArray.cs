using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sfs2X.Protocol.Serialization;
using Sfs2X.Util;

namespace Sfs2X.Entities.Data
{
	// Token: 0x02000A73 RID: 2675
	[Token(Token = "0x2000A73")]
	public class SFSArray : ISFSArray, ICollection, IEnumerable
	{
		// Token: 0x060065B4 RID: 26036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B4")]
		[Address(RVA = "0x2E0BD34", Offset = "0x2E0BD34", VA = "0x2E0BD34")]
		public static SFSArray NewFromBinaryData(ByteArray ba)
		{
			return null;
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B5")]
		[Address(RVA = "0x2E0BDE4", Offset = "0x2E0BDE4", VA = "0x2E0BDE4")]
		public static ISFSArray NewFromJsonData(string js)
		{
			return null;
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B6")]
		[Address(RVA = "0x2DFF75C", Offset = "0x2DFF75C", VA = "0x2DFF75C")]
		public static SFSArray NewInstance()
		{
			return null;
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B7")]
		[Address(RVA = "0x2E0BE44", Offset = "0x2E0BE44", VA = "0x2E0BE44")]
		public SFSArray()
		{
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x0004C2C0 File Offset: 0x0004A4C0
		[Token(Token = "0x60065B8")]
		[Address(RVA = "0x2E0BF04", Offset = "0x2E0BF04", VA = "0x2E0BF04", Slot = "4")]
		public bool Contains(object obj)
		{
			return default(bool);
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065B9")]
		[Address(RVA = "0x2E0C0E8", Offset = "0x2E0C0E8", VA = "0x2E0C0E8", Slot = "6")]
		public SFSDataWrapper GetWrappedElementAt(int index)
		{
			return null;
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BA")]
		[Address(RVA = "0x2E0C01C", Offset = "0x2E0C01C", VA = "0x2E0C01C", Slot = "5")]
		public object GetElementAt(int index)
		{
			return null;
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BB")]
		[Address(RVA = "0x2E0C140", Offset = "0x2E0C140", VA = "0x2E0C140", Slot = "7")]
		public object RemoveElementAt(int index)
		{
			return null;
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
		[Token(Token = "0x60065BC")]
		[Address(RVA = "0x2E0C0A0", Offset = "0x2E0C0A0", VA = "0x2E0C0A0", Slot = "8")]
		public int Size()
		{
			return 0;
		}

		// Token: 0x060065BD RID: 26045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BD")]
		[Address(RVA = "0x2E0C1FC", Offset = "0x2E0C1FC", VA = "0x2E0C1FC", Slot = "9")]
		public ByteArray ToBinary()
		{
			return null;
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BE")]
		[Address(RVA = "0x2E0C2D0", Offset = "0x2E0C2D0", VA = "0x2E0C2D0", Slot = "10")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065BF")]
		[Address(RVA = "0x2E0C384", Offset = "0x2E0C384", VA = "0x2E0C384")]
		private List<object> flatten()
		{
			return null;
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C0")]
		[Address(RVA = "0x2E0C430", Offset = "0x2E0C430", VA = "0x2E0C430", Slot = "12")]
		public string GetDump()
		{
			return null;
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C1")]
		[Address(RVA = "0x2E0C438", Offset = "0x2E0C438", VA = "0x2E0C438", Slot = "11")]
		public string GetDump(bool format)
		{
			return null;
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C2")]
		[Address(RVA = "0x2E0C4B0", Offset = "0x2E0C4B0", VA = "0x2E0C4B0")]
		private string Dump()
		{
			return null;
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065C3")]
		[Address(RVA = "0x2E0CA0C", Offset = "0x2E0CA0C", VA = "0x2E0CA0C", Slot = "13")]
		public string GetHexDump()
		{
			return null;
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C4")]
		[Address(RVA = "0x2E0CA70", Offset = "0x2E0CA70", VA = "0x2E0CA70", Slot = "14")]
		public void AddNull()
		{
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C5")]
		[Address(RVA = "0x2E0CAF4", Offset = "0x2E0CAF4", VA = "0x2E0CAF4", Slot = "15")]
		public void AddBool(bool val)
		{
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C6")]
		[Address(RVA = "0x2E0CB60", Offset = "0x2E0CB60", VA = "0x2E0CB60", Slot = "16")]
		public void AddByte(byte val)
		{
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C7")]
		[Address(RVA = "0x2E0CBCC", Offset = "0x2E0CBCC", VA = "0x2E0CBCC", Slot = "17")]
		public void AddShort(short val)
		{
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C8")]
		[Address(RVA = "0x2E0CC38", Offset = "0x2E0CC38", VA = "0x2E0CC38", Slot = "18")]
		public void AddInt(int val)
		{
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065C9")]
		[Address(RVA = "0x2E0CCA4", Offset = "0x2E0CCA4", VA = "0x2E0CCA4", Slot = "19")]
		public void AddLong(long val)
		{
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CA")]
		[Address(RVA = "0x2E0CD10", Offset = "0x2E0CD10", VA = "0x2E0CD10", Slot = "20")]
		public void AddFloat(float val)
		{
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CB")]
		[Address(RVA = "0x2E0CD7C", Offset = "0x2E0CD7C", VA = "0x2E0CD7C", Slot = "21")]
		public void AddDouble(double val)
		{
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CC")]
		[Address(RVA = "0x2E0CDE8", Offset = "0x2E0CDE8", VA = "0x2E0CDE8", Slot = "22")]
		public void AddUtfString(string val)
		{
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CD")]
		[Address(RVA = "0x2E0CDF0", Offset = "0x2E0CDF0", VA = "0x2E0CDF0", Slot = "23")]
		public void AddText(string val)
		{
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CE")]
		[Address(RVA = "0x2E0CDF8", Offset = "0x2E0CDF8", VA = "0x2E0CDF8", Slot = "24")]
		public void AddBoolArray(bool[] val)
		{
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065CF")]
		[Address(RVA = "0x2E0CE00", Offset = "0x2E0CE00", VA = "0x2E0CE00", Slot = "25")]
		public void AddByteArray(ByteArray val)
		{
		}

		// Token: 0x060065D0 RID: 26064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D0")]
		[Address(RVA = "0x2E0CE08", Offset = "0x2E0CE08", VA = "0x2E0CE08", Slot = "26")]
		public void AddShortArray(short[] val)
		{
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D1")]
		[Address(RVA = "0x2E0CE10", Offset = "0x2E0CE10", VA = "0x2E0CE10", Slot = "27")]
		public void AddIntArray(int[] val)
		{
		}

		// Token: 0x060065D2 RID: 26066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D2")]
		[Address(RVA = "0x2E0CE18", Offset = "0x2E0CE18", VA = "0x2E0CE18", Slot = "28")]
		public void AddLongArray(long[] val)
		{
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0x2E0CE20", Offset = "0x2E0CE20", VA = "0x2E0CE20", Slot = "29")]
		public void AddFloatArray(float[] val)
		{
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0x2E0CE28", Offset = "0x2E0CE28", VA = "0x2E0CE28", Slot = "30")]
		public void AddDoubleArray(double[] val)
		{
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D5")]
		[Address(RVA = "0x2E0CE30", Offset = "0x2E0CE30", VA = "0x2E0CE30", Slot = "31")]
		public void AddUtfStringArray(string[] val)
		{
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D6")]
		[Address(RVA = "0x2E0CE38", Offset = "0x2E0CE38", VA = "0x2E0CE38", Slot = "32")]
		public void AddSFSArray(ISFSArray val)
		{
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D7")]
		[Address(RVA = "0x2E0CE40", Offset = "0x2E0CE40", VA = "0x2E0CE40", Slot = "33")]
		public void AddSFSObject(ISFSObject val)
		{
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D8")]
		[Address(RVA = "0x2E0CE48", Offset = "0x2E0CE48", VA = "0x2E0CE48", Slot = "34")]
		public void AddClass(object val)
		{
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D9")]
		[Address(RVA = "0x2E0CE50", Offset = "0x2E0CE50", VA = "0x2E0CE50", Slot = "35")]
		public void Add(SFSDataWrapper wrappedObject)
		{
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DA")]
		[Address(RVA = "0x2E0CA7C", Offset = "0x2E0CA7C", VA = "0x2E0CA7C")]
		private void AddObject(object val, SFSDataType tp)
		{
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065DB")]
		private T GetValue<T>(int index)
		{
			return null;
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x0004C2F0 File Offset: 0x0004A4F0
		[Token(Token = "0x60065DC")]
		[Address(RVA = "0x2E0CF00", Offset = "0x2E0CF00", VA = "0x2E0CF00", Slot = "36")]
		public bool IsNull(int index)
		{
			return default(bool);
		}

		// Token: 0x060065DD RID: 26077 RVA: 0x0004C308 File Offset: 0x0004A508
		[Token(Token = "0x60065DD")]
		[Address(RVA = "0x2E0CF6C", Offset = "0x2E0CF6C", VA = "0x2E0CF6C", Slot = "62")]
		public virtual bool GetBool(int index)
		{
			return default(bool);
		}

		// Token: 0x060065DE RID: 26078 RVA: 0x0004C320 File Offset: 0x0004A520
		[Token(Token = "0x60065DE")]
		[Address(RVA = "0x2E0CFFC", Offset = "0x2E0CFFC", VA = "0x2E0CFFC", Slot = "63")]
		public virtual byte GetByte(int index)
		{
			return 0;
		}

		// Token: 0x060065DF RID: 26079 RVA: 0x0004C338 File Offset: 0x0004A538
		[Token(Token = "0x60065DF")]
		[Address(RVA = "0x2E0D084", Offset = "0x2E0D084", VA = "0x2E0D084", Slot = "64")]
		public virtual short GetShort(int index)
		{
			return 0;
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x0004C350 File Offset: 0x0004A550
		[Token(Token = "0x60065E0")]
		[Address(RVA = "0x2E0D10C", Offset = "0x2E0D10C", VA = "0x2E0D10C", Slot = "65")]
		public virtual int GetInt(int index)
		{
			return 0;
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x0004C368 File Offset: 0x0004A568
		[Token(Token = "0x60065E1")]
		[Address(RVA = "0x2E0D194", Offset = "0x2E0D194", VA = "0x2E0D194", Slot = "66")]
		public virtual long GetLong(int index)
		{
			return 0L;
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x0004C380 File Offset: 0x0004A580
		[Token(Token = "0x60065E2")]
		[Address(RVA = "0x2E0D220", Offset = "0x2E0D220", VA = "0x2E0D220", Slot = "67")]
		public virtual float GetFloat(int index)
		{
			return 0f;
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x0004C398 File Offset: 0x0004A598
		[Token(Token = "0x60065E3")]
		[Address(RVA = "0x2E0D278", Offset = "0x2E0D278", VA = "0x2E0D278", Slot = "68")]
		public virtual double GetDouble(int index)
		{
			return 0.0;
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E4")]
		[Address(RVA = "0x2E0D2D0", Offset = "0x2E0D2D0", VA = "0x2E0D2D0", Slot = "44")]
		public string GetUtfString(int index)
		{
			return null;
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E5")]
		[Address(RVA = "0x2E0D328", Offset = "0x2E0D328", VA = "0x2E0D328", Slot = "45")]
		public string GetText(int index)
		{
			return null;
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E6")]
		[Address(RVA = "0x2E0D380", Offset = "0x2E0D380", VA = "0x2E0D380")]
		private ICollection GetArray(int index)
		{
			return null;
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E7")]
		[Address(RVA = "0x2E0D3D8", Offset = "0x2E0D3D8", VA = "0x2E0D3D8", Slot = "69")]
		public virtual bool[] GetBoolArray(int index)
		{
			return null;
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E8")]
		[Address(RVA = "0x2E0D44C", Offset = "0x2E0D44C", VA = "0x2E0D44C", Slot = "70")]
		public virtual ByteArray GetByteArray(int index)
		{
			return null;
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065E9")]
		[Address(RVA = "0x2E0D4A4", Offset = "0x2E0D4A4", VA = "0x2E0D4A4", Slot = "71")]
		public virtual short[] GetShortArray(int index)
		{
			return null;
		}

		// Token: 0x060065EA RID: 26090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EA")]
		[Address(RVA = "0x2E0D518", Offset = "0x2E0D518", VA = "0x2E0D518", Slot = "72")]
		public virtual int[] GetIntArray(int index)
		{
			return null;
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EB")]
		[Address(RVA = "0x2E0D58C", Offset = "0x2E0D58C", VA = "0x2E0D58C", Slot = "73")]
		public virtual long[] GetLongArray(int index)
		{
			return null;
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EC")]
		[Address(RVA = "0x2E0D600", Offset = "0x2E0D600", VA = "0x2E0D600", Slot = "74")]
		public virtual float[] GetFloatArray(int index)
		{
			return null;
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065ED")]
		[Address(RVA = "0x2E0D674", Offset = "0x2E0D674", VA = "0x2E0D674", Slot = "75")]
		public virtual double[] GetDoubleArray(int index)
		{
			return null;
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EE")]
		[Address(RVA = "0x2E0D6E8", Offset = "0x2E0D6E8", VA = "0x2E0D6E8", Slot = "76")]
		public virtual string[] GetUtfStringArray(int index)
		{
			return null;
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065EF")]
		[Address(RVA = "0x2E0D75C", Offset = "0x2E0D75C", VA = "0x2E0D75C", Slot = "77")]
		public virtual ISFSArray GetSFSArray(int index)
		{
			return null;
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F0")]
		[Address(RVA = "0x2E0D7B4", Offset = "0x2E0D7B4", VA = "0x2E0D7B4", Slot = "78")]
		public virtual object GetClass(int index)
		{
			return null;
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F1")]
		[Address(RVA = "0x2E0D820", Offset = "0x2E0D820", VA = "0x2E0D820", Slot = "79")]
		public virtual ISFSObject GetSFSObject(int index)
		{
			return null;
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065F2")]
		[Address(RVA = "0x2E0D878", Offset = "0x2E0D878", VA = "0x2E0D878", Slot = "57")]
		private void System.Collections.ICollection.CopyTo(Array toArray, int index)
		{
		}

		// Token: 0x060065F3 RID: 26099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F3")]
		[Address(RVA = "0x2E0D9D0", Offset = "0x2E0D9D0", VA = "0x2E0D9D0", Slot = "61")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060065F4 RID: 26100 RVA: 0x0004C3B0 File Offset: 0x0004A5B0
		[Token(Token = "0x170006B4")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x60065F4")]
			[Address(RVA = "0x2E0DA88", Offset = "0x2E0DA88", VA = "0x2E0DA88", Slot = "60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060065F5 RID: 26101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006B5")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x60065F5")]
			[Address(RVA = "0x2E0DA90", Offset = "0x2E0DA90", VA = "0x2E0DA90", Slot = "59")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060065F6 RID: 26102 RVA: 0x0004C3C8 File Offset: 0x0004A5C8
		[Token(Token = "0x170006B6")]
		private int System.Collections.ICollection.Count
		{
			[Token(Token = "0x60065F6")]
			[Address(RVA = "0x2E0DA94", Offset = "0x2E0DA94", VA = "0x2E0DA94", Slot = "58")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040028B9 RID: 10425
		[Token(Token = "0x40028B9")]
		[FieldOffset(Offset = "0x10")]
		private ISFSDataSerializer serializer;

		// Token: 0x040028BA RID: 10426
		[Token(Token = "0x40028BA")]
		[FieldOffset(Offset = "0x18")]
		private List<SFSDataWrapper> dataHolder;
	}
}
