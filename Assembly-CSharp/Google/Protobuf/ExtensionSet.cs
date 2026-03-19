using System;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AF3 RID: 2803
	[Token(Token = "0x2000AF3")]
	public static class ExtensionSet
	{
		// Token: 0x06006B4F RID: 27471 RVA: 0x0004E330 File Offset: 0x0004C530
		[Token(Token = "0x6006B4F")]
		private static bool TryGetValue<TTarget>(ref ExtensionSet<TTarget> set, Extension extension, out IExtensionValue value) where TTarget : IExtendableMessage<TTarget>
		{
			return default(bool);
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B50")]
		public static TValue Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return null;
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B51")]
		public static RepeatedField<TValue> Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return null;
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B52")]
		public static RepeatedField<TValue> GetOrInitialize<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return null;
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B53")]
		public static void Set<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension, TValue value) where TTarget : IExtendableMessage<TTarget>
		{
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x0004E348 File Offset: 0x0004C548
		[Token(Token = "0x6006B54")]
		public static bool Has<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
			return default(bool);
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B55")]
		public static void Clear<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B56")]
		public static void Clear<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension) where TTarget : IExtendableMessage<TTarget>
		{
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x0004E360 File Offset: 0x0004C560
		[Token(Token = "0x6006B57")]
		public static bool TryMergeFieldFrom<TTarget>(ref ExtensionSet<TTarget> set, CodedInputStream stream) where TTarget : IExtendableMessage<TTarget>
		{
			return default(bool);
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B58")]
		public static void MergeFrom<TTarget>(ref ExtensionSet<TTarget> first, ExtensionSet<TTarget> second) where TTarget : IExtendableMessage<TTarget>
		{
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B59")]
		public static ExtensionSet<TTarget> Clone<TTarget>(ExtensionSet<TTarget> set) where TTarget : IExtendableMessage<TTarget>
		{
			return null;
		}
	}
}
