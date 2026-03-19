using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf.Collections
{
	// Token: 0x02000C03 RID: 3075
	[Token(Token = "0x2000C03")]
	public static class ProtobufEqualityComparers
	{
		// Token: 0x06007559 RID: 30041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007559")]
		public static EqualityComparer<T> GetEqualityComparer<T>()
		{
			return null;
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600755A RID: 30042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A42")]
		public static EqualityComparer<double> BitwiseDoubleEqualityComparer
		{
			[Token(Token = "0x600755A")]
			[Address(RVA = "0x31B781C", Offset = "0x31B781C", VA = "0x31B781C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600755B RID: 30043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A43")]
		public static EqualityComparer<float> BitwiseSingleEqualityComparer
		{
			[Token(Token = "0x600755B")]
			[Address(RVA = "0x31B7874", Offset = "0x31B7874", VA = "0x31B7874")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x0600755C RID: 30044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A44")]
		public static EqualityComparer<double?> BitwiseNullableDoubleEqualityComparer
		{
			[Token(Token = "0x600755C")]
			[Address(RVA = "0x31B78CC", Offset = "0x31B78CC", VA = "0x31B78CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600755D RID: 30045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A45")]
		public static EqualityComparer<float?> BitwiseNullableSingleEqualityComparer
		{
			[Token(Token = "0x600755D")]
			[Address(RVA = "0x31B7924", Offset = "0x31B7924", VA = "0x31B7924")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x02000C04 RID: 3076
		[Token(Token = "0x2000C04")]
		private class BitwiseDoubleEqualityComparerImpl : EqualityComparer<double>
		{
			// Token: 0x0600755F RID: 30047 RVA: 0x00051A50 File Offset: 0x0004FC50
			[Token(Token = "0x600755F")]
			[Address(RVA = "0x31B7BD0", Offset = "0x31B7BD0", VA = "0x31B7BD0", Slot = "8")]
			public override bool Equals(double x, double y)
			{
				return default(bool);
			}

			// Token: 0x06007560 RID: 30048 RVA: 0x00051A68 File Offset: 0x0004FC68
			[Token(Token = "0x6007560")]
			[Address(RVA = "0x31B7C3C", Offset = "0x31B7C3C", VA = "0x31B7C3C", Slot = "9")]
			public override int GetHashCode(double obj)
			{
				return 0;
			}

			// Token: 0x06007561 RID: 30049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007561")]
			[Address(RVA = "0x31B7AB0", Offset = "0x31B7AB0", VA = "0x31B7AB0")]
			public BitwiseDoubleEqualityComparerImpl()
			{
			}
		}

		// Token: 0x02000C05 RID: 3077
		[Token(Token = "0x2000C05")]
		private class BitwiseSingleEqualityComparerImpl : EqualityComparer<float>
		{
			// Token: 0x06007562 RID: 30050 RVA: 0x00051A80 File Offset: 0x0004FC80
			[Token(Token = "0x6007562")]
			[Address(RVA = "0x31B7CB0", Offset = "0x31B7CB0", VA = "0x31B7CB0", Slot = "8")]
			public override bool Equals(float x, float y)
			{
				return default(bool);
			}

			// Token: 0x06007563 RID: 30051 RVA: 0x00051A98 File Offset: 0x0004FC98
			[Token(Token = "0x6007563")]
			[Address(RVA = "0x31B7D24", Offset = "0x31B7D24", VA = "0x31B7D24", Slot = "9")]
			public override int GetHashCode(float obj)
			{
				return 0;
			}

			// Token: 0x06007564 RID: 30052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007564")]
			[Address(RVA = "0x31B7AF8", Offset = "0x31B7AF8", VA = "0x31B7AF8")]
			public BitwiseSingleEqualityComparerImpl()
			{
			}
		}

		// Token: 0x02000C06 RID: 3078
		[Token(Token = "0x2000C06")]
		private class BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer<Nullable<double>>
		{
			// Token: 0x06007565 RID: 30053 RVA: 0x00051AB0 File Offset: 0x0004FCB0
			[Token(Token = "0x6007565")]
			[Address(RVA = "0x31B7D9C", Offset = "0x31B7D9C", VA = "0x31B7D9C", Slot = "8")]
			public override bool Equals(double? x, double? y)
			{
				return default(bool);
			}

			// Token: 0x06007566 RID: 30054 RVA: 0x00051AC8 File Offset: 0x0004FCC8
			[Token(Token = "0x6007566")]
			[Address(RVA = "0x31B7EC0", Offset = "0x31B7EC0", VA = "0x31B7EC0", Slot = "9")]
			public override int GetHashCode(double? obj)
			{
				return 0;
			}

			// Token: 0x06007567 RID: 30055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007567")]
			[Address(RVA = "0x31B7B40", Offset = "0x31B7B40", VA = "0x31B7B40")]
			public BitwiseNullableDoubleEqualityComparerImpl()
			{
			}
		}

		// Token: 0x02000C07 RID: 3079
		[Token(Token = "0x2000C07")]
		private class BitwiseNullableSingleEqualityComparerImpl : EqualityComparer<Nullable<float>>
		{
			// Token: 0x06007568 RID: 30056 RVA: 0x00051AE0 File Offset: 0x0004FCE0
			[Token(Token = "0x6007568")]
			[Address(RVA = "0x31B7FB0", Offset = "0x31B7FB0", VA = "0x31B7FB0", Slot = "8")]
			public override bool Equals(float? x, float? y)
			{
				return default(bool);
			}

			// Token: 0x06007569 RID: 30057 RVA: 0x00051AF8 File Offset: 0x0004FCF8
			[Token(Token = "0x6007569")]
			[Address(RVA = "0x31B80D4", Offset = "0x31B80D4", VA = "0x31B80D4", Slot = "9")]
			public override int GetHashCode(float? obj)
			{
				return 0;
			}

			// Token: 0x0600756A RID: 30058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600756A")]
			[Address(RVA = "0x31B7B88", Offset = "0x31B7B88", VA = "0x31B7B88")]
			public BitwiseNullableSingleEqualityComparerImpl()
			{
			}
		}
	}
}
