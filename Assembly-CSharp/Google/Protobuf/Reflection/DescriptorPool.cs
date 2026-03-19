using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BC1 RID: 3009
	[Token(Token = "0x2000BC1")]
	internal sealed class DescriptorPool
	{
		// Token: 0x060073B0 RID: 29616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B0")]
		[Address(RVA = "0x31A9140", Offset = "0x31A9140", VA = "0x31A9140")]
		internal DescriptorPool(IEnumerable<FileDescriptor> dependencyFiles)
		{
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B1")]
		[Address(RVA = "0x31A9824", Offset = "0x31A9824", VA = "0x31A9824")]
		private void ImportPublicDependencies(FileDescriptor file)
		{
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B2")]
		internal T FindSymbol<T>(string fullName) where T : class
		{
			return null;
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B3")]
		[Address(RVA = "0x31A9B64", Offset = "0x31A9B64", VA = "0x31A9B64")]
		internal void AddPackage(string fullName, FileDescriptor file)
		{
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B4")]
		[Address(RVA = "0x31AA0FC", Offset = "0x31AA0FC", VA = "0x31AA0FC")]
		internal void AddSymbol(IDescriptor descriptor)
		{
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B5")]
		[Address(RVA = "0x31AA7D8", Offset = "0x31AA7D8", VA = "0x31AA7D8")]
		private static void ValidateSymbolName(IDescriptor descriptor)
		{
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B6")]
		[Address(RVA = "0x31AAA24", Offset = "0x31AAA24", VA = "0x31AAA24")]
		internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number)
		{
			return null;
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B7")]
		[Address(RVA = "0x31AAB28", Offset = "0x31AAB28", VA = "0x31AAB28")]
		internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number)
		{
			return null;
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B8")]
		[Address(RVA = "0x31AAC2C", Offset = "0x31AAC2C", VA = "0x31AAC2C")]
		internal void AddFieldByNumber(FieldDescriptor field)
		{
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B9")]
		[Address(RVA = "0x31AB098", Offset = "0x31AB098", VA = "0x31AB098")]
		internal void AddEnumValueByNumber(EnumValueDescriptor enumValue)
		{
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073BA")]
		[Address(RVA = "0x31AB240", Offset = "0x31AB240", VA = "0x31AB240")]
		internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo)
		{
			return null;
		}

		// Token: 0x04002F14 RID: 12052
		[Token(Token = "0x4002F14")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDictionary<string, IDescriptor> descriptorsByName;

		// Token: 0x04002F15 RID: 12053
		[Token(Token = "0x4002F15")]
		[FieldOffset(Offset = "0x18")]
		private readonly IDictionary<ObjectIntPair<IDescriptor>, FieldDescriptor> fieldsByNumber;

		// Token: 0x04002F16 RID: 12054
		[Token(Token = "0x4002F16")]
		[FieldOffset(Offset = "0x20")]
		private readonly IDictionary<ObjectIntPair<IDescriptor>, EnumValueDescriptor> enumValuesByNumber;

		// Token: 0x04002F17 RID: 12055
		[Token(Token = "0x4002F17")]
		[FieldOffset(Offset = "0x28")]
		private readonly HashSet<FileDescriptor> dependencies;

		// Token: 0x04002F18 RID: 12056
		[Token(Token = "0x4002F18")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Regex ValidationRegex;
	}
}
