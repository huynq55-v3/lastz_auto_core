using System;
using System.Runtime.InteropServices;
using System.Text;
using AOT;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001B7 RID: 439
[Token(Token = "0x20001B7")]
public class AspectRatioController : MonoBehaviour
{
	// Token: 0x06000B3C RID: 2876
	[Token(Token = "0x6000B3C")]
	[Address(RVA = "0x3725134", Offset = "0x3725134", VA = "0x3725134")]
	[PreserveSig]
	private static extern IntPtr GetActiveWindow();

	// Token: 0x06000B3D RID: 2877
	[Token(Token = "0x6000B3D")]
	[Address(RVA = "0x372519C", Offset = "0x372519C", VA = "0x372519C")]
	[PreserveSig]
	private static extern uint GetCurrentThreadId();

	// Token: 0x06000B3E RID: 2878
	[Token(Token = "0x6000B3E")]
	[Address(RVA = "0x3725204", Offset = "0x3725204", VA = "0x3725204")]
	[PreserveSig]
	private static extern int GetClassName(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	// Token: 0x06000B3F RID: 2879
	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x37252C4", Offset = "0x37252C4", VA = "0x37252C4")]
	[PreserveSig]
	private static extern IntPtr GetWindowLongPtr(IntPtr hWnd, int nIndex);

	// Token: 0x06000B40 RID: 2880
	[Token(Token = "0x6000B40")]
	[Address(RVA = "0x3725354", Offset = "0x3725354", VA = "0x3725354")]
	[PreserveSig]
	private static extern IntPtr GetWindowLong32(IntPtr hWnd, int nIndex);

	// Token: 0x06000B41 RID: 2881
	[Token(Token = "0x6000B41")]
	[Address(RVA = "0x37253D8", Offset = "0x37253D8", VA = "0x37253D8")]
	[PreserveSig]
	private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

	// Token: 0x06000B42 RID: 2882
	[Token(Token = "0x6000B42")]
	[Address(RVA = "0x372546C", Offset = "0x372546C", VA = "0x372546C")]
	[PreserveSig]
	private static extern IntPtr SetWindowLongPtr(IntPtr hWnd, int nIndex, IntPtr newProc);

	// Token: 0x06000B43 RID: 2883
	[Token(Token = "0x6000B43")]
	[Address(RVA = "0x372550C", Offset = "0x372550C", VA = "0x372550C")]
	[PreserveSig]
	private static extern IntPtr SetWindowLong32(IntPtr hWnd, int nIndex, IntPtr newProc);

	// Token: 0x06000B44 RID: 2884
	[Token(Token = "0x6000B44")]
	[Address(RVA = "0x37255A0", Offset = "0x37255A0", VA = "0x37255A0")]
	[PreserveSig]
	private static extern bool EnumThreadWindows(uint dwThreadId, AspectRatioController.EnumWindowsProc lpEnumFunc, IntPtr lParam);

	// Token: 0x06000B45 RID: 2885
	[Token(Token = "0x6000B45")]
	[Address(RVA = "0x3725644", Offset = "0x3725644", VA = "0x3725644")]
	[PreserveSig]
	private static extern IntPtr CallWindowProc(IntPtr lpPrevWndFunc, IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

	// Token: 0x06000B46 RID: 2886
	[Token(Token = "0x6000B46")]
	[Address(RVA = "0x37256F0", Offset = "0x37256F0", VA = "0x37256F0")]
	[PreserveSig]
	private static extern bool GetWindowRect(IntPtr hwnd, out AspectRatioController.RECT lpRect);

	// Token: 0x06000B47 RID: 2887
	[Token(Token = "0x6000B47")]
	[Address(RVA = "0x3725784", Offset = "0x3725784", VA = "0x3725784")]
	[PreserveSig]
	private static extern bool GetClientRect(IntPtr hWnd, ref AspectRatioController.RECT lpRect);

	// Token: 0x06000B48 RID: 2888
	[Token(Token = "0x6000B48")]
	[Address(RVA = "0x3725810", Offset = "0x3725810", VA = "0x3725810")]
	[PreserveSig]
	private static extern IntPtr MonitorFromWindow(IntPtr hwnd, uint dwFlags);

	// Token: 0x06000B49 RID: 2889
	[Token(Token = "0x6000B49")]
	[Address(RVA = "0x3725894", Offset = "0x3725894", VA = "0x3725894")]
	[PreserveSig]
	private static extern bool GetMonitorInfo(IntPtr hMonitor, ref AspectRatioController.MONITORINFO lpmi);

	// Token: 0x06000B4A RID: 2890
	[Token(Token = "0x6000B4A")]
	[Address(RVA = "0x3725920", Offset = "0x3725920", VA = "0x3725920")]
	[PreserveSig]
	private static extern IntPtr MonitorFromPoint(AspectRatioController.POINT pt, uint dwFlags);

	// Token: 0x06000B4B RID: 2891
	[Token(Token = "0x6000B4B")]
	[Address(RVA = "0x37259A4", Offset = "0x37259A4", VA = "0x37259A4")]
	[PreserveSig]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	// Token: 0x06000B4C RID: 2892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4C")]
	[Address(RVA = "0x3725A78", Offset = "0x3725A78", VA = "0x3725A78")]
	private void Awake()
	{
	}

	// Token: 0x06000B4D RID: 2893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4D")]
	[Address(RVA = "0x3725AE0", Offset = "0x3725AE0", VA = "0x3725AE0")]
	private void Start()
	{
	}

	// Token: 0x06000B4E RID: 2894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4E")]
	[Address(RVA = "0x3725AE4", Offset = "0x3725AE4", VA = "0x3725AE4")]
	private void InitializeWindow()
	{
	}

	// Token: 0x06000B4F RID: 2895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B4F")]
	[Address(RVA = "0x3725CF4", Offset = "0x3725CF4", VA = "0x3725CF4")]
	private void InstallWndProc()
	{
	}

	// Token: 0x06000B50 RID: 2896 RVA: 0x00005820 File Offset: 0x00003A20
	[Token(Token = "0x6000B50")]
	[Address(RVA = "0x3724A84", Offset = "0x3724A84", VA = "0x3724A84")]
	[MonoPInvokeCallback(typeof(AspectRatioController.WndProcDelegate))]
	private static IntPtr CustomWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
	{
		return 0;
	}

	// Token: 0x06000B51 RID: 2897 RVA: 0x00005838 File Offset: 0x00003A38
	[Token(Token = "0x6000B51")]
	[Address(RVA = "0x3725018", Offset = "0x3725018", VA = "0x3725018")]
	[MonoPInvokeCallback(typeof(AspectRatioController.EnumWindowsProc))]
	private static bool enumProc(IntPtr hWnd, IntPtr lParam)
	{
		return default(bool);
	}

	// Token: 0x06000B52 RID: 2898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B52")]
	[Address(RVA = "0x3725DC8", Offset = "0x3725DC8", VA = "0x3725DC8")]
	private void LoadWindowSettings()
	{
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B53")]
	[Address(RVA = "0x3726A50", Offset = "0x3726A50", VA = "0x3726A50")]
	private static void GetMonitorFromPoint(int x, int y, out int monitorWidth, out int monitorHeight)
	{
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B54")]
	[Address(RVA = "0x3726434", Offset = "0x3726434", VA = "0x3726434")]
	private void ApplyWindowSettingsWithoutOverride()
	{
	}

	// Token: 0x06000B55 RID: 2901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x3726C28", Offset = "0x3726C28", VA = "0x3726C28")]
	private void SaveWindowSettings()
	{
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x3726DB4", Offset = "0x3726DB4", VA = "0x3726DB4")]
	private void OnApplicationQuit()
	{
	}

	// Token: 0x06000B57 RID: 2903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x3726DB8", Offset = "0x3726DB8", VA = "0x3726DB8")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00005850 File Offset: 0x00003A50
	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x37269BC", Offset = "0x37269BC", VA = "0x37269BC")]
	private static IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
	{
		return 0;
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x3726DBC", Offset = "0x3726DBC", VA = "0x3726DBC")]
	public AspectRatioController()
	{
	}

	// Token: 0x04000FB9 RID: 4025
	[Token(Token = "0x4000FB9")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Header("分辨率设置")]
	private static int minWidth;

	// Token: 0x04000FBA RID: 4026
	[Token(Token = "0x4000FBA")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	private static int minHeight;

	// Token: 0x04000FBB RID: 4027
	[Token(Token = "0x4000FBB")]
	[FieldOffset(Offset = "0x8")]
	private static float maxAspectRatio;

	// Token: 0x04000FBC RID: 4028
	[Token(Token = "0x4000FBC")]
	[FieldOffset(Offset = "0x18")]
	private int currentWidth;

	// Token: 0x04000FBD RID: 4029
	[Token(Token = "0x4000FBD")]
	[FieldOffset(Offset = "0x1C")]
	private int currentHeight;

	// Token: 0x04000FBE RID: 4030
	[Token(Token = "0x4000FBE")]
	[FieldOffset(Offset = "0x20")]
	private bool isApplyingSettings;

	// Token: 0x04000FBF RID: 4031
	[Token(Token = "0x4000FBF")]
	private const int WM_GETMINMAXINFO = 36;

	// Token: 0x04000FC0 RID: 4032
	[Token(Token = "0x4000FC0")]
	private const int WM_SIZING = 532;

	// Token: 0x04000FC1 RID: 4033
	[Token(Token = "0x4000FC1")]
	private const int GWL_WNDPROC = -4;

	// Token: 0x04000FC2 RID: 4034
	[Token(Token = "0x4000FC2")]
	private const uint SWP_NOZORDER = 4U;

	// Token: 0x04000FC3 RID: 4035
	[Token(Token = "0x4000FC3")]
	private const uint SWP_NOACTIVATE = 16U;

	// Token: 0x04000FC4 RID: 4036
	[Token(Token = "0x4000FC4")]
	private const int MONITOR_DEFAULTTONEAREST = 2;

	// Token: 0x04000FC5 RID: 4037
	[Token(Token = "0x4000FC5")]
	private const string UNITY_WND_CLASSNAME = "UnityWndClass";

	// Token: 0x04000FC6 RID: 4038
	[Token(Token = "0x4000FC6")]
	[FieldOffset(Offset = "0x10")]
	private static IntPtr unityHWnd;

	// Token: 0x04000FC7 RID: 4039
	[Token(Token = "0x4000FC7")]
	[FieldOffset(Offset = "0x18")]
	private static IntPtr oldWndProc;

	// Token: 0x04000FC8 RID: 4040
	[Token(Token = "0x4000FC8")]
	[FieldOffset(Offset = "0x28")]
	private IntPtr newWndProc;

	// Token: 0x04000FC9 RID: 4041
	[Token(Token = "0x4000FC9")]
	[FieldOffset(Offset = "0x20")]
	private static AspectRatioController.WndProcDelegate wndProcDelegate;

	// Token: 0x04000FCA RID: 4042
	[Token(Token = "0x4000FCA")]
	[FieldOffset(Offset = "0x28")]
	private static AspectRatioController.EnumWindowsProc enumProcDelegate;

	// Token: 0x020001B8 RID: 440
	[Token(Token = "0x20001B8")]
	private struct POINT
	{
		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x04000FCC RID: 4044
		[Token(Token = "0x4000FCC")]
		[FieldOffset(Offset = "0x4")]
		public int y;
	}

	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	private struct MINMAXINFO
	{
		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		[FieldOffset(Offset = "0x0")]
		public AspectRatioController.POINT ptReserved;

		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		[FieldOffset(Offset = "0x8")]
		public AspectRatioController.POINT ptMaxSize;

		// Token: 0x04000FCF RID: 4047
		[Token(Token = "0x4000FCF")]
		[FieldOffset(Offset = "0x10")]
		public AspectRatioController.POINT ptMaxPosition;

		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		[FieldOffset(Offset = "0x18")]
		public AspectRatioController.POINT ptMinTrackSize;

		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		[FieldOffset(Offset = "0x20")]
		public AspectRatioController.POINT ptMaxTrackSize;
	}

	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	public struct RECT
	{
		// Token: 0x04000FD2 RID: 4050
		[Token(Token = "0x4000FD2")]
		[FieldOffset(Offset = "0x0")]
		public int Left;

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x4")]
		public int Top;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x8")]
		public int Right;

		// Token: 0x04000FD5 RID: 4053
		[Token(Token = "0x4000FD5")]
		[FieldOffset(Offset = "0xC")]
		public int Bottom;
	}

	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	private struct MONITORINFO
	{
		// Token: 0x04000FD6 RID: 4054
		[Token(Token = "0x4000FD6")]
		[FieldOffset(Offset = "0x0")]
		public int cbSize;

		// Token: 0x04000FD7 RID: 4055
		[Token(Token = "0x4000FD7")]
		[FieldOffset(Offset = "0x4")]
		public AspectRatioController.RECT rcMonitor;

		// Token: 0x04000FD8 RID: 4056
		[Token(Token = "0x4000FD8")]
		[FieldOffset(Offset = "0x14")]
		public AspectRatioController.RECT rcWork;

		// Token: 0x04000FD9 RID: 4057
		[Token(Token = "0x4000FD9")]
		[FieldOffset(Offset = "0x24")]
		public uint dwFlags;
	}

	// Token: 0x020001BC RID: 444
	// (Invoke) Token: 0x06000B5C RID: 2908
	[Token(Token = "0x20001BC")]
	private delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

	// Token: 0x020001BD RID: 445
	// (Invoke) Token: 0x06000B60 RID: 2912
	[Token(Token = "0x20001BD")]
	private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);
}
