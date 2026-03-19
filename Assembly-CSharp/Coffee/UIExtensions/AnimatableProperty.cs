using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Coffee.UIExtensions
{
	// Token: 0x02000A44 RID: 2628
	[Token(Token = "0x2000A44")]
	[Serializable]
	public class AnimatableProperty : ISerializationCallbackReceiver
	{
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x0600636D RID: 25453 RVA: 0x0004BDB0 File Offset: 0x00049FB0
		// (set) Token: 0x0600636E RID: 25454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000677")]
		public int id
		{
			[Token(Token = "0x600636D")]
			[Address(RVA = "0x30437F4", Offset = "0x30437F4", VA = "0x30437F4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600636E")]
			[Address(RVA = "0x30437FC", Offset = "0x30437FC", VA = "0x30437FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600636F RID: 25455 RVA: 0x0004BDC8 File Offset: 0x00049FC8
		[Token(Token = "0x17000678")]
		public AnimatableProperty.ShaderPropertyType type
		{
			[Token(Token = "0x600636F")]
			[Address(RVA = "0x3043804", Offset = "0x3043804", VA = "0x3043804")]
			get
			{
				return AnimatableProperty.ShaderPropertyType.Color;
			}
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006370")]
		[Address(RVA = "0x304380C", Offset = "0x304380C", VA = "0x304380C")]
		public void UpdateMaterialProperties(Material material, MaterialPropertyBlock mpb)
		{
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006371")]
		[Address(RVA = "0x30439EC", Offset = "0x30439EC", VA = "0x30439EC", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006372")]
		[Address(RVA = "0x30439F0", Offset = "0x30439F0", VA = "0x30439F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006373")]
		[Address(RVA = "0x3043A10", Offset = "0x3043A10", VA = "0x3043A10")]
		public AnimatableProperty()
		{
		}

		// Token: 0x04002809 RID: 10249
		[Token(Token = "0x4002809")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Name;

		// Token: 0x0400280A RID: 10250
		[Token(Token = "0x400280A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimatableProperty.ShaderPropertyType m_Type;

		// Token: 0x02000A45 RID: 2629
		[Token(Token = "0x2000A45")]
		public enum ShaderPropertyType
		{
			// Token: 0x0400280D RID: 10253
			[Token(Token = "0x400280D")]
			Color,
			// Token: 0x0400280E RID: 10254
			[Token(Token = "0x400280E")]
			Vector,
			// Token: 0x0400280F RID: 10255
			[Token(Token = "0x400280F")]
			Float,
			// Token: 0x04002810 RID: 10256
			[Token(Token = "0x4002810")]
			Range,
			// Token: 0x04002811 RID: 10257
			[Token(Token = "0x4002811")]
			Texture
		}
	}
}
