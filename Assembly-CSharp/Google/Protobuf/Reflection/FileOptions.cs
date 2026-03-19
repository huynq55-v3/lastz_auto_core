using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000B99 RID: 2969
	[Token(Token = "0x2000B99")]
	public sealed class FileOptions : IExtendableMessage<FileOptions>, IMessage<FileOptions>, IMessage, IEquatable<FileOptions>, IDeepCloneable<FileOptions>
	{
		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06007190 RID: 29072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000914")]
		private ExtensionSet<FileOptions> _Extensions
		{
			[Token(Token = "0x6007190")]
			[Address(RVA = "0x31FABA0", Offset = "0x31FABA0", VA = "0x31FABA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06007191 RID: 29073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000915")]
		[DebuggerNonUserCode]
		public static MessageParser<FileOptions> Parser
		{
			[Token(Token = "0x6007191")]
			[Address(RVA = "0x31FABA8", Offset = "0x31FABA8", VA = "0x31FABA8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06007192 RID: 29074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000916")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Token(Token = "0x6007192")]
			[Address(RVA = "0x31FAC00", Offset = "0x31FAC00", VA = "0x31FAC00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06007193 RID: 29075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000917")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor
		{
			[Token(Token = "0x6007193")]
			[Address(RVA = "0x31FAD04", Offset = "0x31FAD04", VA = "0x31FAD04", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007194")]
		[Address(RVA = "0x31EEA04", Offset = "0x31EEA04", VA = "0x31EEA04")]
		[DebuggerNonUserCode]
		public FileOptions()
		{
		}

		// Token: 0x06007195 RID: 29077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007195")]
		[Address(RVA = "0x31FAD50", Offset = "0x31FAD50", VA = "0x31FAD50")]
		[DebuggerNonUserCode]
		public FileOptions(FileOptions other)
		{
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007196")]
		[Address(RVA = "0x31ED894", Offset = "0x31ED894", VA = "0x31ED894", Slot = "17")]
		[DebuggerNonUserCode]
		public FileOptions Clone()
		{
			return null;
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06007197 RID: 29079 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007198 RID: 29080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000918")]
		[DebuggerNonUserCode]
		public string JavaPackage
		{
			[Token(Token = "0x6007197")]
			[Address(RVA = "0x31FAF04", Offset = "0x31FAF04", VA = "0x31FAF04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007198")]
			[Address(RVA = "0x31FAF68", Offset = "0x31FAF68", VA = "0x31FAF68")]
			set
			{
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06007199 RID: 29081 RVA: 0x00050640 File Offset: 0x0004E840
		[Token(Token = "0x17000919")]
		[DebuggerNonUserCode]
		public bool HasJavaPackage
		{
			[Token(Token = "0x6007199")]
			[Address(RVA = "0x31FAFE4", Offset = "0x31FAFE4", VA = "0x31FAFE4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719A")]
		[Address(RVA = "0x31FAFF4", Offset = "0x31FAFF4", VA = "0x31FAFF4")]
		[DebuggerNonUserCode]
		public void ClearJavaPackage()
		{
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x0600719B RID: 29083 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600719C RID: 29084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091A")]
		[DebuggerNonUserCode]
		public string JavaOuterClassname
		{
			[Token(Token = "0x600719B")]
			[Address(RVA = "0x31FB000", Offset = "0x31FB000", VA = "0x31FB000")]
			get
			{
				return null;
			}
			[Token(Token = "0x600719C")]
			[Address(RVA = "0x31FB064", Offset = "0x31FB064", VA = "0x31FB064")]
			set
			{
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x0600719D RID: 29085 RVA: 0x00050658 File Offset: 0x0004E858
		[Token(Token = "0x1700091B")]
		[DebuggerNonUserCode]
		public bool HasJavaOuterClassname
		{
			[Token(Token = "0x600719D")]
			[Address(RVA = "0x31FB0E0", Offset = "0x31FB0E0", VA = "0x31FB0E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600719E RID: 29086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600719E")]
		[Address(RVA = "0x31FB0F0", Offset = "0x31FB0F0", VA = "0x31FB0F0")]
		[DebuggerNonUserCode]
		public void ClearJavaOuterClassname()
		{
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x0600719F RID: 29087 RVA: 0x00050670 File Offset: 0x0004E870
		// (set) Token: 0x060071A0 RID: 29088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091C")]
		[DebuggerNonUserCode]
		public bool JavaMultipleFiles
		{
			[Token(Token = "0x600719F")]
			[Address(RVA = "0x31FB0FC", Offset = "0x31FB0FC", VA = "0x31FB0FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60071A0")]
			[Address(RVA = "0x31FB16C", Offset = "0x31FB16C", VA = "0x31FB16C")]
			set
			{
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x060071A1 RID: 29089 RVA: 0x00050688 File Offset: 0x0004E888
		[Token(Token = "0x1700091D")]
		[DebuggerNonUserCode]
		public bool HasJavaMultipleFiles
		{
			[Token(Token = "0x60071A1")]
			[Address(RVA = "0x31FB184", Offset = "0x31FB184", VA = "0x31FB184")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071A2 RID: 29090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A2")]
		[Address(RVA = "0x31FB190", Offset = "0x31FB190", VA = "0x31FB190")]
		[DebuggerNonUserCode]
		public void ClearJavaMultipleFiles()
		{
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x060071A3 RID: 29091 RVA: 0x000506A0 File Offset: 0x0004E8A0
		// (set) Token: 0x060071A4 RID: 29092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700091E")]
		[DebuggerNonUserCode]
		[Obsolete]
		public bool JavaGenerateEqualsAndHash
		{
			[Token(Token = "0x60071A3")]
			[Address(RVA = "0x31FB1A0", Offset = "0x31FB1A0", VA = "0x31FB1A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60071A4")]
			[Address(RVA = "0x31FB210", Offset = "0x31FB210", VA = "0x31FB210")]
			set
			{
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x060071A5 RID: 29093 RVA: 0x000506B8 File Offset: 0x0004E8B8
		[Token(Token = "0x1700091F")]
		[Obsolete]
		[DebuggerNonUserCode]
		public bool HasJavaGenerateEqualsAndHash
		{
			[Token(Token = "0x60071A5")]
			[Address(RVA = "0x31FB228", Offset = "0x31FB228", VA = "0x31FB228")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071A6 RID: 29094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071A6")]
		[Address(RVA = "0x31FB234", Offset = "0x31FB234", VA = "0x31FB234")]
		[Obsolete]
		[DebuggerNonUserCode]
		public void ClearJavaGenerateEqualsAndHash()
		{
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x060071A7 RID: 29095 RVA: 0x000506D0 File Offset: 0x0004E8D0
		// (set) Token: 0x060071A8 RID: 29096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000920")]
		[DebuggerNonUserCode]
		public bool JavaStringCheckUtf8
		{
			[Token(Token = "0x60071A7")]
			[Address(RVA = "0x31FB244", Offset = "0x31FB244", VA = "0x31FB244")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60071A8")]
			[Address(RVA = "0x31FB2B4", Offset = "0x31FB2B4", VA = "0x31FB2B4")]
			set
			{
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x060071A9 RID: 29097 RVA: 0x000506E8 File Offset: 0x0004E8E8
		[Token(Token = "0x17000921")]
		[DebuggerNonUserCode]
		public bool HasJavaStringCheckUtf8
		{
			[Token(Token = "0x60071A9")]
			[Address(RVA = "0x31FB2CC", Offset = "0x31FB2CC", VA = "0x31FB2CC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071AA RID: 29098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071AA")]
		[Address(RVA = "0x31FB2D8", Offset = "0x31FB2D8", VA = "0x31FB2D8")]
		[DebuggerNonUserCode]
		public void ClearJavaStringCheckUtf8()
		{
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x060071AB RID: 29099 RVA: 0x00050700 File Offset: 0x0004E900
		// (set) Token: 0x060071AC RID: 29100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000922")]
		[DebuggerNonUserCode]
		public FileOptions.Types.OptimizeMode OptimizeFor
		{
			[Token(Token = "0x60071AB")]
			[Address(RVA = "0x31FB2E8", Offset = "0x31FB2E8", VA = "0x31FB2E8")]
			get
			{
				return (FileOptions.Types.OptimizeMode)0;
			}
			[Token(Token = "0x60071AC")]
			[Address(RVA = "0x31FB358", Offset = "0x31FB358", VA = "0x31FB358")]
			set
			{
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x060071AD RID: 29101 RVA: 0x00050718 File Offset: 0x0004E918
		[Token(Token = "0x17000923")]
		[DebuggerNonUserCode]
		public bool HasOptimizeFor
		{
			[Token(Token = "0x60071AD")]
			[Address(RVA = "0x31FB36C", Offset = "0x31FB36C", VA = "0x31FB36C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071AE RID: 29102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071AE")]
		[Address(RVA = "0x31FB378", Offset = "0x31FB378", VA = "0x31FB378")]
		[DebuggerNonUserCode]
		public void ClearOptimizeFor()
		{
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x060071AF RID: 29103 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060071B0 RID: 29104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000924")]
		[DebuggerNonUserCode]
		public string GoPackage
		{
			[Token(Token = "0x60071AF")]
			[Address(RVA = "0x31FB388", Offset = "0x31FB388", VA = "0x31FB388")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071B0")]
			[Address(RVA = "0x31FB3EC", Offset = "0x31FB3EC", VA = "0x31FB3EC")]
			set
			{
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x060071B1 RID: 29105 RVA: 0x00050730 File Offset: 0x0004E930
		[Token(Token = "0x17000925")]
		[DebuggerNonUserCode]
		public bool HasGoPackage
		{
			[Token(Token = "0x60071B1")]
			[Address(RVA = "0x31FB468", Offset = "0x31FB468", VA = "0x31FB468")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B2")]
		[Address(RVA = "0x31FB478", Offset = "0x31FB478", VA = "0x31FB478")]
		[DebuggerNonUserCode]
		public void ClearGoPackage()
		{
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x060071B3 RID: 29107 RVA: 0x00050748 File Offset: 0x0004E948
		// (set) Token: 0x060071B4 RID: 29108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000926")]
		[DebuggerNonUserCode]
		public bool CcGenericServices
		{
			[Token(Token = "0x60071B3")]
			[Address(RVA = "0x31FB484", Offset = "0x31FB484", VA = "0x31FB484")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60071B4")]
			[Address(RVA = "0x31FB4F4", Offset = "0x31FB4F4", VA = "0x31FB4F4")]
			set
			{
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x060071B5 RID: 29109 RVA: 0x00050760 File Offset: 0x0004E960
		[Token(Token = "0x17000927")]
		[DebuggerNonUserCode]
		public bool HasCcGenericServices
		{
			[Token(Token = "0x60071B5")]
			[Address(RVA = "0x31FB50C", Offset = "0x31FB50C", VA = "0x31FB50C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071B6")]
		[Address(RVA = "0x31FB518", Offset = "0x31FB518", VA = "0x31FB518")]
		[DebuggerNonUserCode]
		public void ClearCcGenericServices()
		{
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x060071B7 RID: 29111 RVA: 0x00050778 File Offset: 0x0004E978
		// (set) Token: 0x060071B8 RID: 29112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000928")]
		[DebuggerNonUserCode]
		public bool JavaGenericServices
		{
			[Token(Token = "0x60071B7")]
			[Address(RVA = "0x31FB528", Offset = "0x31FB528", VA = "0x31FB528")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60071B8")]
			[Address(RVA = "0x31FB598", Offset = "0x31FB598", VA = "0x31FB598")]
			set
			{
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060071B9 RID: 29113 RVA: 0x00050790 File Offset: 0x0004E990
		[Token(Token = "0x17000929")]
		[DebuggerNonUserCode]
		public bool HasJavaGenericServices
		{
			[Token(Token = "0x60071B9")]
			[Address(RVA = "0x31FB5B0", Offset = "0x31FB5B0", VA = "0x31FB5B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071BA")]
		[Address(RVA = "0x31FB5BC", Offset = "0x31FB5BC", VA = "0x31FB5BC")]
		[DebuggerNonUserCode]
		public void ClearJavaGenericServices()
		{
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060071BB RID: 29115 RVA: 0x000507A8 File Offset: 0x0004E9A8
		// (set) Token: 0x060071BC RID: 29116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700092A")]
		[DebuggerNonUserCode]
		public bool PyGenericServices
		{
			[Token(Token = "0x60071BB")]
			[Address(RVA = "0x31FB5CC", Offset = "0x31FB5CC", VA = "0x31FB5CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60071BC")]
			[Address(RVA = "0x31FB63C", Offset = "0x31FB63C", VA = "0x31FB63C")]
			set
			{
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060071BD RID: 29117 RVA: 0x000507C0 File Offset: 0x0004E9C0
		[Token(Token = "0x1700092B")]
		[DebuggerNonUserCode]
		public bool HasPyGenericServices
		{
			[Token(Token = "0x60071BD")]
			[Address(RVA = "0x31FB654", Offset = "0x31FB654", VA = "0x31FB654")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071BE RID: 29118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071BE")]
		[Address(RVA = "0x31FB660", Offset = "0x31FB660", VA = "0x31FB660")]
		[DebuggerNonUserCode]
		public void ClearPyGenericServices()
		{
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060071BF RID: 29119 RVA: 0x000507D8 File Offset: 0x0004E9D8
		// (set) Token: 0x060071C0 RID: 29120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700092C")]
		[DebuggerNonUserCode]
		public bool PhpGenericServices
		{
			[Token(Token = "0x60071BF")]
			[Address(RVA = "0x31FB670", Offset = "0x31FB670", VA = "0x31FB670")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60071C0")]
			[Address(RVA = "0x31FB6E0", Offset = "0x31FB6E0", VA = "0x31FB6E0")]
			set
			{
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x000507F0 File Offset: 0x0004E9F0
		[Token(Token = "0x1700092D")]
		[DebuggerNonUserCode]
		public bool HasPhpGenericServices
		{
			[Token(Token = "0x60071C1")]
			[Address(RVA = "0x31FB6F8", Offset = "0x31FB6F8", VA = "0x31FB6F8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C2")]
		[Address(RVA = "0x31FB704", Offset = "0x31FB704", VA = "0x31FB704")]
		[DebuggerNonUserCode]
		public void ClearPhpGenericServices()
		{
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x060071C3 RID: 29123 RVA: 0x00050808 File Offset: 0x0004EA08
		// (set) Token: 0x060071C4 RID: 29124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700092E")]
		[DebuggerNonUserCode]
		public bool Deprecated
		{
			[Token(Token = "0x60071C3")]
			[Address(RVA = "0x31FB714", Offset = "0x31FB714", VA = "0x31FB714")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60071C4")]
			[Address(RVA = "0x31FB784", Offset = "0x31FB784", VA = "0x31FB784")]
			set
			{
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x060071C5 RID: 29125 RVA: 0x00050820 File Offset: 0x0004EA20
		[Token(Token = "0x1700092F")]
		[DebuggerNonUserCode]
		public bool HasDeprecated
		{
			[Token(Token = "0x60071C5")]
			[Address(RVA = "0x31FB79C", Offset = "0x31FB79C", VA = "0x31FB79C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071C6")]
		[Address(RVA = "0x31FB7A8", Offset = "0x31FB7A8", VA = "0x31FB7A8")]
		[DebuggerNonUserCode]
		public void ClearDeprecated()
		{
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x060071C7 RID: 29127 RVA: 0x00050838 File Offset: 0x0004EA38
		// (set) Token: 0x060071C8 RID: 29128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000930")]
		[DebuggerNonUserCode]
		public bool CcEnableArenas
		{
			[Token(Token = "0x60071C7")]
			[Address(RVA = "0x31FB7B8", Offset = "0x31FB7B8", VA = "0x31FB7B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60071C8")]
			[Address(RVA = "0x31FB828", Offset = "0x31FB828", VA = "0x31FB828")]
			set
			{
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x060071C9 RID: 29129 RVA: 0x00050850 File Offset: 0x0004EA50
		[Token(Token = "0x17000931")]
		[DebuggerNonUserCode]
		public bool HasCcEnableArenas
		{
			[Token(Token = "0x60071C9")]
			[Address(RVA = "0x31FB840", Offset = "0x31FB840", VA = "0x31FB840")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071CA RID: 29130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CA")]
		[Address(RVA = "0x31FB84C", Offset = "0x31FB84C", VA = "0x31FB84C")]
		[DebuggerNonUserCode]
		public void ClearCcEnableArenas()
		{
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x060071CB RID: 29131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060071CC RID: 29132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000932")]
		[DebuggerNonUserCode]
		public string ObjcClassPrefix
		{
			[Token(Token = "0x60071CB")]
			[Address(RVA = "0x31FB85C", Offset = "0x31FB85C", VA = "0x31FB85C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071CC")]
			[Address(RVA = "0x31FB8C0", Offset = "0x31FB8C0", VA = "0x31FB8C0")]
			set
			{
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x060071CD RID: 29133 RVA: 0x00050868 File Offset: 0x0004EA68
		[Token(Token = "0x17000933")]
		[DebuggerNonUserCode]
		public bool HasObjcClassPrefix
		{
			[Token(Token = "0x60071CD")]
			[Address(RVA = "0x31FB93C", Offset = "0x31FB93C", VA = "0x31FB93C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CE")]
		[Address(RVA = "0x31FB94C", Offset = "0x31FB94C", VA = "0x31FB94C")]
		[DebuggerNonUserCode]
		public void ClearObjcClassPrefix()
		{
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060071CF RID: 29135 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060071D0 RID: 29136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000934")]
		[DebuggerNonUserCode]
		public string CsharpNamespace
		{
			[Token(Token = "0x60071CF")]
			[Address(RVA = "0x31FB958", Offset = "0x31FB958", VA = "0x31FB958")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071D0")]
			[Address(RVA = "0x31FB9BC", Offset = "0x31FB9BC", VA = "0x31FB9BC")]
			set
			{
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060071D1 RID: 29137 RVA: 0x00050880 File Offset: 0x0004EA80
		[Token(Token = "0x17000935")]
		[DebuggerNonUserCode]
		public bool HasCsharpNamespace
		{
			[Token(Token = "0x60071D1")]
			[Address(RVA = "0x31FBA38", Offset = "0x31FBA38", VA = "0x31FBA38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D2")]
		[Address(RVA = "0x31FBA48", Offset = "0x31FBA48", VA = "0x31FBA48")]
		[DebuggerNonUserCode]
		public void ClearCsharpNamespace()
		{
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060071D3 RID: 29139 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060071D4 RID: 29140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000936")]
		[DebuggerNonUserCode]
		public string SwiftPrefix
		{
			[Token(Token = "0x60071D3")]
			[Address(RVA = "0x31FBA54", Offset = "0x31FBA54", VA = "0x31FBA54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071D4")]
			[Address(RVA = "0x31FBAB8", Offset = "0x31FBAB8", VA = "0x31FBAB8")]
			set
			{
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060071D5 RID: 29141 RVA: 0x00050898 File Offset: 0x0004EA98
		[Token(Token = "0x17000937")]
		[DebuggerNonUserCode]
		public bool HasSwiftPrefix
		{
			[Token(Token = "0x60071D5")]
			[Address(RVA = "0x31FBB34", Offset = "0x31FBB34", VA = "0x31FBB34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D6")]
		[Address(RVA = "0x31FBB44", Offset = "0x31FBB44", VA = "0x31FBB44")]
		[DebuggerNonUserCode]
		public void ClearSwiftPrefix()
		{
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060071D7 RID: 29143 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060071D8 RID: 29144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000938")]
		[DebuggerNonUserCode]
		public string PhpClassPrefix
		{
			[Token(Token = "0x60071D7")]
			[Address(RVA = "0x31FBB50", Offset = "0x31FBB50", VA = "0x31FBB50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071D8")]
			[Address(RVA = "0x31FBBB4", Offset = "0x31FBBB4", VA = "0x31FBBB4")]
			set
			{
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060071D9 RID: 29145 RVA: 0x000508B0 File Offset: 0x0004EAB0
		[Token(Token = "0x17000939")]
		[DebuggerNonUserCode]
		public bool HasPhpClassPrefix
		{
			[Token(Token = "0x60071D9")]
			[Address(RVA = "0x31FBC30", Offset = "0x31FBC30", VA = "0x31FBC30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DA")]
		[Address(RVA = "0x31FBC40", Offset = "0x31FBC40", VA = "0x31FBC40")]
		[DebuggerNonUserCode]
		public void ClearPhpClassPrefix()
		{
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060071DB RID: 29147 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060071DC RID: 29148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093A")]
		[DebuggerNonUserCode]
		public string PhpNamespace
		{
			[Token(Token = "0x60071DB")]
			[Address(RVA = "0x31FBC4C", Offset = "0x31FBC4C", VA = "0x31FBC4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071DC")]
			[Address(RVA = "0x31FBCB0", Offset = "0x31FBCB0", VA = "0x31FBCB0")]
			set
			{
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060071DD RID: 29149 RVA: 0x000508C8 File Offset: 0x0004EAC8
		[Token(Token = "0x1700093B")]
		[DebuggerNonUserCode]
		public bool HasPhpNamespace
		{
			[Token(Token = "0x60071DD")]
			[Address(RVA = "0x31FBD2C", Offset = "0x31FBD2C", VA = "0x31FBD2C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071DE")]
		[Address(RVA = "0x31FBD3C", Offset = "0x31FBD3C", VA = "0x31FBD3C")]
		[DebuggerNonUserCode]
		public void ClearPhpNamespace()
		{
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060071DF RID: 29151 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060071E0 RID: 29152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093C")]
		[DebuggerNonUserCode]
		public string PhpMetadataNamespace
		{
			[Token(Token = "0x60071DF")]
			[Address(RVA = "0x31FBD48", Offset = "0x31FBD48", VA = "0x31FBD48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071E0")]
			[Address(RVA = "0x31FBDAC", Offset = "0x31FBDAC", VA = "0x31FBDAC")]
			set
			{
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060071E1 RID: 29153 RVA: 0x000508E0 File Offset: 0x0004EAE0
		[Token(Token = "0x1700093D")]
		[DebuggerNonUserCode]
		public bool HasPhpMetadataNamespace
		{
			[Token(Token = "0x60071E1")]
			[Address(RVA = "0x31FBE28", Offset = "0x31FBE28", VA = "0x31FBE28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E2")]
		[Address(RVA = "0x31FBE38", Offset = "0x31FBE38", VA = "0x31FBE38")]
		[DebuggerNonUserCode]
		public void ClearPhpMetadataNamespace()
		{
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060071E3 RID: 29155 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060071E4 RID: 29156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093E")]
		[DebuggerNonUserCode]
		public string RubyPackage
		{
			[Token(Token = "0x60071E3")]
			[Address(RVA = "0x31FBE44", Offset = "0x31FBE44", VA = "0x31FBE44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60071E4")]
			[Address(RVA = "0x31FBEA8", Offset = "0x31FBEA8", VA = "0x31FBEA8")]
			set
			{
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060071E5 RID: 29157 RVA: 0x000508F8 File Offset: 0x0004EAF8
		[Token(Token = "0x1700093F")]
		[DebuggerNonUserCode]
		public bool HasRubyPackage
		{
			[Token(Token = "0x60071E5")]
			[Address(RVA = "0x31FBF24", Offset = "0x31FBF24", VA = "0x31FBF24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071E6")]
		[Address(RVA = "0x31FBF34", Offset = "0x31FBF34", VA = "0x31FBF34")]
		[DebuggerNonUserCode]
		public void ClearRubyPackage()
		{
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060071E7 RID: 29159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000940")]
		[DebuggerNonUserCode]
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			[Token(Token = "0x60071E7")]
			[Address(RVA = "0x31FBF40", Offset = "0x31FBF40", VA = "0x31FBF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060071E8 RID: 29160 RVA: 0x00050910 File Offset: 0x0004EB10
		[Token(Token = "0x60071E8")]
		[Address(RVA = "0x31FBF48", Offset = "0x31FBF48", VA = "0x31FBF48", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060071E9 RID: 29161 RVA: 0x00050928 File Offset: 0x0004EB28
		[Token(Token = "0x60071E9")]
		[Address(RVA = "0x31FBFAC", Offset = "0x31FBFAC", VA = "0x31FBFAC", Slot = "16")]
		[DebuggerNonUserCode]
		public bool Equals(FileOptions other)
		{
			return default(bool);
		}

		// Token: 0x060071EA RID: 29162 RVA: 0x00050940 File Offset: 0x0004EB40
		[Token(Token = "0x60071EA")]
		[Address(RVA = "0x31FC2F8", Offset = "0x31FC2F8", VA = "0x31FC2F8", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060071EB RID: 29163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071EB")]
		[Address(RVA = "0x31FC774", Offset = "0x31FC774", VA = "0x31FC774", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060071EC RID: 29164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EC")]
		[Address(RVA = "0x31FC7CC", Offset = "0x31FC7CC", VA = "0x31FC7CC", Slot = "13")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060071ED RID: 29165 RVA: 0x00050958 File Offset: 0x0004EB58
		[Token(Token = "0x60071ED")]
		[Address(RVA = "0x31FCCF8", Offset = "0x31FCCF8", VA = "0x31FCCF8", Slot = "14")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060071EE RID: 29166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EE")]
		[Address(RVA = "0x31EEA8C", Offset = "0x31EEA8C", VA = "0x31EEA8C", Slot = "11")]
		[DebuggerNonUserCode]
		public void MergeFrom(FileOptions other)
		{
		}

		// Token: 0x060071EF RID: 29167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071EF")]
		[Address(RVA = "0x31FD0EC", Offset = "0x31FD0EC", VA = "0x31FD0EC", Slot = "12")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F0")]
		public TValue GetExtension<TValue>(Extension<FileOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F1")]
		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60071F2")]
		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension)
		{
			return null;
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F3")]
		public void SetExtension<TValue>(Extension<FileOptions, TValue> extension, TValue value)
		{
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x00050970 File Offset: 0x0004EB70
		[Token(Token = "0x60071F4")]
		public bool HasExtension<TValue>(Extension<FileOptions, TValue> extension)
		{
			return default(bool);
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F5")]
		public void ClearExtension<TValue>(Extension<FileOptions, TValue> extension)
		{
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071F6")]
		public void ClearExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension)
		{
		}

		// Token: 0x04002DFD RID: 11773
		[Token(Token = "0x4002DFD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly MessageParser<FileOptions> _parser;

		// Token: 0x04002DFE RID: 11774
		[Token(Token = "0x4002DFE")]
		[FieldOffset(Offset = "0x10")]
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DFF RID: 11775
		[Token(Token = "0x4002DFF")]
		[FieldOffset(Offset = "0x18")]
		internal ExtensionSet<FileOptions> _extensions;

		// Token: 0x04002E00 RID: 11776
		[Token(Token = "0x4002E00")]
		[FieldOffset(Offset = "0x20")]
		private int _hasBits0;

		// Token: 0x04002E01 RID: 11777
		[Token(Token = "0x4002E01")]
		public const int JavaPackageFieldNumber = 1;

		// Token: 0x04002E02 RID: 11778
		[Token(Token = "0x4002E02")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string JavaPackageDefaultValue;

		// Token: 0x04002E03 RID: 11779
		[Token(Token = "0x4002E03")]
		[FieldOffset(Offset = "0x28")]
		private string javaPackage_;

		// Token: 0x04002E04 RID: 11780
		[Token(Token = "0x4002E04")]
		public const int JavaOuterClassnameFieldNumber = 8;

		// Token: 0x04002E05 RID: 11781
		[Token(Token = "0x4002E05")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string JavaOuterClassnameDefaultValue;

		// Token: 0x04002E06 RID: 11782
		[Token(Token = "0x4002E06")]
		[FieldOffset(Offset = "0x30")]
		private string javaOuterClassname_;

		// Token: 0x04002E07 RID: 11783
		[Token(Token = "0x4002E07")]
		public const int JavaMultipleFilesFieldNumber = 10;

		// Token: 0x04002E08 RID: 11784
		[Token(Token = "0x4002E08")]
		[FieldOffset(Offset = "0x18")]
		private static readonly bool JavaMultipleFilesDefaultValue;

		// Token: 0x04002E09 RID: 11785
		[Token(Token = "0x4002E09")]
		[FieldOffset(Offset = "0x38")]
		private bool javaMultipleFiles_;

		// Token: 0x04002E0A RID: 11786
		[Token(Token = "0x4002E0A")]
		public const int JavaGenerateEqualsAndHashFieldNumber = 20;

		// Token: 0x04002E0B RID: 11787
		[Token(Token = "0x4002E0B")]
		[FieldOffset(Offset = "0x19")]
		private static readonly bool JavaGenerateEqualsAndHashDefaultValue;

		// Token: 0x04002E0C RID: 11788
		[Token(Token = "0x4002E0C")]
		[FieldOffset(Offset = "0x39")]
		private bool javaGenerateEqualsAndHash_;

		// Token: 0x04002E0D RID: 11789
		[Token(Token = "0x4002E0D")]
		public const int JavaStringCheckUtf8FieldNumber = 27;

		// Token: 0x04002E0E RID: 11790
		[Token(Token = "0x4002E0E")]
		[FieldOffset(Offset = "0x1A")]
		private static readonly bool JavaStringCheckUtf8DefaultValue;

		// Token: 0x04002E0F RID: 11791
		[Token(Token = "0x4002E0F")]
		[FieldOffset(Offset = "0x3A")]
		private bool javaStringCheckUtf8_;

		// Token: 0x04002E10 RID: 11792
		[Token(Token = "0x4002E10")]
		public const int OptimizeForFieldNumber = 9;

		// Token: 0x04002E11 RID: 11793
		[Token(Token = "0x4002E11")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly FileOptions.Types.OptimizeMode OptimizeForDefaultValue;

		// Token: 0x04002E12 RID: 11794
		[Token(Token = "0x4002E12")]
		[FieldOffset(Offset = "0x3C")]
		private FileOptions.Types.OptimizeMode optimizeFor_;

		// Token: 0x04002E13 RID: 11795
		[Token(Token = "0x4002E13")]
		public const int GoPackageFieldNumber = 11;

		// Token: 0x04002E14 RID: 11796
		[Token(Token = "0x4002E14")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string GoPackageDefaultValue;

		// Token: 0x04002E15 RID: 11797
		[Token(Token = "0x4002E15")]
		[FieldOffset(Offset = "0x40")]
		private string goPackage_;

		// Token: 0x04002E16 RID: 11798
		[Token(Token = "0x4002E16")]
		public const int CcGenericServicesFieldNumber = 16;

		// Token: 0x04002E17 RID: 11799
		[Token(Token = "0x4002E17")]
		[FieldOffset(Offset = "0x28")]
		private static readonly bool CcGenericServicesDefaultValue;

		// Token: 0x04002E18 RID: 11800
		[Token(Token = "0x4002E18")]
		[FieldOffset(Offset = "0x48")]
		private bool ccGenericServices_;

		// Token: 0x04002E19 RID: 11801
		[Token(Token = "0x4002E19")]
		public const int JavaGenericServicesFieldNumber = 17;

		// Token: 0x04002E1A RID: 11802
		[Token(Token = "0x4002E1A")]
		[FieldOffset(Offset = "0x29")]
		private static readonly bool JavaGenericServicesDefaultValue;

		// Token: 0x04002E1B RID: 11803
		[Token(Token = "0x4002E1B")]
		[FieldOffset(Offset = "0x49")]
		private bool javaGenericServices_;

		// Token: 0x04002E1C RID: 11804
		[Token(Token = "0x4002E1C")]
		public const int PyGenericServicesFieldNumber = 18;

		// Token: 0x04002E1D RID: 11805
		[Token(Token = "0x4002E1D")]
		[FieldOffset(Offset = "0x2A")]
		private static readonly bool PyGenericServicesDefaultValue;

		// Token: 0x04002E1E RID: 11806
		[Token(Token = "0x4002E1E")]
		[FieldOffset(Offset = "0x4A")]
		private bool pyGenericServices_;

		// Token: 0x04002E1F RID: 11807
		[Token(Token = "0x4002E1F")]
		public const int PhpGenericServicesFieldNumber = 42;

		// Token: 0x04002E20 RID: 11808
		[Token(Token = "0x4002E20")]
		[FieldOffset(Offset = "0x2B")]
		private static readonly bool PhpGenericServicesDefaultValue;

		// Token: 0x04002E21 RID: 11809
		[Token(Token = "0x4002E21")]
		[FieldOffset(Offset = "0x4B")]
		private bool phpGenericServices_;

		// Token: 0x04002E22 RID: 11810
		[Token(Token = "0x4002E22")]
		public const int DeprecatedFieldNumber = 23;

		// Token: 0x04002E23 RID: 11811
		[Token(Token = "0x4002E23")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly bool DeprecatedDefaultValue;

		// Token: 0x04002E24 RID: 11812
		[Token(Token = "0x4002E24")]
		[FieldOffset(Offset = "0x4C")]
		private bool deprecated_;

		// Token: 0x04002E25 RID: 11813
		[Token(Token = "0x4002E25")]
		public const int CcEnableArenasFieldNumber = 31;

		// Token: 0x04002E26 RID: 11814
		[Token(Token = "0x4002E26")]
		[FieldOffset(Offset = "0x2D")]
		private static readonly bool CcEnableArenasDefaultValue;

		// Token: 0x04002E27 RID: 11815
		[Token(Token = "0x4002E27")]
		[FieldOffset(Offset = "0x4D")]
		private bool ccEnableArenas_;

		// Token: 0x04002E28 RID: 11816
		[Token(Token = "0x4002E28")]
		public const int ObjcClassPrefixFieldNumber = 36;

		// Token: 0x04002E29 RID: 11817
		[Token(Token = "0x4002E29")]
		[FieldOffset(Offset = "0x30")]
		private static readonly string ObjcClassPrefixDefaultValue;

		// Token: 0x04002E2A RID: 11818
		[Token(Token = "0x4002E2A")]
		[FieldOffset(Offset = "0x50")]
		private string objcClassPrefix_;

		// Token: 0x04002E2B RID: 11819
		[Token(Token = "0x4002E2B")]
		public const int CsharpNamespaceFieldNumber = 37;

		// Token: 0x04002E2C RID: 11820
		[Token(Token = "0x4002E2C")]
		[FieldOffset(Offset = "0x38")]
		private static readonly string CsharpNamespaceDefaultValue;

		// Token: 0x04002E2D RID: 11821
		[Token(Token = "0x4002E2D")]
		[FieldOffset(Offset = "0x58")]
		private string csharpNamespace_;

		// Token: 0x04002E2E RID: 11822
		[Token(Token = "0x4002E2E")]
		public const int SwiftPrefixFieldNumber = 39;

		// Token: 0x04002E2F RID: 11823
		[Token(Token = "0x4002E2F")]
		[FieldOffset(Offset = "0x40")]
		private static readonly string SwiftPrefixDefaultValue;

		// Token: 0x04002E30 RID: 11824
		[Token(Token = "0x4002E30")]
		[FieldOffset(Offset = "0x60")]
		private string swiftPrefix_;

		// Token: 0x04002E31 RID: 11825
		[Token(Token = "0x4002E31")]
		public const int PhpClassPrefixFieldNumber = 40;

		// Token: 0x04002E32 RID: 11826
		[Token(Token = "0x4002E32")]
		[FieldOffset(Offset = "0x48")]
		private static readonly string PhpClassPrefixDefaultValue;

		// Token: 0x04002E33 RID: 11827
		[Token(Token = "0x4002E33")]
		[FieldOffset(Offset = "0x68")]
		private string phpClassPrefix_;

		// Token: 0x04002E34 RID: 11828
		[Token(Token = "0x4002E34")]
		public const int PhpNamespaceFieldNumber = 41;

		// Token: 0x04002E35 RID: 11829
		[Token(Token = "0x4002E35")]
		[FieldOffset(Offset = "0x50")]
		private static readonly string PhpNamespaceDefaultValue;

		// Token: 0x04002E36 RID: 11830
		[Token(Token = "0x4002E36")]
		[FieldOffset(Offset = "0x70")]
		private string phpNamespace_;

		// Token: 0x04002E37 RID: 11831
		[Token(Token = "0x4002E37")]
		public const int PhpMetadataNamespaceFieldNumber = 44;

		// Token: 0x04002E38 RID: 11832
		[Token(Token = "0x4002E38")]
		[FieldOffset(Offset = "0x58")]
		private static readonly string PhpMetadataNamespaceDefaultValue;

		// Token: 0x04002E39 RID: 11833
		[Token(Token = "0x4002E39")]
		[FieldOffset(Offset = "0x78")]
		private string phpMetadataNamespace_;

		// Token: 0x04002E3A RID: 11834
		[Token(Token = "0x4002E3A")]
		public const int RubyPackageFieldNumber = 45;

		// Token: 0x04002E3B RID: 11835
		[Token(Token = "0x4002E3B")]
		[FieldOffset(Offset = "0x60")]
		private static readonly string RubyPackageDefaultValue;

		// Token: 0x04002E3C RID: 11836
		[Token(Token = "0x4002E3C")]
		[FieldOffset(Offset = "0x80")]
		private string rubyPackage_;

		// Token: 0x04002E3D RID: 11837
		[Token(Token = "0x4002E3D")]
		public const int UninterpretedOptionFieldNumber = 999;

		// Token: 0x04002E3E RID: 11838
		[Token(Token = "0x4002E3E")]
		[FieldOffset(Offset = "0x68")]
		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		// Token: 0x04002E3F RID: 11839
		[Token(Token = "0x4002E3F")]
		[FieldOffset(Offset = "0x88")]
		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		// Token: 0x02000B9A RID: 2970
		[Token(Token = "0x2000B9A")]
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000B9B RID: 2971
			[Token(Token = "0x2000B9B")]
			public enum OptimizeMode
			{
				// Token: 0x04002E41 RID: 11841
				[Token(Token = "0x4002E41")]
				[OriginalName("SPEED")]
				Speed = 1,
				// Token: 0x04002E42 RID: 11842
				[Token(Token = "0x4002E42")]
				[OriginalName("CODE_SIZE")]
				CodeSize,
				// Token: 0x04002E43 RID: 11843
				[Token(Token = "0x4002E43")]
				[OriginalName("LITE_RUNTIME")]
				LiteRuntime
			}
		}
	}
}
