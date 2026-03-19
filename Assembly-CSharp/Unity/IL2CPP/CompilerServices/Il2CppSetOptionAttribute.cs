using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x020004DC RID: 1244
	[Token(Token = "0x20004DC")]
	[AttributeUsage(4301, Inherited = false, AllowMultiple = true)]
	public class Il2CppSetOptionAttribute : Attribute
	{
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B4")]
		public Option Option
		{
			[Token(Token = "0x600257F")]
			[Address(RVA = "0x2B557E0", Offset = "0x2B557E0", VA = "0x2B557E0")]
			[CompilerGenerated]
			get
			{
				return (Option)0;
			}
			[Token(Token = "0x6002580")]
			[Address(RVA = "0x2B557E8", Offset = "0x2B557E8", VA = "0x2B557E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002581 RID: 9601 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002582 RID: 9602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B5")]
		public object Value
		{
			[Token(Token = "0x6002581")]
			[Address(RVA = "0x2B557F0", Offset = "0x2B557F0", VA = "0x2B557F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002582")]
			[Address(RVA = "0x2B557F8", Offset = "0x2B557F8", VA = "0x2B557F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002583")]
		[Address(RVA = "0x2B55800", Offset = "0x2B55800", VA = "0x2B55800")]
		public Il2CppSetOptionAttribute(Option option, object value)
		{
		}
	}
}
