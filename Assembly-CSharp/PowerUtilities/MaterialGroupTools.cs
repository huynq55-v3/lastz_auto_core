using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace PowerUtilities
{
	// Token: 0x020003AC RID: 940
	[Token(Token = "0x20003AC")]
	public static class MaterialGroupTools
	{
		// Token: 0x060017C3 RID: 6083 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x60017C3")]
		[Address(RVA = "0x1DB9628", Offset = "0x1DB9628", VA = "0x1DB9628")]
		public static bool IsDefaultGroup(string groupName)
		{
			return default(bool);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x1DB96F4", Offset = "0x1DB96F4", VA = "0x1DB96F4")]
		public static int GroupIndentLevel(string groupName)
		{
			return 0;
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x60017C5")]
		[Address(RVA = "0x1DB9754", Offset = "0x1DB9754", VA = "0x1DB9754")]
		public static bool IsGroupOn(string groupName)
		{
			return default(bool);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x60017C6")]
		[Address(RVA = "0x1DB9900", Offset = "0x1DB9900", VA = "0x1DB9900")]
		public static bool IsGroupDisabled(string groupName)
		{
			return default(bool);
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x1DB997C", Offset = "0x1DB997C", VA = "0x1DB997C")]
		public static void SetState(string groupName, bool isOn, bool hasCheckedMark = false, bool isChecked = false)
		{
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x1DB9A10", Offset = "0x1DB9A10", VA = "0x1DB9A10")]
		public static void SetStateAll(bool isOn, bool hasCheckedMark = false, bool isChecked = false)
		{
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017C9")]
		[Address(RVA = "0x1DB97E4", Offset = "0x1DB97E4", VA = "0x1DB97E4")]
		public static MaterialGroupTools.GroupInfo GetGroupInfo(string groupName)
		{
			return null;
		}

		// Token: 0x04001A83 RID: 6787
		[Token(Token = "0x4001A83")]
		public const string DEFAULT_GROUP_NAME = "_";

		// Token: 0x04001A84 RID: 6788
		[Token(Token = "0x4001A84")]
		public const float BASE_LABLE_WIDTH = 162.5f;

		// Token: 0x04001A85 RID: 6789
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<string, MaterialGroupTools.GroupInfo> groupInfoDict;

		// Token: 0x020003AD RID: 941
		[Token(Token = "0x20003AD")]
		public class GroupInfo
		{
			// Token: 0x060017CB RID: 6091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017CB")]
			[Address(RVA = "0x1DB9B3C", Offset = "0x1DB9B3C", VA = "0x1DB9B3C")]
			public GroupInfo()
			{
			}

			// Token: 0x04001A86 RID: 6790
			[Token(Token = "0x4001A86")]
			[FieldOffset(Offset = "0x10")]
			public bool isOn;

			// Token: 0x04001A87 RID: 6791
			[Token(Token = "0x4001A87")]
			[FieldOffset(Offset = "0x11")]
			public bool hasCheckedMark;

			// Token: 0x04001A88 RID: 6792
			[Token(Token = "0x4001A88")]
			[FieldOffset(Offset = "0x12")]
			public bool isChecked;
		}
	}
}
