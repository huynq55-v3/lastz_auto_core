using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000CB6 RID: 3254
	[Token(Token = "0x2000CB6")]
	public class GraphicConnector
	{
		// Token: 0x06007B01 RID: 31489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B01")]
		[Address(RVA = "0x3220778", Offset = "0x3220778", VA = "0x3220778")]
		[RuntimeInitializeOnLoadMethod(1)]
		private static void Init()
		{
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B02")]
		[Address(RVA = "0x32207EC", Offset = "0x32207EC", VA = "0x32207EC")]
		protected static void AddConnector(GraphicConnector connector)
		{
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007B03")]
		[Address(RVA = "0x3220458", Offset = "0x3220458", VA = "0x3220458")]
		public static GraphicConnector FindConnector(Graphic graphic)
		{
			return null;
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06007B04 RID: 31492 RVA: 0x00054090 File Offset: 0x00052290
		[Token(Token = "0x17000B15")]
		protected virtual int priority
		{
			[Token(Token = "0x6007B04")]
			[Address(RVA = "0x32209A4", Offset = "0x32209A4", VA = "0x32209A4", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x000540A8 File Offset: 0x000522A8
		[Token(Token = "0x6007B05")]
		[Address(RVA = "0x32209AC", Offset = "0x32209AC", VA = "0x32209AC", Slot = "5")]
		protected virtual bool IsValid(Graphic graphic)
		{
			return default(bool);
		}

		// Token: 0x06007B06 RID: 31494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B06")]
		[Address(RVA = "0x32209B4", Offset = "0x32209B4", VA = "0x32209B4", Slot = "6")]
		public virtual void SetVerticesDirty(Graphic graphic)
		{
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B07")]
		[Address(RVA = "0x3220A38", Offset = "0x3220A38", VA = "0x3220A38", Slot = "7")]
		public virtual void SetMaterialDirty(Graphic graphic)
		{
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B08")]
		[Address(RVA = "0x32207E4", Offset = "0x32207E4", VA = "0x32207E4")]
		public GraphicConnector()
		{
		}

		// Token: 0x04003626 RID: 13862
		[Token(Token = "0x4003626")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<GraphicConnector> s_Connectors;

		// Token: 0x04003627 RID: 13863
		[Token(Token = "0x4003627")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<Type, GraphicConnector> s_ConnectorMap;

		// Token: 0x04003628 RID: 13864
		[Token(Token = "0x4003628")]
		[FieldOffset(Offset = "0x10")]
		private static readonly GraphicConnector s_EmptyConnector;
	}
}
