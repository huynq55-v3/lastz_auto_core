using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Experiment.Steer
{
	// Token: 0x02000CFC RID: 3324
	[Token(Token = "0x2000CFC")]
	public class SteerManager : MonoBehaviour
	{
		// Token: 0x06007C7A RID: 31866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7A")]
		[Address(RVA = "0x319CF28", Offset = "0x319CF28", VA = "0x319CF28")]
		private void Start()
		{
		}

		// Token: 0x06007C7B RID: 31867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7B")]
		[Address(RVA = "0x319CFDC", Offset = "0x319CFDC", VA = "0x319CFDC")]
		private void InitTraps()
		{
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7C")]
		[Address(RVA = "0x319D56C", Offset = "0x319D56C", VA = "0x319D56C")]
		private void OnGUI()
		{
		}

		// Token: 0x06007C7D RID: 31869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7D")]
		[Address(RVA = "0x319DA44", Offset = "0x319DA44", VA = "0x319DA44")]
		private void Update()
		{
		}

		// Token: 0x06007C7E RID: 31870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7E")]
		[Address(RVA = "0x319DC1C", Offset = "0x319DC1C", VA = "0x319DC1C")]
		private void LateUpdate()
		{
		}

		// Token: 0x06007C7F RID: 31871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7F")]
		[Address(RVA = "0x319DA98", Offset = "0x319DA98", VA = "0x319DA98")]
		private void Tick(float dt)
		{
		}

		// Token: 0x06007C80 RID: 31872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C80")]
		[Address(RVA = "0x319D4E8", Offset = "0x319D4E8", VA = "0x319D4E8")]
		private IEnumerator Spawn()
		{
			return null;
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C81")]
		[Address(RVA = "0x319DD80", Offset = "0x319DD80", VA = "0x319DD80")]
		private void Follow()
		{
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C82")]
		[Address(RVA = "0x319E1BC", Offset = "0x319E1BC", VA = "0x319E1BC")]
		private void Repulsion()
		{
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C83")]
		[Address(RVA = "0x319E51C", Offset = "0x319E51C", VA = "0x319E51C")]
		private void Attraction()
		{
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C84")]
		[Address(RVA = "0x319E6FC", Offset = "0x319E6FC", VA = "0x319E6FC")]
		private void Boid(float dt)
		{
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x00054948 File Offset: 0x00052B48
		[Token(Token = "0x6007C85")]
		[Address(RVA = "0x319E7D0", Offset = "0x319E7D0", VA = "0x319E7D0")]
		private Vector2 Separate(int currIdx, float dt)
		{
			return default(Vector2);
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C86")]
		[Address(RVA = "0x319DF60", Offset = "0x319DF60", VA = "0x319DF60")]
		private void Trap()
		{
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C87")]
		[Address(RVA = "0x319EB74", Offset = "0x319EB74", VA = "0x319EB74")]
		public SteerManager()
		{
		}

		// Token: 0x04003879 RID: 14457
		[Token(Token = "0x4003879")]
		[FieldOffset(Offset = "0x18")]
		public int amount;

		// Token: 0x0400387A RID: 14458
		[Token(Token = "0x400387A")]
		[FieldOffset(Offset = "0x1C")]
		public float unitRadius;

		// Token: 0x0400387B RID: 14459
		[Token(Token = "0x400387B")]
		[FieldOffset(Offset = "0x20")]
		public float repForceFactor;

		// Token: 0x0400387C RID: 14460
		[Token(Token = "0x400387C")]
		[FieldOffset(Offset = "0x24")]
		public float attForceFactor;

		// Token: 0x0400387D RID: 14461
		[Token(Token = "0x400387D")]
		[FieldOffset(Offset = "0x28")]
		public float attSqrMagLimit;

		// Token: 0x0400387E RID: 14462
		[Token(Token = "0x400387E")]
		[FieldOffset(Offset = "0x2C")]
		public int interation;

		// Token: 0x0400387F RID: 14463
		[Token(Token = "0x400387F")]
		[FieldOffset(Offset = "0x30")]
		public int spawnPerFrame;

		// Token: 0x04003880 RID: 14464
		[Token(Token = "0x4003880")]
		[FieldOffset(Offset = "0x34")]
		public bool spawnOnStart;

		// Token: 0x04003881 RID: 14465
		[Token(Token = "0x4003881")]
		[FieldOffset(Offset = "0x38")]
		public float tickInterval;

		// Token: 0x04003882 RID: 14466
		[Token(Token = "0x4003882")]
		[FieldOffset(Offset = "0x40")]
		public GameObject modelTemplate;

		// Token: 0x04003883 RID: 14467
		[Token(Token = "0x4003883")]
		[FieldOffset(Offset = "0x48")]
		public Transform groupCylinder;

		// Token: 0x04003884 RID: 14468
		[Token(Token = "0x4003884")]
		[FieldOffset(Offset = "0x50")]
		public List<GameObject> cylinders;

		// Token: 0x04003885 RID: 14469
		[Token(Token = "0x4003885")]
		[FieldOffset(Offset = "0x58")]
		public List<GameObject> cubes;

		// Token: 0x04003886 RID: 14470
		[Token(Token = "0x4003886")]
		[FieldOffset(Offset = "0x60")]
		private List<SteerManager.Unit> _units;

		// Token: 0x04003887 RID: 14471
		[Token(Token = "0x4003887")]
		[FieldOffset(Offset = "0x68")]
		private List<SteerManager.Shape> _trapShapes;

		// Token: 0x04003888 RID: 14472
		[Token(Token = "0x4003888")]
		[FieldOffset(Offset = "0x70")]
		private SteerManager.Circle _groupCircle;

		// Token: 0x04003889 RID: 14473
		[Token(Token = "0x4003889")]
		[FieldOffset(Offset = "0x78")]
		private bool _attSwitch;

		// Token: 0x0400388A RID: 14474
		[Token(Token = "0x400388A")]
		[FieldOffset(Offset = "0x7C")]
		private float _tickTimer;

		// Token: 0x02000CFD RID: 3325
		[Token(Token = "0x2000CFD")]
		public abstract class Shape
		{
			// Token: 0x06007C88 RID: 31880
			[Token(Token = "0x6007C88")]
			public abstract Vector2 World2Local(Vector2 worldPoint);

			// Token: 0x06007C89 RID: 31881
			[Token(Token = "0x6007C89")]
			public abstract bool Contains(Vector2 point);

			// Token: 0x06007C8A RID: 31882
			[Token(Token = "0x6007C8A")]
			public abstract bool Overlap(SteerManager.Shape other);

			// Token: 0x06007C8B RID: 31883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C8B")]
			[Address(RVA = "0x319ED3C", Offset = "0x319ED3C", VA = "0x319ED3C")]
			protected Shape()
			{
			}

			// Token: 0x0400388B RID: 14475
			[Token(Token = "0x400388B")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 pos;
		}

		// Token: 0x02000CFE RID: 3326
		[Token(Token = "0x2000CFE")]
		public class Circle : SteerManager.Shape
		{
			// Token: 0x06007C8C RID: 31884 RVA: 0x00054960 File Offset: 0x00052B60
			[Token(Token = "0x6007C8C")]
			[Address(RVA = "0x319ED44", Offset = "0x319ED44", VA = "0x319ED44", Slot = "4")]
			public override Vector2 World2Local(Vector2 worldPoint)
			{
				return default(Vector2);
			}

			// Token: 0x06007C8D RID: 31885 RVA: 0x00054978 File Offset: 0x00052B78
			[Token(Token = "0x6007C8D")]
			[Address(RVA = "0x319ED54", Offset = "0x319ED54", VA = "0x319ED54", Slot = "5")]
			public override bool Contains(Vector2 point)
			{
				return default(bool);
			}

			// Token: 0x06007C8E RID: 31886 RVA: 0x00054990 File Offset: 0x00052B90
			[Token(Token = "0x6007C8E")]
			[Address(RVA = "0x319ED80", Offset = "0x319ED80", VA = "0x319ED80", Slot = "6")]
			public override bool Overlap(SteerManager.Shape other)
			{
				return default(bool);
			}

			// Token: 0x06007C8F RID: 31887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C8F")]
			[Address(RVA = "0x319D55C", Offset = "0x319D55C", VA = "0x319D55C")]
			public Circle()
			{
			}

			// Token: 0x0400388C RID: 14476
			[Token(Token = "0x400388C")]
			[FieldOffset(Offset = "0x18")]
			public float radius;
		}

		// Token: 0x02000CFF RID: 3327
		[Token(Token = "0x2000CFF")]
		public class Box : SteerManager.Shape
		{
			// Token: 0x06007C90 RID: 31888 RVA: 0x000549A8 File Offset: 0x00052BA8
			[Token(Token = "0x6007C90")]
			[Address(RVA = "0x319EEAC", Offset = "0x319EEAC", VA = "0x319EEAC", Slot = "4")]
			public override Vector2 World2Local(Vector2 worldPoint)
			{
				return default(Vector2);
			}

			// Token: 0x06007C91 RID: 31889 RVA: 0x000549C0 File Offset: 0x00052BC0
			[Token(Token = "0x6007C91")]
			[Address(RVA = "0x319EF08", Offset = "0x319EF08", VA = "0x319EF08", Slot = "5")]
			public override bool Contains(Vector2 point)
			{
				return default(bool);
			}

			// Token: 0x06007C92 RID: 31890 RVA: 0x000549D8 File Offset: 0x00052BD8
			[Token(Token = "0x6007C92")]
			[Address(RVA = "0x319EF58", Offset = "0x319EF58", VA = "0x319EF58", Slot = "6")]
			public override bool Overlap(SteerManager.Shape other)
			{
				return default(bool);
			}

			// Token: 0x06007C93 RID: 31891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C93")]
			[Address(RVA = "0x319D564", Offset = "0x319D564", VA = "0x319D564")]
			public Box()
			{
			}

			// Token: 0x0400388D RID: 14477
			[Token(Token = "0x400388D")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 size;

			// Token: 0x0400388E RID: 14478
			[Token(Token = "0x400388E")]
			[FieldOffset(Offset = "0x20")]
			public float angle;
		}

		// Token: 0x02000D00 RID: 3328
		[Token(Token = "0x2000D00")]
		public class Unit
		{
			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x06007C94 RID: 31892 RVA: 0x000549F0 File Offset: 0x00052BF0
			[Token(Token = "0x17000B36")]
			public Vector2 pos
			{
				[Token(Token = "0x6007C94")]
				[Address(RVA = "0x319E6E0", Offset = "0x319E6E0", VA = "0x319E6E0")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x06007C95 RID: 31893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C95")]
			[Address(RVA = "0x319D9E8", Offset = "0x319D9E8", VA = "0x319D9E8")]
			public void Destroy()
			{
			}

			// Token: 0x06007C96 RID: 31894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C96")]
			[Address(RVA = "0x319E690", Offset = "0x319E690", VA = "0x319E690")]
			public void Move(Vector2 vec)
			{
			}

			// Token: 0x06007C97 RID: 31895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C97")]
			[Address(RVA = "0x319DD44", Offset = "0x319DD44", VA = "0x319DD44")]
			public void Sync()
			{
			}

			// Token: 0x06007C98 RID: 31896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C98")]
			[Address(RVA = "0x319F05C", Offset = "0x319F05C", VA = "0x319F05C")]
			public Unit()
			{
			}

			// Token: 0x0400388F RID: 14479
			[Token(Token = "0x400388F")]
			[FieldOffset(Offset = "0x10")]
			public GameObject inst;

			// Token: 0x04003890 RID: 14480
			[Token(Token = "0x4003890")]
			[FieldOffset(Offset = "0x18")]
			public SteerManager.Circle shape;

			// Token: 0x04003891 RID: 14481
			[Token(Token = "0x4003891")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 force;
		}
	}
}
