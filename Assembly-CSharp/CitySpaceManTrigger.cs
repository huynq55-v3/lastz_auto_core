using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027C RID: 636
[Token(Token = "0x200027C")]
public class CitySpaceManTrigger : MonoBehaviour, ICulling
{
	// Token: 0x170001EC RID: 492
	// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00006E58 File Offset: 0x00005058
	// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EC")]
	public long ObjectId
	{
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x1BF25B8", Offset = "0x1BF25B8", VA = "0x1BF25B8")]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x1BF25C0", Offset = "0x1BF25C0", VA = "0x1BF25C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x060010E5 RID: 4325 RVA: 0x00006E70 File Offset: 0x00005070
	// (set) Token: 0x060010E4 RID: 4324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001ED")]
	public int resType
	{
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x1BF25D0", Offset = "0x1BF25D0", VA = "0x1BF25D0")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x1BF25C8", Offset = "0x1BF25C8", VA = "0x1BF25C8")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060010E7 RID: 4327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EE")]
	public Action<long, int> TriggerEnterAction
	{
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x1BF25D8", Offset = "0x1BF25D8", VA = "0x1BF25D8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x1BF25E0", Offset = "0x1BF25E0", VA = "0x1BF25E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060010E9 RID: 4329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001EF")]
	public Action<long> TriggerExitAction
	{
		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x1BF25E8", Offset = "0x1BF25E8", VA = "0x1BF25E8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x1BF25F0", Offset = "0x1BF25F0", VA = "0x1BF25F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060010EB RID: 4331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F0")]
	public Action<bool> CullingStateVisible
	{
		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x1BF25F8", Offset = "0x1BF25F8", VA = "0x1BF25F8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x1BF2600", Offset = "0x1BF2600", VA = "0x1BF2600")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x1BF2608", Offset = "0x1BF2608", VA = "0x1BF2608")]
	private void OnEnable()
	{
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x1BF26F0", Offset = "0x1BF26F0", VA = "0x1BF26F0")]
	private void OnDisable()
	{
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x1BF27D8", Offset = "0x1BF27D8", VA = "0x1BF27D8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x1BF28A8", Offset = "0x1BF28A8", VA = "0x1BF28A8")]
	private void OnCollisionExit(Collision other)
	{
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x1BF2974", Offset = "0x1BF2974", VA = "0x1BF2974")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x1BF2AF8", Offset = "0x1BF2AF8", VA = "0x1BF2AF8")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x1BF2C78", Offset = "0x1BF2C78", VA = "0x1BF2C78")]
	private void OnDestroy()
	{
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x060010F3 RID: 4339 RVA: 0x00006E88 File Offset: 0x00005088
	// (set) Token: 0x060010F4 RID: 4340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F1")]
	public int indexId
	{
		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x1BF2CC8", Offset = "0x1BF2CC8", VA = "0x1BF2CC8", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x1BF2CD0", Offset = "0x1BF2CD0", VA = "0x1BF2CD0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00006EA0 File Offset: 0x000050A0
	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x1BF2CD8", Offset = "0x1BF2CD8", VA = "0x1BF2CD8", Slot = "6")]
	public BoundingSphere GetBoundingSphere()
	{
		return default(BoundingSphere);
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x1BF2D00", Offset = "0x1BF2D00", VA = "0x1BF2D00", Slot = "7")]
	public void OnCullingStateVisible(bool visible)
	{
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x1BF2E10", Offset = "0x1BF2E10", VA = "0x1BF2E10")]
	public void AddCullObj()
	{
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x1BF2EB8", Offset = "0x1BF2EB8", VA = "0x1BF2EB8")]
	public void RemoveCullObj()
	{
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x1BF2F60", Offset = "0x1BF2F60", VA = "0x1BF2F60")]
	public CitySpaceManTrigger()
	{
	}

	// Token: 0x040013A3 RID: 5027
	[Token(Token = "0x40013A3")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<Collider, CitySpaceManTrigger> triggerDic;
}
