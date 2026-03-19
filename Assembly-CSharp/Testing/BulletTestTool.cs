using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Testing
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	public class BulletTestTool : MonoBehaviour
	{
		// Token: 0x060017BB RID: 6075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x1DB8980", Offset = "0x1DB8980", VA = "0x1DB8980")]
		private void Awake()
		{
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x1DB8A70", Offset = "0x1DB8A70", VA = "0x1DB8A70")]
		private void Update()
		{
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BD")]
		[Address(RVA = "0x1DB8BBC", Offset = "0x1DB8BBC", VA = "0x1DB8BBC")]
		public void StartFire()
		{
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x1DB8E40", Offset = "0x1DB8E40", VA = "0x1DB8E40")]
		public void Fire()
		{
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BF")]
		[Address(RVA = "0x1DB91E4", Offset = "0x1DB91E4", VA = "0x1DB91E4")]
		private void PlayIdle()
		{
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C0")]
		[Address(RVA = "0x1DB9290", Offset = "0x1DB9290", VA = "0x1DB9290")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x60017C1")]
		[Address(RVA = "0x1DB94E0", Offset = "0x1DB94E0", VA = "0x1DB94E0")]
		private Vector3 GetPathPoint(Vector3 start, Vector3 end, float progress, float h, float p, BulletFlyType type)
		{
			return default(Vector3);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C2")]
		[Address(RVA = "0x1DB9600", Offset = "0x1DB9600", VA = "0x1DB9600")]
		public BulletTestTool()
		{
		}

		// Token: 0x04001A6F RID: 6767
		[Token(Token = "0x4001A6F")]
		[FieldOffset(Offset = "0x18")]
		private BulletTestManager _testManager;

		// Token: 0x04001A70 RID: 6768
		[Token(Token = "0x4001A70")]
		[FieldOffset(Offset = "0x20")]
		[Header("位置配置")]
		public Transform attacker;

		// Token: 0x04001A71 RID: 6769
		[Token(Token = "0x4001A71")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		// Token: 0x04001A72 RID: 6770
		[Token(Token = "0x4001A72")]
		[FieldOffset(Offset = "0x30")]
		[Header("资源配置 (支持直接从 Project/场景 拖入)")]
		public GameObject bulletPrefab;

		// Token: 0x04001A73 RID: 6771
		[Token(Token = "0x4001A73")]
		[FieldOffset(Offset = "0x38")]
		public GameObject hitEffectPrefab;

		// Token: 0x04001A74 RID: 6772
		[Token(Token = "0x4001A74")]
		[FieldOffset(Offset = "0x40")]
		[Header("特效与动画")]
		public GameObject muzzleFlashPrefab;

		// Token: 0x04001A75 RID: 6773
		[Token(Token = "0x4001A75")]
		[FieldOffset(Offset = "0x48")]
		public SimpleAnimation attackerAnim;

		// Token: 0x04001A76 RID: 6774
		[Token(Token = "0x4001A76")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("受击特效销毁延迟时间(秒)")]
		public float hitDestroyDelay;

		// Token: 0x04001A77 RID: 6775
		[Token(Token = "0x4001A77")]
		[FieldOffset(Offset = "0x54")]
		[Header("轨迹参数")]
		public BulletFlyType flyType;

		// Token: 0x04001A78 RID: 6776
		[Token(Token = "0x4001A78")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("高度控制：\n- Arc (抛物线): 代表最高点相对于起点的垂直高度。\n- DStyle (Slerp): 代表旋转中心下移的距离。该值越小，曲线弧度越大；该值越大（如400），轨迹越接近直线。")]
		public float height;

		// Token: 0x04001A79 RID: 6777
		[Token(Token = "0x4001A79")]
		[FieldOffset(Offset = "0x5C")]
		[Tooltip("中心点比例 (仅DStyle有效)：\n- 决定旋转中心在起点和终点之间的水平位置。\n- 0.5 代表在正中间；偏向 0 或 1 会导致轨迹向一侧倾斜（非对称弧线）。")]
		public float percent;

		// Token: 0x04001A7A RID: 6778
		[Token(Token = "0x4001A7A")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("飞行速度：\n- 决定 progress 增长速度。\n- 默认值：DStyle 模式下为 0.0015，其他模式下为 0.003。")]
		public float speed;

		// Token: 0x04001A7B RID: 6779
		[Token(Token = "0x4001A7B")]
		[FieldOffset(Offset = "0x64")]
		[HideInInspector]
		[Tooltip("目标点高度偏移：\n- 最终目标点在 target 变换位置基础上的垂直偏移。")]
		public float flyValue;

		// Token: 0x04001A7C RID: 6780
		[Token(Token = "0x4001A7C")]
		[FieldOffset(Offset = "0x68")]
		[Header("测试控制")]
		public bool autoFire;

		// Token: 0x04001A7D RID: 6781
		[Token(Token = "0x4001A7D")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("连发子弹数")]
		public int burstCount;

		// Token: 0x04001A7E RID: 6782
		[Token(Token = "0x4001A7E")]
		[FieldOffset(Offset = "0x70")]
		[Tooltip("子弹间隔(秒)")]
		public float burstInterval;

		// Token: 0x04001A7F RID: 6783
		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0x74")]
		private readonly float _autoFireInterval;

		// Token: 0x04001A80 RID: 6784
		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0x78")]
		private float _lastAutoFireTime;

		// Token: 0x04001A81 RID: 6785
		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0x7C")]
		private int _burstRemaining;

		// Token: 0x04001A82 RID: 6786
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x80")]
		private float _lastBulletTime;
	}
}
