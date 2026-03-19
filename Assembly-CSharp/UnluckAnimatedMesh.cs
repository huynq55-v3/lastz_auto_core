using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200026B RID: 619
[Token(Token = "0x200026B")]
public class UnluckAnimatedMesh : MonoBehaviour
{
	// Token: 0x0600105A RID: 4186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105A")]
	[Address(RVA = "0x1BED308", Offset = "0x1BED308", VA = "0x1BED308")]
	public void Start()
	{
	}

	// Token: 0x0600105B RID: 4187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105B")]
	[Address(RVA = "0x1BED538", Offset = "0x1BED538", VA = "0x1BED538")]
	public void Play()
	{
	}

	// Token: 0x0600105C RID: 4188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x1BED644", Offset = "0x1BED644", VA = "0x1BED644")]
	public void RandomRotate()
	{
	}

	// Token: 0x0600105D RID: 4189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x1BED4E0", Offset = "0x1BED4E0", VA = "0x1BED4E0")]
	public void GetRequiredComponents()
	{
	}

	// Token: 0x0600105E RID: 4190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105E")]
	[Address(RVA = "0x1BED604", Offset = "0x1BED604", VA = "0x1BED604")]
	public void RandomizePlaySpeed()
	{
	}

	// Token: 0x0600105F RID: 4191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105F")]
	[Address(RVA = "0x1BED7F0", Offset = "0x1BED7F0", VA = "0x1BED7F0")]
	public void FillCacheArray()
	{
	}

	// Token: 0x06001060 RID: 4192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001060")]
	[Address(RVA = "0x1BED434", Offset = "0x1BED434", VA = "0x1BED434")]
	public void CheckIfMeshHasChanged()
	{
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001061")]
	[Address(RVA = "0x1BEDA20", Offset = "0x1BEDA20", VA = "0x1BEDA20")]
	public void Update()
	{
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00006D68 File Offset: 0x00004F68
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x1BEDB1C", Offset = "0x1BEDB1C", VA = "0x1BEDB1C")]
	public bool PingPongFrame()
	{
		return default(bool);
	}

	// Token: 0x06001063 RID: 4195 RVA: 0x00006D80 File Offset: 0x00004F80
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x1BEDB8C", Offset = "0x1BEDB8C", VA = "0x1BEDB8C")]
	public bool NextFrame()
	{
		return default(bool);
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x1BEDC04", Offset = "0x1BEDC04", VA = "0x1BEDC04")]
	public void RandomizePropertiesAfterLoop()
	{
	}

	// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x1BEDA60", Offset = "0x1BEDA60", VA = "0x1BEDA60")]
	public void Animate()
	{
	}

	// Token: 0x06001066 RID: 4198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001066")]
	[Address(RVA = "0x1BEDC38", Offset = "0x1BEDC38", VA = "0x1BEDC38")]
	public UnluckAnimatedMesh()
	{
	}

	// Token: 0x040012E5 RID: 4837
	[Token(Token = "0x40012E5")]
	[FieldOffset(Offset = "0x18")]
	public MeshFilter[] meshCache;

	// Token: 0x040012E6 RID: 4838
	[Token(Token = "0x40012E6")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Transform meshCached;

	// Token: 0x040012E7 RID: 4839
	[Token(Token = "0x40012E7")]
	[FieldOffset(Offset = "0x28")]
	public Transform meshContainerFBX;

	// Token: 0x040012E8 RID: 4840
	[Token(Token = "0x40012E8")]
	[FieldOffset(Offset = "0x30")]
	public float playSpeed;

	// Token: 0x040012E9 RID: 4841
	[Token(Token = "0x40012E9")]
	[FieldOffset(Offset = "0x34")]
	public float playSpeedRandom;

	// Token: 0x040012EA RID: 4842
	[Token(Token = "0x40012EA")]
	[FieldOffset(Offset = "0x38")]
	public bool randomSpeedLoop;

	// Token: 0x040012EB RID: 4843
	[Token(Token = "0x40012EB")]
	[FieldOffset(Offset = "0x3C")]
	private float currentSpeed;

	// Token: 0x040012EC RID: 4844
	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float currentFrame;

	// Token: 0x040012ED RID: 4845
	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public int meshCacheCount;

	// Token: 0x040012EE RID: 4846
	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public MeshFilter meshFilter;

	// Token: 0x040012EF RID: 4847
	[Token(Token = "0x40012EF")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Renderer rendererComponent;

	// Token: 0x040012F0 RID: 4848
	[Token(Token = "0x40012F0")]
	[FieldOffset(Offset = "0x58")]
	public float updateInterval;

	// Token: 0x040012F1 RID: 4849
	[Token(Token = "0x40012F1")]
	[FieldOffset(Offset = "0x5C")]
	public bool randomRotateX;

	// Token: 0x040012F2 RID: 4850
	[Token(Token = "0x40012F2")]
	[FieldOffset(Offset = "0x5D")]
	public bool randomRotateY;

	// Token: 0x040012F3 RID: 4851
	[Token(Token = "0x40012F3")]
	[FieldOffset(Offset = "0x5E")]
	public bool randomRotateZ;

	// Token: 0x040012F4 RID: 4852
	[Token(Token = "0x40012F4")]
	[FieldOffset(Offset = "0x5F")]
	public bool randomStartFrame;

	// Token: 0x040012F5 RID: 4853
	[Token(Token = "0x40012F5")]
	[FieldOffset(Offset = "0x60")]
	public bool randomRotateLoop;

	// Token: 0x040012F6 RID: 4854
	[Token(Token = "0x40012F6")]
	[FieldOffset(Offset = "0x61")]
	public bool loop;

	// Token: 0x040012F7 RID: 4855
	[Token(Token = "0x40012F7")]
	[FieldOffset(Offset = "0x62")]
	public bool pingPong;

	// Token: 0x040012F8 RID: 4856
	[Token(Token = "0x40012F8")]
	[FieldOffset(Offset = "0x63")]
	public bool playOnAwake;

	// Token: 0x040012F9 RID: 4857
	[Token(Token = "0x40012F9")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 randomStartDelay;

	// Token: 0x040012FA RID: 4858
	[Token(Token = "0x40012FA")]
	[FieldOffset(Offset = "0x6C")]
	private float startDelay;

	// Token: 0x040012FB RID: 4859
	[Token(Token = "0x40012FB")]
	[FieldOffset(Offset = "0x70")]
	private float startDelayCounter;

	// Token: 0x040012FC RID: 4860
	[Token(Token = "0x40012FC")]
	[FieldOffset(Offset = "0x0")]
	public static float updateSeed;

	// Token: 0x040012FD RID: 4861
	[Token(Token = "0x40012FD")]
	[FieldOffset(Offset = "0x74")]
	private bool pingPongToggle;

	// Token: 0x040012FE RID: 4862
	[Token(Token = "0x40012FE")]
	[FieldOffset(Offset = "0x78")]
	public Transform transformCache;

	// Token: 0x040012FF RID: 4863
	[Token(Token = "0x40012FF")]
	[FieldOffset(Offset = "0x80")]
	public float delta;
}
