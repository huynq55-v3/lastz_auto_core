using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityGameFramework.Runtime
{
	// Token: 0x020004B1 RID: 1201
	[Token(Token = "0x20004B1")]
	public class EventComponent : IGameController
	{
		// Token: 0x0600239E RID: 9118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x2A047E8", Offset = "0x2A047E8", VA = "0x2A047E8")]
		public EventComponent(EventPoolMode mode)
		{
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x2A04984", Offset = "0x2A04984", VA = "0x2A04984", Slot = "4")]
		public void OnUpdate(float elapseSeconds)
		{
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A0")]
		[Address(RVA = "0x2A04988", Offset = "0x2A04988", VA = "0x2A04988", Slot = "5")]
		public void Shutdown()
		{
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0000D860 File Offset: 0x0000BA60
		[Token(Token = "0x60023A1")]
		[Address(RVA = "0x2A04A3C", Offset = "0x2A04A3C", VA = "0x2A04A3C")]
		private bool Check(EventId id, Action<object> handler)
		{
			return default(bool);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A2")]
		[Address(RVA = "0x2A04A44", Offset = "0x2A04A44", VA = "0x2A04A44")]
		public void Subscribe(EventId eventID, Action<object> handler)
		{
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A3")]
		[Address(RVA = "0x2A04D80", Offset = "0x2A04D80", VA = "0x2A04D80")]
		public void Unsubscribe(EventId eventId, Action<object> handler)
		{
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A4")]
		[Address(RVA = "0x2A04FE0", Offset = "0x2A04FE0", VA = "0x2A04FE0")]
		public void Fire(EventId eventId, [Optional] object userData)
		{
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x2A051A0", Offset = "0x2A051A0", VA = "0x2A051A0")]
		private void HandleEvent(EventId eventId, object userData)
		{
		}

		// Token: 0x040020F1 RID: 8433
		[Token(Token = "0x40020F1")]
		[FieldOffset(Offset = "0x10")]
		private EventComponent.ObjectPool<List<Action<object>>> m_Pool;

		// Token: 0x040020F2 RID: 8434
		[Token(Token = "0x40020F2")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, List<Action<object>>> m_EventHandlers;

		// Token: 0x040020F3 RID: 8435
		[Token(Token = "0x40020F3")]
		[FieldOffset(Offset = "0x20")]
		private readonly EventPoolMode m_EventPoolMode;

		// Token: 0x020004B2 RID: 1202
		[Token(Token = "0x20004B2")]
		public class ObjectPool<T>
		{
			// Token: 0x060023A6 RID: 9126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023A6")]
			public ObjectPool(Func<T> objectGenerator)
			{
			}

			// Token: 0x060023A7 RID: 9127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60023A7")]
			public T Get()
			{
				return null;
			}

			// Token: 0x060023A8 RID: 9128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023A8")]
			public void Return(T item)
			{
			}

			// Token: 0x060023A9 RID: 9129 RVA: 0x0000D878 File Offset: 0x0000BA78
			[Token(Token = "0x60023A9")]
			public int Count()
			{
				return 0;
			}

			// Token: 0x040020F4 RID: 8436
			[Token(Token = "0x40020F4")]
			[FieldOffset(Offset = "0x0")]
			private readonly Queue<T> _objects;

			// Token: 0x040020F5 RID: 8437
			[Token(Token = "0x40020F5")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<T> _objectGenerator;
		}
	}
}
