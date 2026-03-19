using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.Protobuf.WellKnownTypes;
using Il2CppDummyDll;

namespace Google.Protobuf
{
	// Token: 0x02000B0C RID: 2828
	[Token(Token = "0x2000B0C")]
	internal sealed class FieldMaskTree
	{
		// Token: 0x06006C10 RID: 27664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C10")]
		[Address(RVA = "0x36DB0EC", Offset = "0x36DB0EC", VA = "0x36DB0EC")]
		public FieldMaskTree()
		{
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C11")]
		[Address(RVA = "0x36DB1E4", Offset = "0x36DB1E4", VA = "0x36DB1E4")]
		public FieldMaskTree(FieldMask mask)
		{
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C12")]
		[Address(RVA = "0x36DB4F8", Offset = "0x36DB4F8", VA = "0x36DB4F8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C13")]
		[Address(RVA = "0x36DB640", Offset = "0x36DB640", VA = "0x36DB640")]
		public FieldMaskTree AddFieldPath(string path)
		{
			return null;
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C14")]
		[Address(RVA = "0x36DB26C", Offset = "0x36DB26C", VA = "0x36DB26C")]
		public FieldMaskTree MergeFromFieldMask(FieldMask mask)
		{
			return null;
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C15")]
		[Address(RVA = "0x36DB518", Offset = "0x36DB518", VA = "0x36DB518")]
		public FieldMask ToFieldMask()
		{
			return null;
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C16")]
		[Address(RVA = "0x36DB800", Offset = "0x36DB800", VA = "0x36DB800")]
		private void GetFieldPaths(FieldMaskTree.Node node, string path, List<string> paths)
		{
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C17")]
		[Address(RVA = "0x36DBA58", Offset = "0x36DBA58", VA = "0x36DBA58")]
		public void IntersectFieldPath(string path, FieldMaskTree output)
		{
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C18")]
		[Address(RVA = "0x36DBD08", Offset = "0x36DBD08", VA = "0x36DBD08")]
		public void Merge(IMessage source, IMessage destination, FieldMask.MergeOptions options)
		{
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C19")]
		[Address(RVA = "0x36DBEF4", Offset = "0x36DBEF4", VA = "0x36DBEF4")]
		private void Merge(FieldMaskTree.Node node, string path, IMessage source, IMessage destination, FieldMask.MergeOptions options)
		{
		}

		// Token: 0x04002B75 RID: 11125
		[Token(Token = "0x4002B75")]
		private const char FIELD_PATH_SEPARATOR = '.';

		// Token: 0x04002B76 RID: 11126
		[Token(Token = "0x4002B76")]
		[FieldOffset(Offset = "0x10")]
		private readonly FieldMaskTree.Node root;

		// Token: 0x02000B0D RID: 2829
		[Token(Token = "0x2000B0D")]
		internal sealed class Node
		{
			// Token: 0x170007C9 RID: 1993
			// (get) Token: 0x06006C1A RID: 27674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170007C9")]
			public Dictionary<string, FieldMaskTree.Node> Children
			{
				[Token(Token = "0x6006C1A")]
				[Address(RVA = "0x36DD114", Offset = "0x36DD114", VA = "0x36DD114")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006C1B RID: 27675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C1B")]
			[Address(RVA = "0x36DB15C", Offset = "0x36DB15C", VA = "0x36DB15C")]
			public Node()
			{
			}
		}
	}
}
