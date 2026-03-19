using System;
using System.Collections;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000ADD RID: 2781
	[Token(Token = "0x2000ADD")]
	public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060069DE RID: 27102 RVA: 0x0004D448 File Offset: 0x0004B648
		[Token(Token = "0x17000785")]
		public bool IsArray
		{
			[Token(Token = "0x60069DE")]
			[Address(RVA = "0x3497C04", Offset = "0x3497C04", VA = "0x3497C04", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060069DF RID: 27103 RVA: 0x0004D460 File Offset: 0x0004B660
		[Token(Token = "0x17000786")]
		public bool IsBoolean
		{
			[Token(Token = "0x60069DF")]
			[Address(RVA = "0x3497C0C", Offset = "0x3497C0C", VA = "0x3497C0C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060069E0 RID: 27104 RVA: 0x0004D478 File Offset: 0x0004B678
		[Token(Token = "0x17000787")]
		public bool IsDouble
		{
			[Token(Token = "0x60069E0")]
			[Address(RVA = "0x3497C14", Offset = "0x3497C14", VA = "0x3497C14", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060069E1 RID: 27105 RVA: 0x0004D490 File Offset: 0x0004B690
		[Token(Token = "0x17000788")]
		public bool IsInt
		{
			[Token(Token = "0x60069E1")]
			[Address(RVA = "0x3497C1C", Offset = "0x3497C1C", VA = "0x3497C1C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060069E2 RID: 27106 RVA: 0x0004D4A8 File Offset: 0x0004B6A8
		[Token(Token = "0x17000789")]
		public bool IsLong
		{
			[Token(Token = "0x60069E2")]
			[Address(RVA = "0x3497C24", Offset = "0x3497C24", VA = "0x3497C24", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060069E3 RID: 27107 RVA: 0x0004D4C0 File Offset: 0x0004B6C0
		[Token(Token = "0x1700078A")]
		public bool IsObject
		{
			[Token(Token = "0x60069E3")]
			[Address(RVA = "0x3497C2C", Offset = "0x3497C2C", VA = "0x3497C2C", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060069E4 RID: 27108 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
		[Token(Token = "0x1700078B")]
		public bool IsString
		{
			[Token(Token = "0x60069E4")]
			[Address(RVA = "0x3497C34", Offset = "0x3497C34", VA = "0x3497C34", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x0004D4F0 File Offset: 0x0004B6F0
		[Token(Token = "0x60069E5")]
		[Address(RVA = "0x3497C3C", Offset = "0x3497C3C", VA = "0x3497C3C", Slot = "11")]
		public bool GetBoolean()
		{
			return default(bool);
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x0004D508 File Offset: 0x0004B708
		[Token(Token = "0x60069E6")]
		[Address(RVA = "0x3497C44", Offset = "0x3497C44", VA = "0x3497C44", Slot = "12")]
		public double GetDouble()
		{
			return 0.0;
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x0004D520 File Offset: 0x0004B720
		[Token(Token = "0x60069E7")]
		[Address(RVA = "0x3497C4C", Offset = "0x3497C4C", VA = "0x3497C4C", Slot = "13")]
		public int GetInt()
		{
			return 0;
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x0004D538 File Offset: 0x0004B738
		[Token(Token = "0x60069E8")]
		[Address(RVA = "0x3497C54", Offset = "0x3497C54", VA = "0x3497C54", Slot = "14")]
		public JsonType GetJsonType()
		{
			return JsonType.None;
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x0004D550 File Offset: 0x0004B750
		[Token(Token = "0x60069E9")]
		[Address(RVA = "0x3497C5C", Offset = "0x3497C5C", VA = "0x3497C5C", Slot = "15")]
		public long GetLong()
		{
			return 0L;
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069EA")]
		[Address(RVA = "0x3497C64", Offset = "0x3497C64", VA = "0x3497C64", Slot = "16")]
		public string GetString()
		{
			return null;
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069EB")]
		[Address(RVA = "0x3497CA4", Offset = "0x3497CA4", VA = "0x3497CA4", Slot = "17")]
		public void SetBoolean(bool val)
		{
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069EC")]
		[Address(RVA = "0x3497CA8", Offset = "0x3497CA8", VA = "0x3497CA8", Slot = "18")]
		public void SetDouble(double val)
		{
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069ED")]
		[Address(RVA = "0x3497CAC", Offset = "0x3497CAC", VA = "0x3497CAC", Slot = "19")]
		public void SetInt(int val)
		{
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069EE")]
		[Address(RVA = "0x3497CB0", Offset = "0x3497CB0", VA = "0x3497CB0", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069EF")]
		[Address(RVA = "0x3497CB4", Offset = "0x3497CB4", VA = "0x3497CB4", Slot = "21")]
		public void SetLong(long val)
		{
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F0")]
		[Address(RVA = "0x3497CB8", Offset = "0x3497CB8", VA = "0x3497CB8", Slot = "22")]
		public void SetString(string val)
		{
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069F1")]
		[Address(RVA = "0x3497CBC", Offset = "0x3497CBC", VA = "0x3497CBC", Slot = "23")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F2")]
		[Address(RVA = "0x3497CFC", Offset = "0x3497CFC", VA = "0x3497CFC", Slot = "24")]
		public void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060069F3 RID: 27123 RVA: 0x0004D568 File Offset: 0x0004B768
		[Token(Token = "0x1700078C")]
		private bool System.Collections.IList.IsFixedSize
		{
			[Token(Token = "0x60069F3")]
			[Address(RVA = "0x3497D00", Offset = "0x3497D00", VA = "0x3497D00", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060069F4 RID: 27124 RVA: 0x0004D580 File Offset: 0x0004B780
		[Token(Token = "0x1700078D")]
		private bool System.Collections.IList.IsReadOnly
		{
			[Token(Token = "0x60069F4")]
			[Address(RVA = "0x3497D08", Offset = "0x3497D08", VA = "0x3497D08", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060069F5 RID: 27125 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060069F6 RID: 27126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078E")]
		private object System.Collections.IList.Item
		{
			[Token(Token = "0x60069F5")]
			[Address(RVA = "0x3497D10", Offset = "0x3497D10", VA = "0x3497D10", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x60069F6")]
			[Address(RVA = "0x3497D18", Offset = "0x3497D18", VA = "0x3497D18", Slot = "26")]
			set
			{
			}
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x0004D598 File Offset: 0x0004B798
		[Token(Token = "0x60069F7")]
		[Address(RVA = "0x3497D1C", Offset = "0x3497D1C", VA = "0x3497D1C", Slot = "27")]
		private int System.Collections.IList.Add(object value)
		{
			return 0;
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069F8")]
		[Address(RVA = "0x3497D24", Offset = "0x3497D24", VA = "0x3497D24", Slot = "29")]
		private void System.Collections.IList.Clear()
		{
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x0004D5B0 File Offset: 0x0004B7B0
		[Token(Token = "0x60069F9")]
		[Address(RVA = "0x3497D28", Offset = "0x3497D28", VA = "0x3497D28", Slot = "28")]
		private bool System.Collections.IList.Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x0004D5C8 File Offset: 0x0004B7C8
		[Token(Token = "0x60069FA")]
		[Address(RVA = "0x3497D30", Offset = "0x3497D30", VA = "0x3497D30", Slot = "32")]
		private int System.Collections.IList.IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FB")]
		[Address(RVA = "0x3497D38", Offset = "0x3497D38", VA = "0x3497D38", Slot = "33")]
		private void System.Collections.IList.Insert(int i, object v)
		{
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FC")]
		[Address(RVA = "0x3497D3C", Offset = "0x3497D3C", VA = "0x3497D3C", Slot = "34")]
		private void System.Collections.IList.Remove(object value)
		{
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FD")]
		[Address(RVA = "0x3497D40", Offset = "0x3497D40", VA = "0x3497D40", Slot = "35")]
		private void System.Collections.IList.RemoveAt(int index)
		{
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060069FE RID: 27134 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
		[Token(Token = "0x1700078F")]
		private int System.Collections.ICollection.Count
		{
			[Token(Token = "0x60069FE")]
			[Address(RVA = "0x3497D44", Offset = "0x3497D44", VA = "0x3497D44", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060069FF RID: 27135 RVA: 0x0004D5F8 File Offset: 0x0004B7F8
		[Token(Token = "0x17000790")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x60069FF")]
			[Address(RVA = "0x3497D4C", Offset = "0x3497D4C", VA = "0x3497D4C", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06006A00 RID: 27136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000791")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x6006A00")]
			[Address(RVA = "0x3497D54", Offset = "0x3497D54", VA = "0x3497D54", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A01")]
		[Address(RVA = "0x3497D5C", Offset = "0x3497D5C", VA = "0x3497D5C", Slot = "36")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A02")]
		[Address(RVA = "0x3497D60", Offset = "0x3497D60", VA = "0x3497D60", Slot = "40")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06006A03 RID: 27139 RVA: 0x0004D610 File Offset: 0x0004B810
		[Token(Token = "0x17000792")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[Token(Token = "0x6006A03")]
			[Address(RVA = "0x3497D68", Offset = "0x3497D68", VA = "0x3497D68", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06006A04 RID: 27140 RVA: 0x0004D628 File Offset: 0x0004B828
		[Token(Token = "0x17000793")]
		private bool System.Collections.IDictionary.IsReadOnly
		{
			[Token(Token = "0x6006A04")]
			[Address(RVA = "0x3497D70", Offset = "0x3497D70", VA = "0x3497D70", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06006A05 RID: 27141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000794")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[Token(Token = "0x6006A05")]
			[Address(RVA = "0x3497D78", Offset = "0x3497D78", VA = "0x3497D78", Slot = "48")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06006A06 RID: 27142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000795")]
		private ICollection System.Collections.IDictionary.Values
		{
			[Token(Token = "0x6006A06")]
			[Address(RVA = "0x3497D80", Offset = "0x3497D80", VA = "0x3497D80", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06006A07 RID: 27143 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A08 RID: 27144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000796")]
		private object System.Collections.IDictionary.Item
		{
			[Token(Token = "0x6006A07")]
			[Address(RVA = "0x3497D88", Offset = "0x3497D88", VA = "0x3497D88", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A08")]
			[Address(RVA = "0x3497D90", Offset = "0x3497D90", VA = "0x3497D90", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A09")]
		[Address(RVA = "0x3497D94", Offset = "0x3497D94", VA = "0x3497D94", Slot = "51")]
		private void System.Collections.IDictionary.Add(object k, object v)
		{
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A0A")]
		[Address(RVA = "0x3497D98", Offset = "0x3497D98", VA = "0x3497D98", Slot = "52")]
		private void System.Collections.IDictionary.Clear()
		{
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x0004D640 File Offset: 0x0004B840
		[Token(Token = "0x6006A0B")]
		[Address(RVA = "0x3497D9C", Offset = "0x3497D9C", VA = "0x3497D9C", Slot = "50")]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A0C")]
		[Address(RVA = "0x3497DA4", Offset = "0x3497DA4", VA = "0x3497DA4", Slot = "56")]
		private void System.Collections.IDictionary.Remove(object key)
		{
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A0D")]
		[Address(RVA = "0x3497DA8", Offset = "0x3497DA8", VA = "0x3497DA8", Slot = "55")]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06006A0E RID: 27150 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A0F RID: 27151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000797")]
		private object System.Collections.Specialized.IOrderedDictionary.Item
		{
			[Token(Token = "0x6006A0E")]
			[Address(RVA = "0x3497DB0", Offset = "0x3497DB0", VA = "0x3497DB0", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A0F")]
			[Address(RVA = "0x3497DB8", Offset = "0x3497DB8", VA = "0x3497DB8", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A10")]
		[Address(RVA = "0x3497DBC", Offset = "0x3497DBC", VA = "0x3497DBC", Slot = "43")]
		private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A11")]
		[Address(RVA = "0x3497DC4", Offset = "0x3497DC4", VA = "0x3497DC4", Slot = "44")]
		private void System.Collections.Specialized.IOrderedDictionary.Insert(int i, object k, object v)
		{
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A12")]
		[Address(RVA = "0x3497DC8", Offset = "0x3497DC8", VA = "0x3497DC8", Slot = "45")]
		private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int i)
		{
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A13")]
		[Address(RVA = "0x3496660", Offset = "0x3496660", VA = "0x3496660")]
		public JsonMockWrapper()
		{
		}
	}
}
