using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

// Token: 0x020002E7 RID: 743
[Token(Token = "0x20002E7")]
[BurstCompile]
public struct VelocityJob : IJobParallelFor
{
	// Token: 0x0600132D RID: 4909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132D")]
	[Address(RVA = "0x1A47B30", Offset = "0x1A47B30", VA = "0x1A47B30", Slot = "4")]
	public void Execute(int index)
	{
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x00007980 File Offset: 0x00005B80
	[Token(Token = "0x600132E")]
	[Address(RVA = "0x1A47EF8", Offset = "0x1A47EF8", VA = "0x1A47EF8")]
	private float3 CalculatePosition(int index, float p)
	{
		return default(float3);
	}

	// Token: 0x0400160F RID: 5647
	[Token(Token = "0x400160F")]
	[FieldOffset(Offset = "0x0")]
	public NativeArray<float3> positions;

	// Token: 0x04001610 RID: 5648
	[Token(Token = "0x4001610")]
	[FieldOffset(Offset = "0x10")]
	public NativeArray<quaternion> rotations;

	// Token: 0x04001611 RID: 5649
	[Token(Token = "0x4001611")]
	[FieldOffset(Offset = "0x20")]
	[ReadOnly]
	public NativeArray<float3> startPositions;

	// Token: 0x04001612 RID: 5650
	[Token(Token = "0x4001612")]
	[FieldOffset(Offset = "0x30")]
	[ReadOnly]
	public NativeArray<double> timeArray;

	// Token: 0x04001613 RID: 5651
	[Token(Token = "0x4001613")]
	[FieldOffset(Offset = "0x40")]
	[WriteOnly]
	public NativeArray<float> distances;

	// Token: 0x04001614 RID: 5652
	[Token(Token = "0x4001614")]
	[FieldOffset(Offset = "0x50")]
	[ReadOnly]
	public NativeArray<float3> endPos;

	// Token: 0x04001615 RID: 5653
	[Token(Token = "0x4001615")]
	[FieldOffset(Offset = "0x60")]
	[ReadOnly]
	public double delaTime;

	// Token: 0x04001616 RID: 5654
	[Token(Token = "0x4001616")]
	[FieldOffset(Offset = "0x68")]
	[ReadOnly]
	public NativeArray<bool> isCreateFinish;

	// Token: 0x04001617 RID: 5655
	[Token(Token = "0x4001617")]
	[FieldOffset(Offset = "0x78")]
	[ReadOnly]
	public NativeArray<float> height;

	// Token: 0x04001618 RID: 5656
	[Token(Token = "0x4001618")]
	[FieldOffset(Offset = "0x88")]
	[ReadOnly]
	public NativeArray<float> speed;

	// Token: 0x04001619 RID: 5657
	[Token(Token = "0x4001619")]
	[FieldOffset(Offset = "0x98")]
	[ReadOnly]
	public NativeArray<float> percent;

	// Token: 0x0400161A RID: 5658
	[Token(Token = "0x400161A")]
	[FieldOffset(Offset = "0xA8")]
	[ReadOnly]
	public NativeArray<int> flyType;
}
