using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Framework.Utils.UnityEx
{
	// Token: 0x020003D8 RID: 984
	[Token(Token = "0x20003D8")]
	public class ScreenToucher : MonoBehaviour
	{
		// Token: 0x060018D3 RID: 6355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D3")]
		[Address(RVA = "0x2024190", Offset = "0x2024190", VA = "0x2024190")]
		public void Clear()
		{
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x20241F0", Offset = "0x20241F0", VA = "0x20241F0")]
		private bool AddPointerDownRecord(int pointerId, Vector2 pointerPosi)
		{
			return default(bool);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x202429C", Offset = "0x202429C", VA = "0x202429C")]
		private bool AddPointerDownIgnoreUIRecord(int pointerId, Vector2 pointerPosi)
		{
			return default(bool);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x2024348", Offset = "0x2024348", VA = "0x2024348")]
		private void AddTempMoveRecord(int pointerId, Vector2 pointerPosi)
		{
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x2024420", Offset = "0x2024420", VA = "0x2024420")]
		private void RemoveTempMoveRecord(int pointerId)
		{
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x20244B0", Offset = "0x20244B0", VA = "0x20244B0")]
		private void RemovePointerDownRecord(int pointerId)
		{
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x2024578", Offset = "0x2024578", VA = "0x2024578")]
		private void CallTouchDownEvent(int pointerId, Vector2 pointerPosi)
		{
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x2024674", Offset = "0x2024674", VA = "0x2024674")]
		private void CallTouchDownIgnoreUIEvent(int pointerId, Vector2 pointerPosi)
		{
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x2024770", Offset = "0x2024770", VA = "0x2024770")]
		private void CallTouchUpEvent(int pointerId, Vector2 pointerPosi)
		{
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x20249A4", Offset = "0x20249A4", VA = "0x20249A4")]
		private void CallTouchClickEvent(int pointerId, Vector2 pointerPosi)
		{
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x2024BC4", Offset = "0x2024BC4", VA = "0x2024BC4")]
		private void CallTouchMoveEvent(int pointerId, Vector2 pointerPosi, Vector2 deltaPosi)
		{
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x2024C94", Offset = "0x2024C94", VA = "0x2024C94")]
		private void Update()
		{
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x20248E8", Offset = "0x20248E8", VA = "0x20248E8")]
		public bool IsPointerOverUIObject(int fingerID, Vector2 screenPosition)
		{
			return default(bool);
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x20250C8", Offset = "0x20250C8", VA = "0x20250C8")]
		public bool IsPointerOverUIObject(Vector2 screenPosition)
		{
			return default(bool);
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x2025234", Offset = "0x2025234", VA = "0x2025234")]
		public ScreenToucher()
		{
		}

		// Token: 0x04001B57 RID: 6999
		[Token(Token = "0x4001B57")]
		private const float CLICK_JUDGE = 200f;

		// Token: 0x04001B58 RID: 7000
		[Token(Token = "0x4001B58")]
		[FieldOffset(Offset = "0x18")]
		public readonly Dictionary<int, Vector2> _pointerDownPosi;

		// Token: 0x04001B59 RID: 7001
		[Token(Token = "0x4001B59")]
		[FieldOffset(Offset = "0x20")]
		public readonly Dictionary<int, Vector2> _pointerDownPosiIgnoreUI;

		// Token: 0x04001B5A RID: 7002
		[Token(Token = "0x4001B5A")]
		[FieldOffset(Offset = "0x28")]
		public readonly Dictionary<int, Vector2> _tempMovePosi;

		// Token: 0x04001B5B RID: 7003
		[Token(Token = "0x4001B5B")]
		[FieldOffset(Offset = "0x30")]
		public EventSystem eventSystem;
	}
}
