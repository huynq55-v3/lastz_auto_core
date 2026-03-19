using System;
using System.Reflection;
using BitBenderGames;
using DG.Tweening;
using Framework.Utils.UnityEx;
using GameFramework.Localization;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace XLua
{
	// Token: 0x02000568 RID: 1384
	[Token(Token = "0x2000568")]
	public static class ObjectTranslator_Gen
	{
		// Token: 0x060029BB RID: 10683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BB")]
		[Address(RVA = "0x25D6C7C", Offset = "0x25D6C7C", VA = "0x25D6C7C")]
		public static void Init(LuaEnv luaenv, ObjectTranslator translator)
		{
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BC")]
		[Address(RVA = "0x25DBF50", Offset = "0x25DBF50", VA = "0x25DBF50")]
		public static void PushFrameworkUtilsUnityExTouchInfo(this ObjectTranslator thiz, IntPtr L, TouchInfo val)
		{
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BD")]
		[Address(RVA = "0x25DC168", Offset = "0x25DC168", VA = "0x25DC168")]
		public static void GetFrameworkUtilsUnityExTouchInfo(this ObjectTranslator thiz, IntPtr L, int index, out TouchInfo val)
		{
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BE")]
		[Address(RVA = "0x25DC3F4", Offset = "0x25DC3F4", VA = "0x25DC3F4")]
		public static void UpdateFrameworkUtilsUnityExTouchInfo(this ObjectTranslator thiz, IntPtr L, int index, TouchInfo val)
		{
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029BF")]
		[Address(RVA = "0x25DC654", Offset = "0x25DC654", VA = "0x25DC654")]
		public static void PushUnityEngineVector2(this ObjectTranslator thiz, IntPtr L, Vector2 val)
		{
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x25DC850", Offset = "0x25DC850", VA = "0x25DC850")]
		public static void GetUnityEngineVector2(this ObjectTranslator thiz, IntPtr L, int index, out Vector2 val)
		{
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x25DCAD4", Offset = "0x25DCAD4", VA = "0x25DCAD4")]
		public static void UpdateUnityEngineVector2(this ObjectTranslator thiz, IntPtr L, int index, Vector2 val)
		{
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C2")]
		[Address(RVA = "0x25DCD10", Offset = "0x25DCD10", VA = "0x25DCD10")]
		public static void PushUnityEngineVector3(this ObjectTranslator thiz, IntPtr L, Vector3 val)
		{
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C3")]
		[Address(RVA = "0x25DCF24", Offset = "0x25DCF24", VA = "0x25DCF24")]
		public static void GetUnityEngineVector3(this ObjectTranslator thiz, IntPtr L, int index, out Vector3 val)
		{
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0x25DD1B0", Offset = "0x25DD1B0", VA = "0x25DD1B0")]
		public static void UpdateUnityEngineVector3(this ObjectTranslator thiz, IntPtr L, int index, Vector3 val)
		{
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C5")]
		[Address(RVA = "0x25DD404", Offset = "0x25DD404", VA = "0x25DD404")]
		public static void PushUnityEngineVector4(this ObjectTranslator thiz, IntPtr L, Vector4 val)
		{
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C6")]
		[Address(RVA = "0x25DD61C", Offset = "0x25DD61C", VA = "0x25DD61C")]
		public static void GetUnityEngineVector4(this ObjectTranslator thiz, IntPtr L, int index, out Vector4 val)
		{
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x25DD8A0", Offset = "0x25DD8A0", VA = "0x25DD8A0")]
		public static void UpdateUnityEngineVector4(this ObjectTranslator thiz, IntPtr L, int index, Vector4 val)
		{
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x25DDAF8", Offset = "0x25DDAF8", VA = "0x25DDAF8")]
		public static void PushUnityEngineColor(this ObjectTranslator thiz, IntPtr L, Color val)
		{
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x25DDD10", Offset = "0x25DDD10", VA = "0x25DDD10")]
		public static void GetUnityEngineColor(this ObjectTranslator thiz, IntPtr L, int index, out Color val)
		{
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x25DDF94", Offset = "0x25DDF94", VA = "0x25DDF94")]
		public static void UpdateUnityEngineColor(this ObjectTranslator thiz, IntPtr L, int index, Color val)
		{
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CB")]
		[Address(RVA = "0x25DE1EC", Offset = "0x25DE1EC", VA = "0x25DE1EC")]
		public static void PushUnityEngineQuaternion(this ObjectTranslator thiz, IntPtr L, Quaternion val)
		{
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CC")]
		[Address(RVA = "0x25DE404", Offset = "0x25DE404", VA = "0x25DE404")]
		public static void GetUnityEngineQuaternion(this ObjectTranslator thiz, IntPtr L, int index, out Quaternion val)
		{
		}

		// Token: 0x060029CD RID: 10701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CD")]
		[Address(RVA = "0x25DE688", Offset = "0x25DE688", VA = "0x25DE688")]
		public static void UpdateUnityEngineQuaternion(this ObjectTranslator thiz, IntPtr L, int index, Quaternion val)
		{
		}

		// Token: 0x060029CE RID: 10702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CE")]
		[Address(RVA = "0x25DE8E0", Offset = "0x25DE8E0", VA = "0x25DE8E0")]
		public static void PushUnityEngineRay(this ObjectTranslator thiz, IntPtr L, Ray val)
		{
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CF")]
		[Address(RVA = "0x25DEAEC", Offset = "0x25DEAEC", VA = "0x25DEAEC")]
		public static void GetUnityEngineRay(this ObjectTranslator thiz, IntPtr L, int index, out Ray val)
		{
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D0")]
		[Address(RVA = "0x25DED78", Offset = "0x25DED78", VA = "0x25DED78")]
		public static void UpdateUnityEngineRay(this ObjectTranslator thiz, IntPtr L, int index, Ray val)
		{
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D1")]
		[Address(RVA = "0x25DEFCC", Offset = "0x25DEFCC", VA = "0x25DEFCC")]
		public static void PushUnityEngineBounds(this ObjectTranslator thiz, IntPtr L, Bounds val)
		{
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D2")]
		[Address(RVA = "0x25DF1D8", Offset = "0x25DF1D8", VA = "0x25DF1D8")]
		public static void GetUnityEngineBounds(this ObjectTranslator thiz, IntPtr L, int index, out Bounds val)
		{
		}

		// Token: 0x060029D3 RID: 10707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D3")]
		[Address(RVA = "0x25DF464", Offset = "0x25DF464", VA = "0x25DF464")]
		public static void UpdateUnityEngineBounds(this ObjectTranslator thiz, IntPtr L, int index, Bounds val)
		{
		}

		// Token: 0x060029D4 RID: 10708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D4")]
		[Address(RVA = "0x25DF6B8", Offset = "0x25DF6B8", VA = "0x25DF6B8")]
		public static void PushUnityEngineRay2D(this ObjectTranslator thiz, IntPtr L, Ray2D val)
		{
		}

		// Token: 0x060029D5 RID: 10709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D5")]
		[Address(RVA = "0x25DF8D0", Offset = "0x25DF8D0", VA = "0x25DF8D0")]
		public static void GetUnityEngineRay2D(this ObjectTranslator thiz, IntPtr L, int index, out Ray2D val)
		{
		}

		// Token: 0x060029D6 RID: 10710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D6")]
		[Address(RVA = "0x25DFB54", Offset = "0x25DFB54", VA = "0x25DFB54")]
		public static void UpdateUnityEngineRay2D(this ObjectTranslator thiz, IntPtr L, int index, Ray2D val)
		{
		}

		// Token: 0x060029D7 RID: 10711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D7")]
		[Address(RVA = "0x25DFDAC", Offset = "0x25DFDAC", VA = "0x25DFDAC")]
		public static void PushConfigStatus(this ObjectTranslator thiz, IntPtr L, ConfigStatus val)
		{
		}

		// Token: 0x060029D8 RID: 10712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D8")]
		[Address(RVA = "0x25E0134", Offset = "0x25E0134", VA = "0x25E0134")]
		public static void GetConfigStatus(this ObjectTranslator thiz, IntPtr L, int index, out ConfigStatus val)
		{
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029D9")]
		[Address(RVA = "0x25E0394", Offset = "0x25E0394", VA = "0x25E0394")]
		public static void UpdateConfigStatus(this ObjectTranslator thiz, IntPtr L, int index, ConfigStatus val)
		{
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DA")]
		[Address(RVA = "0x25E05D8", Offset = "0x25E05D8", VA = "0x25E05D8")]
		public static void PushMat_Type(this ObjectTranslator thiz, IntPtr L, Mat_Type val)
		{
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DB")]
		[Address(RVA = "0x25E0960", Offset = "0x25E0960", VA = "0x25E0960")]
		public static void GetMat_Type(this ObjectTranslator thiz, IntPtr L, int index, out Mat_Type val)
		{
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DC")]
		[Address(RVA = "0x25E0BC0", Offset = "0x25E0BC0", VA = "0x25E0BC0")]
		public static void UpdateMat_Type(this ObjectTranslator thiz, IntPtr L, int index, Mat_Type val)
		{
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DD")]
		[Address(RVA = "0x25E0E04", Offset = "0x25E0E04", VA = "0x25E0E04")]
		public static void PushSystemReflectionBindingFlags(this ObjectTranslator thiz, IntPtr L, BindingFlags val)
		{
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DE")]
		[Address(RVA = "0x25E118C", Offset = "0x25E118C", VA = "0x25E118C")]
		public static void GetSystemReflectionBindingFlags(this ObjectTranslator thiz, IntPtr L, int index, out BindingFlags val)
		{
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029DF")]
		[Address(RVA = "0x25E13EC", Offset = "0x25E13EC", VA = "0x25E13EC")]
		public static void UpdateSystemReflectionBindingFlags(this ObjectTranslator thiz, IntPtr L, int index, BindingFlags val)
		{
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E0")]
		[Address(RVA = "0x25E1630", Offset = "0x25E1630", VA = "0x25E1630")]
		public static void PushUnityEngineSpace(this ObjectTranslator thiz, IntPtr L, Space val)
		{
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E1")]
		[Address(RVA = "0x25E19B8", Offset = "0x25E19B8", VA = "0x25E19B8")]
		public static void GetUnityEngineSpace(this ObjectTranslator thiz, IntPtr L, int index, out Space val)
		{
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E2")]
		[Address(RVA = "0x25E1C18", Offset = "0x25E1C18", VA = "0x25E1C18")]
		public static void UpdateUnityEngineSpace(this ObjectTranslator thiz, IntPtr L, int index, Space val)
		{
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E3")]
		[Address(RVA = "0x25E1E5C", Offset = "0x25E1E5C", VA = "0x25E1E5C")]
		public static void PushUnityEngineCameraGateFitMode(this ObjectTranslator thiz, IntPtr L, Camera.GateFitMode val)
		{
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x25E21E4", Offset = "0x25E21E4", VA = "0x25E21E4")]
		public static void GetUnityEngineCameraGateFitMode(this ObjectTranslator thiz, IntPtr L, int index, out Camera.GateFitMode val)
		{
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x25E2444", Offset = "0x25E2444", VA = "0x25E2444")]
		public static void UpdateUnityEngineCameraGateFitMode(this ObjectTranslator thiz, IntPtr L, int index, Camera.GateFitMode val)
		{
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E6")]
		[Address(RVA = "0x25E2688", Offset = "0x25E2688", VA = "0x25E2688")]
		public static void PushUnityEngineCameraFieldOfViewAxis(this ObjectTranslator thiz, IntPtr L, Camera.FieldOfViewAxis val)
		{
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E7")]
		[Address(RVA = "0x25E2A10", Offset = "0x25E2A10", VA = "0x25E2A10")]
		public static void GetUnityEngineCameraFieldOfViewAxis(this ObjectTranslator thiz, IntPtr L, int index, out Camera.FieldOfViewAxis val)
		{
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x25E2C70", Offset = "0x25E2C70", VA = "0x25E2C70")]
		public static void UpdateUnityEngineCameraFieldOfViewAxis(this ObjectTranslator thiz, IntPtr L, int index, Camera.FieldOfViewAxis val)
		{
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x25E2EB4", Offset = "0x25E2EB4", VA = "0x25E2EB4")]
		public static void PushUnityEngineAINavMeshPathStatus(this ObjectTranslator thiz, IntPtr L, NavMeshPathStatus val)
		{
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EA")]
		[Address(RVA = "0x25E323C", Offset = "0x25E323C", VA = "0x25E323C")]
		public static void GetUnityEngineAINavMeshPathStatus(this ObjectTranslator thiz, IntPtr L, int index, out NavMeshPathStatus val)
		{
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x25E349C", Offset = "0x25E349C", VA = "0x25E349C")]
		public static void UpdateUnityEngineAINavMeshPathStatus(this ObjectTranslator thiz, IntPtr L, int index, NavMeshPathStatus val)
		{
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x25E36E0", Offset = "0x25E36E0", VA = "0x25E36E0")]
		public static void PushDGTweeningEase(this ObjectTranslator thiz, IntPtr L, Ease val)
		{
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029ED")]
		[Address(RVA = "0x25E3A68", Offset = "0x25E3A68", VA = "0x25E3A68")]
		public static void GetDGTweeningEase(this ObjectTranslator thiz, IntPtr L, int index, out Ease val)
		{
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EE")]
		[Address(RVA = "0x25E3CC8", Offset = "0x25E3CC8", VA = "0x25E3CC8")]
		public static void UpdateDGTweeningEase(this ObjectTranslator thiz, IntPtr L, int index, Ease val)
		{
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029EF")]
		[Address(RVA = "0x25E3F0C", Offset = "0x25E3F0C", VA = "0x25E3F0C")]
		public static void PushDGTweeningLoopType(this ObjectTranslator thiz, IntPtr L, LoopType val)
		{
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F0")]
		[Address(RVA = "0x25E4294", Offset = "0x25E4294", VA = "0x25E4294")]
		public static void GetDGTweeningLoopType(this ObjectTranslator thiz, IntPtr L, int index, out LoopType val)
		{
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x25E44F4", Offset = "0x25E44F4", VA = "0x25E44F4")]
		public static void UpdateDGTweeningLoopType(this ObjectTranslator thiz, IntPtr L, int index, LoopType val)
		{
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F2")]
		[Address(RVA = "0x25E4738", Offset = "0x25E4738", VA = "0x25E4738")]
		public static void PushDGTweeningDOTweenAnimationAnimationType(this ObjectTranslator thiz, IntPtr L, DOTweenAnimation.AnimationType val)
		{
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F3")]
		[Address(RVA = "0x25E4AC0", Offset = "0x25E4AC0", VA = "0x25E4AC0")]
		public static void GetDGTweeningDOTweenAnimationAnimationType(this ObjectTranslator thiz, IntPtr L, int index, out DOTweenAnimation.AnimationType val)
		{
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x25E4D20", Offset = "0x25E4D20", VA = "0x25E4D20")]
		public static void UpdateDGTweeningDOTweenAnimationAnimationType(this ObjectTranslator thiz, IntPtr L, int index, DOTweenAnimation.AnimationType val)
		{
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F5")]
		[Address(RVA = "0x25E4F64", Offset = "0x25E4F64", VA = "0x25E4F64")]
		public static void PushDGTweeningDOTweenAnimationTargetType(this ObjectTranslator thiz, IntPtr L, DOTweenAnimation.TargetType val)
		{
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x25E52EC", Offset = "0x25E52EC", VA = "0x25E52EC")]
		public static void GetDGTweeningDOTweenAnimationTargetType(this ObjectTranslator thiz, IntPtr L, int index, out DOTweenAnimation.TargetType val)
		{
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x25E554C", Offset = "0x25E554C", VA = "0x25E554C")]
		public static void UpdateDGTweeningDOTweenAnimationTargetType(this ObjectTranslator thiz, IntPtr L, int index, DOTweenAnimation.TargetType val)
		{
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x25E5790", Offset = "0x25E5790", VA = "0x25E5790")]
		public static void PushUnityEnginePrimitiveType(this ObjectTranslator thiz, IntPtr L, PrimitiveType val)
		{
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029F9")]
		[Address(RVA = "0x25E5B18", Offset = "0x25E5B18", VA = "0x25E5B18")]
		public static void GetUnityEnginePrimitiveType(this ObjectTranslator thiz, IntPtr L, int index, out PrimitiveType val)
		{
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FA")]
		[Address(RVA = "0x25E5D78", Offset = "0x25E5D78", VA = "0x25E5D78")]
		public static void UpdateUnityEnginePrimitiveType(this ObjectTranslator thiz, IntPtr L, int index, PrimitiveType val)
		{
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FB")]
		[Address(RVA = "0x25E5FBC", Offset = "0x25E5FBC", VA = "0x25E5FBC")]
		public static void PushUnityEngineRectTransformEdge(this ObjectTranslator thiz, IntPtr L, RectTransform.Edge val)
		{
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x25E6344", Offset = "0x25E6344", VA = "0x25E6344")]
		public static void GetUnityEngineRectTransformEdge(this ObjectTranslator thiz, IntPtr L, int index, out RectTransform.Edge val)
		{
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FD")]
		[Address(RVA = "0x25E65A4", Offset = "0x25E65A4", VA = "0x25E65A4")]
		public static void UpdateUnityEngineRectTransformEdge(this ObjectTranslator thiz, IntPtr L, int index, RectTransform.Edge val)
		{
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FE")]
		[Address(RVA = "0x25E67E8", Offset = "0x25E67E8", VA = "0x25E67E8")]
		public static void PushUnityEngineRectTransformAxis(this ObjectTranslator thiz, IntPtr L, RectTransform.Axis val)
		{
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029FF")]
		[Address(RVA = "0x25E6B70", Offset = "0x25E6B70", VA = "0x25E6B70")]
		public static void GetUnityEngineRectTransformAxis(this ObjectTranslator thiz, IntPtr L, int index, out RectTransform.Axis val)
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A00")]
		[Address(RVA = "0x25E6DD0", Offset = "0x25E6DD0", VA = "0x25E6DD0")]
		public static void UpdateUnityEngineRectTransformAxis(this ObjectTranslator thiz, IntPtr L, int index, RectTransform.Axis val)
		{
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A01")]
		[Address(RVA = "0x25E7014", Offset = "0x25E7014", VA = "0x25E7014")]
		public static void PushUnityEngineEventSystemsPointerEventDataInputButton(this ObjectTranslator thiz, IntPtr L, PointerEventData.InputButton val)
		{
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A02")]
		[Address(RVA = "0x25E739C", Offset = "0x25E739C", VA = "0x25E739C")]
		public static void GetUnityEngineEventSystemsPointerEventDataInputButton(this ObjectTranslator thiz, IntPtr L, int index, out PointerEventData.InputButton val)
		{
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A03")]
		[Address(RVA = "0x25E75FC", Offset = "0x25E75FC", VA = "0x25E75FC")]
		public static void UpdateUnityEngineEventSystemsPointerEventDataInputButton(this ObjectTranslator thiz, IntPtr L, int index, PointerEventData.InputButton val)
		{
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A04")]
		[Address(RVA = "0x25E7840", Offset = "0x25E7840", VA = "0x25E7840")]
		public static void PushUnityEngineEventSystemsPointerEventDataFramePressState(this ObjectTranslator thiz, IntPtr L, PointerEventData.FramePressState val)
		{
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A05")]
		[Address(RVA = "0x25E7BC8", Offset = "0x25E7BC8", VA = "0x25E7BC8")]
		public static void GetUnityEngineEventSystemsPointerEventDataFramePressState(this ObjectTranslator thiz, IntPtr L, int index, out PointerEventData.FramePressState val)
		{
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A06")]
		[Address(RVA = "0x25E7E28", Offset = "0x25E7E28", VA = "0x25E7E28")]
		public static void UpdateUnityEngineEventSystemsPointerEventDataFramePressState(this ObjectTranslator thiz, IntPtr L, int index, PointerEventData.FramePressState val)
		{
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A07")]
		[Address(RVA = "0x25E806C", Offset = "0x25E806C", VA = "0x25E806C")]
		public static void PushUnityEngineRenderTextureFormat(this ObjectTranslator thiz, IntPtr L, RenderTextureFormat val)
		{
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A08")]
		[Address(RVA = "0x25E83F4", Offset = "0x25E83F4", VA = "0x25E83F4")]
		public static void GetUnityEngineRenderTextureFormat(this ObjectTranslator thiz, IntPtr L, int index, out RenderTextureFormat val)
		{
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A09")]
		[Address(RVA = "0x25E8654", Offset = "0x25E8654", VA = "0x25E8654")]
		public static void UpdateUnityEngineRenderTextureFormat(this ObjectTranslator thiz, IntPtr L, int index, RenderTextureFormat val)
		{
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0A")]
		[Address(RVA = "0x25E8898", Offset = "0x25E8898", VA = "0x25E8898")]
		public static void PushUnityEngineRenderMode(this ObjectTranslator thiz, IntPtr L, RenderMode val)
		{
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0B")]
		[Address(RVA = "0x25E8C20", Offset = "0x25E8C20", VA = "0x25E8C20")]
		public static void GetUnityEngineRenderMode(this ObjectTranslator thiz, IntPtr L, int index, out RenderMode val)
		{
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x25E8E80", Offset = "0x25E8E80", VA = "0x25E8E80")]
		public static void UpdateUnityEngineRenderMode(this ObjectTranslator thiz, IntPtr L, int index, RenderMode val)
		{
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0x25E90C4", Offset = "0x25E90C4", VA = "0x25E90C4")]
		public static void PushUnityEngineRenderingBlendMode(this ObjectTranslator thiz, IntPtr L, BlendMode val)
		{
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x25E944C", Offset = "0x25E944C", VA = "0x25E944C")]
		public static void GetUnityEngineRenderingBlendMode(this ObjectTranslator thiz, IntPtr L, int index, out BlendMode val)
		{
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x25E96AC", Offset = "0x25E96AC", VA = "0x25E96AC")]
		public static void UpdateUnityEngineRenderingBlendMode(this ObjectTranslator thiz, IntPtr L, int index, BlendMode val)
		{
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x25E98F0", Offset = "0x25E98F0", VA = "0x25E98F0")]
		public static void PushUnityEngineUISelectableTransition(this ObjectTranslator thiz, IntPtr L, Selectable.Transition val)
		{
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x25E9C78", Offset = "0x25E9C78", VA = "0x25E9C78")]
		public static void GetUnityEngineUISelectableTransition(this ObjectTranslator thiz, IntPtr L, int index, out Selectable.Transition val)
		{
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x25E9ED8", Offset = "0x25E9ED8", VA = "0x25E9ED8")]
		public static void UpdateUnityEngineUISelectableTransition(this ObjectTranslator thiz, IntPtr L, int index, Selectable.Transition val)
		{
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x25EA11C", Offset = "0x25EA11C", VA = "0x25EA11C")]
		public static void PushUnityEngineUIInputFieldContentType(this ObjectTranslator thiz, IntPtr L, InputField.ContentType val)
		{
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A14")]
		[Address(RVA = "0x25EA4A4", Offset = "0x25EA4A4", VA = "0x25EA4A4")]
		public static void GetUnityEngineUIInputFieldContentType(this ObjectTranslator thiz, IntPtr L, int index, out InputField.ContentType val)
		{
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A15")]
		[Address(RVA = "0x25EA704", Offset = "0x25EA704", VA = "0x25EA704")]
		public static void UpdateUnityEngineUIInputFieldContentType(this ObjectTranslator thiz, IntPtr L, int index, InputField.ContentType val)
		{
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A16")]
		[Address(RVA = "0x25EA948", Offset = "0x25EA948", VA = "0x25EA948")]
		public static void PushUnityEngineUIInputFieldInputType(this ObjectTranslator thiz, IntPtr L, InputField.InputType val)
		{
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A17")]
		[Address(RVA = "0x25EACD0", Offset = "0x25EACD0", VA = "0x25EACD0")]
		public static void GetUnityEngineUIInputFieldInputType(this ObjectTranslator thiz, IntPtr L, int index, out InputField.InputType val)
		{
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A18")]
		[Address(RVA = "0x25EAF30", Offset = "0x25EAF30", VA = "0x25EAF30")]
		public static void UpdateUnityEngineUIInputFieldInputType(this ObjectTranslator thiz, IntPtr L, int index, InputField.InputType val)
		{
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A19")]
		[Address(RVA = "0x25EB174", Offset = "0x25EB174", VA = "0x25EB174")]
		public static void PushUnityEngineUIInputFieldCharacterValidation(this ObjectTranslator thiz, IntPtr L, InputField.CharacterValidation val)
		{
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1A")]
		[Address(RVA = "0x25EB4FC", Offset = "0x25EB4FC", VA = "0x25EB4FC")]
		public static void GetUnityEngineUIInputFieldCharacterValidation(this ObjectTranslator thiz, IntPtr L, int index, out InputField.CharacterValidation val)
		{
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1B")]
		[Address(RVA = "0x25EB75C", Offset = "0x25EB75C", VA = "0x25EB75C")]
		public static void UpdateUnityEngineUIInputFieldCharacterValidation(this ObjectTranslator thiz, IntPtr L, int index, InputField.CharacterValidation val)
		{
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1C")]
		[Address(RVA = "0x25EB9A0", Offset = "0x25EB9A0", VA = "0x25EB9A0")]
		public static void PushUnityEngineUIInputFieldLineType(this ObjectTranslator thiz, IntPtr L, InputField.LineType val)
		{
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1D")]
		[Address(RVA = "0x25EBD28", Offset = "0x25EBD28", VA = "0x25EBD28")]
		public static void GetUnityEngineUIInputFieldLineType(this ObjectTranslator thiz, IntPtr L, int index, out InputField.LineType val)
		{
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1E")]
		[Address(RVA = "0x25EBF88", Offset = "0x25EBF88", VA = "0x25EBF88")]
		public static void UpdateUnityEngineUIInputFieldLineType(this ObjectTranslator thiz, IntPtr L, int index, InputField.LineType val)
		{
		}

		// Token: 0x06002A1F RID: 10783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A1F")]
		[Address(RVA = "0x25EC1CC", Offset = "0x25EC1CC", VA = "0x25EC1CC")]
		public static void PushUnityEngineUIImageType(this ObjectTranslator thiz, IntPtr L, Image.Type val)
		{
		}

		// Token: 0x06002A20 RID: 10784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A20")]
		[Address(RVA = "0x25EC554", Offset = "0x25EC554", VA = "0x25EC554")]
		public static void GetUnityEngineUIImageType(this ObjectTranslator thiz, IntPtr L, int index, out Image.Type val)
		{
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x25EC7B4", Offset = "0x25EC7B4", VA = "0x25EC7B4")]
		public static void UpdateUnityEngineUIImageType(this ObjectTranslator thiz, IntPtr L, int index, Image.Type val)
		{
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x25EC9F8", Offset = "0x25EC9F8", VA = "0x25EC9F8")]
		public static void PushUnityEngineUIImageFillMethod(this ObjectTranslator thiz, IntPtr L, Image.FillMethod val)
		{
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x25ECD80", Offset = "0x25ECD80", VA = "0x25ECD80")]
		public static void GetUnityEngineUIImageFillMethod(this ObjectTranslator thiz, IntPtr L, int index, out Image.FillMethod val)
		{
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x25ECFE0", Offset = "0x25ECFE0", VA = "0x25ECFE0")]
		public static void UpdateUnityEngineUIImageFillMethod(this ObjectTranslator thiz, IntPtr L, int index, Image.FillMethod val)
		{
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x25ED224", Offset = "0x25ED224", VA = "0x25ED224")]
		public static void PushUnityEngineUIImageOriginHorizontal(this ObjectTranslator thiz, IntPtr L, Image.OriginHorizontal val)
		{
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x25ED5AC", Offset = "0x25ED5AC", VA = "0x25ED5AC")]
		public static void GetUnityEngineUIImageOriginHorizontal(this ObjectTranslator thiz, IntPtr L, int index, out Image.OriginHorizontal val)
		{
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x25ED80C", Offset = "0x25ED80C", VA = "0x25ED80C")]
		public static void UpdateUnityEngineUIImageOriginHorizontal(this ObjectTranslator thiz, IntPtr L, int index, Image.OriginHorizontal val)
		{
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x25EDA50", Offset = "0x25EDA50", VA = "0x25EDA50")]
		public static void PushUnityEngineUIImageOriginVertical(this ObjectTranslator thiz, IntPtr L, Image.OriginVertical val)
		{
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x25EDDD8", Offset = "0x25EDDD8", VA = "0x25EDDD8")]
		public static void GetUnityEngineUIImageOriginVertical(this ObjectTranslator thiz, IntPtr L, int index, out Image.OriginVertical val)
		{
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x25EE038", Offset = "0x25EE038", VA = "0x25EE038")]
		public static void UpdateUnityEngineUIImageOriginVertical(this ObjectTranslator thiz, IntPtr L, int index, Image.OriginVertical val)
		{
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x25EE27C", Offset = "0x25EE27C", VA = "0x25EE27C")]
		public static void PushUnityEngineUIImageOrigin90(this ObjectTranslator thiz, IntPtr L, Image.Origin90 val)
		{
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x25EE604", Offset = "0x25EE604", VA = "0x25EE604")]
		public static void GetUnityEngineUIImageOrigin90(this ObjectTranslator thiz, IntPtr L, int index, out Image.Origin90 val)
		{
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x25EE864", Offset = "0x25EE864", VA = "0x25EE864")]
		public static void UpdateUnityEngineUIImageOrigin90(this ObjectTranslator thiz, IntPtr L, int index, Image.Origin90 val)
		{
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x25EEAA8", Offset = "0x25EEAA8", VA = "0x25EEAA8")]
		public static void PushUnityEngineUIImageOrigin180(this ObjectTranslator thiz, IntPtr L, Image.Origin180 val)
		{
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x25EEE30", Offset = "0x25EEE30", VA = "0x25EEE30")]
		public static void GetUnityEngineUIImageOrigin180(this ObjectTranslator thiz, IntPtr L, int index, out Image.Origin180 val)
		{
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x25EF090", Offset = "0x25EF090", VA = "0x25EF090")]
		public static void UpdateUnityEngineUIImageOrigin180(this ObjectTranslator thiz, IntPtr L, int index, Image.Origin180 val)
		{
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A31")]
		[Address(RVA = "0x25EF2D4", Offset = "0x25EF2D4", VA = "0x25EF2D4")]
		public static void PushUnityEngineUIImageOrigin360(this ObjectTranslator thiz, IntPtr L, Image.Origin360 val)
		{
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A32")]
		[Address(RVA = "0x25EF65C", Offset = "0x25EF65C", VA = "0x25EF65C")]
		public static void GetUnityEngineUIImageOrigin360(this ObjectTranslator thiz, IntPtr L, int index, out Image.Origin360 val)
		{
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x25EF8BC", Offset = "0x25EF8BC", VA = "0x25EF8BC")]
		public static void UpdateUnityEngineUIImageOrigin360(this ObjectTranslator thiz, IntPtr L, int index, Image.Origin360 val)
		{
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x25EFB00", Offset = "0x25EFB00", VA = "0x25EFB00")]
		public static void PushUnityEngineUIScrollRectMovementType(this ObjectTranslator thiz, IntPtr L, ScrollRect.MovementType val)
		{
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x25EFE88", Offset = "0x25EFE88", VA = "0x25EFE88")]
		public static void GetUnityEngineUIScrollRectMovementType(this ObjectTranslator thiz, IntPtr L, int index, out ScrollRect.MovementType val)
		{
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A36")]
		[Address(RVA = "0x25F00E8", Offset = "0x25F00E8", VA = "0x25F00E8")]
		public static void UpdateUnityEngineUIScrollRectMovementType(this ObjectTranslator thiz, IntPtr L, int index, ScrollRect.MovementType val)
		{
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A37")]
		[Address(RVA = "0x25F032C", Offset = "0x25F032C", VA = "0x25F032C")]
		public static void PushUnityEngineUIScrollRectScrollbarVisibility(this ObjectTranslator thiz, IntPtr L, ScrollRect.ScrollbarVisibility val)
		{
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A38")]
		[Address(RVA = "0x25F06B4", Offset = "0x25F06B4", VA = "0x25F06B4")]
		public static void GetUnityEngineUIScrollRectScrollbarVisibility(this ObjectTranslator thiz, IntPtr L, int index, out ScrollRect.ScrollbarVisibility val)
		{
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A39")]
		[Address(RVA = "0x25F0914", Offset = "0x25F0914", VA = "0x25F0914")]
		public static void UpdateUnityEngineUIScrollRectScrollbarVisibility(this ObjectTranslator thiz, IntPtr L, int index, ScrollRect.ScrollbarVisibility val)
		{
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0x25F0B58", Offset = "0x25F0B58", VA = "0x25F0B58")]
		public static void PushUnityEngineUISliderDirection(this ObjectTranslator thiz, IntPtr L, Slider.Direction val)
		{
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0x25F0EE0", Offset = "0x25F0EE0", VA = "0x25F0EE0")]
		public static void GetUnityEngineUISliderDirection(this ObjectTranslator thiz, IntPtr L, int index, out Slider.Direction val)
		{
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3C")]
		[Address(RVA = "0x25F1140", Offset = "0x25F1140", VA = "0x25F1140")]
		public static void UpdateUnityEngineUISliderDirection(this ObjectTranslator thiz, IntPtr L, int index, Slider.Direction val)
		{
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3D")]
		[Address(RVA = "0x25F1384", Offset = "0x25F1384", VA = "0x25F1384")]
		public static void PushUnityEngineUIToggleToggleTransition(this ObjectTranslator thiz, IntPtr L, Toggle.ToggleTransition val)
		{
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3E")]
		[Address(RVA = "0x25F170C", Offset = "0x25F170C", VA = "0x25F170C")]
		public static void GetUnityEngineUIToggleToggleTransition(this ObjectTranslator thiz, IntPtr L, int index, out Toggle.ToggleTransition val)
		{
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x25F196C", Offset = "0x25F196C", VA = "0x25F196C")]
		public static void UpdateUnityEngineUIToggleToggleTransition(this ObjectTranslator thiz, IntPtr L, int index, Toggle.ToggleTransition val)
		{
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A40")]
		[Address(RVA = "0x25F1BB0", Offset = "0x25F1BB0", VA = "0x25F1BB0")]
		public static void PushUnityEngineUIGridLayoutGroupCorner(this ObjectTranslator thiz, IntPtr L, GridLayoutGroup.Corner val)
		{
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x25F1F38", Offset = "0x25F1F38", VA = "0x25F1F38")]
		public static void GetUnityEngineUIGridLayoutGroupCorner(this ObjectTranslator thiz, IntPtr L, int index, out GridLayoutGroup.Corner val)
		{
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x25F2198", Offset = "0x25F2198", VA = "0x25F2198")]
		public static void UpdateUnityEngineUIGridLayoutGroupCorner(this ObjectTranslator thiz, IntPtr L, int index, GridLayoutGroup.Corner val)
		{
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x25F23DC", Offset = "0x25F23DC", VA = "0x25F23DC")]
		public static void PushUnityEngineUIGridLayoutGroupAxis(this ObjectTranslator thiz, IntPtr L, GridLayoutGroup.Axis val)
		{
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A44")]
		[Address(RVA = "0x25F2764", Offset = "0x25F2764", VA = "0x25F2764")]
		public static void GetUnityEngineUIGridLayoutGroupAxis(this ObjectTranslator thiz, IntPtr L, int index, out GridLayoutGroup.Axis val)
		{
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A45")]
		[Address(RVA = "0x25F29C4", Offset = "0x25F29C4", VA = "0x25F29C4")]
		public static void UpdateUnityEngineUIGridLayoutGroupAxis(this ObjectTranslator thiz, IntPtr L, int index, GridLayoutGroup.Axis val)
		{
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A46")]
		[Address(RVA = "0x25F2C08", Offset = "0x25F2C08", VA = "0x25F2C08")]
		public static void PushUnityEngineUIGridLayoutGroupConstraint(this ObjectTranslator thiz, IntPtr L, GridLayoutGroup.Constraint val)
		{
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A47")]
		[Address(RVA = "0x25F2F90", Offset = "0x25F2F90", VA = "0x25F2F90")]
		public static void GetUnityEngineUIGridLayoutGroupConstraint(this ObjectTranslator thiz, IntPtr L, int index, out GridLayoutGroup.Constraint val)
		{
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A48")]
		[Address(RVA = "0x25F31F0", Offset = "0x25F31F0", VA = "0x25F31F0")]
		public static void UpdateUnityEngineUIGridLayoutGroupConstraint(this ObjectTranslator thiz, IntPtr L, int index, GridLayoutGroup.Constraint val)
		{
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A49")]
		[Address(RVA = "0x25F3434", Offset = "0x25F3434", VA = "0x25F3434")]
		public static void PushUnityEngineUIContentSizeFitterFitMode(this ObjectTranslator thiz, IntPtr L, ContentSizeFitter.FitMode val)
		{
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0x25F37BC", Offset = "0x25F37BC", VA = "0x25F37BC")]
		public static void GetUnityEngineUIContentSizeFitterFitMode(this ObjectTranslator thiz, IntPtr L, int index, out ContentSizeFitter.FitMode val)
		{
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4B")]
		[Address(RVA = "0x25F3A1C", Offset = "0x25F3A1C", VA = "0x25F3A1C")]
		public static void UpdateUnityEngineUIContentSizeFitterFitMode(this ObjectTranslator thiz, IntPtr L, int index, ContentSizeFitter.FitMode val)
		{
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4C")]
		[Address(RVA = "0x25F3C60", Offset = "0x25F3C60", VA = "0x25F3C60")]
		public static void PushSuperTextMeshAlignment(this ObjectTranslator thiz, IntPtr L, SuperTextMesh.Alignment val)
		{
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4D")]
		[Address(RVA = "0x25F3FE8", Offset = "0x25F3FE8", VA = "0x25F3FE8")]
		public static void GetSuperTextMeshAlignment(this ObjectTranslator thiz, IntPtr L, int index, out SuperTextMesh.Alignment val)
		{
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4E")]
		[Address(RVA = "0x25F4248", Offset = "0x25F4248", VA = "0x25F4248")]
		public static void UpdateSuperTextMeshAlignment(this ObjectTranslator thiz, IntPtr L, int index, SuperTextMesh.Alignment val)
		{
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4F")]
		[Address(RVA = "0x25F448C", Offset = "0x25F448C", VA = "0x25F448C")]
		public static void PushScrollViewMovementType(this ObjectTranslator thiz, IntPtr L, ScrollView.MovementType val)
		{
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A50")]
		[Address(RVA = "0x25F4814", Offset = "0x25F4814", VA = "0x25F4814")]
		public static void GetScrollViewMovementType(this ObjectTranslator thiz, IntPtr L, int index, out ScrollView.MovementType val)
		{
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A51")]
		[Address(RVA = "0x25F4A74", Offset = "0x25F4A74", VA = "0x25F4A74")]
		public static void UpdateScrollViewMovementType(this ObjectTranslator thiz, IntPtr L, int index, ScrollView.MovementType val)
		{
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A52")]
		[Address(RVA = "0x25F4CB8", Offset = "0x25F4CB8", VA = "0x25F4CB8")]
		public static void PushScrollViewScrollbarVisibility(this ObjectTranslator thiz, IntPtr L, ScrollView.ScrollbarVisibility val)
		{
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A53")]
		[Address(RVA = "0x25F5040", Offset = "0x25F5040", VA = "0x25F5040")]
		public static void GetScrollViewScrollbarVisibility(this ObjectTranslator thiz, IntPtr L, int index, out ScrollView.ScrollbarVisibility val)
		{
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A54")]
		[Address(RVA = "0x25F52A0", Offset = "0x25F52A0", VA = "0x25F52A0")]
		public static void UpdateScrollViewScrollbarVisibility(this ObjectTranslator thiz, IntPtr L, int index, ScrollView.ScrollbarVisibility val)
		{
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x25F54E4", Offset = "0x25F54E4", VA = "0x25F54E4")]
		public static void PushScrollViewScrollViewLayoutType(this ObjectTranslator thiz, IntPtr L, ScrollView.ScrollViewLayoutType val)
		{
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x25F586C", Offset = "0x25F586C", VA = "0x25F586C")]
		public static void GetScrollViewScrollViewLayoutType(this ObjectTranslator thiz, IntPtr L, int index, out ScrollView.ScrollViewLayoutType val)
		{
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x25F5ACC", Offset = "0x25F5ACC", VA = "0x25F5ACC")]
		public static void UpdateScrollViewScrollViewLayoutType(this ObjectTranslator thiz, IntPtr L, int index, ScrollView.ScrollViewLayoutType val)
		{
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A58")]
		[Address(RVA = "0x25F5D10", Offset = "0x25F5D10", VA = "0x25F5D10")]
		public static void PushCenterScrollViewMovementType(this ObjectTranslator thiz, IntPtr L, CenterScrollView.MovementType val)
		{
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x25F6098", Offset = "0x25F6098", VA = "0x25F6098")]
		public static void GetCenterScrollViewMovementType(this ObjectTranslator thiz, IntPtr L, int index, out CenterScrollView.MovementType val)
		{
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x25F62F8", Offset = "0x25F62F8", VA = "0x25F62F8")]
		public static void UpdateCenterScrollViewMovementType(this ObjectTranslator thiz, IntPtr L, int index, CenterScrollView.MovementType val)
		{
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x25F653C", Offset = "0x25F653C", VA = "0x25F653C")]
		public static void PushCenterScrollViewScrollbarVisibility(this ObjectTranslator thiz, IntPtr L, CenterScrollView.ScrollbarVisibility val)
		{
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5C")]
		[Address(RVA = "0x25F68C4", Offset = "0x25F68C4", VA = "0x25F68C4")]
		public static void GetCenterScrollViewScrollbarVisibility(this ObjectTranslator thiz, IntPtr L, int index, out CenterScrollView.ScrollbarVisibility val)
		{
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0x25F6B24", Offset = "0x25F6B24", VA = "0x25F6B24")]
		public static void UpdateCenterScrollViewScrollbarVisibility(this ObjectTranslator thiz, IntPtr L, int index, CenterScrollView.ScrollbarVisibility val)
		{
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x25F6D68", Offset = "0x25F6D68", VA = "0x25F6D68")]
		public static void PushCenterScrollViewScrollViewLayoutType(this ObjectTranslator thiz, IntPtr L, CenterScrollView.ScrollViewLayoutType val)
		{
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5F")]
		[Address(RVA = "0x25F70F0", Offset = "0x25F70F0", VA = "0x25F70F0")]
		public static void GetCenterScrollViewScrollViewLayoutType(this ObjectTranslator thiz, IntPtr L, int index, out CenterScrollView.ScrollViewLayoutType val)
		{
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A60")]
		[Address(RVA = "0x25F7350", Offset = "0x25F7350", VA = "0x25F7350")]
		public static void UpdateCenterScrollViewScrollViewLayoutType(this ObjectTranslator thiz, IntPtr L, int index, CenterScrollView.ScrollViewLayoutType val)
		{
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A61")]
		[Address(RVA = "0x25F7594", Offset = "0x25F7594", VA = "0x25F7594")]
		public static void PushUnityEngineTouchPhase(this ObjectTranslator thiz, IntPtr L, TouchPhase val)
		{
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A62")]
		[Address(RVA = "0x25F791C", Offset = "0x25F791C", VA = "0x25F791C")]
		public static void GetUnityEngineTouchPhase(this ObjectTranslator thiz, IntPtr L, int index, out TouchPhase val)
		{
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A63")]
		[Address(RVA = "0x25F7B7C", Offset = "0x25F7B7C", VA = "0x25F7B7C")]
		public static void UpdateUnityEngineTouchPhase(this ObjectTranslator thiz, IntPtr L, int index, TouchPhase val)
		{
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A64")]
		[Address(RVA = "0x25F7DC0", Offset = "0x25F7DC0", VA = "0x25F7DC0")]
		public static void PushResourceManagerPreloadType(this ObjectTranslator thiz, IntPtr L, ResourceManager.PreloadType val)
		{
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A65")]
		[Address(RVA = "0x25F8148", Offset = "0x25F8148", VA = "0x25F8148")]
		public static void GetResourceManagerPreloadType(this ObjectTranslator thiz, IntPtr L, int index, out ResourceManager.PreloadType val)
		{
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A66")]
		[Address(RVA = "0x25F83A8", Offset = "0x25F83A8", VA = "0x25F83A8")]
		public static void UpdateResourceManagerPreloadType(this ObjectTranslator thiz, IntPtr L, int index, ResourceManager.PreloadType val)
		{
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A67")]
		[Address(RVA = "0x25F85EC", Offset = "0x25F85EC", VA = "0x25F85EC")]
		public static void PushNewQueueState(this ObjectTranslator thiz, IntPtr L, NewQueueState val)
		{
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x25F8974", Offset = "0x25F8974", VA = "0x25F8974")]
		public static void GetNewQueueState(this ObjectTranslator thiz, IntPtr L, int index, out NewQueueState val)
		{
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A69")]
		[Address(RVA = "0x25F8BD4", Offset = "0x25F8BD4", VA = "0x25F8BD4")]
		public static void UpdateNewQueueState(this ObjectTranslator thiz, IntPtr L, int index, NewQueueState val)
		{
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x25F8E18", Offset = "0x25F8E18", VA = "0x25F8E18")]
		public static void PushResourceType(this ObjectTranslator thiz, IntPtr L, ResourceType val)
		{
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0x25F91A0", Offset = "0x25F91A0", VA = "0x25F91A0")]
		public static void GetResourceType(this ObjectTranslator thiz, IntPtr L, int index, out ResourceType val)
		{
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0x25F9400", Offset = "0x25F9400", VA = "0x25F9400")]
		public static void UpdateResourceType(this ObjectTranslator thiz, IntPtr L, int index, ResourceType val)
		{
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6D")]
		[Address(RVA = "0x25F9644", Offset = "0x25F9644", VA = "0x25F9644")]
		public static void PushBuildingState(this ObjectTranslator thiz, IntPtr L, BuildingState val)
		{
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0x25F99CC", Offset = "0x25F99CC", VA = "0x25F99CC")]
		public static void GetBuildingState(this ObjectTranslator thiz, IntPtr L, int index, out BuildingState val)
		{
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6F")]
		[Address(RVA = "0x25F9C2C", Offset = "0x25F9C2C", VA = "0x25F9C2C")]
		public static void UpdateBuildingState(this ObjectTranslator thiz, IntPtr L, int index, BuildingState val)
		{
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A70")]
		[Address(RVA = "0x25F9E70", Offset = "0x25F9E70", VA = "0x25F9E70")]
		public static void PushMarchStatus(this ObjectTranslator thiz, IntPtr L, MarchStatus val)
		{
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A71")]
		[Address(RVA = "0x25FA1F8", Offset = "0x25FA1F8", VA = "0x25FA1F8")]
		public static void GetMarchStatus(this ObjectTranslator thiz, IntPtr L, int index, out MarchStatus val)
		{
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A72")]
		[Address(RVA = "0x25FA458", Offset = "0x25FA458", VA = "0x25FA458")]
		public static void UpdateMarchStatus(this ObjectTranslator thiz, IntPtr L, int index, MarchStatus val)
		{
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A73")]
		[Address(RVA = "0x25FA69C", Offset = "0x25FA69C", VA = "0x25FA69C")]
		public static void PushTMProTMP_InputFieldContentType(this ObjectTranslator thiz, IntPtr L, TMP_InputField.ContentType val)
		{
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A74")]
		[Address(RVA = "0x25FAA24", Offset = "0x25FAA24", VA = "0x25FAA24")]
		public static void GetTMProTMP_InputFieldContentType(this ObjectTranslator thiz, IntPtr L, int index, out TMP_InputField.ContentType val)
		{
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A75")]
		[Address(RVA = "0x25FAC84", Offset = "0x25FAC84", VA = "0x25FAC84")]
		public static void UpdateTMProTMP_InputFieldContentType(this ObjectTranslator thiz, IntPtr L, int index, TMP_InputField.ContentType val)
		{
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A76")]
		[Address(RVA = "0x25FAEC8", Offset = "0x25FAEC8", VA = "0x25FAEC8")]
		public static void PushTMProTMP_InputFieldInputType(this ObjectTranslator thiz, IntPtr L, TMP_InputField.InputType val)
		{
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A77")]
		[Address(RVA = "0x25FB250", Offset = "0x25FB250", VA = "0x25FB250")]
		public static void GetTMProTMP_InputFieldInputType(this ObjectTranslator thiz, IntPtr L, int index, out TMP_InputField.InputType val)
		{
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A78")]
		[Address(RVA = "0x25FB4B0", Offset = "0x25FB4B0", VA = "0x25FB4B0")]
		public static void UpdateTMProTMP_InputFieldInputType(this ObjectTranslator thiz, IntPtr L, int index, TMP_InputField.InputType val)
		{
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A79")]
		[Address(RVA = "0x25FB6F4", Offset = "0x25FB6F4", VA = "0x25FB6F4")]
		public static void PushTMProTMP_InputFieldCharacterValidation(this ObjectTranslator thiz, IntPtr L, TMP_InputField.CharacterValidation val)
		{
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7A")]
		[Address(RVA = "0x25FBA7C", Offset = "0x25FBA7C", VA = "0x25FBA7C")]
		public static void GetTMProTMP_InputFieldCharacterValidation(this ObjectTranslator thiz, IntPtr L, int index, out TMP_InputField.CharacterValidation val)
		{
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x25FBCDC", Offset = "0x25FBCDC", VA = "0x25FBCDC")]
		public static void UpdateTMProTMP_InputFieldCharacterValidation(this ObjectTranslator thiz, IntPtr L, int index, TMP_InputField.CharacterValidation val)
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x25FBF20", Offset = "0x25FBF20", VA = "0x25FBF20")]
		public static void PushTMProTMP_InputFieldLineType(this ObjectTranslator thiz, IntPtr L, TMP_InputField.LineType val)
		{
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0x25FC2A8", Offset = "0x25FC2A8", VA = "0x25FC2A8")]
		public static void GetTMProTMP_InputFieldLineType(this ObjectTranslator thiz, IntPtr L, int index, out TMP_InputField.LineType val)
		{
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x25FC508", Offset = "0x25FC508", VA = "0x25FC508")]
		public static void UpdateTMProTMP_InputFieldLineType(this ObjectTranslator thiz, IntPtr L, int index, TMP_InputField.LineType val)
		{
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0x25FC74C", Offset = "0x25FC74C", VA = "0x25FC74C")]
		public static void PushTMProTextAlignmentOptions(this ObjectTranslator thiz, IntPtr L, TextAlignmentOptions val)
		{
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A80")]
		[Address(RVA = "0x25FCAD4", Offset = "0x25FCAD4", VA = "0x25FCAD4")]
		public static void GetTMProTextAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, out TextAlignmentOptions val)
		{
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A81")]
		[Address(RVA = "0x25FCD34", Offset = "0x25FCD34", VA = "0x25FCD34")]
		public static void UpdateTMProTextAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, TextAlignmentOptions val)
		{
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A82")]
		[Address(RVA = "0x25FCF78", Offset = "0x25FCF78", VA = "0x25FCF78")]
		public static void PushNewTMPTextHorizontalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, NewTMPText.HorizontalAlignmentOptions val)
		{
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x25FD300", Offset = "0x25FD300", VA = "0x25FD300")]
		public static void GetNewTMPTextHorizontalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, out NewTMPText.HorizontalAlignmentOptions val)
		{
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A84")]
		[Address(RVA = "0x25FD560", Offset = "0x25FD560", VA = "0x25FD560")]
		public static void UpdateNewTMPTextHorizontalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, NewTMPText.HorizontalAlignmentOptions val)
		{
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A85")]
		[Address(RVA = "0x25FD7A4", Offset = "0x25FD7A4", VA = "0x25FD7A4")]
		public static void PushNewTMPTextVerticalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, NewTMPText.VerticalAlignmentOptions val)
		{
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A86")]
		[Address(RVA = "0x25FDB2C", Offset = "0x25FDB2C", VA = "0x25FDB2C")]
		public static void GetNewTMPTextVerticalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, out NewTMPText.VerticalAlignmentOptions val)
		{
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A87")]
		[Address(RVA = "0x25FDD8C", Offset = "0x25FDD8C", VA = "0x25FDD8C")]
		public static void UpdateNewTMPTextVerticalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, NewTMPText.VerticalAlignmentOptions val)
		{
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A88")]
		[Address(RVA = "0x25FDFD0", Offset = "0x25FDFD0", VA = "0x25FDFD0")]
		public static void PushNewTMP3DTextHorizontalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, NewTMP3DText.HorizontalAlignmentOptions val)
		{
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A89")]
		[Address(RVA = "0x25FE358", Offset = "0x25FE358", VA = "0x25FE358")]
		public static void GetNewTMP3DTextHorizontalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, out NewTMP3DText.HorizontalAlignmentOptions val)
		{
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8A")]
		[Address(RVA = "0x25FE5B8", Offset = "0x25FE5B8", VA = "0x25FE5B8")]
		public static void UpdateNewTMP3DTextHorizontalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, NewTMP3DText.HorizontalAlignmentOptions val)
		{
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8B")]
		[Address(RVA = "0x25FE7FC", Offset = "0x25FE7FC", VA = "0x25FE7FC")]
		public static void PushNewTMP3DTextVerticalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, NewTMP3DText.VerticalAlignmentOptions val)
		{
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8C")]
		[Address(RVA = "0x25FEB84", Offset = "0x25FEB84", VA = "0x25FEB84")]
		public static void GetNewTMP3DTextVerticalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, out NewTMP3DText.VerticalAlignmentOptions val)
		{
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8D")]
		[Address(RVA = "0x25FEDE4", Offset = "0x25FEDE4", VA = "0x25FEDE4")]
		public static void UpdateNewTMP3DTextVerticalAlignmentOptions(this ObjectTranslator thiz, IntPtr L, int index, NewTMP3DText.VerticalAlignmentOptions val)
		{
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8E")]
		[Address(RVA = "0x25FF028", Offset = "0x25FF028", VA = "0x25FF028")]
		public static void PushUnityEngineForceMode(this ObjectTranslator thiz, IntPtr L, ForceMode val)
		{
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A8F")]
		[Address(RVA = "0x25FF3B0", Offset = "0x25FF3B0", VA = "0x25FF3B0")]
		public static void GetUnityEngineForceMode(this ObjectTranslator thiz, IntPtr L, int index, out ForceMode val)
		{
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A90")]
		[Address(RVA = "0x25FF610", Offset = "0x25FF610", VA = "0x25FF610")]
		public static void UpdateUnityEngineForceMode(this ObjectTranslator thiz, IntPtr L, int index, ForceMode val)
		{
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A91")]
		[Address(RVA = "0x25FF854", Offset = "0x25FF854", VA = "0x25FF854")]
		public static void PushUnityEngineHumanBodyBones(this ObjectTranslator thiz, IntPtr L, HumanBodyBones val)
		{
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A92")]
		[Address(RVA = "0x25FFBDC", Offset = "0x25FFBDC", VA = "0x25FFBDC")]
		public static void GetUnityEngineHumanBodyBones(this ObjectTranslator thiz, IntPtr L, int index, out HumanBodyBones val)
		{
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A93")]
		[Address(RVA = "0x25FFE3C", Offset = "0x25FFE3C", VA = "0x25FFE3C")]
		public static void UpdateUnityEngineHumanBodyBones(this ObjectTranslator thiz, IntPtr L, int index, HumanBodyBones val)
		{
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x2600080", Offset = "0x2600080", VA = "0x2600080")]
		public static void PushBitBenderGamesMobileTouchCameraState(this ObjectTranslator thiz, IntPtr L, MobileTouchCamera.State val)
		{
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A95")]
		[Address(RVA = "0x2600408", Offset = "0x2600408", VA = "0x2600408")]
		public static void GetBitBenderGamesMobileTouchCameraState(this ObjectTranslator thiz, IntPtr L, int index, out MobileTouchCamera.State val)
		{
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A96")]
		[Address(RVA = "0x2600668", Offset = "0x2600668", VA = "0x2600668")]
		public static void UpdateBitBenderGamesMobileTouchCameraState(this ObjectTranslator thiz, IntPtr L, int index, MobileTouchCamera.State val)
		{
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A97")]
		[Address(RVA = "0x26008AC", Offset = "0x26008AC", VA = "0x26008AC")]
		public static void PushInstanceRequestState(this ObjectTranslator thiz, IntPtr L, InstanceRequest.State val)
		{
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A98")]
		[Address(RVA = "0x2600C34", Offset = "0x2600C34", VA = "0x2600C34")]
		public static void GetInstanceRequestState(this ObjectTranslator thiz, IntPtr L, int index, out InstanceRequest.State val)
		{
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A99")]
		[Address(RVA = "0x2600E94", Offset = "0x2600E94", VA = "0x2600E94")]
		public static void UpdateInstanceRequestState(this ObjectTranslator thiz, IntPtr L, int index, InstanceRequest.State val)
		{
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0x26010D8", Offset = "0x26010D8", VA = "0x26010D8")]
		public static void PushNewMarchType(this ObjectTranslator thiz, IntPtr L, NewMarchType val)
		{
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0x2601460", Offset = "0x2601460", VA = "0x2601460")]
		public static void GetNewMarchType(this ObjectTranslator thiz, IntPtr L, int index, out NewMarchType val)
		{
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0x26016C0", Offset = "0x26016C0", VA = "0x26016C0")]
		public static void UpdateNewMarchType(this ObjectTranslator thiz, IntPtr L, int index, NewMarchType val)
		{
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0x2601904", Offset = "0x2601904", VA = "0x2601904")]
		public static void PushWorldPointType(this ObjectTranslator thiz, IntPtr L, WorldPointType val)
		{
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x2601C8C", Offset = "0x2601C8C", VA = "0x2601C8C")]
		public static void GetWorldPointType(this ObjectTranslator thiz, IntPtr L, int index, out WorldPointType val)
		{
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x2601EEC", Offset = "0x2601EEC", VA = "0x2601EEC")]
		public static void UpdateWorldPointType(this ObjectTranslator thiz, IntPtr L, int index, WorldPointType val)
		{
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x2602130", Offset = "0x2602130", VA = "0x2602130")]
		public static void PushUnityEngineNetworkingUnityWebRequestResult(this ObjectTranslator thiz, IntPtr L, UnityWebRequest.Result val)
		{
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA1")]
		[Address(RVA = "0x26024B8", Offset = "0x26024B8", VA = "0x26024B8")]
		public static void GetUnityEngineNetworkingUnityWebRequestResult(this ObjectTranslator thiz, IntPtr L, int index, out UnityWebRequest.Result val)
		{
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x2602718", Offset = "0x2602718", VA = "0x2602718")]
		public static void UpdateUnityEngineNetworkingUnityWebRequestResult(this ObjectTranslator thiz, IntPtr L, int index, UnityWebRequest.Result val)
		{
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x260295C", Offset = "0x260295C", VA = "0x260295C")]
		public static void PushUnityEngineKeyCode(this ObjectTranslator thiz, IntPtr L, KeyCode val)
		{
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x2602CE4", Offset = "0x2602CE4", VA = "0x2602CE4")]
		public static void GetUnityEngineKeyCode(this ObjectTranslator thiz, IntPtr L, int index, out KeyCode val)
		{
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x2602F44", Offset = "0x2602F44", VA = "0x2602F44")]
		public static void UpdateUnityEngineKeyCode(this ObjectTranslator thiz, IntPtr L, int index, KeyCode val)
		{
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x2603188", Offset = "0x2603188", VA = "0x2603188")]
		public static void PushGameFrameworkLocalizationLanguage(this ObjectTranslator thiz, IntPtr L, Language val)
		{
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x2603510", Offset = "0x2603510", VA = "0x2603510")]
		public static void GetGameFrameworkLocalizationLanguage(this ObjectTranslator thiz, IntPtr L, int index, out Language val)
		{
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x2603770", Offset = "0x2603770", VA = "0x2603770")]
		public static void UpdateGameFrameworkLocalizationLanguage(this ObjectTranslator thiz, IntPtr L, int index, Language val)
		{
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x26039B4", Offset = "0x26039B4", VA = "0x26039B4")]
		public static void PushUnityEngineWeightedMode(this ObjectTranslator thiz, IntPtr L, WeightedMode val)
		{
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x2603D3C", Offset = "0x2603D3C", VA = "0x2603D3C")]
		public static void GetUnityEngineWeightedMode(this ObjectTranslator thiz, IntPtr L, int index, out WeightedMode val)
		{
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAB")]
		[Address(RVA = "0x2603F9C", Offset = "0x2603F9C", VA = "0x2603F9C")]
		public static void UpdateUnityEngineWeightedMode(this ObjectTranslator thiz, IntPtr L, int index, WeightedMode val)
		{
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAC")]
		[Address(RVA = "0x26041E0", Offset = "0x26041E0", VA = "0x26041E0")]
		public static void PushUnityEngineQueryTriggerInteraction(this ObjectTranslator thiz, IntPtr L, QueryTriggerInteraction val)
		{
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAD")]
		[Address(RVA = "0x2604568", Offset = "0x2604568", VA = "0x2604568")]
		public static void GetUnityEngineQueryTriggerInteraction(this ObjectTranslator thiz, IntPtr L, int index, out QueryTriggerInteraction val)
		{
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AAE")]
		[Address(RVA = "0x26047C8", Offset = "0x26047C8", VA = "0x26047C8")]
		public static void UpdateUnityEngineQueryTriggerInteraction(this ObjectTranslator thiz, IntPtr L, int index, QueryTriggerInteraction val)
		{
		}

		// Token: 0x04002476 RID: 9334
		[Token(Token = "0x4002476")]
		[FieldOffset(Offset = "0x0")]
		private static int FrameworkUtilsUnityExTouchInfo_TypeID;

		// Token: 0x04002477 RID: 9335
		[Token(Token = "0x4002477")]
		[FieldOffset(Offset = "0x4")]
		private static int UnityEngineVector2_TypeID;

		// Token: 0x04002478 RID: 9336
		[Token(Token = "0x4002478")]
		[FieldOffset(Offset = "0x8")]
		private static int UnityEngineVector3_TypeID;

		// Token: 0x04002479 RID: 9337
		[Token(Token = "0x4002479")]
		[FieldOffset(Offset = "0xC")]
		private static int UnityEngineVector4_TypeID;

		// Token: 0x0400247A RID: 9338
		[Token(Token = "0x400247A")]
		[FieldOffset(Offset = "0x10")]
		private static int UnityEngineColor_TypeID;

		// Token: 0x0400247B RID: 9339
		[Token(Token = "0x400247B")]
		[FieldOffset(Offset = "0x14")]
		private static int UnityEngineQuaternion_TypeID;

		// Token: 0x0400247C RID: 9340
		[Token(Token = "0x400247C")]
		[FieldOffset(Offset = "0x18")]
		private static int UnityEngineRay_TypeID;

		// Token: 0x0400247D RID: 9341
		[Token(Token = "0x400247D")]
		[FieldOffset(Offset = "0x1C")]
		private static int UnityEngineBounds_TypeID;

		// Token: 0x0400247E RID: 9342
		[Token(Token = "0x400247E")]
		[FieldOffset(Offset = "0x20")]
		private static int UnityEngineRay2D_TypeID;

		// Token: 0x0400247F RID: 9343
		[Token(Token = "0x400247F")]
		[FieldOffset(Offset = "0x24")]
		private static int ConfigStatus_TypeID;

		// Token: 0x04002480 RID: 9344
		[Token(Token = "0x4002480")]
		[FieldOffset(Offset = "0x28")]
		private static int ConfigStatus_EnumRef;

		// Token: 0x04002481 RID: 9345
		[Token(Token = "0x4002481")]
		[FieldOffset(Offset = "0x2C")]
		private static int Mat_Type_TypeID;

		// Token: 0x04002482 RID: 9346
		[Token(Token = "0x4002482")]
		[FieldOffset(Offset = "0x30")]
		private static int Mat_Type_EnumRef;

		// Token: 0x04002483 RID: 9347
		[Token(Token = "0x4002483")]
		[FieldOffset(Offset = "0x34")]
		private static int SystemReflectionBindingFlags_TypeID;

		// Token: 0x04002484 RID: 9348
		[Token(Token = "0x4002484")]
		[FieldOffset(Offset = "0x38")]
		private static int SystemReflectionBindingFlags_EnumRef;

		// Token: 0x04002485 RID: 9349
		[Token(Token = "0x4002485")]
		[FieldOffset(Offset = "0x3C")]
		private static int UnityEngineSpace_TypeID;

		// Token: 0x04002486 RID: 9350
		[Token(Token = "0x4002486")]
		[FieldOffset(Offset = "0x40")]
		private static int UnityEngineSpace_EnumRef;

		// Token: 0x04002487 RID: 9351
		[Token(Token = "0x4002487")]
		[FieldOffset(Offset = "0x44")]
		private static int UnityEngineCameraGateFitMode_TypeID;

		// Token: 0x04002488 RID: 9352
		[Token(Token = "0x4002488")]
		[FieldOffset(Offset = "0x48")]
		private static int UnityEngineCameraGateFitMode_EnumRef;

		// Token: 0x04002489 RID: 9353
		[Token(Token = "0x4002489")]
		[FieldOffset(Offset = "0x4C")]
		private static int UnityEngineCameraFieldOfViewAxis_TypeID;

		// Token: 0x0400248A RID: 9354
		[Token(Token = "0x400248A")]
		[FieldOffset(Offset = "0x50")]
		private static int UnityEngineCameraFieldOfViewAxis_EnumRef;

		// Token: 0x0400248B RID: 9355
		[Token(Token = "0x400248B")]
		[FieldOffset(Offset = "0x54")]
		private static int UnityEngineAINavMeshPathStatus_TypeID;

		// Token: 0x0400248C RID: 9356
		[Token(Token = "0x400248C")]
		[FieldOffset(Offset = "0x58")]
		private static int UnityEngineAINavMeshPathStatus_EnumRef;

		// Token: 0x0400248D RID: 9357
		[Token(Token = "0x400248D")]
		[FieldOffset(Offset = "0x5C")]
		private static int DGTweeningEase_TypeID;

		// Token: 0x0400248E RID: 9358
		[Token(Token = "0x400248E")]
		[FieldOffset(Offset = "0x60")]
		private static int DGTweeningEase_EnumRef;

		// Token: 0x0400248F RID: 9359
		[Token(Token = "0x400248F")]
		[FieldOffset(Offset = "0x64")]
		private static int DGTweeningLoopType_TypeID;

		// Token: 0x04002490 RID: 9360
		[Token(Token = "0x4002490")]
		[FieldOffset(Offset = "0x68")]
		private static int DGTweeningLoopType_EnumRef;

		// Token: 0x04002491 RID: 9361
		[Token(Token = "0x4002491")]
		[FieldOffset(Offset = "0x6C")]
		private static int DGTweeningDOTweenAnimationAnimationType_TypeID;

		// Token: 0x04002492 RID: 9362
		[Token(Token = "0x4002492")]
		[FieldOffset(Offset = "0x70")]
		private static int DGTweeningDOTweenAnimationAnimationType_EnumRef;

		// Token: 0x04002493 RID: 9363
		[Token(Token = "0x4002493")]
		[FieldOffset(Offset = "0x74")]
		private static int DGTweeningDOTweenAnimationTargetType_TypeID;

		// Token: 0x04002494 RID: 9364
		[Token(Token = "0x4002494")]
		[FieldOffset(Offset = "0x78")]
		private static int DGTweeningDOTweenAnimationTargetType_EnumRef;

		// Token: 0x04002495 RID: 9365
		[Token(Token = "0x4002495")]
		[FieldOffset(Offset = "0x7C")]
		private static int UnityEnginePrimitiveType_TypeID;

		// Token: 0x04002496 RID: 9366
		[Token(Token = "0x4002496")]
		[FieldOffset(Offset = "0x80")]
		private static int UnityEnginePrimitiveType_EnumRef;

		// Token: 0x04002497 RID: 9367
		[Token(Token = "0x4002497")]
		[FieldOffset(Offset = "0x84")]
		private static int UnityEngineRectTransformEdge_TypeID;

		// Token: 0x04002498 RID: 9368
		[Token(Token = "0x4002498")]
		[FieldOffset(Offset = "0x88")]
		private static int UnityEngineRectTransformEdge_EnumRef;

		// Token: 0x04002499 RID: 9369
		[Token(Token = "0x4002499")]
		[FieldOffset(Offset = "0x8C")]
		private static int UnityEngineRectTransformAxis_TypeID;

		// Token: 0x0400249A RID: 9370
		[Token(Token = "0x400249A")]
		[FieldOffset(Offset = "0x90")]
		private static int UnityEngineRectTransformAxis_EnumRef;

		// Token: 0x0400249B RID: 9371
		[Token(Token = "0x400249B")]
		[FieldOffset(Offset = "0x94")]
		private static int UnityEngineEventSystemsPointerEventDataInputButton_TypeID;

		// Token: 0x0400249C RID: 9372
		[Token(Token = "0x400249C")]
		[FieldOffset(Offset = "0x98")]
		private static int UnityEngineEventSystemsPointerEventDataInputButton_EnumRef;

		// Token: 0x0400249D RID: 9373
		[Token(Token = "0x400249D")]
		[FieldOffset(Offset = "0x9C")]
		private static int UnityEngineEventSystemsPointerEventDataFramePressState_TypeID;

		// Token: 0x0400249E RID: 9374
		[Token(Token = "0x400249E")]
		[FieldOffset(Offset = "0xA0")]
		private static int UnityEngineEventSystemsPointerEventDataFramePressState_EnumRef;

		// Token: 0x0400249F RID: 9375
		[Token(Token = "0x400249F")]
		[FieldOffset(Offset = "0xA4")]
		private static int UnityEngineRenderTextureFormat_TypeID;

		// Token: 0x040024A0 RID: 9376
		[Token(Token = "0x40024A0")]
		[FieldOffset(Offset = "0xA8")]
		private static int UnityEngineRenderTextureFormat_EnumRef;

		// Token: 0x040024A1 RID: 9377
		[Token(Token = "0x40024A1")]
		[FieldOffset(Offset = "0xAC")]
		private static int UnityEngineRenderMode_TypeID;

		// Token: 0x040024A2 RID: 9378
		[Token(Token = "0x40024A2")]
		[FieldOffset(Offset = "0xB0")]
		private static int UnityEngineRenderMode_EnumRef;

		// Token: 0x040024A3 RID: 9379
		[Token(Token = "0x40024A3")]
		[FieldOffset(Offset = "0xB4")]
		private static int UnityEngineRenderingBlendMode_TypeID;

		// Token: 0x040024A4 RID: 9380
		[Token(Token = "0x40024A4")]
		[FieldOffset(Offset = "0xB8")]
		private static int UnityEngineRenderingBlendMode_EnumRef;

		// Token: 0x040024A5 RID: 9381
		[Token(Token = "0x40024A5")]
		[FieldOffset(Offset = "0xBC")]
		private static int UnityEngineUISelectableTransition_TypeID;

		// Token: 0x040024A6 RID: 9382
		[Token(Token = "0x40024A6")]
		[FieldOffset(Offset = "0xC0")]
		private static int UnityEngineUISelectableTransition_EnumRef;

		// Token: 0x040024A7 RID: 9383
		[Token(Token = "0x40024A7")]
		[FieldOffset(Offset = "0xC4")]
		private static int UnityEngineUIInputFieldContentType_TypeID;

		// Token: 0x040024A8 RID: 9384
		[Token(Token = "0x40024A8")]
		[FieldOffset(Offset = "0xC8")]
		private static int UnityEngineUIInputFieldContentType_EnumRef;

		// Token: 0x040024A9 RID: 9385
		[Token(Token = "0x40024A9")]
		[FieldOffset(Offset = "0xCC")]
		private static int UnityEngineUIInputFieldInputType_TypeID;

		// Token: 0x040024AA RID: 9386
		[Token(Token = "0x40024AA")]
		[FieldOffset(Offset = "0xD0")]
		private static int UnityEngineUIInputFieldInputType_EnumRef;

		// Token: 0x040024AB RID: 9387
		[Token(Token = "0x40024AB")]
		[FieldOffset(Offset = "0xD4")]
		private static int UnityEngineUIInputFieldCharacterValidation_TypeID;

		// Token: 0x040024AC RID: 9388
		[Token(Token = "0x40024AC")]
		[FieldOffset(Offset = "0xD8")]
		private static int UnityEngineUIInputFieldCharacterValidation_EnumRef;

		// Token: 0x040024AD RID: 9389
		[Token(Token = "0x40024AD")]
		[FieldOffset(Offset = "0xDC")]
		private static int UnityEngineUIInputFieldLineType_TypeID;

		// Token: 0x040024AE RID: 9390
		[Token(Token = "0x40024AE")]
		[FieldOffset(Offset = "0xE0")]
		private static int UnityEngineUIInputFieldLineType_EnumRef;

		// Token: 0x040024AF RID: 9391
		[Token(Token = "0x40024AF")]
		[FieldOffset(Offset = "0xE4")]
		private static int UnityEngineUIImageType_TypeID;

		// Token: 0x040024B0 RID: 9392
		[Token(Token = "0x40024B0")]
		[FieldOffset(Offset = "0xE8")]
		private static int UnityEngineUIImageType_EnumRef;

		// Token: 0x040024B1 RID: 9393
		[Token(Token = "0x40024B1")]
		[FieldOffset(Offset = "0xEC")]
		private static int UnityEngineUIImageFillMethod_TypeID;

		// Token: 0x040024B2 RID: 9394
		[Token(Token = "0x40024B2")]
		[FieldOffset(Offset = "0xF0")]
		private static int UnityEngineUIImageFillMethod_EnumRef;

		// Token: 0x040024B3 RID: 9395
		[Token(Token = "0x40024B3")]
		[FieldOffset(Offset = "0xF4")]
		private static int UnityEngineUIImageOriginHorizontal_TypeID;

		// Token: 0x040024B4 RID: 9396
		[Token(Token = "0x40024B4")]
		[FieldOffset(Offset = "0xF8")]
		private static int UnityEngineUIImageOriginHorizontal_EnumRef;

		// Token: 0x040024B5 RID: 9397
		[Token(Token = "0x40024B5")]
		[FieldOffset(Offset = "0xFC")]
		private static int UnityEngineUIImageOriginVertical_TypeID;

		// Token: 0x040024B6 RID: 9398
		[Token(Token = "0x40024B6")]
		[FieldOffset(Offset = "0x100")]
		private static int UnityEngineUIImageOriginVertical_EnumRef;

		// Token: 0x040024B7 RID: 9399
		[Token(Token = "0x40024B7")]
		[FieldOffset(Offset = "0x104")]
		private static int UnityEngineUIImageOrigin90_TypeID;

		// Token: 0x040024B8 RID: 9400
		[Token(Token = "0x40024B8")]
		[FieldOffset(Offset = "0x108")]
		private static int UnityEngineUIImageOrigin90_EnumRef;

		// Token: 0x040024B9 RID: 9401
		[Token(Token = "0x40024B9")]
		[FieldOffset(Offset = "0x10C")]
		private static int UnityEngineUIImageOrigin180_TypeID;

		// Token: 0x040024BA RID: 9402
		[Token(Token = "0x40024BA")]
		[FieldOffset(Offset = "0x110")]
		private static int UnityEngineUIImageOrigin180_EnumRef;

		// Token: 0x040024BB RID: 9403
		[Token(Token = "0x40024BB")]
		[FieldOffset(Offset = "0x114")]
		private static int UnityEngineUIImageOrigin360_TypeID;

		// Token: 0x040024BC RID: 9404
		[Token(Token = "0x40024BC")]
		[FieldOffset(Offset = "0x118")]
		private static int UnityEngineUIImageOrigin360_EnumRef;

		// Token: 0x040024BD RID: 9405
		[Token(Token = "0x40024BD")]
		[FieldOffset(Offset = "0x11C")]
		private static int UnityEngineUIScrollRectMovementType_TypeID;

		// Token: 0x040024BE RID: 9406
		[Token(Token = "0x40024BE")]
		[FieldOffset(Offset = "0x120")]
		private static int UnityEngineUIScrollRectMovementType_EnumRef;

		// Token: 0x040024BF RID: 9407
		[Token(Token = "0x40024BF")]
		[FieldOffset(Offset = "0x124")]
		private static int UnityEngineUIScrollRectScrollbarVisibility_TypeID;

		// Token: 0x040024C0 RID: 9408
		[Token(Token = "0x40024C0")]
		[FieldOffset(Offset = "0x128")]
		private static int UnityEngineUIScrollRectScrollbarVisibility_EnumRef;

		// Token: 0x040024C1 RID: 9409
		[Token(Token = "0x40024C1")]
		[FieldOffset(Offset = "0x12C")]
		private static int UnityEngineUISliderDirection_TypeID;

		// Token: 0x040024C2 RID: 9410
		[Token(Token = "0x40024C2")]
		[FieldOffset(Offset = "0x130")]
		private static int UnityEngineUISliderDirection_EnumRef;

		// Token: 0x040024C3 RID: 9411
		[Token(Token = "0x40024C3")]
		[FieldOffset(Offset = "0x134")]
		private static int UnityEngineUIToggleToggleTransition_TypeID;

		// Token: 0x040024C4 RID: 9412
		[Token(Token = "0x40024C4")]
		[FieldOffset(Offset = "0x138")]
		private static int UnityEngineUIToggleToggleTransition_EnumRef;

		// Token: 0x040024C5 RID: 9413
		[Token(Token = "0x40024C5")]
		[FieldOffset(Offset = "0x13C")]
		private static int UnityEngineUIGridLayoutGroupCorner_TypeID;

		// Token: 0x040024C6 RID: 9414
		[Token(Token = "0x40024C6")]
		[FieldOffset(Offset = "0x140")]
		private static int UnityEngineUIGridLayoutGroupCorner_EnumRef;

		// Token: 0x040024C7 RID: 9415
		[Token(Token = "0x40024C7")]
		[FieldOffset(Offset = "0x144")]
		private static int UnityEngineUIGridLayoutGroupAxis_TypeID;

		// Token: 0x040024C8 RID: 9416
		[Token(Token = "0x40024C8")]
		[FieldOffset(Offset = "0x148")]
		private static int UnityEngineUIGridLayoutGroupAxis_EnumRef;

		// Token: 0x040024C9 RID: 9417
		[Token(Token = "0x40024C9")]
		[FieldOffset(Offset = "0x14C")]
		private static int UnityEngineUIGridLayoutGroupConstraint_TypeID;

		// Token: 0x040024CA RID: 9418
		[Token(Token = "0x40024CA")]
		[FieldOffset(Offset = "0x150")]
		private static int UnityEngineUIGridLayoutGroupConstraint_EnumRef;

		// Token: 0x040024CB RID: 9419
		[Token(Token = "0x40024CB")]
		[FieldOffset(Offset = "0x154")]
		private static int UnityEngineUIContentSizeFitterFitMode_TypeID;

		// Token: 0x040024CC RID: 9420
		[Token(Token = "0x40024CC")]
		[FieldOffset(Offset = "0x158")]
		private static int UnityEngineUIContentSizeFitterFitMode_EnumRef;

		// Token: 0x040024CD RID: 9421
		[Token(Token = "0x40024CD")]
		[FieldOffset(Offset = "0x15C")]
		private static int SuperTextMeshAlignment_TypeID;

		// Token: 0x040024CE RID: 9422
		[Token(Token = "0x40024CE")]
		[FieldOffset(Offset = "0x160")]
		private static int SuperTextMeshAlignment_EnumRef;

		// Token: 0x040024CF RID: 9423
		[Token(Token = "0x40024CF")]
		[FieldOffset(Offset = "0x164")]
		private static int ScrollViewMovementType_TypeID;

		// Token: 0x040024D0 RID: 9424
		[Token(Token = "0x40024D0")]
		[FieldOffset(Offset = "0x168")]
		private static int ScrollViewMovementType_EnumRef;

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x16C")]
		private static int ScrollViewScrollbarVisibility_TypeID;

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40024D2")]
		[FieldOffset(Offset = "0x170")]
		private static int ScrollViewScrollbarVisibility_EnumRef;

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40024D3")]
		[FieldOffset(Offset = "0x174")]
		private static int ScrollViewScrollViewLayoutType_TypeID;

		// Token: 0x040024D4 RID: 9428
		[Token(Token = "0x40024D4")]
		[FieldOffset(Offset = "0x178")]
		private static int ScrollViewScrollViewLayoutType_EnumRef;

		// Token: 0x040024D5 RID: 9429
		[Token(Token = "0x40024D5")]
		[FieldOffset(Offset = "0x17C")]
		private static int CenterScrollViewMovementType_TypeID;

		// Token: 0x040024D6 RID: 9430
		[Token(Token = "0x40024D6")]
		[FieldOffset(Offset = "0x180")]
		private static int CenterScrollViewMovementType_EnumRef;

		// Token: 0x040024D7 RID: 9431
		[Token(Token = "0x40024D7")]
		[FieldOffset(Offset = "0x184")]
		private static int CenterScrollViewScrollbarVisibility_TypeID;

		// Token: 0x040024D8 RID: 9432
		[Token(Token = "0x40024D8")]
		[FieldOffset(Offset = "0x188")]
		private static int CenterScrollViewScrollbarVisibility_EnumRef;

		// Token: 0x040024D9 RID: 9433
		[Token(Token = "0x40024D9")]
		[FieldOffset(Offset = "0x18C")]
		private static int CenterScrollViewScrollViewLayoutType_TypeID;

		// Token: 0x040024DA RID: 9434
		[Token(Token = "0x40024DA")]
		[FieldOffset(Offset = "0x190")]
		private static int CenterScrollViewScrollViewLayoutType_EnumRef;

		// Token: 0x040024DB RID: 9435
		[Token(Token = "0x40024DB")]
		[FieldOffset(Offset = "0x194")]
		private static int UnityEngineTouchPhase_TypeID;

		// Token: 0x040024DC RID: 9436
		[Token(Token = "0x40024DC")]
		[FieldOffset(Offset = "0x198")]
		private static int UnityEngineTouchPhase_EnumRef;

		// Token: 0x040024DD RID: 9437
		[Token(Token = "0x40024DD")]
		[FieldOffset(Offset = "0x19C")]
		private static int ResourceManagerPreloadType_TypeID;

		// Token: 0x040024DE RID: 9438
		[Token(Token = "0x40024DE")]
		[FieldOffset(Offset = "0x1A0")]
		private static int ResourceManagerPreloadType_EnumRef;

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40024DF")]
		[FieldOffset(Offset = "0x1A4")]
		private static int NewQueueState_TypeID;

		// Token: 0x040024E0 RID: 9440
		[Token(Token = "0x40024E0")]
		[FieldOffset(Offset = "0x1A8")]
		private static int NewQueueState_EnumRef;

		// Token: 0x040024E1 RID: 9441
		[Token(Token = "0x40024E1")]
		[FieldOffset(Offset = "0x1AC")]
		private static int ResourceType_TypeID;

		// Token: 0x040024E2 RID: 9442
		[Token(Token = "0x40024E2")]
		[FieldOffset(Offset = "0x1B0")]
		private static int ResourceType_EnumRef;

		// Token: 0x040024E3 RID: 9443
		[Token(Token = "0x40024E3")]
		[FieldOffset(Offset = "0x1B4")]
		private static int BuildingState_TypeID;

		// Token: 0x040024E4 RID: 9444
		[Token(Token = "0x40024E4")]
		[FieldOffset(Offset = "0x1B8")]
		private static int BuildingState_EnumRef;

		// Token: 0x040024E5 RID: 9445
		[Token(Token = "0x40024E5")]
		[FieldOffset(Offset = "0x1BC")]
		private static int MarchStatus_TypeID;

		// Token: 0x040024E6 RID: 9446
		[Token(Token = "0x40024E6")]
		[FieldOffset(Offset = "0x1C0")]
		private static int MarchStatus_EnumRef;

		// Token: 0x040024E7 RID: 9447
		[Token(Token = "0x40024E7")]
		[FieldOffset(Offset = "0x1C4")]
		private static int TMProTMP_InputFieldContentType_TypeID;

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40024E8")]
		[FieldOffset(Offset = "0x1C8")]
		private static int TMProTMP_InputFieldContentType_EnumRef;

		// Token: 0x040024E9 RID: 9449
		[Token(Token = "0x40024E9")]
		[FieldOffset(Offset = "0x1CC")]
		private static int TMProTMP_InputFieldInputType_TypeID;

		// Token: 0x040024EA RID: 9450
		[Token(Token = "0x40024EA")]
		[FieldOffset(Offset = "0x1D0")]
		private static int TMProTMP_InputFieldInputType_EnumRef;

		// Token: 0x040024EB RID: 9451
		[Token(Token = "0x40024EB")]
		[FieldOffset(Offset = "0x1D4")]
		private static int TMProTMP_InputFieldCharacterValidation_TypeID;

		// Token: 0x040024EC RID: 9452
		[Token(Token = "0x40024EC")]
		[FieldOffset(Offset = "0x1D8")]
		private static int TMProTMP_InputFieldCharacterValidation_EnumRef;

		// Token: 0x040024ED RID: 9453
		[Token(Token = "0x40024ED")]
		[FieldOffset(Offset = "0x1DC")]
		private static int TMProTMP_InputFieldLineType_TypeID;

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x1E0")]
		private static int TMProTMP_InputFieldLineType_EnumRef;

		// Token: 0x040024EF RID: 9455
		[Token(Token = "0x40024EF")]
		[FieldOffset(Offset = "0x1E4")]
		private static int TMProTextAlignmentOptions_TypeID;

		// Token: 0x040024F0 RID: 9456
		[Token(Token = "0x40024F0")]
		[FieldOffset(Offset = "0x1E8")]
		private static int TMProTextAlignmentOptions_EnumRef;

		// Token: 0x040024F1 RID: 9457
		[Token(Token = "0x40024F1")]
		[FieldOffset(Offset = "0x1EC")]
		private static int NewTMPTextHorizontalAlignmentOptions_TypeID;

		// Token: 0x040024F2 RID: 9458
		[Token(Token = "0x40024F2")]
		[FieldOffset(Offset = "0x1F0")]
		private static int NewTMPTextHorizontalAlignmentOptions_EnumRef;

		// Token: 0x040024F3 RID: 9459
		[Token(Token = "0x40024F3")]
		[FieldOffset(Offset = "0x1F4")]
		private static int NewTMPTextVerticalAlignmentOptions_TypeID;

		// Token: 0x040024F4 RID: 9460
		[Token(Token = "0x40024F4")]
		[FieldOffset(Offset = "0x1F8")]
		private static int NewTMPTextVerticalAlignmentOptions_EnumRef;

		// Token: 0x040024F5 RID: 9461
		[Token(Token = "0x40024F5")]
		[FieldOffset(Offset = "0x1FC")]
		private static int NewTMP3DTextHorizontalAlignmentOptions_TypeID;

		// Token: 0x040024F6 RID: 9462
		[Token(Token = "0x40024F6")]
		[FieldOffset(Offset = "0x200")]
		private static int NewTMP3DTextHorizontalAlignmentOptions_EnumRef;

		// Token: 0x040024F7 RID: 9463
		[Token(Token = "0x40024F7")]
		[FieldOffset(Offset = "0x204")]
		private static int NewTMP3DTextVerticalAlignmentOptions_TypeID;

		// Token: 0x040024F8 RID: 9464
		[Token(Token = "0x40024F8")]
		[FieldOffset(Offset = "0x208")]
		private static int NewTMP3DTextVerticalAlignmentOptions_EnumRef;

		// Token: 0x040024F9 RID: 9465
		[Token(Token = "0x40024F9")]
		[FieldOffset(Offset = "0x20C")]
		private static int UnityEngineForceMode_TypeID;

		// Token: 0x040024FA RID: 9466
		[Token(Token = "0x40024FA")]
		[FieldOffset(Offset = "0x210")]
		private static int UnityEngineForceMode_EnumRef;

		// Token: 0x040024FB RID: 9467
		[Token(Token = "0x40024FB")]
		[FieldOffset(Offset = "0x214")]
		private static int UnityEngineHumanBodyBones_TypeID;

		// Token: 0x040024FC RID: 9468
		[Token(Token = "0x40024FC")]
		[FieldOffset(Offset = "0x218")]
		private static int UnityEngineHumanBodyBones_EnumRef;

		// Token: 0x040024FD RID: 9469
		[Token(Token = "0x40024FD")]
		[FieldOffset(Offset = "0x21C")]
		private static int BitBenderGamesMobileTouchCameraState_TypeID;

		// Token: 0x040024FE RID: 9470
		[Token(Token = "0x40024FE")]
		[FieldOffset(Offset = "0x220")]
		private static int BitBenderGamesMobileTouchCameraState_EnumRef;

		// Token: 0x040024FF RID: 9471
		[Token(Token = "0x40024FF")]
		[FieldOffset(Offset = "0x224")]
		private static int InstanceRequestState_TypeID;

		// Token: 0x04002500 RID: 9472
		[Token(Token = "0x4002500")]
		[FieldOffset(Offset = "0x228")]
		private static int InstanceRequestState_EnumRef;

		// Token: 0x04002501 RID: 9473
		[Token(Token = "0x4002501")]
		[FieldOffset(Offset = "0x22C")]
		private static int NewMarchType_TypeID;

		// Token: 0x04002502 RID: 9474
		[Token(Token = "0x4002502")]
		[FieldOffset(Offset = "0x230")]
		private static int NewMarchType_EnumRef;

		// Token: 0x04002503 RID: 9475
		[Token(Token = "0x4002503")]
		[FieldOffset(Offset = "0x234")]
		private static int WorldPointType_TypeID;

		// Token: 0x04002504 RID: 9476
		[Token(Token = "0x4002504")]
		[FieldOffset(Offset = "0x238")]
		private static int WorldPointType_EnumRef;

		// Token: 0x04002505 RID: 9477
		[Token(Token = "0x4002505")]
		[FieldOffset(Offset = "0x23C")]
		private static int UnityEngineNetworkingUnityWebRequestResult_TypeID;

		// Token: 0x04002506 RID: 9478
		[Token(Token = "0x4002506")]
		[FieldOffset(Offset = "0x240")]
		private static int UnityEngineNetworkingUnityWebRequestResult_EnumRef;

		// Token: 0x04002507 RID: 9479
		[Token(Token = "0x4002507")]
		[FieldOffset(Offset = "0x244")]
		private static int UnityEngineKeyCode_TypeID;

		// Token: 0x04002508 RID: 9480
		[Token(Token = "0x4002508")]
		[FieldOffset(Offset = "0x248")]
		private static int UnityEngineKeyCode_EnumRef;

		// Token: 0x04002509 RID: 9481
		[Token(Token = "0x4002509")]
		[FieldOffset(Offset = "0x24C")]
		private static int GameFrameworkLocalizationLanguage_TypeID;

		// Token: 0x0400250A RID: 9482
		[Token(Token = "0x400250A")]
		[FieldOffset(Offset = "0x250")]
		private static int GameFrameworkLocalizationLanguage_EnumRef;

		// Token: 0x0400250B RID: 9483
		[Token(Token = "0x400250B")]
		[FieldOffset(Offset = "0x254")]
		private static int UnityEngineWeightedMode_TypeID;

		// Token: 0x0400250C RID: 9484
		[Token(Token = "0x400250C")]
		[FieldOffset(Offset = "0x258")]
		private static int UnityEngineWeightedMode_EnumRef;

		// Token: 0x0400250D RID: 9485
		[Token(Token = "0x400250D")]
		[FieldOffset(Offset = "0x25C")]
		private static int UnityEngineQueryTriggerInteraction_TypeID;

		// Token: 0x0400250E RID: 9486
		[Token(Token = "0x400250E")]
		[FieldOffset(Offset = "0x260")]
		private static int UnityEngineQueryTriggerInteraction_EnumRef;
	}
}
