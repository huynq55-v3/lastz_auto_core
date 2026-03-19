using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F5 RID: 757
[Token(Token = "0x20002F5")]
public class WorldCulling : WorldManagerBase
{
	// Token: 0x060013B2 RID: 5042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B2")]
	[Address(RVA = "0x1A4F8EC", Offset = "0x1A4F8EC", VA = "0x1A4F8EC")]
	public WorldCulling(WorldScene scene)
	{
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x1A4F9E4", Offset = "0x1A4F9E4", VA = "0x1A4F9E4", Slot = "4")]
	public override void Init()
	{
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x1A4FB54", Offset = "0x1A4FB54", VA = "0x1A4FB54", Slot = "5")]
	public override void UnInit()
	{
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x1A4FBF4", Offset = "0x1A4FBF4", VA = "0x1A4FBF4", Slot = "6")]
	public override void OnUpdate(float deltaTime)
	{
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x1A4FE80", Offset = "0x1A4FE80", VA = "0x1A4FE80")]
	public void AddCullingBounds(WorldCulling.ICullingObject cullingObject)
	{
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x1A4FFCC", Offset = "0x1A4FFCC", VA = "0x1A4FFCC")]
	public void RemoveCullingBounds(WorldCulling.ICullingObject cullingObject)
	{
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x1A4FBFC", Offset = "0x1A4FBFC", VA = "0x1A4FBFC")]
	private void UpdateCullingBounds()
	{
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x1A502E8", Offset = "0x1A502E8", VA = "0x1A502E8")]
	private void OnCullingGroupStateChanged(CullingGroupEvent evt)
	{
	}

	// Token: 0x040016A0 RID: 5792
	[Token(Token = "0x40016A0")]
	[FieldOffset(Offset = "0x18")]
	private CullingGroup cullingGroup;

	// Token: 0x040016A1 RID: 5793
	[Token(Token = "0x40016A1")]
	[FieldOffset(Offset = "0x20")]
	private GPUSkinningBetterList<BoundingSphere> cullingBounds;

	// Token: 0x040016A2 RID: 5794
	[Token(Token = "0x40016A2")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, WorldCulling.ICullingObject> objs;

	// Token: 0x020002F6 RID: 758
	[Token(Token = "0x20002F6")]
	public interface ICullingObject
	{
		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060013BA RID: 5050
		// (set) Token: 0x060013BB RID: 5051
		[Token(Token = "0x17000219")]
		int CullingBoundsIndex
		{
			[Token(Token = "0x60013BA")]
			get;
			[Token(Token = "0x60013BB")]
			set;
		}

		// Token: 0x060013BC RID: 5052
		[Token(Token = "0x60013BC")]
		BoundingSphere GetBoundingSphere();

		// Token: 0x060013BD RID: 5053
		[Token(Token = "0x60013BD")]
		void OnCullingStateVisible(bool visible);
	}
}
