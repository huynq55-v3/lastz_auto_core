using System;
using System.Collections;
using System.Collections.Generic;
using BitBenderGames;
using GameKit.Base;
using Il2CppDummyDll;
using LW.CountBattle;
using Sfs2X.Core;
using Sfs2X.Requests;
using SuperScrollView;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityEngine.Video;
using VEngine;

namespace XLua
{
	// Token: 0x02000566 RID: 1382
	[Token(Token = "0x2000566")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	public class DelegateBridge_Wrap : DelegateBridge
	{
		// Token: 0x06002945 RID: 10565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002945")]
		[Address(RVA = "0x228AE64", Offset = "0x228AE64", VA = "0x228AE64")]
		public DelegateBridge_Wrap(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002946")]
		[Address(RVA = "0x228AED4", Offset = "0x228AED4", VA = "0x228AED4")]
		public void __Gen_Delegate_Imp0(int p0)
		{
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x228AF9C", Offset = "0x228AF9C", VA = "0x228AF9C")]
		public void __Gen_Delegate_Imp1(float p0)
		{
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002948")]
		[Address(RVA = "0x228B06C", Offset = "0x228B06C", VA = "0x228B06C")]
		public void __Gen_Delegate_Imp2(float p0, float p1)
		{
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x228B150", Offset = "0x228B150", VA = "0x228B150")]
		public void __Gen_Delegate_Imp3(bool p0)
		{
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x228B218", Offset = "0x228B218", VA = "0x228B218")]
		public void __Gen_Delegate_Imp4(long p0)
		{
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294B")]
		[Address(RVA = "0x228B2E0", Offset = "0x228B2E0", VA = "0x228B2E0")]
		public void __Gen_Delegate_Imp5(string p0, string p1, string p2)
		{
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x228B3D8", Offset = "0x228B3D8", VA = "0x228B3D8")]
		public void __Gen_Delegate_Imp6(string p0, string p1, string p2, string p3)
		{
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x228B4EC", Offset = "0x228B4EC", VA = "0x228B4EC")]
		public void __Gen_Delegate_Imp7(string p0, int p1, string p2, string p3, Action p4, Action p5, Action p6, string p7, bool p8)
		{
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x228B690", Offset = "0x228B690", VA = "0x228B690")]
		public void __Gen_Delegate_Imp8(string p0)
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x228B758", Offset = "0x228B758", VA = "0x228B758")]
		public string __Gen_Delegate_Imp9(string p0, int p1, string p2)
		{
			return null;
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002950")]
		[Address(RVA = "0x228B86C", Offset = "0x228B86C", VA = "0x228B86C")]
		public void __Gen_Delegate_Imp10()
		{
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002951")]
		[Address(RVA = "0x228B920", Offset = "0x228B920", VA = "0x228B920")]
		public string __Gen_Delegate_Imp11(int p0)
		{
			return null;
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002952")]
		[Address(RVA = "0x228BA04", Offset = "0x228BA04", VA = "0x228BA04")]
		public string __Gen_Delegate_Imp12(string p0, int p1)
		{
			return null;
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002953")]
		[Address(RVA = "0x228BB04", Offset = "0x228BB04", VA = "0x228BB04")]
		public List<int> __Gen_Delegate_Imp13(string p0)
		{
			return null;
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002954")]
		[Address(RVA = "0x228BC94", Offset = "0x228BC94", VA = "0x228BC94")]
		public void __Gen_Delegate_Imp14(byte[] p0)
		{
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x228BD5C", Offset = "0x228BD5C", VA = "0x228BD5C")]
		public void __Gen_Delegate_Imp15(int p0, object p1)
		{
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002956")]
		[Address(RVA = "0x228BE4C", Offset = "0x228BE4C", VA = "0x228BE4C")]
		public void __Gen_Delegate_Imp16(string p0, string p1, int p2)
		{
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002957")]
		[Address(RVA = "0x228BF44", Offset = "0x228BF44", VA = "0x228BF44")]
		public void __Gen_Delegate_Imp17(bool p0, int p1)
		{
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002958")]
		[Address(RVA = "0x228C028", Offset = "0x228C028", VA = "0x228C028")]
		public void __Gen_Delegate_Imp18(long p0, int p1)
		{
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002959")]
		[Address(RVA = "0x228C10C", Offset = "0x228C10C", VA = "0x228C10C")]
		public void __Gen_Delegate_Imp19(int p0, int p1)
		{
		}

		// Token: 0x0600295A RID: 10586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295A")]
		[Address(RVA = "0x228C1F0", Offset = "0x228C1F0", VA = "0x228C1F0")]
		public void __Gen_Delegate_Imp20(int p0, string p1)
		{
		}

		// Token: 0x0600295B RID: 10587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295B")]
		[Address(RVA = "0x228C2D4", Offset = "0x228C2D4", VA = "0x228C2D4")]
		public void __Gen_Delegate_Imp21(UnityWebRequest p0, bool p1, object p2)
		{
		}

		// Token: 0x0600295C RID: 10588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x228C3DC", Offset = "0x228C3DC", VA = "0x228C3DC")]
		public void __Gen_Delegate_Imp22(Asset p0)
		{
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295D")]
		[Address(RVA = "0x228C4B0", Offset = "0x228C4B0", VA = "0x228C4B0")]
		public void __Gen_Delegate_Imp23(GameObject p0)
		{
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295E")]
		[Address(RVA = "0x228C584", Offset = "0x228C584", VA = "0x228C584")]
		public void __Gen_Delegate_Imp24(Vector2 p0)
		{
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295F")]
		[Address(RVA = "0x228C690", Offset = "0x228C690", VA = "0x228C690")]
		public void __Gen_Delegate_Imp25(Vector3 p0)
		{
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002960")]
		[Address(RVA = "0x228C7AC", Offset = "0x228C7AC", VA = "0x228C7AC")]
		public void __Gen_Delegate_Imp26(Vector3 p0, Vector3 p1)
		{
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002961")]
		[Address(RVA = "0x228C8F8", Offset = "0x228C8F8", VA = "0x228C8F8")]
		public void __Gen_Delegate_Imp27(Vector3 p0, Vector3 p1, Vector3 p2)
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002962")]
		[Address(RVA = "0x228CA7C", Offset = "0x228CA7C", VA = "0x228CA7C")]
		public void __Gen_Delegate_Imp28(Vector3 p0, bool p1)
		{
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002963")]
		[Address(RVA = "0x228CBB4", Offset = "0x228CBB4", VA = "0x228CBB4")]
		public void __Gen_Delegate_Imp29(Vector3 p0, bool p1, bool p2)
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002964")]
		[Address(RVA = "0x228CD00", Offset = "0x228CD00", VA = "0x228CD00")]
		public void __Gen_Delegate_Imp30(LuaTable p0)
		{
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x228CDD4", Offset = "0x228CDD4", VA = "0x228CDD4")]
		public void __Gen_Delegate_Imp31(GameObject p0, int p1)
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002966")]
		[Address(RVA = "0x228CEC4", Offset = "0x228CEC4", VA = "0x228CEC4")]
		public void __Gen_Delegate_Imp32(GameObject p0, int p1, int p2)
		{
		}

		// Token: 0x06002967 RID: 10599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002967")]
		[Address(RVA = "0x228CFC8", Offset = "0x228CFC8", VA = "0x228CFC8")]
		public void __Gen_Delegate_Imp33(Image p0)
		{
		}

		// Token: 0x06002968 RID: 10600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002968")]
		[Address(RVA = "0x228D09C", Offset = "0x228D09C", VA = "0x228D09C")]
		public void __Gen_Delegate_Imp34(Scene p0, LoadSceneMode p1)
		{
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002969")]
		[Address(RVA = "0x228D1E4", Offset = "0x228D1E4", VA = "0x228D1E4")]
		public void __Gen_Delegate_Imp35(INetProxy p0, BaseEvent p1)
		{
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296A")]
		[Address(RVA = "0x228D2D8", Offset = "0x228D2D8", VA = "0x228D2D8")]
		public void __Gen_Delegate_Imp36(string p0, INetProxy p1)
		{
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296B")]
		[Address(RVA = "0x228D3C8", Offset = "0x228D3C8", VA = "0x228D3C8")]
		public void __Gen_Delegate_Imp37(InstanceRequest p0)
		{
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296C")]
		[Address(RVA = "0x228D49C", Offset = "0x228D49C", VA = "0x228D49C")]
		public void __Gen_Delegate_Imp38(PointerEventData p0)
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x228D570", Offset = "0x228D570", VA = "0x228D570")]
		public void __Gen_Delegate_Imp39(GameObject p0, PointerEventData p1, ExecuteEvents.EventFunction<IBeginDragHandler> p2)
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x228D67C", Offset = "0x228D67C", VA = "0x228D67C")]
		public Vector2 __Gen_Delegate_Imp40()
		{
			return default(Vector2);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[Token(Token = "0x600296F")]
		[Address(RVA = "0x228D778", Offset = "0x228D778", VA = "0x228D778")]
		public Vector3 __Gen_Delegate_Imp41()
		{
			return default(Vector3);
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[Token(Token = "0x6002970")]
		[Address(RVA = "0x228D87C", Offset = "0x228D87C", VA = "0x228D87C")]
		public float __Gen_Delegate_Imp42()
		{
			return 0f;
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002971")]
		[Address(RVA = "0x228D954", Offset = "0x228D954", VA = "0x228D954")]
		public void __Gen_Delegate_Imp43(bool p0, int p1, int p2, int p3)
		{
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002972")]
		[Address(RVA = "0x228DA68", Offset = "0x228DA68", VA = "0x228DA68")]
		public LoopListViewItem2 __Gen_Delegate_Imp44(LoopListView2 p0, int p1)
		{
			return null;
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002973")]
		[Address(RVA = "0x228DC18", Offset = "0x228DC18", VA = "0x228DC18")]
		public LoopListLazyViewItem2 __Gen_Delegate_Imp45(LoopListLazyView2 p0, int p1)
		{
			return null;
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002974")]
		[Address(RVA = "0x228DDC8", Offset = "0x228DDC8", VA = "0x228DDC8")]
		public void __Gen_Delegate_Imp46(Vector3 p0, float p1)
		{
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002975")]
		[Address(RVA = "0x228DEF8", Offset = "0x228DEF8", VA = "0x228DEF8")]
		public void __Gen_Delegate_Imp47(PinchUpdateData p0)
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002976")]
		[Address(RVA = "0x228DFCC", Offset = "0x228DFCC", VA = "0x228DFCC")]
		public void __Gen_Delegate_Imp48(SteerUnit p0)
		{
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002977")]
		[Address(RVA = "0x228E0A0", Offset = "0x228E0A0", VA = "0x228E0A0")]
		public void __Gen_Delegate_Imp49(int p0, SteerUnit p1)
		{
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002978")]
		[Address(RVA = "0x228E190", Offset = "0x228E190", VA = "0x228E190")]
		public void __Gen_Delegate_Imp50(VideoPlayer p0, long p1)
		{
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002979")]
		[Address(RVA = "0x228E280", Offset = "0x228E280", VA = "0x228E280")]
		public void __Gen_Delegate_Imp51(object p0)
		{
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0000FC30 File Offset: 0x0000DE30
		[Token(Token = "0x600297A")]
		[Address(RVA = "0x228E354", Offset = "0x228E354", VA = "0x228E354")]
		public int __Gen_Delegate_Imp52()
		{
			return 0;
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x0000FC48 File Offset: 0x0000DE48
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x228E424", Offset = "0x228E424", VA = "0x228E424")]
		public bool __Gen_Delegate_Imp53(object p0)
		{
			return default(bool);
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x228E514", Offset = "0x228E514", VA = "0x228E514")]
		public string __Gen_Delegate_Imp54()
		{
			return null;
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[Token(Token = "0x600297D")]
		[Address(RVA = "0x228E5E4", Offset = "0x228E5E4", VA = "0x228E5E4")]
		public bool __Gen_Delegate_Imp55()
		{
			return default(bool);
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600297E")]
		[Address(RVA = "0x228E6B4", Offset = "0x228E6B4", VA = "0x228E6B4")]
		public UnityWebRequest __Gen_Delegate_Imp56(object p0, object p1)
		{
			return null;
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x0000FC78 File Offset: 0x0000DE78
		[Token(Token = "0x600297F")]
		[Address(RVA = "0x228E868", Offset = "0x228E868", VA = "0x228E868")]
		public long __Gen_Delegate_Imp57(object p0)
		{
			return 0L;
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x0000FC90 File Offset: 0x0000DE90
		[Token(Token = "0x6002980")]
		[Address(RVA = "0x228E958", Offset = "0x228E958", VA = "0x228E958")]
		public bool __Gen_Delegate_Imp58(object p0, Vector3 p1, Vector3 p2, float p3)
		{
			return default(bool);
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002981")]
		[Address(RVA = "0x228EAF8", Offset = "0x228EAF8", VA = "0x228EAF8")]
		public void __Gen_Delegate_Imp59(object p0, object p1)
		{
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		[Token(Token = "0x6002982")]
		[Address(RVA = "0x228EBEC", Offset = "0x228EBEC", VA = "0x228EBEC")]
		public long __Gen_Delegate_Imp60(object p0, object p1)
		{
			return 0L;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		[Token(Token = "0x6002983")]
		[Address(RVA = "0x228ECFC", Offset = "0x228ECFC", VA = "0x228ECFC")]
		public int __Gen_Delegate_Imp61(object p0)
		{
			return 0;
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002984")]
		[Address(RVA = "0x228EDEC", Offset = "0x228EDEC", VA = "0x228EDEC")]
		public byte[] __Gen_Delegate_Imp62(object p0, int p1, int p2)
		{
			return null;
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002985")]
		[Address(RVA = "0x228EF0C", Offset = "0x228EF0C", VA = "0x228EF0C")]
		public string __Gen_Delegate_Imp63(object p0)
		{
			return null;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002986")]
		[Address(RVA = "0x228EFFC", Offset = "0x228EFFC", VA = "0x228EFFC")]
		public IRequest __Gen_Delegate_Imp64(object p0, object[] p1)
		{
			return null;
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002987")]
		[Address(RVA = "0x228F1F0", Offset = "0x228F1F0", VA = "0x228F1F0")]
		public void __Gen_Delegate_Imp65(object p0, object p1, object p2)
		{
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002988")]
		[Address(RVA = "0x228F2FC", Offset = "0x228F2FC", VA = "0x228F2FC")]
		public IEnumerator __Gen_Delegate_Imp66(object p0, object p1, object p2)
		{
			return null;
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002989")]
		[Address(RVA = "0x228F4B4", Offset = "0x228F4B4", VA = "0x228F4B4", Slot = "7")]
		public override Delegate GetDelegateByType(Type type)
		{
			return null;
		}
	}
}
