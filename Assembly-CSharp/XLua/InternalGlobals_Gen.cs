using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Threading;
using BitBenderGames;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using Main.Scripts.Network;
using SuperScrollView;
using TMPro;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.UI;

namespace XLua
{
	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x200056A")]
	[Il2CppSetOption(Option.NullChecks, false)]
	[Preserve]
	public class InternalGlobals_Gen
	{
		// Token: 0x06002AB3 RID: 10931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB3")]
		[Address(RVA = "0x229AAAC", Offset = "0x229AAAC", VA = "0x229AAAC")]
		public static void Init(out Dictionary<Type, IEnumerable<MethodInfo>> extensionMethodMap, out InternalGlobals_Gen.TryArrayGet genTryArrayGetPtr, out InternalGlobals_Gen.TryArraySet genTryArraySetPtr)
		{
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x22B4818", Offset = "0x22B4818", VA = "0x22B4818")]
		public InternalGlobals_Gen()
		{
		}

		// Token: 0x0200056B RID: 1387
		// (Invoke) Token: 0x06002AB6 RID: 10934
		[Token(Token = "0x200056B")]
		private delegate void __GEN_DELEGATE0(GameObject gameObject);

		// Token: 0x0200056C RID: 1388
		// (Invoke) Token: 0x06002ABA RID: 10938
		[Token(Token = "0x200056C")]
		private delegate void __GEN_DELEGATE1(GameObject gameObject);

		// Token: 0x0200056D RID: 1389
		// (Invoke) Token: 0x06002ABE RID: 10942
		[Token(Token = "0x200056D")]
		private delegate void __GEN_DELEGATE2(GameObject o, bool update);

		// Token: 0x0200056E RID: 1390
		// (Invoke) Token: 0x06002AC2 RID: 10946
		[Token(Token = "0x200056E")]
		private delegate void __GEN_DELEGATE3(Volume volume, bool active);

		// Token: 0x0200056F RID: 1391
		// (Invoke) Token: 0x06002AC6 RID: 10950
		[Token(Token = "0x200056F")]
		private delegate float __GEN_DELEGATE4(Animator animator, int clipHash, string begin, string end);

		// Token: 0x02000570 RID: 1392
		// (Invoke) Token: 0x06002ACA RID: 10954
		[Token(Token = "0x2000570")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE5(CanvasGroup target, float endValue, float duration);

		// Token: 0x02000571 RID: 1393
		// (Invoke) Token: 0x06002ACE RID: 10958
		[Token(Token = "0x2000571")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE6(Graphic target, Color endValue, float duration);

		// Token: 0x02000572 RID: 1394
		// (Invoke) Token: 0x06002AD2 RID: 10962
		[Token(Token = "0x2000572")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE7(Graphic target, float endValue, float duration);

		// Token: 0x02000573 RID: 1395
		// (Invoke) Token: 0x06002AD6 RID: 10966
		[Token(Token = "0x2000573")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE8(Image target, Color endValue, float duration);

		// Token: 0x02000574 RID: 1396
		// (Invoke) Token: 0x06002ADA RID: 10970
		[Token(Token = "0x2000574")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE9(Image target, float endValue, float duration);

		// Token: 0x02000575 RID: 1397
		// (Invoke) Token: 0x06002ADE RID: 10974
		[Token(Token = "0x2000575")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE10(Image target, float endValue, float duration);

		// Token: 0x02000576 RID: 1398
		// (Invoke) Token: 0x06002AE2 RID: 10978
		[Token(Token = "0x2000576")]
		private delegate Sequence __GEN_DELEGATE11(Image target, Gradient gradient, float duration);

		// Token: 0x02000577 RID: 1399
		// (Invoke) Token: 0x06002AE6 RID: 10982
		[Token(Token = "0x2000577")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE12(LayoutElement target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x02000578 RID: 1400
		// (Invoke) Token: 0x06002AEA RID: 10986
		[Token(Token = "0x2000578")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE13(LayoutElement target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x02000579 RID: 1401
		// (Invoke) Token: 0x06002AEE RID: 10990
		[Token(Token = "0x2000579")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE14(LayoutElement target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x0200057A RID: 1402
		// (Invoke) Token: 0x06002AF2 RID: 10994
		[Token(Token = "0x200057A")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE15(Outline target, Color endValue, float duration);

		// Token: 0x0200057B RID: 1403
		// (Invoke) Token: 0x06002AF6 RID: 10998
		[Token(Token = "0x200057B")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE16(Outline target, float endValue, float duration);

		// Token: 0x0200057C RID: 1404
		// (Invoke) Token: 0x06002AFA RID: 11002
		[Token(Token = "0x200057C")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE17(Outline target, Vector2 endValue, float duration);

		// Token: 0x0200057D RID: 1405
		// (Invoke) Token: 0x06002AFE RID: 11006
		[Token(Token = "0x200057D")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE18(RectTransform target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x0200057E RID: 1406
		// (Invoke) Token: 0x06002B02 RID: 11010
		[Token(Token = "0x200057E")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE19(RectTransform target, float endValue, float duration, bool snapping);

		// Token: 0x0200057F RID: 1407
		// (Invoke) Token: 0x06002B06 RID: 11014
		[Token(Token = "0x200057F")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE20(RectTransform target, float endValue, float duration, bool snapping);

		// Token: 0x02000580 RID: 1408
		// (Invoke) Token: 0x06002B0A RID: 11018
		[Token(Token = "0x2000580")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE21(RectTransform target, Vector3 endValue, float duration, bool snapping);

		// Token: 0x02000581 RID: 1409
		// (Invoke) Token: 0x06002B0E RID: 11022
		[Token(Token = "0x2000581")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE22(RectTransform target, float endValue, float duration, bool snapping);

		// Token: 0x02000582 RID: 1410
		// (Invoke) Token: 0x06002B12 RID: 11026
		[Token(Token = "0x2000582")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE23(RectTransform target, float endValue, float duration, bool snapping);

		// Token: 0x02000583 RID: 1411
		// (Invoke) Token: 0x06002B16 RID: 11030
		[Token(Token = "0x2000583")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE24(RectTransform target, float endValue, float duration, bool snapping);

		// Token: 0x02000584 RID: 1412
		// (Invoke) Token: 0x06002B1A RID: 11034
		[Token(Token = "0x2000584")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE25(RectTransform target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x02000585 RID: 1413
		// (Invoke) Token: 0x06002B1E RID: 11038
		[Token(Token = "0x2000585")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE26(RectTransform target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x02000586 RID: 1414
		// (Invoke) Token: 0x06002B22 RID: 11042
		[Token(Token = "0x2000586")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE27(RectTransform target, Vector2 endValue, float duration);

		// Token: 0x02000587 RID: 1415
		// (Invoke) Token: 0x06002B26 RID: 11046
		[Token(Token = "0x2000587")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE28(RectTransform target, float endValue, float duration);

		// Token: 0x02000588 RID: 1416
		// (Invoke) Token: 0x06002B2A RID: 11050
		[Token(Token = "0x2000588")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE29(RectTransform target, float endValue, float duration);

		// Token: 0x02000589 RID: 1417
		// (Invoke) Token: 0x06002B2E RID: 11054
		[Token(Token = "0x2000589")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE30(RectTransform target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x0200058A RID: 1418
		// (Invoke) Token: 0x06002B32 RID: 11058
		[Token(Token = "0x200058A")]
		private delegate Tweener __GEN_DELEGATE31(RectTransform target, Vector2 punch, float duration, int vibrato, float elasticity, bool snapping);

		// Token: 0x0200058B RID: 1419
		// (Invoke) Token: 0x06002B36 RID: 11062
		[Token(Token = "0x200058B")]
		private delegate Tweener __GEN_DELEGATE32(RectTransform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut);

		// Token: 0x0200058C RID: 1420
		// (Invoke) Token: 0x06002B3A RID: 11066
		[Token(Token = "0x200058C")]
		private delegate Tweener __GEN_DELEGATE33(RectTransform target, float duration, Vector2 strength, int vibrato, float randomness, bool snapping, bool fadeOut);

		// Token: 0x0200058D RID: 1421
		// (Invoke) Token: 0x06002B3E RID: 11070
		[Token(Token = "0x200058D")]
		private delegate Sequence __GEN_DELEGATE34(RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping);

		// Token: 0x0200058E RID: 1422
		// (Invoke) Token: 0x06002B42 RID: 11074
		[Token(Token = "0x200058E")]
		private delegate Tweener __GEN_DELEGATE35(ScrollRect target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x0200058F RID: 1423
		// (Invoke) Token: 0x06002B46 RID: 11078
		[Token(Token = "0x200058F")]
		private delegate Tweener __GEN_DELEGATE36(ScrollRect target, float endValue, float duration, bool snapping);

		// Token: 0x02000590 RID: 1424
		// (Invoke) Token: 0x06002B4A RID: 11082
		[Token(Token = "0x2000590")]
		private delegate Tweener __GEN_DELEGATE37(ScrollRect target, float endValue, float duration, bool snapping);

		// Token: 0x02000591 RID: 1425
		// (Invoke) Token: 0x06002B4E RID: 11086
		[Token(Token = "0x2000591")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE38(Slider target, float endValue, float duration, bool snapping);

		// Token: 0x02000592 RID: 1426
		// (Invoke) Token: 0x06002B52 RID: 11090
		[Token(Token = "0x2000592")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE39(Text target, Color endValue, float duration);

		// Token: 0x02000593 RID: 1427
		// (Invoke) Token: 0x06002B56 RID: 11094
		[Token(Token = "0x2000593")]
		private delegate TweenerCore<int, int, NoOptions> __GEN_DELEGATE40(Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator, CultureInfo culture);

		// Token: 0x02000594 RID: 1428
		// (Invoke) Token: 0x06002B5A RID: 11098
		[Token(Token = "0x2000594")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE41(Text target, float endValue, float duration);

		// Token: 0x02000595 RID: 1429
		// (Invoke) Token: 0x06002B5E RID: 11102
		[Token(Token = "0x2000595")]
		private delegate TweenerCore<string, string, StringOptions> __GEN_DELEGATE42(Text target, string endValue, float duration, bool richTextEnabled, ScrambleMode scrambleMode, string scrambleChars);

		// Token: 0x02000596 RID: 1430
		// (Invoke) Token: 0x06002B62 RID: 11106
		[Token(Token = "0x2000596")]
		private delegate Tweener __GEN_DELEGATE43(Graphic target, Color endValue, float duration);

		// Token: 0x02000597 RID: 1431
		// (Invoke) Token: 0x06002B66 RID: 11110
		[Token(Token = "0x2000597")]
		private delegate Tweener __GEN_DELEGATE44(Image target, Color endValue, float duration);

		// Token: 0x02000598 RID: 1432
		// (Invoke) Token: 0x06002B6A RID: 11114
		[Token(Token = "0x2000598")]
		private delegate Tweener __GEN_DELEGATE45(Text target, Color endValue, float duration);

		// Token: 0x02000599 RID: 1433
		// (Invoke) Token: 0x06002B6E RID: 11118
		[Token(Token = "0x2000599")]
		private delegate void __GEN_DELEGATE46(Tween t);

		// Token: 0x0200059A RID: 1434
		// (Invoke) Token: 0x06002B72 RID: 11122
		[Token(Token = "0x200059A")]
		private delegate void __GEN_DELEGATE47(Tween t, bool withCallbacks);

		// Token: 0x0200059B RID: 1435
		// (Invoke) Token: 0x06002B76 RID: 11126
		[Token(Token = "0x200059B")]
		private delegate void __GEN_DELEGATE48(Tween t);

		// Token: 0x0200059C RID: 1436
		// (Invoke) Token: 0x06002B7A RID: 11130
		[Token(Token = "0x200059C")]
		private delegate void __GEN_DELEGATE49(Tween t);

		// Token: 0x0200059D RID: 1437
		// (Invoke) Token: 0x06002B7E RID: 11134
		[Token(Token = "0x200059D")]
		private delegate void __GEN_DELEGATE50(Tween t, float to, bool andPlay);

		// Token: 0x0200059E RID: 1438
		// (Invoke) Token: 0x06002B82 RID: 11138
		[Token(Token = "0x200059E")]
		private delegate void __GEN_DELEGATE51(Tween t, bool complete);

		// Token: 0x0200059F RID: 1439
		// (Invoke) Token: 0x06002B86 RID: 11142
		[Token(Token = "0x200059F")]
		private delegate Tween __GEN_DELEGATE52(Tween t);

		// Token: 0x020005A0 RID: 1440
		// (Invoke) Token: 0x06002B8A RID: 11146
		[Token(Token = "0x20005A0")]
		private delegate Tween __GEN_DELEGATE53(Tween t);

		// Token: 0x020005A1 RID: 1441
		// (Invoke) Token: 0x06002B8E RID: 11150
		[Token(Token = "0x20005A1")]
		private delegate void __GEN_DELEGATE54(Tween t);

		// Token: 0x020005A2 RID: 1442
		// (Invoke) Token: 0x06002B92 RID: 11154
		[Token(Token = "0x20005A2")]
		private delegate void __GEN_DELEGATE55(Tween t);

		// Token: 0x020005A3 RID: 1443
		// (Invoke) Token: 0x06002B96 RID: 11158
		[Token(Token = "0x20005A3")]
		private delegate void __GEN_DELEGATE56(Tween t, bool includeDelay, float changeDelayTo);

		// Token: 0x020005A4 RID: 1444
		// (Invoke) Token: 0x06002B9A RID: 11162
		[Token(Token = "0x20005A4")]
		private delegate void __GEN_DELEGATE57(Tween t, bool includeDelay);

		// Token: 0x020005A5 RID: 1445
		// (Invoke) Token: 0x06002B9E RID: 11166
		[Token(Token = "0x20005A5")]
		private delegate void __GEN_DELEGATE58(Tween t);

		// Token: 0x020005A6 RID: 1446
		// (Invoke) Token: 0x06002BA2 RID: 11170
		[Token(Token = "0x20005A6")]
		private delegate void __GEN_DELEGATE59(Tween t);

		// Token: 0x020005A7 RID: 1447
		// (Invoke) Token: 0x06002BA6 RID: 11174
		[Token(Token = "0x20005A7")]
		private delegate void __GEN_DELEGATE60(Tween t, int waypointIndex, bool andPlay);

		// Token: 0x020005A8 RID: 1448
		// (Invoke) Token: 0x06002BAA RID: 11178
		[Token(Token = "0x20005A8")]
		private delegate YieldInstruction __GEN_DELEGATE61(Tween t);

		// Token: 0x020005A9 RID: 1449
		// (Invoke) Token: 0x06002BAE RID: 11182
		[Token(Token = "0x20005A9")]
		private delegate YieldInstruction __GEN_DELEGATE62(Tween t);

		// Token: 0x020005AA RID: 1450
		// (Invoke) Token: 0x06002BB2 RID: 11186
		[Token(Token = "0x20005AA")]
		private delegate YieldInstruction __GEN_DELEGATE63(Tween t);

		// Token: 0x020005AB RID: 1451
		// (Invoke) Token: 0x06002BB6 RID: 11190
		[Token(Token = "0x20005AB")]
		private delegate YieldInstruction __GEN_DELEGATE64(Tween t, int elapsedLoops);

		// Token: 0x020005AC RID: 1452
		// (Invoke) Token: 0x06002BBA RID: 11194
		[Token(Token = "0x20005AC")]
		private delegate YieldInstruction __GEN_DELEGATE65(Tween t, float position);

		// Token: 0x020005AD RID: 1453
		// (Invoke) Token: 0x06002BBE RID: 11198
		[Token(Token = "0x20005AD")]
		private delegate Coroutine __GEN_DELEGATE66(Tween t);

		// Token: 0x020005AE RID: 1454
		// (Invoke) Token: 0x06002BC2 RID: 11202
		[Token(Token = "0x20005AE")]
		private delegate int __GEN_DELEGATE67(Tween t);

		// Token: 0x020005AF RID: 1455
		// (Invoke) Token: 0x06002BC6 RID: 11206
		[Token(Token = "0x20005AF")]
		private delegate float __GEN_DELEGATE68(Tween t);

		// Token: 0x020005B0 RID: 1456
		// (Invoke) Token: 0x06002BCA RID: 11210
		[Token(Token = "0x20005B0")]
		private delegate float __GEN_DELEGATE69(Tween t);

		// Token: 0x020005B1 RID: 1457
		// (Invoke) Token: 0x06002BCE RID: 11214
		[Token(Token = "0x20005B1")]
		private delegate float __GEN_DELEGATE70(Tween t, bool includeLoops);

		// Token: 0x020005B2 RID: 1458
		// (Invoke) Token: 0x06002BD2 RID: 11218
		[Token(Token = "0x20005B2")]
		private delegate float __GEN_DELEGATE71(Tween t, bool includeLoops);

		// Token: 0x020005B3 RID: 1459
		// (Invoke) Token: 0x06002BD6 RID: 11222
		[Token(Token = "0x20005B3")]
		private delegate float __GEN_DELEGATE72(Tween t, bool includeLoops);

		// Token: 0x020005B4 RID: 1460
		// (Invoke) Token: 0x06002BDA RID: 11226
		[Token(Token = "0x20005B4")]
		private delegate float __GEN_DELEGATE73(Tween t);

		// Token: 0x020005B5 RID: 1461
		// (Invoke) Token: 0x06002BDE RID: 11230
		[Token(Token = "0x20005B5")]
		private delegate bool __GEN_DELEGATE74(Tween t);

		// Token: 0x020005B6 RID: 1462
		// (Invoke) Token: 0x06002BE2 RID: 11234
		[Token(Token = "0x20005B6")]
		private delegate bool __GEN_DELEGATE75(Tween t);

		// Token: 0x020005B7 RID: 1463
		// (Invoke) Token: 0x06002BE6 RID: 11238
		[Token(Token = "0x20005B7")]
		private delegate bool __GEN_DELEGATE76(Tween t);

		// Token: 0x020005B8 RID: 1464
		// (Invoke) Token: 0x06002BEA RID: 11242
		[Token(Token = "0x20005B8")]
		private delegate bool __GEN_DELEGATE77(Tween t);

		// Token: 0x020005B9 RID: 1465
		// (Invoke) Token: 0x06002BEE RID: 11246
		[Token(Token = "0x20005B9")]
		private delegate bool __GEN_DELEGATE78(Tween t);

		// Token: 0x020005BA RID: 1466
		// (Invoke) Token: 0x06002BF2 RID: 11250
		[Token(Token = "0x20005BA")]
		private delegate int __GEN_DELEGATE79(Tween t);

		// Token: 0x020005BB RID: 1467
		// (Invoke) Token: 0x06002BF6 RID: 11254
		[Token(Token = "0x20005BB")]
		private delegate Vector3 __GEN_DELEGATE80(Tween t, float pathPercentage);

		// Token: 0x020005BC RID: 1468
		// (Invoke) Token: 0x06002BFA RID: 11258
		[Token(Token = "0x20005BC")]
		private delegate Vector3[] __GEN_DELEGATE81(Tween t, int subdivisionsXSegment);

		// Token: 0x020005BD RID: 1469
		// (Invoke) Token: 0x06002BFE RID: 11262
		[Token(Token = "0x20005BD")]
		private delegate float __GEN_DELEGATE82(Tween t);

		// Token: 0x020005BE RID: 1470
		// (Invoke) Token: 0x06002C02 RID: 11266
		[Token(Token = "0x20005BE")]
		private delegate Tween __GEN_DELEGATE83(Tween t);

		// Token: 0x020005BF RID: 1471
		// (Invoke) Token: 0x06002C06 RID: 11270
		[Token(Token = "0x20005BF")]
		private delegate Tween __GEN_DELEGATE84(Tween t, bool autoKillOnCompletion);

		// Token: 0x020005C0 RID: 1472
		// (Invoke) Token: 0x06002C0A RID: 11274
		[Token(Token = "0x20005C0")]
		private delegate Tween __GEN_DELEGATE85(Tween t, object objectId);

		// Token: 0x020005C1 RID: 1473
		// (Invoke) Token: 0x06002C0E RID: 11278
		[Token(Token = "0x20005C1")]
		private delegate Tween __GEN_DELEGATE86(Tween t, string stringId);

		// Token: 0x020005C2 RID: 1474
		// (Invoke) Token: 0x06002C12 RID: 11282
		[Token(Token = "0x20005C2")]
		private delegate Tween __GEN_DELEGATE87(Tween t, int intId);

		// Token: 0x020005C3 RID: 1475
		// (Invoke) Token: 0x06002C16 RID: 11286
		[Token(Token = "0x20005C3")]
		private delegate Tween __GEN_DELEGATE88(Tween t, GameObject gameObject);

		// Token: 0x020005C4 RID: 1476
		// (Invoke) Token: 0x06002C1A RID: 11290
		[Token(Token = "0x20005C4")]
		private delegate Tween __GEN_DELEGATE89(Tween t, GameObject gameObject, LinkBehaviour behaviour);

		// Token: 0x020005C5 RID: 1477
		// (Invoke) Token: 0x06002C1E RID: 11294
		[Token(Token = "0x20005C5")]
		private delegate Tween __GEN_DELEGATE90(Tween t, object target);

		// Token: 0x020005C6 RID: 1478
		// (Invoke) Token: 0x06002C22 RID: 11298
		[Token(Token = "0x20005C6")]
		private delegate Tween __GEN_DELEGATE91(Tween t, int loops);

		// Token: 0x020005C7 RID: 1479
		// (Invoke) Token: 0x06002C26 RID: 11302
		[Token(Token = "0x20005C7")]
		private delegate Tween __GEN_DELEGATE92(Tween t, int loops, LoopType loopType);

		// Token: 0x020005C8 RID: 1480
		// (Invoke) Token: 0x06002C2A RID: 11306
		[Token(Token = "0x20005C8")]
		private delegate Tween __GEN_DELEGATE93(Tween t, Ease ease);

		// Token: 0x020005C9 RID: 1481
		// (Invoke) Token: 0x06002C2E RID: 11310
		[Token(Token = "0x20005C9")]
		private delegate Tween __GEN_DELEGATE94(Tween t, Ease ease, float overshoot);

		// Token: 0x020005CA RID: 1482
		// (Invoke) Token: 0x06002C32 RID: 11314
		[Token(Token = "0x20005CA")]
		private delegate Tween __GEN_DELEGATE95(Tween t, Ease ease, float amplitude, float period);

		// Token: 0x020005CB RID: 1483
		// (Invoke) Token: 0x06002C36 RID: 11318
		[Token(Token = "0x20005CB")]
		private delegate Tween __GEN_DELEGATE96(Tween t, AnimationCurve animCurve);

		// Token: 0x020005CC RID: 1484
		// (Invoke) Token: 0x06002C3A RID: 11322
		[Token(Token = "0x20005CC")]
		private delegate Tween __GEN_DELEGATE97(Tween t, EaseFunction customEase);

		// Token: 0x020005CD RID: 1485
		// (Invoke) Token: 0x06002C3E RID: 11326
		[Token(Token = "0x20005CD")]
		private delegate Tween __GEN_DELEGATE98(Tween t);

		// Token: 0x020005CE RID: 1486
		// (Invoke) Token: 0x06002C42 RID: 11330
		[Token(Token = "0x20005CE")]
		private delegate Tween __GEN_DELEGATE99(Tween t, bool recyclable);

		// Token: 0x020005CF RID: 1487
		// (Invoke) Token: 0x06002C46 RID: 11334
		[Token(Token = "0x20005CF")]
		private delegate Tween __GEN_DELEGATE100(Tween t, bool isIndependentUpdate);

		// Token: 0x020005D0 RID: 1488
		// (Invoke) Token: 0x06002C4A RID: 11338
		[Token(Token = "0x20005D0")]
		private delegate Tween __GEN_DELEGATE101(Tween t, UpdateType updateType);

		// Token: 0x020005D1 RID: 1489
		// (Invoke) Token: 0x06002C4E RID: 11342
		[Token(Token = "0x20005D1")]
		private delegate Tween __GEN_DELEGATE102(Tween t, UpdateType updateType, bool isIndependentUpdate);

		// Token: 0x020005D2 RID: 1490
		// (Invoke) Token: 0x06002C52 RID: 11346
		[Token(Token = "0x20005D2")]
		private delegate Tween __GEN_DELEGATE103(Tween t, TweenCallback action);

		// Token: 0x020005D3 RID: 1491
		// (Invoke) Token: 0x06002C56 RID: 11350
		[Token(Token = "0x20005D3")]
		private delegate Tween __GEN_DELEGATE104(Tween t, TweenCallback action);

		// Token: 0x020005D4 RID: 1492
		// (Invoke) Token: 0x06002C5A RID: 11354
		[Token(Token = "0x20005D4")]
		private delegate Tween __GEN_DELEGATE105(Tween t, TweenCallback action);

		// Token: 0x020005D5 RID: 1493
		// (Invoke) Token: 0x06002C5E RID: 11358
		[Token(Token = "0x20005D5")]
		private delegate Tween __GEN_DELEGATE106(Tween t, TweenCallback action);

		// Token: 0x020005D6 RID: 1494
		// (Invoke) Token: 0x06002C62 RID: 11362
		[Token(Token = "0x20005D6")]
		private delegate Tween __GEN_DELEGATE107(Tween t, TweenCallback action);

		// Token: 0x020005D7 RID: 1495
		// (Invoke) Token: 0x06002C66 RID: 11366
		[Token(Token = "0x20005D7")]
		private delegate Tween __GEN_DELEGATE108(Tween t, TweenCallback action);

		// Token: 0x020005D8 RID: 1496
		// (Invoke) Token: 0x06002C6A RID: 11370
		[Token(Token = "0x20005D8")]
		private delegate Tween __GEN_DELEGATE109(Tween t, TweenCallback action);

		// Token: 0x020005D9 RID: 1497
		// (Invoke) Token: 0x06002C6E RID: 11374
		[Token(Token = "0x20005D9")]
		private delegate Tween __GEN_DELEGATE110(Tween t, TweenCallback action);

		// Token: 0x020005DA RID: 1498
		// (Invoke) Token: 0x06002C72 RID: 11378
		[Token(Token = "0x20005DA")]
		private delegate Tween __GEN_DELEGATE111(Tween t, TweenCallback<int> action);

		// Token: 0x020005DB RID: 1499
		// (Invoke) Token: 0x06002C76 RID: 11382
		[Token(Token = "0x20005DB")]
		private delegate Tween __GEN_DELEGATE112(Tween t, Tween asTween);

		// Token: 0x020005DC RID: 1500
		// (Invoke) Token: 0x06002C7A RID: 11386
		[Token(Token = "0x20005DC")]
		private delegate Tween __GEN_DELEGATE113(Tween t, TweenParams tweenParams);

		// Token: 0x020005DD RID: 1501
		// (Invoke) Token: 0x06002C7E RID: 11390
		[Token(Token = "0x20005DD")]
		private delegate Sequence __GEN_DELEGATE114(Sequence s, Tween t);

		// Token: 0x020005DE RID: 1502
		// (Invoke) Token: 0x06002C82 RID: 11394
		[Token(Token = "0x20005DE")]
		private delegate Sequence __GEN_DELEGATE115(Sequence s, Tween t);

		// Token: 0x020005DF RID: 1503
		// (Invoke) Token: 0x06002C86 RID: 11398
		[Token(Token = "0x20005DF")]
		private delegate Sequence __GEN_DELEGATE116(Sequence s, Tween t);

		// Token: 0x020005E0 RID: 1504
		// (Invoke) Token: 0x06002C8A RID: 11402
		[Token(Token = "0x20005E0")]
		private delegate Sequence __GEN_DELEGATE117(Sequence s, float atPosition, Tween t);

		// Token: 0x020005E1 RID: 1505
		// (Invoke) Token: 0x06002C8E RID: 11406
		[Token(Token = "0x20005E1")]
		private delegate Sequence __GEN_DELEGATE118(Sequence s, float interval);

		// Token: 0x020005E2 RID: 1506
		// (Invoke) Token: 0x06002C92 RID: 11410
		[Token(Token = "0x20005E2")]
		private delegate Sequence __GEN_DELEGATE119(Sequence s, float interval);

		// Token: 0x020005E3 RID: 1507
		// (Invoke) Token: 0x06002C96 RID: 11414
		[Token(Token = "0x20005E3")]
		private delegate Sequence __GEN_DELEGATE120(Sequence s, TweenCallback callback);

		// Token: 0x020005E4 RID: 1508
		// (Invoke) Token: 0x06002C9A RID: 11418
		[Token(Token = "0x20005E4")]
		private delegate Sequence __GEN_DELEGATE121(Sequence s, TweenCallback callback);

		// Token: 0x020005E5 RID: 1509
		// (Invoke) Token: 0x06002C9E RID: 11422
		[Token(Token = "0x20005E5")]
		private delegate Sequence __GEN_DELEGATE122(Sequence s, float atPosition, TweenCallback callback);

		// Token: 0x020005E6 RID: 1510
		// (Invoke) Token: 0x06002CA2 RID: 11426
		[Token(Token = "0x20005E6")]
		private delegate Tweener __GEN_DELEGATE123(Tweener t);

		// Token: 0x020005E7 RID: 1511
		// (Invoke) Token: 0x06002CA6 RID: 11430
		[Token(Token = "0x20005E7")]
		private delegate Tweener __GEN_DELEGATE124(Tweener t, bool isRelative);

		// Token: 0x020005E8 RID: 1512
		// (Invoke) Token: 0x06002CAA RID: 11434
		[Token(Token = "0x20005E8")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE125(TweenerCore<Color, Color, ColorOptions> t, float fromAlphaValue, bool setImmediately, bool isRelative);

		// Token: 0x020005E9 RID: 1513
		// (Invoke) Token: 0x06002CAE RID: 11438
		[Token(Token = "0x20005E9")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE126(TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately, bool isRelative);

		// Token: 0x020005EA RID: 1514
		// (Invoke) Token: 0x06002CB2 RID: 11442
		[Token(Token = "0x20005EA")]
		private delegate Tween __GEN_DELEGATE127(Tween t, float delay);

		// Token: 0x020005EB RID: 1515
		// (Invoke) Token: 0x06002CB6 RID: 11446
		[Token(Token = "0x20005EB")]
		private delegate Tween __GEN_DELEGATE128(Tween t, float delay, bool asPrependedIntervalIfSequence);

		// Token: 0x020005EC RID: 1516
		// (Invoke) Token: 0x06002CBA RID: 11450
		[Token(Token = "0x20005EC")]
		private delegate Tween __GEN_DELEGATE129(Tween t);

		// Token: 0x020005ED RID: 1517
		// (Invoke) Token: 0x06002CBE RID: 11454
		[Token(Token = "0x20005ED")]
		private delegate Tween __GEN_DELEGATE130(Tween t, bool isRelative);

		// Token: 0x020005EE RID: 1518
		// (Invoke) Token: 0x06002CC2 RID: 11458
		[Token(Token = "0x20005EE")]
		private delegate Tween __GEN_DELEGATE131(Tween t);

		// Token: 0x020005EF RID: 1519
		// (Invoke) Token: 0x06002CC6 RID: 11462
		[Token(Token = "0x20005EF")]
		private delegate Tween __GEN_DELEGATE132(Tween t, bool isSpeedBased);

		// Token: 0x020005F0 RID: 1520
		// (Invoke) Token: 0x06002CCA RID: 11466
		[Token(Token = "0x20005F0")]
		private delegate Tweener __GEN_DELEGATE133(TweenerCore<float, float, FloatOptions> t, bool snapping);

		// Token: 0x020005F1 RID: 1521
		// (Invoke) Token: 0x06002CCE RID: 11470
		[Token(Token = "0x20005F1")]
		private delegate Tweener __GEN_DELEGATE134(TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping);

		// Token: 0x020005F2 RID: 1522
		// (Invoke) Token: 0x06002CD2 RID: 11474
		[Token(Token = "0x20005F2")]
		private delegate Tweener __GEN_DELEGATE135(TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x020005F3 RID: 1523
		// (Invoke) Token: 0x06002CD6 RID: 11478
		[Token(Token = "0x20005F3")]
		private delegate Tweener __GEN_DELEGATE136(TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping);

		// Token: 0x020005F4 RID: 1524
		// (Invoke) Token: 0x06002CDA RID: 11482
		[Token(Token = "0x20005F4")]
		private delegate Tweener __GEN_DELEGATE137(TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x020005F5 RID: 1525
		// (Invoke) Token: 0x06002CDE RID: 11486
		[Token(Token = "0x20005F5")]
		private delegate Tweener __GEN_DELEGATE138(TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping);

		// Token: 0x020005F6 RID: 1526
		// (Invoke) Token: 0x06002CE2 RID: 11490
		[Token(Token = "0x20005F6")]
		private delegate Tweener __GEN_DELEGATE139(TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x020005F7 RID: 1527
		// (Invoke) Token: 0x06002CE6 RID: 11494
		[Token(Token = "0x20005F7")]
		private delegate Tweener __GEN_DELEGATE140(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route);

		// Token: 0x020005F8 RID: 1528
		// (Invoke) Token: 0x06002CEA RID: 11498
		[Token(Token = "0x20005F8")]
		private delegate Tweener __GEN_DELEGATE141(TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly);

		// Token: 0x020005F9 RID: 1529
		// (Invoke) Token: 0x06002CEE RID: 11502
		[Token(Token = "0x20005F9")]
		private delegate Tweener __GEN_DELEGATE142(TweenerCore<Rect, Rect, RectOptions> t, bool snapping);

		// Token: 0x020005FA RID: 1530
		// (Invoke) Token: 0x06002CF2 RID: 11506
		[Token(Token = "0x20005FA")]
		private delegate Tweener __GEN_DELEGATE143(TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode, string scrambleChars);

		// Token: 0x020005FB RID: 1531
		// (Invoke) Token: 0x06002CF6 RID: 11510
		[Token(Token = "0x20005FB")]
		private delegate Tweener __GEN_DELEGATE144(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping);

		// Token: 0x020005FC RID: 1532
		// (Invoke) Token: 0x06002CFA RID: 11514
		[Token(Token = "0x20005FC")]
		private delegate Tweener __GEN_DELEGATE145(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x020005FD RID: 1533
		// (Invoke) Token: 0x06002CFE RID: 11518
		[Token(Token = "0x20005FD")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE146(TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation);

		// Token: 0x020005FE RID: 1534
		// (Invoke) Token: 0x06002D02 RID: 11522
		[Token(Token = "0x20005FE")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE147(TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition, AxisConstraint lockRotation);

		// Token: 0x020005FF RID: 1535
		// (Invoke) Token: 0x06002D06 RID: 11526
		[Token(Token = "0x20005FF")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE148(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection, Vector3? up);

		// Token: 0x02000600 RID: 1536
		// (Invoke) Token: 0x06002D0A RID: 11530
		[Token(Token = "0x2000600")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE149(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation);

		// Token: 0x02000601 RID: 1537
		// (Invoke) Token: 0x06002D0E RID: 11534
		[Token(Token = "0x2000601")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE150(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection, Vector3? up);

		// Token: 0x02000602 RID: 1538
		// (Invoke) Token: 0x06002D12 RID: 11538
		[Token(Token = "0x2000602")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE151(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation);

		// Token: 0x02000603 RID: 1539
		// (Invoke) Token: 0x06002D16 RID: 11542
		[Token(Token = "0x2000603")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE152(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection, Vector3? up);

		// Token: 0x02000604 RID: 1540
		// (Invoke) Token: 0x06002D1A RID: 11546
		[Token(Token = "0x2000604")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE153(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation);

		// Token: 0x02000605 RID: 1541
		// (Invoke) Token: 0x06002D1E RID: 11550
		[Token(Token = "0x2000605")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE154(Camera target, float endValue, float duration);

		// Token: 0x02000606 RID: 1542
		// (Invoke) Token: 0x06002D22 RID: 11554
		[Token(Token = "0x2000606")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE155(Camera target, Color endValue, float duration);

		// Token: 0x02000607 RID: 1543
		// (Invoke) Token: 0x06002D26 RID: 11558
		[Token(Token = "0x2000607")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE156(Camera target, float endValue, float duration);

		// Token: 0x02000608 RID: 1544
		// (Invoke) Token: 0x06002D2A RID: 11562
		[Token(Token = "0x2000608")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE157(Camera target, float endValue, float duration);

		// Token: 0x02000609 RID: 1545
		// (Invoke) Token: 0x06002D2E RID: 11566
		[Token(Token = "0x2000609")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE158(Camera target, float endValue, float duration);

		// Token: 0x0200060A RID: 1546
		// (Invoke) Token: 0x06002D32 RID: 11570
		[Token(Token = "0x200060A")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE159(Camera target, float endValue, float duration);

		// Token: 0x0200060B RID: 1547
		// (Invoke) Token: 0x06002D36 RID: 11574
		[Token(Token = "0x200060B")]
		private delegate TweenerCore<Rect, Rect, RectOptions> __GEN_DELEGATE160(Camera target, Rect endValue, float duration);

		// Token: 0x0200060C RID: 1548
		// (Invoke) Token: 0x06002D3A RID: 11578
		[Token(Token = "0x200060C")]
		private delegate TweenerCore<Rect, Rect, RectOptions> __GEN_DELEGATE161(Camera target, Rect endValue, float duration);

		// Token: 0x0200060D RID: 1549
		// (Invoke) Token: 0x06002D3E RID: 11582
		[Token(Token = "0x200060D")]
		private delegate Tweener __GEN_DELEGATE162(Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut);

		// Token: 0x0200060E RID: 1550
		// (Invoke) Token: 0x06002D42 RID: 11586
		[Token(Token = "0x200060E")]
		private delegate Tweener __GEN_DELEGATE163(Camera target, float duration, Vector3 strength, int vibrato, float randomness, bool fadeOut);

		// Token: 0x0200060F RID: 1551
		// (Invoke) Token: 0x06002D46 RID: 11590
		[Token(Token = "0x200060F")]
		private delegate Tweener __GEN_DELEGATE164(Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut);

		// Token: 0x02000610 RID: 1552
		// (Invoke) Token: 0x06002D4A RID: 11594
		[Token(Token = "0x2000610")]
		private delegate Tweener __GEN_DELEGATE165(Camera target, float duration, Vector3 strength, int vibrato, float randomness, bool fadeOut);

		// Token: 0x02000611 RID: 1553
		// (Invoke) Token: 0x06002D4E RID: 11598
		[Token(Token = "0x2000611")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE166(Light target, Color endValue, float duration);

		// Token: 0x02000612 RID: 1554
		// (Invoke) Token: 0x06002D52 RID: 11602
		[Token(Token = "0x2000612")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE167(Light target, float endValue, float duration);

		// Token: 0x02000613 RID: 1555
		// (Invoke) Token: 0x06002D56 RID: 11606
		[Token(Token = "0x2000613")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE168(Light target, float endValue, float duration);

		// Token: 0x02000614 RID: 1556
		// (Invoke) Token: 0x06002D5A RID: 11610
		[Token(Token = "0x2000614")]
		private delegate Tweener __GEN_DELEGATE169(LineRenderer target, Color2 startValue, Color2 endValue, float duration);

		// Token: 0x02000615 RID: 1557
		// (Invoke) Token: 0x06002D5E RID: 11614
		[Token(Token = "0x2000615")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE170(Material target, Color endValue, float duration);

		// Token: 0x02000616 RID: 1558
		// (Invoke) Token: 0x06002D62 RID: 11618
		[Token(Token = "0x2000616")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE171(Material target, Color endValue, string property, float duration);

		// Token: 0x02000617 RID: 1559
		// (Invoke) Token: 0x06002D66 RID: 11622
		[Token(Token = "0x2000617")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE172(Material target, Color endValue, int propertyID, float duration);

		// Token: 0x02000618 RID: 1560
		// (Invoke) Token: 0x06002D6A RID: 11626
		[Token(Token = "0x2000618")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE173(Material target, float endValue, float duration);

		// Token: 0x02000619 RID: 1561
		// (Invoke) Token: 0x06002D6E RID: 11630
		[Token(Token = "0x2000619")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE174(Material target, float endValue, string property, float duration);

		// Token: 0x0200061A RID: 1562
		// (Invoke) Token: 0x06002D72 RID: 11634
		[Token(Token = "0x200061A")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE175(Material target, float endValue, int propertyID, float duration);

		// Token: 0x0200061B RID: 1563
		// (Invoke) Token: 0x06002D76 RID: 11638
		[Token(Token = "0x200061B")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE176(Material target, float endValue, string property, float duration);

		// Token: 0x0200061C RID: 1564
		// (Invoke) Token: 0x06002D7A RID: 11642
		[Token(Token = "0x200061C")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE177(Material target, float endValue, int propertyID, float duration);

		// Token: 0x0200061D RID: 1565
		// (Invoke) Token: 0x06002D7E RID: 11646
		[Token(Token = "0x200061D")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE178(Material target, Vector2 endValue, float duration);

		// Token: 0x0200061E RID: 1566
		// (Invoke) Token: 0x06002D82 RID: 11650
		[Token(Token = "0x200061E")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE179(Material target, Vector2 endValue, string property, float duration);

		// Token: 0x0200061F RID: 1567
		// (Invoke) Token: 0x06002D86 RID: 11654
		[Token(Token = "0x200061F")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE180(Material target, Vector2 endValue, float duration);

		// Token: 0x02000620 RID: 1568
		// (Invoke) Token: 0x06002D8A RID: 11658
		[Token(Token = "0x2000620")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE181(Material target, Vector2 endValue, string property, float duration);

		// Token: 0x02000621 RID: 1569
		// (Invoke) Token: 0x06002D8E RID: 11662
		[Token(Token = "0x2000621")]
		private delegate TweenerCore<Vector4, Vector4, VectorOptions> __GEN_DELEGATE182(Material target, Vector4 endValue, string property, float duration);

		// Token: 0x02000622 RID: 1570
		// (Invoke) Token: 0x06002D92 RID: 11666
		[Token(Token = "0x2000622")]
		private delegate TweenerCore<Vector4, Vector4, VectorOptions> __GEN_DELEGATE183(Material target, Vector4 endValue, int propertyID, float duration);

		// Token: 0x02000623 RID: 1571
		// (Invoke) Token: 0x06002D96 RID: 11670
		[Token(Token = "0x2000623")]
		private delegate Tweener __GEN_DELEGATE184(TrailRenderer target, float toStartWidth, float toEndWidth, float duration);

		// Token: 0x02000624 RID: 1572
		// (Invoke) Token: 0x06002D9A RID: 11674
		[Token(Token = "0x2000624")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE185(TrailRenderer target, float endValue, float duration);

		// Token: 0x02000625 RID: 1573
		// (Invoke) Token: 0x06002D9E RID: 11678
		[Token(Token = "0x2000625")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE186(Transform target, Vector3 endValue, float duration, bool snapping);

		// Token: 0x02000626 RID: 1574
		// (Invoke) Token: 0x06002DA2 RID: 11682
		[Token(Token = "0x2000626")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE187(Transform target, float endValue, float duration, bool snapping);

		// Token: 0x02000627 RID: 1575
		// (Invoke) Token: 0x06002DA6 RID: 11686
		[Token(Token = "0x2000627")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE188(Transform target, float endValue, float duration, bool snapping);

		// Token: 0x02000628 RID: 1576
		// (Invoke) Token: 0x06002DAA RID: 11690
		[Token(Token = "0x2000628")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE189(Transform target, float endValue, float duration, bool snapping);

		// Token: 0x02000629 RID: 1577
		// (Invoke) Token: 0x06002DAE RID: 11694
		[Token(Token = "0x2000629")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE190(Transform target, Vector3 endValue, float duration, bool snapping);

		// Token: 0x0200062A RID: 1578
		// (Invoke) Token: 0x06002DB2 RID: 11698
		[Token(Token = "0x200062A")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE191(Transform target, float endValue, float duration, bool snapping);

		// Token: 0x0200062B RID: 1579
		// (Invoke) Token: 0x06002DB6 RID: 11702
		[Token(Token = "0x200062B")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE192(Transform target, float endValue, float duration, bool snapping);

		// Token: 0x0200062C RID: 1580
		// (Invoke) Token: 0x06002DBA RID: 11706
		[Token(Token = "0x200062C")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE193(Transform target, float endValue, float duration, bool snapping);

		// Token: 0x0200062D RID: 1581
		// (Invoke) Token: 0x06002DBE RID: 11710
		[Token(Token = "0x200062D")]
		private delegate TweenerCore<Quaternion, Vector3, QuaternionOptions> __GEN_DELEGATE194(Transform target, Vector3 endValue, float duration, RotateMode mode);

		// Token: 0x0200062E RID: 1582
		// (Invoke) Token: 0x06002DC2 RID: 11714
		[Token(Token = "0x200062E")]
		private delegate TweenerCore<Quaternion, Quaternion, NoOptions> __GEN_DELEGATE195(Transform target, Quaternion endValue, float duration);

		// Token: 0x0200062F RID: 1583
		// (Invoke) Token: 0x06002DC6 RID: 11718
		[Token(Token = "0x200062F")]
		private delegate TweenerCore<Quaternion, Vector3, QuaternionOptions> __GEN_DELEGATE196(Transform target, Vector3 endValue, float duration, RotateMode mode);

		// Token: 0x02000630 RID: 1584
		// (Invoke) Token: 0x06002DCA RID: 11722
		[Token(Token = "0x2000630")]
		private delegate TweenerCore<Quaternion, Quaternion, NoOptions> __GEN_DELEGATE197(Transform target, Quaternion endValue, float duration);

		// Token: 0x02000631 RID: 1585
		// (Invoke) Token: 0x06002DCE RID: 11726
		[Token(Token = "0x2000631")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE198(Transform target, Vector3 endValue, float duration);

		// Token: 0x02000632 RID: 1586
		// (Invoke) Token: 0x06002DD2 RID: 11730
		[Token(Token = "0x2000632")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE199(Transform target, float endValue, float duration);

		// Token: 0x02000633 RID: 1587
		// (Invoke) Token: 0x06002DD6 RID: 11734
		[Token(Token = "0x2000633")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE200(Transform target, float endValue, float duration);

		// Token: 0x02000634 RID: 1588
		// (Invoke) Token: 0x06002DDA RID: 11738
		[Token(Token = "0x2000634")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE201(Transform target, float endValue, float duration);

		// Token: 0x02000635 RID: 1589
		// (Invoke) Token: 0x06002DDE RID: 11742
		[Token(Token = "0x2000635")]
		private delegate TweenerCore<Vector3, Vector3, VectorOptions> __GEN_DELEGATE202(Transform target, float endValue, float duration);

		// Token: 0x02000636 RID: 1590
		// (Invoke) Token: 0x06002DE2 RID: 11746
		[Token(Token = "0x2000636")]
		private delegate Tweener __GEN_DELEGATE203(Transform target, Vector3 towards, float duration, AxisConstraint axisConstraint, Vector3? up);

		// Token: 0x02000637 RID: 1591
		// (Invoke) Token: 0x06002DE6 RID: 11750
		[Token(Token = "0x2000637")]
		private delegate Tweener __GEN_DELEGATE204(Transform target, Vector3 punch, float duration, int vibrato, float elasticity, bool snapping);

		// Token: 0x02000638 RID: 1592
		// (Invoke) Token: 0x06002DEA RID: 11754
		[Token(Token = "0x2000638")]
		private delegate Tweener __GEN_DELEGATE205(Transform target, Vector3 punch, float duration, int vibrato, float elasticity);

		// Token: 0x02000639 RID: 1593
		// (Invoke) Token: 0x06002DEE RID: 11758
		[Token(Token = "0x2000639")]
		private delegate Tweener __GEN_DELEGATE206(Transform target, Vector3 punch, float duration, int vibrato, float elasticity);

		// Token: 0x0200063A RID: 1594
		// (Invoke) Token: 0x06002DF2 RID: 11762
		[Token(Token = "0x200063A")]
		private delegate Tweener __GEN_DELEGATE207(Transform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut);

		// Token: 0x0200063B RID: 1595
		// (Invoke) Token: 0x06002DF6 RID: 11766
		[Token(Token = "0x200063B")]
		private delegate Tweener __GEN_DELEGATE208(Transform target, float duration, Vector3 strength, int vibrato, float randomness, bool snapping, bool fadeOut);

		// Token: 0x0200063C RID: 1596
		// (Invoke) Token: 0x06002DFA RID: 11770
		[Token(Token = "0x200063C")]
		private delegate Tweener __GEN_DELEGATE209(Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut);

		// Token: 0x0200063D RID: 1597
		// (Invoke) Token: 0x06002DFE RID: 11774
		[Token(Token = "0x200063D")]
		private delegate Tweener __GEN_DELEGATE210(Transform target, float duration, Vector3 strength, int vibrato, float randomness, bool fadeOut);

		// Token: 0x0200063E RID: 1598
		// (Invoke) Token: 0x06002E02 RID: 11778
		[Token(Token = "0x200063E")]
		private delegate Tweener __GEN_DELEGATE211(Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut);

		// Token: 0x0200063F RID: 1599
		// (Invoke) Token: 0x06002E06 RID: 11782
		[Token(Token = "0x200063F")]
		private delegate Tweener __GEN_DELEGATE212(Transform target, float duration, Vector3 strength, int vibrato, float randomness, bool fadeOut);

		// Token: 0x02000640 RID: 1600
		// (Invoke) Token: 0x06002E0A RID: 11786
		[Token(Token = "0x2000640")]
		private delegate Sequence __GEN_DELEGATE213(Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);

		// Token: 0x02000641 RID: 1601
		// (Invoke) Token: 0x06002E0E RID: 11790
		[Token(Token = "0x2000641")]
		private delegate Sequence __GEN_DELEGATE214(Transform target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);

		// Token: 0x02000642 RID: 1602
		// (Invoke) Token: 0x06002E12 RID: 11794
		[Token(Token = "0x2000642")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE215(Transform target, Vector3[] path, float duration, PathType pathType, PathMode pathMode, int resolution, Color? gizmoColor);

		// Token: 0x02000643 RID: 1603
		// (Invoke) Token: 0x06002E16 RID: 11798
		[Token(Token = "0x2000643")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE216(Transform target, Vector3[] path, float duration, PathType pathType, PathMode pathMode, int resolution, Color? gizmoColor);

		// Token: 0x02000644 RID: 1604
		// (Invoke) Token: 0x06002E1A RID: 11802
		[Token(Token = "0x2000644")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE217(Transform target, Path path, float duration, PathMode pathMode);

		// Token: 0x02000645 RID: 1605
		// (Invoke) Token: 0x06002E1E RID: 11806
		[Token(Token = "0x2000645")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE218(Transform target, Path path, float duration, PathMode pathMode);

		// Token: 0x02000646 RID: 1606
		// (Invoke) Token: 0x06002E22 RID: 11810
		[Token(Token = "0x2000646")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE219(Tween target, float endValue, float duration);

		// Token: 0x02000647 RID: 1607
		// (Invoke) Token: 0x06002E26 RID: 11814
		[Token(Token = "0x2000647")]
		private delegate Tweener __GEN_DELEGATE220(Light target, Color endValue, float duration);

		// Token: 0x02000648 RID: 1608
		// (Invoke) Token: 0x06002E2A RID: 11818
		[Token(Token = "0x2000648")]
		private delegate Tweener __GEN_DELEGATE221(Material target, Color endValue, float duration);

		// Token: 0x02000649 RID: 1609
		// (Invoke) Token: 0x06002E2E RID: 11822
		[Token(Token = "0x2000649")]
		private delegate Tweener __GEN_DELEGATE222(Material target, Color endValue, string property, float duration);

		// Token: 0x0200064A RID: 1610
		// (Invoke) Token: 0x06002E32 RID: 11826
		[Token(Token = "0x200064A")]
		private delegate Tweener __GEN_DELEGATE223(Material target, Color endValue, int propertyID, float duration);

		// Token: 0x0200064B RID: 1611
		// (Invoke) Token: 0x06002E36 RID: 11830
		[Token(Token = "0x200064B")]
		private delegate Tweener __GEN_DELEGATE224(Transform target, Vector3 byValue, float duration, bool snapping);

		// Token: 0x0200064C RID: 1612
		// (Invoke) Token: 0x06002E3A RID: 11834
		[Token(Token = "0x200064C")]
		private delegate Tweener __GEN_DELEGATE225(Transform target, Vector3 byValue, float duration, bool snapping);

		// Token: 0x0200064D RID: 1613
		// (Invoke) Token: 0x06002E3E RID: 11838
		[Token(Token = "0x200064D")]
		private delegate Tweener __GEN_DELEGATE226(Transform target, Vector3 byValue, float duration, RotateMode mode);

		// Token: 0x0200064E RID: 1614
		// (Invoke) Token: 0x06002E42 RID: 11842
		[Token(Token = "0x200064E")]
		private delegate Tweener __GEN_DELEGATE227(Transform target, Vector3 byValue, float duration, RotateMode mode);

		// Token: 0x0200064F RID: 1615
		// (Invoke) Token: 0x06002E46 RID: 11846
		[Token(Token = "0x200064F")]
		private delegate Tweener __GEN_DELEGATE228(Transform target, Vector3 punch, float duration, int vibrato, float elasticity);

		// Token: 0x02000650 RID: 1616
		// (Invoke) Token: 0x06002E4A RID: 11850
		[Token(Token = "0x2000650")]
		private delegate Tweener __GEN_DELEGATE229(Transform target, Vector3 byValue, float duration);

		// Token: 0x02000651 RID: 1617
		// (Invoke) Token: 0x06002E4E RID: 11854
		[Token(Token = "0x2000651")]
		private delegate int __GEN_DELEGATE230(Component target, bool withCallbacks);

		// Token: 0x02000652 RID: 1618
		// (Invoke) Token: 0x06002E52 RID: 11858
		[Token(Token = "0x2000652")]
		private delegate int __GEN_DELEGATE231(Material target, bool withCallbacks);

		// Token: 0x02000653 RID: 1619
		// (Invoke) Token: 0x06002E56 RID: 11862
		[Token(Token = "0x2000653")]
		private delegate int __GEN_DELEGATE232(Component target, bool complete);

		// Token: 0x02000654 RID: 1620
		// (Invoke) Token: 0x06002E5A RID: 11866
		[Token(Token = "0x2000654")]
		private delegate int __GEN_DELEGATE233(Material target, bool complete);

		// Token: 0x02000655 RID: 1621
		// (Invoke) Token: 0x06002E5E RID: 11870
		[Token(Token = "0x2000655")]
		private delegate int __GEN_DELEGATE234(Component target);

		// Token: 0x02000656 RID: 1622
		// (Invoke) Token: 0x06002E62 RID: 11874
		[Token(Token = "0x2000656")]
		private delegate int __GEN_DELEGATE235(Material target);

		// Token: 0x02000657 RID: 1623
		// (Invoke) Token: 0x06002E66 RID: 11878
		[Token(Token = "0x2000657")]
		private delegate int __GEN_DELEGATE236(Component target, float to, bool andPlay);

		// Token: 0x02000658 RID: 1624
		// (Invoke) Token: 0x06002E6A RID: 11882
		[Token(Token = "0x2000658")]
		private delegate int __GEN_DELEGATE237(Material target, float to, bool andPlay);

		// Token: 0x02000659 RID: 1625
		// (Invoke) Token: 0x06002E6E RID: 11886
		[Token(Token = "0x2000659")]
		private delegate int __GEN_DELEGATE238(Component target);

		// Token: 0x0200065A RID: 1626
		// (Invoke) Token: 0x06002E72 RID: 11890
		[Token(Token = "0x200065A")]
		private delegate int __GEN_DELEGATE239(Material target);

		// Token: 0x0200065B RID: 1627
		// (Invoke) Token: 0x06002E76 RID: 11894
		[Token(Token = "0x200065B")]
		private delegate int __GEN_DELEGATE240(Component target);

		// Token: 0x0200065C RID: 1628
		// (Invoke) Token: 0x06002E7A RID: 11898
		[Token(Token = "0x200065C")]
		private delegate int __GEN_DELEGATE241(Material target);

		// Token: 0x0200065D RID: 1629
		// (Invoke) Token: 0x06002E7E RID: 11902
		[Token(Token = "0x200065D")]
		private delegate int __GEN_DELEGATE242(Component target);

		// Token: 0x0200065E RID: 1630
		// (Invoke) Token: 0x06002E82 RID: 11906
		[Token(Token = "0x200065E")]
		private delegate int __GEN_DELEGATE243(Material target);

		// Token: 0x0200065F RID: 1631
		// (Invoke) Token: 0x06002E86 RID: 11910
		[Token(Token = "0x200065F")]
		private delegate int __GEN_DELEGATE244(Component target);

		// Token: 0x02000660 RID: 1632
		// (Invoke) Token: 0x06002E8A RID: 11914
		[Token(Token = "0x2000660")]
		private delegate int __GEN_DELEGATE245(Material target);

		// Token: 0x02000661 RID: 1633
		// (Invoke) Token: 0x06002E8E RID: 11918
		[Token(Token = "0x2000661")]
		private delegate int __GEN_DELEGATE246(Component target, bool includeDelay);

		// Token: 0x02000662 RID: 1634
		// (Invoke) Token: 0x06002E92 RID: 11922
		[Token(Token = "0x2000662")]
		private delegate int __GEN_DELEGATE247(Material target, bool includeDelay);

		// Token: 0x02000663 RID: 1635
		// (Invoke) Token: 0x06002E96 RID: 11926
		[Token(Token = "0x2000663")]
		private delegate int __GEN_DELEGATE248(Component target, bool includeDelay);

		// Token: 0x02000664 RID: 1636
		// (Invoke) Token: 0x06002E9A RID: 11930
		[Token(Token = "0x2000664")]
		private delegate int __GEN_DELEGATE249(Material target, bool includeDelay);

		// Token: 0x02000665 RID: 1637
		// (Invoke) Token: 0x06002E9E RID: 11934
		[Token(Token = "0x2000665")]
		private delegate int __GEN_DELEGATE250(Component target);

		// Token: 0x02000666 RID: 1638
		// (Invoke) Token: 0x06002EA2 RID: 11938
		[Token(Token = "0x2000666")]
		private delegate int __GEN_DELEGATE251(Material target);

		// Token: 0x02000667 RID: 1639
		// (Invoke) Token: 0x06002EA6 RID: 11942
		[Token(Token = "0x2000667")]
		private delegate int __GEN_DELEGATE252(Component target);

		// Token: 0x02000668 RID: 1640
		// (Invoke) Token: 0x06002EAA RID: 11946
		[Token(Token = "0x2000668")]
		private delegate int __GEN_DELEGATE253(Material target);

		// Token: 0x02000669 RID: 1641
		// (Invoke) Token: 0x06002EAE RID: 11950
		[Token(Token = "0x2000669")]
		private delegate bool __GEN_DELEGATE254(Object o);

		// Token: 0x0200066A RID: 1642
		// (Invoke) Token: 0x06002EB2 RID: 11954
		[Token(Token = "0x200066A")]
		private delegate void __GEN_DELEGATE255(GameObject prefab);

		// Token: 0x0200066B RID: 1643
		// (Invoke) Token: 0x06002EB6 RID: 11958
		[Token(Token = "0x200066B")]
		private delegate GameObject __GEN_DELEGATE256(GameObject prefab);

		// Token: 0x0200066C RID: 1644
		// (Invoke) Token: 0x06002EBA RID: 11962
		[Token(Token = "0x200066C")]
		private delegate GameObject __GEN_DELEGATE257(GameObject prefab, Transform parent);

		// Token: 0x0200066D RID: 1645
		// (Invoke) Token: 0x06002EBE RID: 11966
		[Token(Token = "0x200066D")]
		private delegate void __GEN_DELEGATE258(GameObject obj);

		// Token: 0x0200066E RID: 1646
		// (Invoke) Token: 0x06002EC2 RID: 11970
		[Token(Token = "0x200066E")]
		private delegate void __GEN_DELEGATE259(GameObject prefab);

		// Token: 0x0200066F RID: 1647
		// (Invoke) Token: 0x06002EC6 RID: 11974
		[Token(Token = "0x200066F")]
		private delegate Component __GEN_DELEGATE260(Component comp, Type type, bool set_enable);

		// Token: 0x02000670 RID: 1648
		// (Invoke) Token: 0x06002ECA RID: 11978
		[Token(Token = "0x2000670")]
		private delegate Component __GEN_DELEGATE261(GameObject go, Type type, bool set_enable);

		// Token: 0x02000671 RID: 1649
		// (Invoke) Token: 0x06002ECE RID: 11982
		[Token(Token = "0x2000671")]
		private delegate void __GEN_DELEGATE262(ScrollRect scrollRect);

		// Token: 0x02000672 RID: 1650
		// (Invoke) Token: 0x06002ED2 RID: 11986
		[Token(Token = "0x2000672")]
		private delegate void __GEN_DELEGATE263(ScrollView scrollView);

		// Token: 0x02000673 RID: 1651
		// (Invoke) Token: 0x06002ED6 RID: 11990
		[Token(Token = "0x2000673")]
		private delegate Transform __GEN_DELEGATE264(Transform parent, string childName, Vector3 position, Vector3 roll);

		// Token: 0x02000674 RID: 1652
		// (Invoke) Token: 0x06002EDA RID: 11994
		[Token(Token = "0x2000674")]
		private delegate Transform __GEN_DELEGATE265(Transform parent, string childName, Vector3 position, Quaternion rotation);

		// Token: 0x02000675 RID: 1653
		// (Invoke) Token: 0x06002EDE RID: 11998
		[Token(Token = "0x2000675")]
		private delegate Transform __GEN_DELEGATE266(Transform parent, string childName);

		// Token: 0x02000676 RID: 1654
		// (Invoke) Token: 0x06002EE2 RID: 12002
		[Token(Token = "0x2000676")]
		private delegate void __GEN_DELEGATE267(Image image, string uid, string pic, int picVer);

		// Token: 0x02000677 RID: 1655
		// (Invoke) Token: 0x06002EE6 RID: 12006
		[Token(Token = "0x2000677")]
		private delegate void __GEN_DELEGATE268(Image image, string cacheKey, string smallCacheKey, string default_sprite, Action<string, string> callBack, int width, int height, int widthSmall, int heightSmall, int reqType);

		// Token: 0x02000678 RID: 1656
		// (Invoke) Token: 0x06002EEA RID: 12010
		[Token(Token = "0x2000678")]
		private delegate void __GEN_DELEGATE269(Image image, string default_sprite);

		// Token: 0x02000679 RID: 1657
		// (Invoke) Token: 0x06002EEE RID: 12014
		[Token(Token = "0x2000679")]
		private delegate void __GEN_DELEGATE270(Image image, string url, string cacheKey, string defaultSprite, string cacheFolder, string smallCacheKey, Action<string, string> callBack, int width, int height, int widthSmall, int heightSmall);

		// Token: 0x0200067A RID: 1658
		// (Invoke) Token: 0x06002EF2 RID: 12018
		[Token(Token = "0x200067A")]
		private delegate void __GEN_DELEGATE271(UnityEventBase ev);

		// Token: 0x0200067B RID: 1659
		// (Invoke) Token: 0x06002EF6 RID: 12022
		[Token(Token = "0x200067B")]
		private delegate void __GEN_DELEGATE272(Image image, string spritePath, string defaultSprite);

		// Token: 0x0200067C RID: 1660
		// (Invoke) Token: 0x06002EFA RID: 12026
		[Token(Token = "0x200067C")]
		private delegate void __GEN_DELEGATE273(CircleImage image, string spritePath, string defaultSprite);

		// Token: 0x0200067D RID: 1661
		// (Invoke) Token: 0x06002EFE RID: 12030
		[Token(Token = "0x200067D")]
		private delegate void __GEN_DELEGATE274(SpriteRenderer spriteRenderer, string spritePath, string defaultSprite);

		// Token: 0x0200067E RID: 1662
		// (Invoke) Token: 0x06002F02 RID: 12034
		[Token(Token = "0x200067E")]
		private delegate void __GEN_DELEGATE275(SpriteMask spriteMask, string spritePath, string defaultSprite);

		// Token: 0x0200067F RID: 1663
		// (Invoke) Token: 0x06002F06 RID: 12038
		[Token(Token = "0x200067F")]
		private delegate void __GEN_DELEGATE276(SpriteMeshRenderer meshRenderer, string spritePath, string defaultSprite);

		// Token: 0x02000680 RID: 1664
		// (Invoke) Token: 0x06002F0A RID: 12042
		[Token(Token = "0x2000680")]
		private delegate void __GEN_DELEGATE277(ScrollRect scrollRect, float ratio);

		// Token: 0x02000681 RID: 1665
		// (Invoke) Token: 0x06002F0E RID: 12046
		[Token(Token = "0x2000681")]
		private delegate float __GEN_DELEGATE278(ScrollRect scrollRect);

		// Token: 0x02000682 RID: 1666
		// (Invoke) Token: 0x06002F12 RID: 12050
		[Token(Token = "0x2000682")]
		private delegate bool __GEN_DELEGATE279(string str);

		// Token: 0x02000683 RID: 1667
		// (Invoke) Token: 0x06002F16 RID: 12054
		[Token(Token = "0x2000683")]
		private delegate bool __GEN_DELEGATE280(string value);

		// Token: 0x02000684 RID: 1668
		// (Invoke) Token: 0x06002F1A RID: 12058
		[Token(Token = "0x2000684")]
		private delegate string __GEN_DELEGATE281(string str);

		// Token: 0x02000685 RID: 1669
		// (Invoke) Token: 0x06002F1E RID: 12062
		[Token(Token = "0x2000685")]
		private delegate string __GEN_DELEGATE282(string path, char separator);

		// Token: 0x02000686 RID: 1670
		// (Invoke) Token: 0x06002F22 RID: 12066
		[Token(Token = "0x2000686")]
		private delegate string __GEN_DELEGATE283(string path, char separator);

		// Token: 0x02000687 RID: 1671
		// (Invoke) Token: 0x06002F26 RID: 12070
		[Token(Token = "0x2000687")]
		private delegate int __GEN_DELEGATE284(string sourceStr);

		// Token: 0x02000688 RID: 1672
		// (Invoke) Token: 0x06002F2A RID: 12074
		[Token(Token = "0x2000688")]
		private delegate string __GEN_DELEGATE285(string sourceStr, int len);

		// Token: 0x02000689 RID: 1673
		// (Invoke) Token: 0x06002F2E RID: 12078
		[Token(Token = "0x2000689")]
		private delegate void __GEN_DELEGATE286(Quaternion q, out float x, out float y, out float z);

		// Token: 0x0200068A RID: 1674
		// (Invoke) Token: 0x06002F32 RID: 12082
		[Token(Token = "0x200068A")]
		private delegate bool __GEN_DELEGATE287(CharacterController cc, float x, float y, float z);

		// Token: 0x0200068B RID: 1675
		// (Invoke) Token: 0x06002F36 RID: 12086
		[Token(Token = "0x200068B")]
		private delegate void __GEN_DELEGATE288(CharacterController cc, float x, float y, float z);

		// Token: 0x0200068C RID: 1676
		// (Invoke) Token: 0x06002F3A RID: 12090
		[Token(Token = "0x200068C")]
		private delegate void __GEN_DELEGATE289(RectTransform rt, float x, float y);

		// Token: 0x0200068D RID: 1677
		// (Invoke) Token: 0x06002F3E RID: 12094
		[Token(Token = "0x200068D")]
		private delegate void __GEN_DELEGATE290(RectTransform rt, out float x, out float y);

		// Token: 0x0200068E RID: 1678
		// (Invoke) Token: 0x06002F42 RID: 12098
		[Token(Token = "0x200068E")]
		private delegate void __GEN_DELEGATE291(RectTransform rt, float x, float y);

		// Token: 0x0200068F RID: 1679
		// (Invoke) Token: 0x06002F46 RID: 12102
		[Token(Token = "0x200068F")]
		private delegate void __GEN_DELEGATE292(RectTransform rt, out float x, out float y);

		// Token: 0x02000690 RID: 1680
		// (Invoke) Token: 0x06002F4A RID: 12106
		[Token(Token = "0x2000690")]
		private delegate void __GEN_DELEGATE293(RectTransform rt, float x, float y);

		// Token: 0x02000691 RID: 1681
		// (Invoke) Token: 0x06002F4E RID: 12110
		[Token(Token = "0x2000691")]
		private delegate void __GEN_DELEGATE294(RectTransform rt, out float x, out float y);

		// Token: 0x02000692 RID: 1682
		// (Invoke) Token: 0x06002F52 RID: 12114
		[Token(Token = "0x2000692")]
		private delegate void __GEN_DELEGATE295(RectTransform rt, float x, float y);

		// Token: 0x02000693 RID: 1683
		// (Invoke) Token: 0x06002F56 RID: 12118
		[Token(Token = "0x2000693")]
		private delegate void __GEN_DELEGATE296(RectTransform rt, out float x, out float y);

		// Token: 0x02000694 RID: 1684
		// (Invoke) Token: 0x06002F5A RID: 12122
		[Token(Token = "0x2000694")]
		private delegate void __GEN_DELEGATE297(RectTransform rt, float x, float y);

		// Token: 0x02000695 RID: 1685
		// (Invoke) Token: 0x06002F5E RID: 12126
		[Token(Token = "0x2000695")]
		private delegate void __GEN_DELEGATE298(RectTransform rt, out float x, out float y);

		// Token: 0x02000696 RID: 1686
		// (Invoke) Token: 0x06002F62 RID: 12130
		[Token(Token = "0x2000696")]
		private delegate void __GEN_DELEGATE299(RectTransform rt, float x, float y, float z);

		// Token: 0x02000697 RID: 1687
		// (Invoke) Token: 0x06002F66 RID: 12134
		[Token(Token = "0x2000697")]
		private delegate void __GEN_DELEGATE300(RectTransform rt, out float x, out float y, out float z);

		// Token: 0x02000698 RID: 1688
		// (Invoke) Token: 0x06002F6A RID: 12138
		[Token(Token = "0x2000698")]
		private delegate void __GEN_DELEGATE301(RectTransform rt, float x, float y);

		// Token: 0x02000699 RID: 1689
		// (Invoke) Token: 0x06002F6E RID: 12142
		[Token(Token = "0x2000699")]
		private delegate void __GEN_DELEGATE302(RectTransform rt, out float x, out float y);

		// Token: 0x0200069A RID: 1690
		// (Invoke) Token: 0x06002F72 RID: 12146
		[Token(Token = "0x200069A")]
		private delegate void __GEN_DELEGATE303(RectTransform rt, float x, float y);

		// Token: 0x0200069B RID: 1691
		// (Invoke) Token: 0x06002F76 RID: 12150
		[Token(Token = "0x200069B")]
		private delegate void __GEN_DELEGATE304(RectTransform rt, float x);

		// Token: 0x0200069C RID: 1692
		// (Invoke) Token: 0x06002F7A RID: 12154
		[Token(Token = "0x200069C")]
		private delegate void __GEN_DELEGATE305(RectTransform rt, float y);

		// Token: 0x0200069D RID: 1693
		// (Invoke) Token: 0x06002F7E RID: 12158
		[Token(Token = "0x200069D")]
		private delegate void __GEN_DELEGATE306(RectTransform rt, out float x, out float y);

		// Token: 0x0200069E RID: 1694
		// (Invoke) Token: 0x06002F82 RID: 12162
		[Token(Token = "0x200069E")]
		private delegate void __GEN_DELEGATE307(RectTransform rt, out float x);

		// Token: 0x0200069F RID: 1695
		// (Invoke) Token: 0x06002F86 RID: 12166
		[Token(Token = "0x200069F")]
		private delegate void __GEN_DELEGATE308(RectTransform rt, out float y);

		// Token: 0x020006A0 RID: 1696
		// (Invoke) Token: 0x06002F8A RID: 12170
		[Token(Token = "0x20006A0")]
		private delegate void __GEN_DELEGATE309(Transform t, float x, float y, float z);

		// Token: 0x020006A1 RID: 1697
		// (Invoke) Token: 0x06002F8E RID: 12174
		[Token(Token = "0x20006A1")]
		private delegate void __GEN_DELEGATE310(Transform t, float x);

		// Token: 0x020006A2 RID: 1698
		// (Invoke) Token: 0x06002F92 RID: 12178
		[Token(Token = "0x20006A2")]
		private delegate void __GEN_DELEGATE311(Transform t, float x, float y, float z);

		// Token: 0x020006A3 RID: 1699
		// (Invoke) Token: 0x06002F96 RID: 12182
		[Token(Token = "0x20006A3")]
		private delegate void __GEN_DELEGATE312(Transform t, float x, float y, float z);

		// Token: 0x020006A4 RID: 1700
		// (Invoke) Token: 0x06002F9A RID: 12186
		[Token(Token = "0x20006A4")]
		private delegate void __GEN_DELEGATE313(Transform rt, out float x, out float y, out float z);

		// Token: 0x020006A5 RID: 1701
		// (Invoke) Token: 0x06002F9E RID: 12190
		[Token(Token = "0x20006A5")]
		private delegate void __GEN_DELEGATE314(Transform t, float x, float y, float z);

		// Token: 0x020006A6 RID: 1702
		// (Invoke) Token: 0x06002FA2 RID: 12194
		[Token(Token = "0x20006A6")]
		private delegate void __GEN_DELEGATE315(Transform rt, out float x, out float y, out float z);

		// Token: 0x020006A7 RID: 1703
		// (Invoke) Token: 0x06002FA6 RID: 12198
		[Token(Token = "0x20006A7")]
		private delegate void __GEN_DELEGATE316(Transform t, float x, float y, float z);

		// Token: 0x020006A8 RID: 1704
		// (Invoke) Token: 0x06002FAA RID: 12202
		[Token(Token = "0x20006A8")]
		private delegate void __GEN_DELEGATE317(Transform rt, out float x, out float y, out float z);

		// Token: 0x020006A9 RID: 1705
		// (Invoke) Token: 0x06002FAE RID: 12206
		[Token(Token = "0x20006A9")]
		private delegate void __GEN_DELEGATE318(Transform rt, out float x, out float y, out float z);

		// Token: 0x020006AA RID: 1706
		// (Invoke) Token: 0x06002FB2 RID: 12210
		[Token(Token = "0x20006AA")]
		private delegate void __GEN_DELEGATE319(Transform t, float x, float y, float z);

		// Token: 0x020006AB RID: 1707
		// (Invoke) Token: 0x06002FB6 RID: 12214
		[Token(Token = "0x20006AB")]
		private delegate void __GEN_DELEGATE320(Transform rt, out float x, out float y, out float z);

		// Token: 0x020006AC RID: 1708
		// (Invoke) Token: 0x06002FBA RID: 12218
		[Token(Token = "0x20006AC")]
		private delegate void __GEN_DELEGATE321(Transform t, float x, float y, float z);

		// Token: 0x020006AD RID: 1709
		// (Invoke) Token: 0x06002FBE RID: 12222
		[Token(Token = "0x20006AD")]
		private delegate void __GEN_DELEGATE322(Transform rt, out float x, out float y, out float z);

		// Token: 0x020006AE RID: 1710
		// (Invoke) Token: 0x06002FC2 RID: 12226
		[Token(Token = "0x20006AE")]
		private delegate void __GEN_DELEGATE323(Transform t, float x, float y, float z, float w);

		// Token: 0x020006AF RID: 1711
		// (Invoke) Token: 0x06002FC6 RID: 12230
		[Token(Token = "0x20006AF")]
		private delegate void __GEN_DELEGATE324(Transform t, out float x, out float y, out float z, out float w);

		// Token: 0x020006B0 RID: 1712
		// (Invoke) Token: 0x06002FCA RID: 12234
		[Token(Token = "0x20006B0")]
		private delegate void __GEN_DELEGATE325(Transform t, float x, float y, float z, float w);

		// Token: 0x020006B1 RID: 1713
		// (Invoke) Token: 0x06002FCE RID: 12238
		[Token(Token = "0x20006B1")]
		private delegate void __GEN_DELEGATE326(Transform t, out float x, out float y, out float z, out float w);

		// Token: 0x020006B2 RID: 1714
		// (Invoke) Token: 0x06002FD2 RID: 12242
		[Token(Token = "0x20006B2")]
		private delegate void __GEN_DELEGATE327(Transform t, float x, float y, float z);

		// Token: 0x020006B3 RID: 1715
		// (Invoke) Token: 0x06002FD6 RID: 12246
		[Token(Token = "0x20006B3")]
		private delegate void __GEN_DELEGATE328(Transform t, out float x, out float y, out float z);

		// Token: 0x020006B4 RID: 1716
		// (Invoke) Token: 0x06002FDA RID: 12250
		[Token(Token = "0x20006B4")]
		private delegate void __GEN_DELEGATE329(Transform rt, float x, float y, float z, float rx, float ry, float rz, float rw);

		// Token: 0x020006B5 RID: 1717
		// (Invoke) Token: 0x06002FDE RID: 12254
		[Token(Token = "0x20006B5")]
		private delegate void __GEN_DELEGATE330(GameObject go, float x, float y, float z);

		// Token: 0x020006B6 RID: 1718
		// (Invoke) Token: 0x06002FE2 RID: 12258
		[Token(Token = "0x20006B6")]
		private delegate void __GEN_DELEGATE331(GameObject go, out float x, out float y, out float z);

		// Token: 0x020006B7 RID: 1719
		// (Invoke) Token: 0x06002FE6 RID: 12262
		[Token(Token = "0x20006B7")]
		private delegate void __GEN_DELEGATE332(GameObject go, float x, float y, float z);

		// Token: 0x020006B8 RID: 1720
		// (Invoke) Token: 0x06002FEA RID: 12266
		[Token(Token = "0x20006B8")]
		private delegate void __GEN_DELEGATE333(GameObject go, out float x, out float y, out float z);

		// Token: 0x020006B9 RID: 1721
		// (Invoke) Token: 0x06002FEE RID: 12270
		[Token(Token = "0x20006B9")]
		private delegate void __GEN_DELEGATE334(GameObject go, float x, float y, float z);

		// Token: 0x020006BA RID: 1722
		// (Invoke) Token: 0x06002FF2 RID: 12274
		[Token(Token = "0x20006BA")]
		private delegate void __GEN_DELEGATE335(GameObject go, out float x, out float y, out float z);

		// Token: 0x020006BB RID: 1723
		// (Invoke) Token: 0x06002FF6 RID: 12278
		[Token(Token = "0x20006BB")]
		private delegate void __GEN_DELEGATE336(GameObject go, float x, float y, float z);

		// Token: 0x020006BC RID: 1724
		// (Invoke) Token: 0x06002FFA RID: 12282
		[Token(Token = "0x20006BC")]
		private delegate void __GEN_DELEGATE337(GameObject go, out float x, out float y, out float z);

		// Token: 0x020006BD RID: 1725
		// (Invoke) Token: 0x06002FFE RID: 12286
		[Token(Token = "0x20006BD")]
		private delegate void __GEN_DELEGATE338(GameObject go, float x, float y, float z);

		// Token: 0x020006BE RID: 1726
		// (Invoke) Token: 0x06003002 RID: 12290
		[Token(Token = "0x20006BE")]
		private delegate void __GEN_DELEGATE339(GameObject go, out float x, out float y, out float z);

		// Token: 0x020006BF RID: 1727
		// (Invoke) Token: 0x06003006 RID: 12294
		[Token(Token = "0x20006BF")]
		private delegate void __GEN_DELEGATE340(GameObject go, float x, float y, float z, float w);

		// Token: 0x020006C0 RID: 1728
		// (Invoke) Token: 0x0600300A RID: 12298
		[Token(Token = "0x20006C0")]
		private delegate void __GEN_DELEGATE341(GameObject go, out float x, out float y, out float z, out float w);

		// Token: 0x020006C1 RID: 1729
		// (Invoke) Token: 0x0600300E RID: 12302
		[Token(Token = "0x20006C1")]
		private delegate void __GEN_DELEGATE342(GameObject go, float x, float y, float z, float w);

		// Token: 0x020006C2 RID: 1730
		// (Invoke) Token: 0x06003012 RID: 12306
		[Token(Token = "0x20006C2")]
		private delegate void __GEN_DELEGATE343(GameObject go, out float x, out float y, out float z, out float w);

		// Token: 0x020006C3 RID: 1731
		// (Invoke) Token: 0x06003016 RID: 12310
		[Token(Token = "0x20006C3")]
		private delegate void __GEN_DELEGATE344(GameObject go, float x, float y, float z);

		// Token: 0x020006C4 RID: 1732
		// (Invoke) Token: 0x0600301A RID: 12314
		[Token(Token = "0x20006C4")]
		private delegate void __GEN_DELEGATE345(GameObject go, out float x, out float y, out float z);

		// Token: 0x020006C5 RID: 1733
		// (Invoke) Token: 0x0600301E RID: 12318
		[Token(Token = "0x20006C5")]
		private delegate void __GEN_DELEGATE346(GameObject go, float x, float y, float z, float rx, float ry, float rz, float rw);

		// Token: 0x020006C6 RID: 1734
		// (Invoke) Token: 0x06003022 RID: 12322
		[Token(Token = "0x20006C6")]
		private delegate void __GEN_DELEGATE347(Transform rt);

		// Token: 0x020006C7 RID: 1735
		// (Invoke) Token: 0x06003026 RID: 12326
		[Token(Token = "0x20006C7")]
		private delegate void __GEN_DELEGATE348(Transform rt);

		// Token: 0x020006C8 RID: 1736
		// (Invoke) Token: 0x0600302A RID: 12330
		[Token(Token = "0x20006C8")]
		private delegate void __GEN_DELEGATE349(GameObject go);

		// Token: 0x020006C9 RID: 1737
		// (Invoke) Token: 0x0600302E RID: 12334
		[Token(Token = "0x20006C9")]
		private delegate void __GEN_DELEGATE350(GameObject go);

		// Token: 0x020006CA RID: 1738
		// (Invoke) Token: 0x06003032 RID: 12338
		[Token(Token = "0x20006CA")]
		private delegate void __GEN_DELEGATE351(Graphic graphic, float r, float g, float b, float a);

		// Token: 0x020006CB RID: 1739
		// (Invoke) Token: 0x06003036 RID: 12342
		[Token(Token = "0x20006CB")]
		private delegate void __GEN_DELEGATE352(Graphic graphic, float r);

		// Token: 0x020006CC RID: 1740
		// (Invoke) Token: 0x0600303A RID: 12346
		[Token(Token = "0x20006CC")]
		private delegate void __GEN_DELEGATE353(Graphic graphic, float g);

		// Token: 0x020006CD RID: 1741
		// (Invoke) Token: 0x0600303E RID: 12350
		[Token(Token = "0x20006CD")]
		private delegate void __GEN_DELEGATE354(Graphic graphic, float b);

		// Token: 0x020006CE RID: 1742
		// (Invoke) Token: 0x06003042 RID: 12354
		[Token(Token = "0x20006CE")]
		private delegate void __GEN_DELEGATE355(Graphic graphic, float a);

		// Token: 0x020006CF RID: 1743
		// (Invoke) Token: 0x06003046 RID: 12358
		[Token(Token = "0x20006CF")]
		private delegate void __GEN_DELEGATE356(Graphic graphic, out float r, out float g, out float b, out float a);

		// Token: 0x020006D0 RID: 1744
		// (Invoke) Token: 0x0600304A RID: 12362
		[Token(Token = "0x20006D0")]
		private delegate void __GEN_DELEGATE357(Graphic graphic, out float r);

		// Token: 0x020006D1 RID: 1745
		// (Invoke) Token: 0x0600304E RID: 12366
		[Token(Token = "0x20006D1")]
		private delegate void __GEN_DELEGATE358(Graphic graphic, out float g);

		// Token: 0x020006D2 RID: 1746
		// (Invoke) Token: 0x06003052 RID: 12370
		[Token(Token = "0x20006D2")]
		private delegate void __GEN_DELEGATE359(Graphic graphic, out float b);

		// Token: 0x020006D3 RID: 1747
		// (Invoke) Token: 0x06003056 RID: 12374
		[Token(Token = "0x20006D3")]
		private delegate void __GEN_DELEGATE360(Graphic graphic, out float a);

		// Token: 0x020006D4 RID: 1748
		// (Invoke) Token: 0x0600305A RID: 12378
		[Token(Token = "0x20006D4")]
		private delegate void __GEN_DELEGATE361(SpriteRenderer r, float x, float y);

		// Token: 0x020006D5 RID: 1749
		// (Invoke) Token: 0x0600305E RID: 12382
		[Token(Token = "0x20006D5")]
		private delegate void __GEN_DELEGATE362(SpriteRenderer r, out float x, out float y);

		// Token: 0x020006D6 RID: 1750
		// (Invoke) Token: 0x06003062 RID: 12386
		[Token(Token = "0x20006D6")]
		private delegate void __GEN_DELEGATE363(SpriteRenderer sr, float r, float g, float b, float a);

		// Token: 0x020006D7 RID: 1751
		// (Invoke) Token: 0x06003066 RID: 12390
		[Token(Token = "0x20006D7")]
		private delegate void __GEN_DELEGATE364(SpriteRenderer sr, float r);

		// Token: 0x020006D8 RID: 1752
		// (Invoke) Token: 0x0600306A RID: 12394
		[Token(Token = "0x20006D8")]
		private delegate void __GEN_DELEGATE365(SpriteRenderer sr, float g);

		// Token: 0x020006D9 RID: 1753
		// (Invoke) Token: 0x0600306E RID: 12398
		[Token(Token = "0x20006D9")]
		private delegate void __GEN_DELEGATE366(SpriteRenderer sr, float b);

		// Token: 0x020006DA RID: 1754
		// (Invoke) Token: 0x06003072 RID: 12402
		[Token(Token = "0x20006DA")]
		private delegate void __GEN_DELEGATE367(SpriteRenderer sr, float a);

		// Token: 0x020006DB RID: 1755
		// (Invoke) Token: 0x06003076 RID: 12406
		[Token(Token = "0x20006DB")]
		private delegate void __GEN_DELEGATE368(SpriteMeshRenderer sr, float a);

		// Token: 0x020006DC RID: 1756
		// (Invoke) Token: 0x0600307A RID: 12410
		[Token(Token = "0x20006DC")]
		private delegate void __GEN_DELEGATE369(SpriteRenderer sr, out float r, out float g, out float b, out float a);

		// Token: 0x020006DD RID: 1757
		// (Invoke) Token: 0x0600307E RID: 12414
		[Token(Token = "0x20006DD")]
		private delegate void __GEN_DELEGATE370(SpriteRenderer sr, out float r);

		// Token: 0x020006DE RID: 1758
		// (Invoke) Token: 0x06003082 RID: 12418
		[Token(Token = "0x20006DE")]
		private delegate void __GEN_DELEGATE371(SpriteRenderer sr, out float g);

		// Token: 0x020006DF RID: 1759
		// (Invoke) Token: 0x06003086 RID: 12422
		[Token(Token = "0x20006DF")]
		private delegate void __GEN_DELEGATE372(SpriteRenderer sr, out float b);

		// Token: 0x020006E0 RID: 1760
		// (Invoke) Token: 0x0600308A RID: 12426
		[Token(Token = "0x20006E0")]
		private delegate void __GEN_DELEGATE373(SpriteRenderer sr, out float a);

		// Token: 0x020006E1 RID: 1761
		// (Invoke) Token: 0x0600308E RID: 12430
		[Token(Token = "0x20006E1")]
		private delegate void __GEN_DELEGATE374(MobileTouchCamera touchCamera, out float x, out float y, out float z);

		// Token: 0x020006E2 RID: 1762
		// (Invoke) Token: 0x06003092 RID: 12434
		[Token(Token = "0x20006E2")]
		private delegate void __GEN_DELEGATE375(TextMeshProUGUI text, string value);

		// Token: 0x020006E3 RID: 1763
		// (Invoke) Token: 0x06003096 RID: 12438
		[Token(Token = "0x20006E3")]
		private delegate void __GEN_DELEGATE376(TextMeshProUGUI text, int value);

		// Token: 0x020006E4 RID: 1764
		// (Invoke) Token: 0x0600309A RID: 12442
		[Token(Token = "0x20006E4")]
		private delegate void __GEN_DELEGATE377(TextMeshProUGUI text, int cacheID);

		// Token: 0x020006E5 RID: 1765
		// (Invoke) Token: 0x0600309E RID: 12446
		[Token(Token = "0x20006E5")]
		private delegate int __GEN_DELEGATE378(TextMeshProUGUI text);

		// Token: 0x020006E6 RID: 1766
		// (Invoke) Token: 0x060030A2 RID: 12450
		[Token(Token = "0x20006E6")]
		private delegate void __GEN_DELEGATE379(Text text, string value);

		// Token: 0x020006E7 RID: 1767
		// (Invoke) Token: 0x060030A6 RID: 12454
		[Token(Token = "0x20006E7")]
		private delegate void __GEN_DELEGATE380(Text text, int value);

		// Token: 0x020006E8 RID: 1768
		// (Invoke) Token: 0x060030AA RID: 12458
		[Token(Token = "0x20006E8")]
		private delegate void __GEN_DELEGATE381(Text text, int cacheID);

		// Token: 0x020006E9 RID: 1769
		// (Invoke) Token: 0x060030AE RID: 12462
		[Token(Token = "0x20006E9")]
		private delegate void __GEN_DELEGATE382(TMP_InputField text, string value);

		// Token: 0x020006EA RID: 1770
		// (Invoke) Token: 0x060030B2 RID: 12466
		[Token(Token = "0x20006EA")]
		private delegate void __GEN_DELEGATE383(TMP_InputField text, int value);

		// Token: 0x020006EB RID: 1771
		// (Invoke) Token: 0x060030B6 RID: 12470
		[Token(Token = "0x20006EB")]
		private delegate void __GEN_DELEGATE384(TMP_InputField text, int cacheID);

		// Token: 0x020006EC RID: 1772
		// (Invoke) Token: 0x060030BA RID: 12474
		[Token(Token = "0x20006EC")]
		private delegate void __GEN_DELEGATE385(SuperTextMesh text, string value);

		// Token: 0x020006ED RID: 1773
		// (Invoke) Token: 0x060030BE RID: 12478
		[Token(Token = "0x20006ED")]
		private delegate void __GEN_DELEGATE386(SuperTextMesh text, int value);

		// Token: 0x020006EE RID: 1774
		// (Invoke) Token: 0x060030C2 RID: 12482
		[Token(Token = "0x20006EE")]
		private delegate void __GEN_DELEGATE387(SuperTextMesh text, int cacheID);

		// Token: 0x020006EF RID: 1775
		// (Invoke) Token: 0x060030C6 RID: 12486
		[Token(Token = "0x20006EF")]
		private delegate void __GEN_DELEGATE388(NavMeshAgent agent, float x, float y, float z);

		// Token: 0x020006F0 RID: 1776
		// (Invoke) Token: 0x060030CA RID: 12490
		[Token(Token = "0x20006F0")]
		private delegate void __GEN_DELEGATE389(NavMeshAgent agent, out float x, out float y, out float z);

		// Token: 0x020006F1 RID: 1777
		// (Invoke) Token: 0x060030CE RID: 12494
		[Token(Token = "0x20006F1")]
		private delegate bool __GEN_DELEGATE390(NavMeshAgent agent);

		// Token: 0x020006F2 RID: 1778
		// (Invoke) Token: 0x060030D2 RID: 12498
		[Token(Token = "0x20006F2")]
		private delegate void __GEN_DELEGATE391(Camera camera, float x, float y, float z, out float ox, out float oy, out float oz);

		// Token: 0x020006F3 RID: 1779
		// (Invoke) Token: 0x060030D6 RID: 12502
		[Token(Token = "0x20006F3")]
		private delegate void __GEN_DELEGATE392(Camera camera, float x, float y, float z, out float ox, out float oy, out float oz);

		// Token: 0x020006F4 RID: 1780
		// (Invoke) Token: 0x060030DA RID: 12506
		[Token(Token = "0x20006F4")]
		private delegate void __GEN_DELEGATE393(Camera camera, float x, float y, float z, out float ox, out float oy, out float oz);

		// Token: 0x020006F5 RID: 1781
		// (Invoke) Token: 0x060030DE RID: 12510
		[Token(Token = "0x20006F5")]
		private delegate void __GEN_DELEGATE394(Camera camera, float x, float y, float z, out float ox, out float oy, out float oz);

		// Token: 0x020006F6 RID: 1782
		// (Invoke) Token: 0x060030E2 RID: 12514
		[Token(Token = "0x20006F6")]
		private delegate LoopListViewItem2 __GEN_DELEGATE395(LoopListView2 loopList, int itemPrefabNameCacheId);

		// Token: 0x020006F7 RID: 1783
		// (Invoke) Token: 0x060030E6 RID: 12518
		[Token(Token = "0x20006F7")]
		private delegate LoopListLazyViewItem2 __GEN_DELEGATE396(LoopListLazyView2 loopList, int itemPrefabNameCacheId);

		// Token: 0x020006F8 RID: 1784
		// (Invoke) Token: 0x060030EA RID: 12522
		[Token(Token = "0x20006F8")]
		private delegate void __GEN_DELEGATE397(MobileTouchCamera camera, out float x, out float y, out float z);

		// Token: 0x020006F9 RID: 1785
		// (Invoke) Token: 0x060030EE RID: 12526
		[Token(Token = "0x20006F9")]
		private delegate void __GEN_DELEGATE398(Transform tf, float targetPosX, float targetPosY, float targetPosZ, float upX, float upY, float upZ, out float x, out float y, out float z, out float w);

		// Token: 0x020006FA RID: 1786
		// (Invoke) Token: 0x060030F2 RID: 12530
		[Token(Token = "0x20006FA")]
		private delegate int __GEN_DELEGATE399(string str);

		// Token: 0x020006FB RID: 1787
		// (Invoke) Token: 0x060030F6 RID: 12534
		[Token(Token = "0x20006FB")]
		private delegate int __GEN_DELEGATE400(object obj);

		// Token: 0x020006FC RID: 1788
		// (Invoke) Token: 0x060030FA RID: 12538
		[Token(Token = "0x20006FC")]
		private delegate int __GEN_DELEGATE401(ReadOnlySpan<char> str);

		// Token: 0x020006FD RID: 1789
		// (Invoke) Token: 0x060030FE RID: 12542
		[Token(Token = "0x20006FD")]
		private delegate float __GEN_DELEGATE402(string str);

		// Token: 0x020006FE RID: 1790
		// (Invoke) Token: 0x06003102 RID: 12546
		[Token(Token = "0x20006FE")]
		private delegate string __GEN_DELEGATE403(Transform transform);

		// Token: 0x020006FF RID: 1791
		// (Invoke) Token: 0x06003106 RID: 12550
		[Token(Token = "0x20006FF")]
		private delegate void __GEN_DELEGATE404(RectTransform rectTransform, bool rebuildParent);

		// Token: 0x02000700 RID: 1792
		// (Invoke) Token: 0x0600310A RID: 12554
		[Token(Token = "0x2000700")]
		private delegate float __GEN_DELEGATE405(ReadOnlySpan<char> str);

		// Token: 0x02000701 RID: 1793
		// (Invoke) Token: 0x0600310E RID: 12558
		[Token(Token = "0x2000701")]
		private delegate ulong __GEN_DELEGATE406(ReadOnlySpan<char> str);

		// Token: 0x02000702 RID: 1794
		// (Invoke) Token: 0x06003112 RID: 12562
		[Token(Token = "0x2000702")]
		private delegate float __GEN_DELEGATE407(long value);

		// Token: 0x02000703 RID: 1795
		// (Invoke) Token: 0x06003116 RID: 12566
		[Token(Token = "0x2000703")]
		private delegate float __GEN_DELEGATE408(object obj);

		// Token: 0x02000704 RID: 1796
		// (Invoke) Token: 0x0600311A RID: 12570
		[Token(Token = "0x2000704")]
		private delegate long __GEN_DELEGATE409(string str);

		// Token: 0x02000705 RID: 1797
		// (Invoke) Token: 0x0600311E RID: 12574
		[Token(Token = "0x2000705")]
		private delegate GameObject __GEN_DELEGATE410(GameObject go);

		// Token: 0x02000706 RID: 1798
		// (Invoke) Token: 0x06003122 RID: 12578
		[Token(Token = "0x2000706")]
		private delegate void __GEN_DELEGATE411(GameObject go);

		// Token: 0x02000707 RID: 1799
		// (Invoke) Token: 0x06003126 RID: 12582
		[Token(Token = "0x2000707")]
		private delegate bool __GEN_DELEGATE412(GameObject gameObject);

		// Token: 0x02000708 RID: 1800
		// (Invoke) Token: 0x0600312A RID: 12586
		[Token(Token = "0x2000708")]
		private delegate void __GEN_DELEGATE413(GameObject gameObject, int layer);

		// Token: 0x02000709 RID: 1801
		// (Invoke) Token: 0x0600312E RID: 12590
		[Token(Token = "0x2000709")]
		private delegate void __GEN_DELEGATE414(Camera camera, string layerMask);

		// Token: 0x0200070A RID: 1802
		// (Invoke) Token: 0x06003132 RID: 12594
		[Token(Token = "0x200070A")]
		private delegate void __GEN_DELEGATE415(GameObject gameObject, string tag);

		// Token: 0x0200070B RID: 1803
		// (Invoke) Token: 0x06003136 RID: 12598
		[Token(Token = "0x200070B")]
		private delegate Vector2 __GEN_DELEGATE416(Vector3 vector3);

		// Token: 0x0200070C RID: 1804
		// (Invoke) Token: 0x0600313A RID: 12602
		[Token(Token = "0x200070C")]
		private delegate Vector3 __GEN_DELEGATE417(Vector2 vector2);

		// Token: 0x0200070D RID: 1805
		// (Invoke) Token: 0x0600313E RID: 12606
		[Token(Token = "0x200070D")]
		private delegate void __GEN_DELEGATE418(GameObject obj);

		// Token: 0x0200070E RID: 1806
		// (Invoke) Token: 0x06003142 RID: 12610
		[Token(Token = "0x200070E")]
		private delegate void __GEN_DELEGATE419(Text text, long leftMilliSecond);

		// Token: 0x0200070F RID: 1807
		// (Invoke) Token: 0x06003146 RID: 12614
		[Token(Token = "0x200070F")]
		private delegate void __GEN_DELEGATE420(Transform transform);

		// Token: 0x02000710 RID: 1808
		// (Invoke) Token: 0x0600314A RID: 12618
		[Token(Token = "0x2000710")]
		private delegate void __GEN_DELEGATE421(Volume volume, Vector2 center);

		// Token: 0x02000711 RID: 1809
		// (Invoke) Token: 0x0600314E RID: 12622
		[Token(Token = "0x2000711")]
		private delegate Component __GEN_DELEGATE422(Transform tran, string path, Type type);

		// Token: 0x02000712 RID: 1810
		// (Invoke) Token: 0x06003152 RID: 12626
		[Token(Token = "0x2000712")]
		private delegate Component __GEN_DELEGATE423(Transform tran);

		// Token: 0x02000713 RID: 1811
		// (Invoke) Token: 0x06003156 RID: 12630
		[Token(Token = "0x2000713")]
		private delegate Component __GEN_DELEGATE424(GameObject obj);

		// Token: 0x02000714 RID: 1812
		// (Invoke) Token: 0x0600315A RID: 12634
		[Token(Token = "0x2000714")]
		private delegate Component __GEN_DELEGATE425(Transform tran, string path);

		// Token: 0x02000715 RID: 1813
		// (Invoke) Token: 0x0600315E RID: 12638
		[Token(Token = "0x2000715")]
		private delegate Component __GEN_DELEGATE426(Transform tran, int pathId);

		// Token: 0x02000716 RID: 1814
		// (Invoke) Token: 0x06003162 RID: 12642
		[Token(Token = "0x2000716")]
		private delegate Component __GEN_DELEGATE427(Transform tran);

		// Token: 0x02000717 RID: 1815
		// (Invoke) Token: 0x06003166 RID: 12646
		[Token(Token = "0x2000717")]
		private delegate Component __GEN_DELEGATE428(GameObject obj);

		// Token: 0x02000718 RID: 1816
		// (Invoke) Token: 0x0600316A RID: 12650
		[Token(Token = "0x2000718")]
		private delegate Component __GEN_DELEGATE429(Transform tran, string path);

		// Token: 0x02000719 RID: 1817
		// (Invoke) Token: 0x0600316E RID: 12654
		[Token(Token = "0x2000719")]
		private delegate Component __GEN_DELEGATE430(Transform tran, int pathId);

		// Token: 0x0200071A RID: 1818
		// (Invoke) Token: 0x06003172 RID: 12658
		[Token(Token = "0x200071A")]
		private delegate Component __GEN_DELEGATE431(Transform tran);

		// Token: 0x0200071B RID: 1819
		// (Invoke) Token: 0x06003176 RID: 12662
		[Token(Token = "0x200071B")]
		private delegate Component __GEN_DELEGATE432(GameObject obj);

		// Token: 0x0200071C RID: 1820
		// (Invoke) Token: 0x0600317A RID: 12666
		[Token(Token = "0x200071C")]
		private delegate Component __GEN_DELEGATE433(Transform tran, string path);

		// Token: 0x0200071D RID: 1821
		// (Invoke) Token: 0x0600317E RID: 12670
		[Token(Token = "0x200071D")]
		private delegate Component __GEN_DELEGATE434(Transform tran, int pathId);

		// Token: 0x0200071E RID: 1822
		// (Invoke) Token: 0x06003182 RID: 12674
		[Token(Token = "0x200071E")]
		private delegate Component __GEN_DELEGATE435(Transform tran);

		// Token: 0x0200071F RID: 1823
		// (Invoke) Token: 0x06003186 RID: 12678
		[Token(Token = "0x200071F")]
		private delegate Component __GEN_DELEGATE436(GameObject obj);

		// Token: 0x02000720 RID: 1824
		// (Invoke) Token: 0x0600318A RID: 12682
		[Token(Token = "0x2000720")]
		private delegate Component __GEN_DELEGATE437(Transform tran, string path);

		// Token: 0x02000721 RID: 1825
		// (Invoke) Token: 0x0600318E RID: 12686
		[Token(Token = "0x2000721")]
		private delegate Component __GEN_DELEGATE438(Transform tran, int pathId);

		// Token: 0x02000722 RID: 1826
		// (Invoke) Token: 0x06003192 RID: 12690
		[Token(Token = "0x2000722")]
		private delegate Component __GEN_DELEGATE439(Transform tran);

		// Token: 0x02000723 RID: 1827
		// (Invoke) Token: 0x06003196 RID: 12694
		[Token(Token = "0x2000723")]
		private delegate Component __GEN_DELEGATE440(GameObject obj);

		// Token: 0x02000724 RID: 1828
		// (Invoke) Token: 0x0600319A RID: 12698
		[Token(Token = "0x2000724")]
		private delegate Component __GEN_DELEGATE441(Transform tran, string path);

		// Token: 0x02000725 RID: 1829
		// (Invoke) Token: 0x0600319E RID: 12702
		[Token(Token = "0x2000725")]
		private delegate Component __GEN_DELEGATE442(Transform tran, int pathId);

		// Token: 0x02000726 RID: 1830
		// (Invoke) Token: 0x060031A2 RID: 12706
		[Token(Token = "0x2000726")]
		private delegate Component __GEN_DELEGATE443(Transform tran);

		// Token: 0x02000727 RID: 1831
		// (Invoke) Token: 0x060031A6 RID: 12710
		[Token(Token = "0x2000727")]
		private delegate Component __GEN_DELEGATE444(GameObject obj);

		// Token: 0x02000728 RID: 1832
		// (Invoke) Token: 0x060031AA RID: 12714
		[Token(Token = "0x2000728")]
		private delegate Component __GEN_DELEGATE445(Transform tran, string path);

		// Token: 0x02000729 RID: 1833
		// (Invoke) Token: 0x060031AE RID: 12718
		[Token(Token = "0x2000729")]
		private delegate Component __GEN_DELEGATE446(Transform tran, int pathId);

		// Token: 0x0200072A RID: 1834
		// (Invoke) Token: 0x060031B2 RID: 12722
		[Token(Token = "0x200072A")]
		private delegate Component __GEN_DELEGATE447(Transform tran);

		// Token: 0x0200072B RID: 1835
		// (Invoke) Token: 0x060031B6 RID: 12726
		[Token(Token = "0x200072B")]
		private delegate Component __GEN_DELEGATE448(GameObject obj);

		// Token: 0x0200072C RID: 1836
		// (Invoke) Token: 0x060031BA RID: 12730
		[Token(Token = "0x200072C")]
		private delegate Component __GEN_DELEGATE449(Transform tran, string path);

		// Token: 0x0200072D RID: 1837
		// (Invoke) Token: 0x060031BE RID: 12734
		[Token(Token = "0x200072D")]
		private delegate Component __GEN_DELEGATE450(Transform tran, int pathId);

		// Token: 0x0200072E RID: 1838
		// (Invoke) Token: 0x060031C2 RID: 12738
		[Token(Token = "0x200072E")]
		private delegate Component __GEN_DELEGATE451(Transform tran);

		// Token: 0x0200072F RID: 1839
		// (Invoke) Token: 0x060031C6 RID: 12742
		[Token(Token = "0x200072F")]
		private delegate Component __GEN_DELEGATE452(GameObject obj);

		// Token: 0x02000730 RID: 1840
		// (Invoke) Token: 0x060031CA RID: 12746
		[Token(Token = "0x2000730")]
		private delegate Component __GEN_DELEGATE453(Transform tran, string path);

		// Token: 0x02000731 RID: 1841
		// (Invoke) Token: 0x060031CE RID: 12750
		[Token(Token = "0x2000731")]
		private delegate Component __GEN_DELEGATE454(Transform tran, int pathId);

		// Token: 0x02000732 RID: 1842
		// (Invoke) Token: 0x060031D2 RID: 12754
		[Token(Token = "0x2000732")]
		private delegate Component __GEN_DELEGATE455(Transform tran);

		// Token: 0x02000733 RID: 1843
		// (Invoke) Token: 0x060031D6 RID: 12758
		[Token(Token = "0x2000733")]
		private delegate Component __GEN_DELEGATE456(GameObject obj);

		// Token: 0x02000734 RID: 1844
		// (Invoke) Token: 0x060031DA RID: 12762
		[Token(Token = "0x2000734")]
		private delegate Component __GEN_DELEGATE457(Transform tran);

		// Token: 0x02000735 RID: 1845
		// (Invoke) Token: 0x060031DE RID: 12766
		[Token(Token = "0x2000735")]
		private delegate Component __GEN_DELEGATE458(GameObject obj);

		// Token: 0x02000736 RID: 1846
		// (Invoke) Token: 0x060031E2 RID: 12770
		[Token(Token = "0x2000736")]
		private delegate int __GEN_DELEGATE459(Transform tran);

		// Token: 0x02000737 RID: 1847
		// (Invoke) Token: 0x060031E6 RID: 12774
		[Token(Token = "0x2000737")]
		private delegate int __GEN_DELEGATE460(GameObject obj);

		// Token: 0x02000738 RID: 1848
		// (Invoke) Token: 0x060031EA RID: 12778
		[Token(Token = "0x2000738")]
		private delegate Component __GEN_DELEGATE461(Transform tran);

		// Token: 0x02000739 RID: 1849
		// (Invoke) Token: 0x060031EE RID: 12782
		[Token(Token = "0x2000739")]
		private delegate Component __GEN_DELEGATE462(GameObject obj);

		// Token: 0x0200073A RID: 1850
		// (Invoke) Token: 0x060031F2 RID: 12786
		[Token(Token = "0x200073A")]
		private delegate Component __GEN_DELEGATE463(Transform tran);

		// Token: 0x0200073B RID: 1851
		// (Invoke) Token: 0x060031F6 RID: 12790
		[Token(Token = "0x200073B")]
		private delegate Component __GEN_DELEGATE464(GameObject obj);

		// Token: 0x0200073C RID: 1852
		// (Invoke) Token: 0x060031FA RID: 12794
		[Token(Token = "0x200073C")]
		private delegate Component __GEN_DELEGATE465(Transform tran);

		// Token: 0x0200073D RID: 1853
		// (Invoke) Token: 0x060031FE RID: 12798
		[Token(Token = "0x200073D")]
		private delegate Component __GEN_DELEGATE466(GameObject obj);

		// Token: 0x0200073E RID: 1854
		// (Invoke) Token: 0x06003202 RID: 12802
		[Token(Token = "0x200073E")]
		private delegate Component __GEN_DELEGATE467(Transform tran);

		// Token: 0x0200073F RID: 1855
		// (Invoke) Token: 0x06003206 RID: 12806
		[Token(Token = "0x200073F")]
		private delegate Component __GEN_DELEGATE468(GameObject obj);

		// Token: 0x02000740 RID: 1856
		// (Invoke) Token: 0x0600320A RID: 12810
		[Token(Token = "0x2000740")]
		private delegate Component __GEN_DELEGATE469(Transform tran);

		// Token: 0x02000741 RID: 1857
		// (Invoke) Token: 0x0600320E RID: 12814
		[Token(Token = "0x2000741")]
		private delegate Component __GEN_DELEGATE470(GameObject obj);

		// Token: 0x02000742 RID: 1858
		// (Invoke) Token: 0x06003212 RID: 12818
		[Token(Token = "0x2000742")]
		private delegate void __GEN_DELEGATE471(PlayableDirector director, string key, GameObject obj);

		// Token: 0x02000743 RID: 1859
		// (Invoke) Token: 0x06003216 RID: 12822
		[Token(Token = "0x2000743")]
		private delegate float __GEN_DELEGATE472(Animator animator, string stateName);

		// Token: 0x02000744 RID: 1860
		// (Invoke) Token: 0x0600321A RID: 12826
		[Token(Token = "0x2000744")]
		private delegate float __GEN_DELEGATE473(Animator animator, string name);

		// Token: 0x02000745 RID: 1861
		// (Invoke) Token: 0x0600321E RID: 12830
		[Token(Token = "0x2000745")]
		private delegate float __GEN_DELEGATE474(Animator animator, int nameId);

		// Token: 0x02000746 RID: 1862
		// (Invoke) Token: 0x06003222 RID: 12834
		[Token(Token = "0x2000746")]
		private delegate bool __GEN_DELEGATE475(Transform transform, Transform targetTransform, bool ignoreRayPass);

		// Token: 0x02000747 RID: 1863
		// (Invoke) Token: 0x06003226 RID: 12838
		[Token(Token = "0x2000747")]
		private delegate bool __GEN_DELEGATE476(Bounds bounds, Vector3 point);

		// Token: 0x02000748 RID: 1864
		// (Invoke) Token: 0x0600322A RID: 12842
		[Token(Token = "0x2000748")]
		private delegate bool __GEN_DELEGATE477(Bounds bounds1, Bounds bounds2);

		// Token: 0x02000749 RID: 1865
		// (Invoke) Token: 0x0600322E RID: 12846
		[Token(Token = "0x2000749")]
		private delegate Vector3 __GEN_DELEGATE478(Quaternion q, Vector3 v);

		// Token: 0x0200074A RID: 1866
		// (Invoke) Token: 0x06003232 RID: 12850
		[Token(Token = "0x200074A")]
		private delegate void __GEN_DELEGATE479(GameObject o, GameObject t);

		// Token: 0x0200074B RID: 1867
		// (Invoke) Token: 0x06003236 RID: 12854
		[Token(Token = "0x200074B")]
		private delegate void __GEN_DELEGATE480(TMPTeletypeComponent com, int dialogId, Action callback, int startIndex, float speed);

		// Token: 0x0200074C RID: 1868
		// (Invoke) Token: 0x0600323A RID: 12858
		[Token(Token = "0x200074C")]
		private delegate void __GEN_DELEGATE481(Transform transform, float newValue);

		// Token: 0x0200074D RID: 1869
		// (Invoke) Token: 0x0600323E RID: 12862
		[Token(Token = "0x200074D")]
		private delegate void __GEN_DELEGATE482(Transform transform, float newValue);

		// Token: 0x0200074E RID: 1870
		// (Invoke) Token: 0x06003242 RID: 12866
		[Token(Token = "0x200074E")]
		private delegate void __GEN_DELEGATE483(Transform transform, float newValue);

		// Token: 0x0200074F RID: 1871
		// (Invoke) Token: 0x06003246 RID: 12870
		[Token(Token = "0x200074F")]
		private delegate void __GEN_DELEGATE484(Transform transform, float deltaValue);

		// Token: 0x02000750 RID: 1872
		// (Invoke) Token: 0x0600324A RID: 12874
		[Token(Token = "0x2000750")]
		private delegate void __GEN_DELEGATE485(Transform transform, float deltaValue);

		// Token: 0x02000751 RID: 1873
		// (Invoke) Token: 0x0600324E RID: 12878
		[Token(Token = "0x2000751")]
		private delegate void __GEN_DELEGATE486(Transform transform, float deltaValue);

		// Token: 0x02000752 RID: 1874
		// (Invoke) Token: 0x06003252 RID: 12882
		[Token(Token = "0x2000752")]
		private delegate void __GEN_DELEGATE487(Transform transform, float newValue);

		// Token: 0x02000753 RID: 1875
		// (Invoke) Token: 0x06003256 RID: 12886
		[Token(Token = "0x2000753")]
		private delegate void __GEN_DELEGATE488(Transform transform, float newValue);

		// Token: 0x02000754 RID: 1876
		// (Invoke) Token: 0x0600325A RID: 12890
		[Token(Token = "0x2000754")]
		private delegate void __GEN_DELEGATE489(Transform transform, float newValue);

		// Token: 0x02000755 RID: 1877
		// (Invoke) Token: 0x0600325E RID: 12894
		[Token(Token = "0x2000755")]
		private delegate void __GEN_DELEGATE490(Transform transform, float deltaValue);

		// Token: 0x02000756 RID: 1878
		// (Invoke) Token: 0x06003262 RID: 12898
		[Token(Token = "0x2000756")]
		private delegate void __GEN_DELEGATE491(Transform transform, float deltaValue);

		// Token: 0x02000757 RID: 1879
		// (Invoke) Token: 0x06003266 RID: 12902
		[Token(Token = "0x2000757")]
		private delegate void __GEN_DELEGATE492(Transform transform, float deltaValue);

		// Token: 0x02000758 RID: 1880
		// (Invoke) Token: 0x0600326A RID: 12906
		[Token(Token = "0x2000758")]
		private delegate void __GEN_DELEGATE493(Transform transform, float newValue);

		// Token: 0x02000759 RID: 1881
		// (Invoke) Token: 0x0600326E RID: 12910
		[Token(Token = "0x2000759")]
		private delegate void __GEN_DELEGATE494(Transform transform, float newValue);

		// Token: 0x0200075A RID: 1882
		// (Invoke) Token: 0x06003272 RID: 12914
		[Token(Token = "0x200075A")]
		private delegate void __GEN_DELEGATE495(Transform transform, float newValue);

		// Token: 0x0200075B RID: 1883
		// (Invoke) Token: 0x06003276 RID: 12918
		[Token(Token = "0x200075B")]
		private delegate void __GEN_DELEGATE496(Transform transform, float deltaValue);

		// Token: 0x0200075C RID: 1884
		// (Invoke) Token: 0x0600327A RID: 12922
		[Token(Token = "0x200075C")]
		private delegate void __GEN_DELEGATE497(Transform transform, float deltaValue);

		// Token: 0x0200075D RID: 1885
		// (Invoke) Token: 0x0600327E RID: 12926
		[Token(Token = "0x200075D")]
		private delegate void __GEN_DELEGATE498(Transform transform, float deltaValue);

		// Token: 0x0200075E RID: 1886
		// (Invoke) Token: 0x06003282 RID: 12930
		[Token(Token = "0x200075E")]
		private delegate Transform __GEN_DELEGATE499(Transform root, string childName, bool includeInVisible);

		// Token: 0x0200075F RID: 1887
		// (Invoke) Token: 0x06003286 RID: 12934
		[Token(Token = "0x200075F")]
		private delegate Transform __GEN_DELEGATE500(Transform root, int childNameId, bool includeInVisible);

		// Token: 0x02000760 RID: 1888
		// (Invoke) Token: 0x0600328A RID: 12938
		[Token(Token = "0x2000760")]
		private delegate void __GEN_DELEGATE501(Text obj);

		// Token: 0x02000761 RID: 1889
		// (Invoke) Token: 0x0600328E RID: 12942
		[Token(Token = "0x2000761")]
		private delegate void __GEN_DELEGATE502(NewText obj);

		// Token: 0x02000762 RID: 1890
		// (Invoke) Token: 0x06003292 RID: 12946
		[Token(Token = "0x2000762")]
		private delegate void __GEN_DELEGATE503(NewTMP3DText obj);

		// Token: 0x02000763 RID: 1891
		// (Invoke) Token: 0x06003296 RID: 12950
		[Token(Token = "0x2000763")]
		private delegate void __GEN_DELEGATE504(TextMeshPro obj);

		// Token: 0x02000764 RID: 1892
		// (Invoke) Token: 0x0600329A RID: 12954
		[Token(Token = "0x2000764")]
		private delegate void __GEN_DELEGATE505(TextMeshProUGUI obj);

		// Token: 0x02000765 RID: 1893
		// (Invoke) Token: 0x0600329E RID: 12958
		[Token(Token = "0x2000765")]
		private delegate void __GEN_DELEGATE506(InputField obj);

		// Token: 0x02000766 RID: 1894
		// (Invoke) Token: 0x060032A2 RID: 12962
		[Token(Token = "0x2000766")]
		private delegate void __GEN_DELEGATE507(SuperTextMesh obj);

		// Token: 0x02000767 RID: 1895
		// (Invoke) Token: 0x060032A6 RID: 12966
		[Token(Token = "0x2000767")]
		private delegate void __GEN_DELEGATE508(Text obj, int formatId);

		// Token: 0x02000768 RID: 1896
		// (Invoke) Token: 0x060032AA RID: 12970
		[Token(Token = "0x2000768")]
		private delegate bool __GEN_DELEGATE509(SimpleAnimation ani, int stateNameToId);

		// Token: 0x02000769 RID: 1897
		// (Invoke) Token: 0x060032AE RID: 12974
		[Token(Token = "0x2000769")]
		private delegate void __GEN_DELEGATE510(SimpleAnimation ani, int stateNameToId);

		// Token: 0x0200076A RID: 1898
		// (Invoke) Token: 0x060032B2 RID: 12978
		[Token(Token = "0x200076A")]
		private delegate bool __GEN_DELEGATE511(SimpleAnimation ani, int stateNameToId);

		// Token: 0x0200076B RID: 1899
		// (Invoke) Token: 0x060032B6 RID: 12982
		[Token(Token = "0x200076B")]
		private delegate void __GEN_DELEGATE512(SimpleAnimation simpleAni, int stateNameToId);

		// Token: 0x0200076C RID: 1900
		// (Invoke) Token: 0x060032BA RID: 12986
		[Token(Token = "0x200076C")]
		private delegate SimpleAnimation.State __GEN_DELEGATE513(SimpleAnimation simpleAni, int stateNameToId);

		// Token: 0x0200076D RID: 1901
		// (Invoke) Token: 0x060032BE RID: 12990
		[Token(Token = "0x200076D")]
		private delegate bool __GEN_DELEGATE514(SimpleAnimation simpleAni, int stateNameId);

		// Token: 0x0200076E RID: 1902
		// (Invoke) Token: 0x060032C2 RID: 12994
		[Token(Token = "0x200076E")]
		private delegate float __GEN_DELEGATE515(SimpleAnimation simpleAni, int stateNameId);

		// Token: 0x0200076F RID: 1903
		// (Invoke) Token: 0x060032C6 RID: 12998
		[Token(Token = "0x200076F")]
		private delegate float __GEN_DELEGATE516(SimpleAnimation simpleAni, int stateNameId);

		// Token: 0x02000770 RID: 1904
		// (Invoke) Token: 0x060032CA RID: 13002
		[Token(Token = "0x2000770")]
		private delegate void __GEN_DELEGATE517(SimpleAnimation simpleAni, int stateNameId, float fadeLength);

		// Token: 0x02000771 RID: 1905
		// (Invoke) Token: 0x060032CE RID: 13006
		[Token(Token = "0x2000771")]
		private delegate void __GEN_DELEGATE518(SimpleAnimation simpleAni, int stateNameId, float fadeLength, QueueMode queueMode);

		// Token: 0x02000772 RID: 1906
		// (Invoke) Token: 0x060032D2 RID: 13010
		[Token(Token = "0x2000772")]
		private delegate void __GEN_DELEGATE519(SimpleAnimation simpleAni, int stateNameId, float speed);

		// Token: 0x02000773 RID: 1907
		// (Invoke) Token: 0x060032D6 RID: 13014
		[Token(Token = "0x2000773")]
		private delegate void __GEN_DELEGATE520(SimpleAnimation simpleAni, int stateNameId, float time);

		// Token: 0x02000774 RID: 1908
		// (Invoke) Token: 0x060032DA RID: 13018
		[Token(Token = "0x2000774")]
		private delegate void __GEN_DELEGATE521(SurvivalLodEx lodEx, int animationNameId);

		// Token: 0x02000775 RID: 1909
		// (Invoke) Token: 0x060032DE RID: 13022
		[Token(Token = "0x2000775")]
		private delegate void __GEN_DELEGATE522(Animator ani, int stateNameToId, int layerIdx, float normalizedTime);

		// Token: 0x02000776 RID: 1910
		// (Invoke) Token: 0x060032E2 RID: 13026
		[Token(Token = "0x2000776")]
		private delegate void __GEN_DELEGATE523(Animator ani, int triggerNameToId);

		// Token: 0x02000777 RID: 1911
		// (Invoke) Token: 0x060032E6 RID: 13030
		[Token(Token = "0x2000777")]
		private delegate Transform __GEN_DELEGATE524(Transform tran, int pathToId);

		// Token: 0x02000778 RID: 1912
		// (Invoke) Token: 0x060032EA RID: 13034
		[Token(Token = "0x2000778")]
		private delegate void __GEN_DELEGATE525(Material mater, int id);

		// Token: 0x02000779 RID: 1913
		// (Invoke) Token: 0x060032EE RID: 13038
		[Token(Token = "0x2000779")]
		private delegate void __GEN_DELEGATE526(Material mater, int id);

		// Token: 0x0200077A RID: 1914
		// (Invoke) Token: 0x060032F2 RID: 13042
		[Token(Token = "0x200077A")]
		private delegate InstanceRequest __GEN_DELEGATE527(ResourceManager resMgr, int prefabPathId, Action<InstanceRequest> callback, Transform presetParent);

		// Token: 0x0200077B RID: 1915
		// (Invoke) Token: 0x060032F6 RID: 13046
		[Token(Token = "0x200077B")]
		private delegate InstanceRequest __GEN_DELEGATE528(ResourceManager resMgr, int prefabPathId, Action<InstanceRequest> callback, Transform presetParent);

		// Token: 0x0200077C RID: 1916
		// (Invoke) Token: 0x060032FA RID: 13050
		[Token(Token = "0x200077C")]
		private delegate int __GEN_DELEGATE529(SoundComponent sound, int effectId, bool loop, float volume, int groupId);

		// Token: 0x0200077D RID: 1917
		// (Invoke) Token: 0x060032FE RID: 13054
		[Token(Token = "0x200077D")]
		private delegate int __GEN_DELEGATE530(SoundComponent sound, int effectId, string soundGroupName, SoundComponent.PlaySoundParams playSoundParams, object userData, Action<bool, int> action);

		// Token: 0x0200077E RID: 1918
		// (Invoke) Token: 0x06003302 RID: 13058
		[Token(Token = "0x200077E")]
		private delegate int __GEN_DELEGATE531(SoundComponent sound, int effectId, bool loop);

		// Token: 0x0200077F RID: 1919
		// (Invoke) Token: 0x06003306 RID: 13062
		[Token(Token = "0x200077F")]
		private delegate int __GEN_DELEGATE532(SoundComponent sound, int effectId, bool loop, float volume);

		// Token: 0x02000780 RID: 1920
		// (Invoke) Token: 0x0600330A RID: 13066
		[Token(Token = "0x2000780")]
		private delegate bool __GEN_DELEGATE533(ResourceManager res, int pathId);

		// Token: 0x02000781 RID: 1921
		// (Invoke) Token: 0x0600330E RID: 13070
		[Token(Token = "0x2000781")]
		private delegate void __GEN_DELEGATE534(Object obj, int nameId);

		// Token: 0x02000782 RID: 1922
		// (Invoke) Token: 0x06003312 RID: 13074
		[Token(Token = "0x2000782")]
		private delegate void __GEN_DELEGATE535(Image image, int spritePathId, string defaultSprite);

		// Token: 0x02000783 RID: 1923
		// (Invoke) Token: 0x06003316 RID: 13078
		[Token(Token = "0x2000783")]
		private delegate void __GEN_DELEGATE536(CircleImage image, int spritePathId, string defaultSprite);

		// Token: 0x02000784 RID: 1924
		// (Invoke) Token: 0x0600331A RID: 13082
		[Token(Token = "0x2000784")]
		private delegate void __GEN_DELEGATE537(SpriteRenderer spriteRenderer, int spritePathId, string defaultSprite);

		// Token: 0x02000785 RID: 1925
		// (Invoke) Token: 0x0600331E RID: 13086
		[Token(Token = "0x2000785")]
		private delegate void __GEN_DELEGATE538(SpriteMeshRenderer meshRenderer, int spritePathId, string defaultSprite);

		// Token: 0x02000786 RID: 1926
		// (Invoke) Token: 0x06003322 RID: 13090
		[Token(Token = "0x2000786")]
		private delegate void __GEN_DELEGATE539(NetworkManager netMgr, int msgToId, byte[] sfsObjBinary);

		// Token: 0x02000787 RID: 1927
		// (Invoke) Token: 0x06003326 RID: 13094
		[Token(Token = "0x2000787")]
		private delegate void __GEN_DELEGATE540(FutureManager mgr, int fuid, int msgIntId);

		// Token: 0x02000788 RID: 1928
		// (Invoke) Token: 0x0600332A RID: 13098
		[Token(Token = "0x2000788")]
		private delegate void __GEN_DELEGATE541(SoundComponent s, int soundGroupNameId);

		// Token: 0x02000789 RID: 1929
		// (Invoke) Token: 0x0600332E RID: 13102
		[Token(Token = "0x2000789")]
		private delegate void __GEN_DELEGATE542(Thread t, string name);

		// Token: 0x0200078A RID: 1930
		// (Invoke) Token: 0x06003332 RID: 13106
		[Token(Token = "0x200078A")]
		private delegate Tweener __GEN_DELEGATE543(TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping);

		// Token: 0x0200078B RID: 1931
		// (Invoke) Token: 0x06003336 RID: 13110
		[Token(Token = "0x200078B")]
		private delegate Tweener __GEN_DELEGATE544(TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x0200078C RID: 1932
		// (Invoke) Token: 0x0600333A RID: 13114
		[Token(Token = "0x200078C")]
		private delegate Tweener __GEN_DELEGATE545(TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping);

		// Token: 0x0200078D RID: 1933
		// (Invoke) Token: 0x0600333E RID: 13118
		[Token(Token = "0x200078D")]
		private delegate Tweener __GEN_DELEGATE546(TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x0200078E RID: 1934
		// (Invoke) Token: 0x06003342 RID: 13122
		[Token(Token = "0x200078E")]
		private delegate Tweener __GEN_DELEGATE547(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route);

		// Token: 0x0200078F RID: 1935
		// (Invoke) Token: 0x06003346 RID: 13126
		[Token(Token = "0x200078F")]
		private delegate Tweener __GEN_DELEGATE548(TweenerCore<Rect, Rect, RectOptions> t, bool snapping);

		// Token: 0x02000790 RID: 1936
		// (Invoke) Token: 0x0600334A RID: 13130
		[Token(Token = "0x2000790")]
		private delegate Tweener __GEN_DELEGATE549(TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode, string scrambleChars);

		// Token: 0x02000791 RID: 1937
		// (Invoke) Token: 0x0600334E RID: 13134
		[Token(Token = "0x2000791")]
		private delegate Tweener __GEN_DELEGATE550(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping);

		// Token: 0x02000792 RID: 1938
		// (Invoke) Token: 0x06003352 RID: 13138
		[Token(Token = "0x2000792")]
		private delegate Tweener __GEN_DELEGATE551(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x02000793 RID: 1939
		// (Invoke) Token: 0x06003356 RID: 13142
		[Token(Token = "0x2000793")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE552(TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation);

		// Token: 0x02000794 RID: 1940
		// (Invoke) Token: 0x0600335A RID: 13146
		[Token(Token = "0x2000794")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE553(TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition, AxisConstraint lockRotation);

		// Token: 0x02000795 RID: 1941
		// (Invoke) Token: 0x0600335E RID: 13150
		[Token(Token = "0x2000795")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE554(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection, Vector3? up);

		// Token: 0x02000796 RID: 1942
		// (Invoke) Token: 0x06003362 RID: 13154
		[Token(Token = "0x2000796")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE555(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation);

		// Token: 0x02000797 RID: 1943
		// (Invoke) Token: 0x06003366 RID: 13158
		[Token(Token = "0x2000797")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE556(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection, Vector3? up);

		// Token: 0x02000798 RID: 1944
		// (Invoke) Token: 0x0600336A RID: 13162
		[Token(Token = "0x2000798")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE557(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation);

		// Token: 0x02000799 RID: 1945
		// (Invoke) Token: 0x0600336E RID: 13166
		[Token(Token = "0x2000799")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE558(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection, Vector3? up);

		// Token: 0x0200079A RID: 1946
		// (Invoke) Token: 0x06003372 RID: 13170
		[Token(Token = "0x200079A")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE559(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation);

		// Token: 0x0200079B RID: 1947
		// (Invoke) Token: 0x06003376 RID: 13174
		[Token(Token = "0x200079B")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE560(Light target, Color endValue, float duration);

		// Token: 0x0200079C RID: 1948
		// (Invoke) Token: 0x0600337A RID: 13178
		[Token(Token = "0x200079C")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE561(Light target, float endValue, float duration);

		// Token: 0x0200079D RID: 1949
		// (Invoke) Token: 0x0600337E RID: 13182
		[Token(Token = "0x200079D")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE562(Light target, float endValue, float duration);

		// Token: 0x0200079E RID: 1950
		// (Invoke) Token: 0x06003382 RID: 13186
		[Token(Token = "0x200079E")]
		private delegate Tweener __GEN_DELEGATE563(LineRenderer target, Color2 startValue, Color2 endValue, float duration);

		// Token: 0x0200079F RID: 1951
		// (Invoke) Token: 0x06003386 RID: 13190
		[Token(Token = "0x200079F")]
		private delegate Tweener __GEN_DELEGATE564(TrailRenderer target, float toStartWidth, float toEndWidth, float duration);

		// Token: 0x020007A0 RID: 1952
		// (Invoke) Token: 0x0600338A RID: 13194
		[Token(Token = "0x20007A0")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE565(TrailRenderer target, float endValue, float duration);

		// Token: 0x020007A1 RID: 1953
		// (Invoke) Token: 0x0600338E RID: 13198
		[Token(Token = "0x20007A1")]
		private delegate Tweener __GEN_DELEGATE566(Light target, Color endValue, float duration);

		// Token: 0x020007A2 RID: 1954
		// (Invoke) Token: 0x06003392 RID: 13202
		[Token(Token = "0x20007A2")]
		private delegate bool __GEN_DELEGATE567(string str);

		// Token: 0x020007A3 RID: 1955
		// (Invoke) Token: 0x06003396 RID: 13206
		[Token(Token = "0x20007A3")]
		private delegate bool __GEN_DELEGATE568(string value);

		// Token: 0x020007A4 RID: 1956
		// (Invoke) Token: 0x0600339A RID: 13210
		[Token(Token = "0x20007A4")]
		private delegate string __GEN_DELEGATE569(string str);

		// Token: 0x020007A5 RID: 1957
		// (Invoke) Token: 0x0600339E RID: 13214
		[Token(Token = "0x20007A5")]
		private delegate string __GEN_DELEGATE570(string path, char separator);

		// Token: 0x020007A6 RID: 1958
		// (Invoke) Token: 0x060033A2 RID: 13218
		[Token(Token = "0x20007A6")]
		private delegate string __GEN_DELEGATE571(string path, char separator);

		// Token: 0x020007A7 RID: 1959
		// (Invoke) Token: 0x060033A6 RID: 13222
		[Token(Token = "0x20007A7")]
		private delegate int __GEN_DELEGATE572(string sourceStr);

		// Token: 0x020007A8 RID: 1960
		// (Invoke) Token: 0x060033AA RID: 13226
		[Token(Token = "0x20007A8")]
		private delegate string __GEN_DELEGATE573(string sourceStr, int len);

		// Token: 0x020007A9 RID: 1961
		// (Invoke) Token: 0x060033AE RID: 13230
		[Token(Token = "0x20007A9")]
		private delegate int __GEN_DELEGATE574(string str);

		// Token: 0x020007AA RID: 1962
		// (Invoke) Token: 0x060033B2 RID: 13234
		[Token(Token = "0x20007AA")]
		private delegate int __GEN_DELEGATE575(ReadOnlySpan<char> str);

		// Token: 0x020007AB RID: 1963
		// (Invoke) Token: 0x060033B6 RID: 13238
		[Token(Token = "0x20007AB")]
		private delegate float __GEN_DELEGATE576(string str);

		// Token: 0x020007AC RID: 1964
		// (Invoke) Token: 0x060033BA RID: 13242
		[Token(Token = "0x20007AC")]
		private delegate float __GEN_DELEGATE577(ReadOnlySpan<char> str);

		// Token: 0x020007AD RID: 1965
		// (Invoke) Token: 0x060033BE RID: 13246
		[Token(Token = "0x20007AD")]
		private delegate ulong __GEN_DELEGATE578(ReadOnlySpan<char> str);

		// Token: 0x020007AE RID: 1966
		// (Invoke) Token: 0x060033C2 RID: 13250
		[Token(Token = "0x20007AE")]
		private delegate float __GEN_DELEGATE579(long value);

		// Token: 0x020007AF RID: 1967
		// (Invoke) Token: 0x060033C6 RID: 13254
		[Token(Token = "0x20007AF")]
		private delegate long __GEN_DELEGATE580(string str);

		// Token: 0x020007B0 RID: 1968
		// (Invoke) Token: 0x060033CA RID: 13258
		[Token(Token = "0x20007B0")]
		private delegate void __GEN_DELEGATE581(Thread t, string name);

		// Token: 0x020007B1 RID: 1969
		// (Invoke) Token: 0x060033CE RID: 13262
		[Token(Token = "0x20007B1")]
		public delegate bool TryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index);

		// Token: 0x020007B2 RID: 1970
		// (Invoke) Token: 0x060033D2 RID: 13266
		[Token(Token = "0x20007B2")]
		public delegate bool TryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx);
	}
}
