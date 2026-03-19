using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000AF1 RID: 2801
	[Token(Token = "0x2000AF1")]
	public sealed class ExtensionRegistry : ICollection<Extension>, IEnumerable<Extension>, IEnumerable, IDeepCloneable<ExtensionRegistry>
	{
		// Token: 0x06006B3D RID: 27453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B3D")]
		[Address(RVA = "0x36D7674", Offset = "0x36D7674", VA = "0x36D7674")]
		public ExtensionRegistry()
		{
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B3E")]
		[Address(RVA = "0x36D76FC", Offset = "0x36D76FC", VA = "0x36D76FC")]
		private ExtensionRegistry(IDictionary<ObjectIntPair<Type>, Extension> collection)
		{
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06006B3F RID: 27455 RVA: 0x0004E2A0 File Offset: 0x0004C4A0
		[Token(Token = "0x170007BC")]
		public int Count
		{
			[Token(Token = "0x6006B3F")]
			[Address(RVA = "0x36D78C0", Offset = "0x36D78C0", VA = "0x36D78C0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06006B40 RID: 27456 RVA: 0x0004E2B8 File Offset: 0x0004C4B8
		[Token(Token = "0x170007BD")]
		private bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.IsReadOnly
		{
			[Token(Token = "0x6006B40")]
			[Address(RVA = "0x36D7960", Offset = "0x36D7960", VA = "0x36D7960", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x0004E2D0 File Offset: 0x0004C4D0
		[Token(Token = "0x6006B41")]
		[Address(RVA = "0x36D7968", Offset = "0x36D7968", VA = "0x36D7968")]
		internal bool ContainsInputField(CodedInputStream stream, Type target, out Extension extension)
		{
			return default(bool);
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B42")]
		[Address(RVA = "0x36D7A7C", Offset = "0x36D7A7C", VA = "0x36D7A7C", Slot = "6")]
		public void Add(Extension extension)
		{
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B43")]
		[Address(RVA = "0x36D7BC0", Offset = "0x36D7BC0", VA = "0x36D7BC0")]
		public void AddRange(IEnumerable<Extension> extensions)
		{
		}

		// Token: 0x06006B44 RID: 27460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B44")]
		[Address(RVA = "0x36D7ED0", Offset = "0x36D7ED0", VA = "0x36D7ED0", Slot = "7")]
		public void Clear()
		{
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x0004E2E8 File Offset: 0x0004C4E8
		[Token(Token = "0x6006B45")]
		[Address(RVA = "0x36D7F74", Offset = "0x36D7F74", VA = "0x36D7F74", Slot = "8")]
		public bool Contains(Extension item)
		{
			return default(bool);
		}

		// Token: 0x06006B46 RID: 27462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B46")]
		[Address(RVA = "0x36D80B8", Offset = "0x36D80B8", VA = "0x36D80B8", Slot = "9")]
		private void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(Extension[] array, int arrayIndex)
		{
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B47")]
		[Address(RVA = "0x36D82F0", Offset = "0x36D82F0", VA = "0x36D82F0", Slot = "11")]
		public IEnumerator<Extension> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x0004E300 File Offset: 0x0004C500
		[Token(Token = "0x6006B48")]
		[Address(RVA = "0x36D8408", Offset = "0x36D8408", VA = "0x36D8408", Slot = "10")]
		public bool Remove(Extension item)
		{
			return default(bool);
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B49")]
		[Address(RVA = "0x36D854C", Offset = "0x36D854C", VA = "0x36D854C", Slot = "12")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B4A")]
		[Address(RVA = "0x36D8550", Offset = "0x36D8550", VA = "0x36D8550", Slot = "13")]
		public ExtensionRegistry Clone()
		{
			return null;
		}

		// Token: 0x04002B24 RID: 11044
		[Token(Token = "0x4002B24")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<ObjectIntPair<Type>, Extension> extensions;
	}
}
