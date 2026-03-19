using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameFramework.Localization;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001C2 RID: 450
[Token(Token = "0x20001C2")]
public class LocalizationManager
{
	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00005868 File Offset: 0x00003A68
	// (set) Token: 0x06000B99 RID: 2969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000174")]
	public bool IsInitDone
	{
		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x3729898", Offset = "0x3729898", VA = "0x3729898")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x37298A0", Offset = "0x37298A0", VA = "0x37298A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00005880 File Offset: 0x00003A80
	// (set) Token: 0x06000B9B RID: 2971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000175")]
	public bool IsInitSuccess
	{
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x37298AC", Offset = "0x37298AC", VA = "0x37298AC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x37298B4", Offset = "0x37298B4", VA = "0x37298B4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000B9C RID: 2972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0x3728CB0", Offset = "0x3728CB0", VA = "0x3728CB0")]
	public LocalizationManager()
	{
	}

	// Token: 0x06000B9D RID: 2973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B9D")]
	[Address(RVA = "0x37298C0", Offset = "0x37298C0", VA = "0x37298C0")]
	public string GetDeviceLang()
	{
		return null;
	}

	// Token: 0x06000B9E RID: 2974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9E")]
	[Address(RVA = "0x3729A6C", Offset = "0x3729A6C", VA = "0x3729A6C")]
	public void Initialize(Language userLanguage)
	{
	}

	// Token: 0x06000B9F RID: 2975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B9F")]
	[Address(RVA = "0x3729B88", Offset = "0x3729B88", VA = "0x3729B88")]
	public void Uninitialize()
	{
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA0")]
	[Address(RVA = "0x3729B8C", Offset = "0x3729B8C", VA = "0x3729B8C")]
	public void LoadDictionary(string dictionaryName)
	{
	}

	// Token: 0x06000BA1 RID: 2977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA1")]
	[Address(RVA = "0x372A54C", Offset = "0x372A54C", VA = "0x372A54C")]
	private void LoadDictionaryCallback(TextAsset asset)
	{
	}

	// Token: 0x06000BA2 RID: 2978 RVA: 0x00005898 File Offset: 0x00003A98
	[Token(Token = "0x6000BA2")]
	[Address(RVA = "0x372A1A8", Offset = "0x372A1A8", VA = "0x372A1A8")]
	private bool ParseTxtDictionary(string text)
	{
		return default(bool);
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000058B0 File Offset: 0x00003AB0
	// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000176")]
	public Language Language
	{
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x372A6CC", Offset = "0x372A6CC", VA = "0x372A6CC")]
		get
		{
			return Language.Unspecified;
		}
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x372A6D4", Offset = "0x372A6D4", VA = "0x372A6D4")]
		set
		{
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x000058C8 File Offset: 0x00003AC8
	[Token(Token = "0x17000177")]
	public static Language SystemLanguage
	{
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x3729B54", Offset = "0x3729B54", VA = "0x3729B54")]
		get
		{
			return Language.Unspecified;
		}
	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x000058E0 File Offset: 0x00003AE0
	[Token(Token = "0x6000BA6")]
	[Address(RVA = "0x372A154", Offset = "0x372A154", VA = "0x372A154")]
	public bool IsSuported()
	{
		return default(bool);
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BA7")]
	[Address(RVA = "0x372A750", Offset = "0x372A750", VA = "0x372A750")]
	public void SetSuportedLanguages(List<int> langList)
	{
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA8")]
	[Address(RVA = "0x372A92C", Offset = "0x372A92C", VA = "0x372A92C")]
	public string GetString(int key)
	{
		return null;
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BA9")]
	[Address(RVA = "0x3714C0C", Offset = "0x3714C0C", VA = "0x3714C0C")]
	public string GetString(string key)
	{
		return null;
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BAA")]
	[Address(RVA = "0x3723594", Offset = "0x3723594", VA = "0x3723594")]
	public string GetString(string key, params object[] args)
	{
		return null;
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BAB")]
	[Address(RVA = "0x372A934", Offset = "0x372A934", VA = "0x372A934")]
	public string GetString(int key, params object[] args)
	{
		return null;
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x000058F8 File Offset: 0x00003AF8
	[Token(Token = "0x6000BAC")]
	[Address(RVA = "0x372AB80", Offset = "0x372AB80", VA = "0x372AB80")]
	private bool HasRawString(string key)
	{
		return default(bool);
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x00005910 File Offset: 0x00003B10
	[Token(Token = "0x6000BAD")]
	[Address(RVA = "0x372AC34", Offset = "0x372AC34", VA = "0x372AC34")]
	private bool HasRawString(int key)
	{
		return default(bool);
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x00005928 File Offset: 0x00003B28
	[Token(Token = "0x6000BAE")]
	[Address(RVA = "0x372A58C", Offset = "0x372A58C", VA = "0x372A58C")]
	private bool AddRawString(ReadOnlySpan<char> key, string value)
	{
		return default(bool);
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BAF")]
	[Address(RVA = "0x372AC8C", Offset = "0x372AC8C", VA = "0x372AC8C")]
	public string GetLocalCvName()
	{
		return null;
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB0")]
	[Address(RVA = "0x372AF3C", Offset = "0x372AF3C", VA = "0x372AF3C")]
	public string GetLanguageName()
	{
		return null;
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00005940 File Offset: 0x00003B40
	[Token(Token = "0x6000BB1")]
	[Address(RVA = "0x372B1EC", Offset = "0x372B1EC", VA = "0x372B1EC")]
	public int GetLanguage()
	{
		return 0;
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BB2")]
	[Address(RVA = "0x372B1F4", Offset = "0x372B1F4", VA = "0x372B1F4")]
	public void SetLanguage(int language)
	{
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BB3")]
	[Address(RVA = "0x372B298", Offset = "0x372B298", VA = "0x372B298")]
	public Font GetFontByLanguage()
	{
		return null;
	}

	// Token: 0x04000FF2 RID: 4082
	[Token(Token = "0x4000FF2")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<string, LocalizationManager.DialogEntry> m_Dictionary;

	// Token: 0x04000FF3 RID: 4083
	[Token(Token = "0x4000FF3")]
	[FieldOffset(Offset = "0x18")]
	private readonly Dictionary<int, LocalizationManager.DialogEntry> m_IntDictionary;

	// Token: 0x04000FF4 RID: 4084
	[Token(Token = "0x4000FF4")]
	[FieldOffset(Offset = "0x20")]
	private Language m_Language;

	// Token: 0x04000FF7 RID: 4087
	[Token(Token = "0x4000FF7")]
	[FieldOffset(Offset = "0x28")]
	private List<Language> SuportedLanguages;

	// Token: 0x04000FF8 RID: 4088
	[Token(Token = "0x4000FF8")]
	[FieldOffset(Offset = "0x30")]
	private Language m_localCv;

	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x20001C3")]
	private struct DialogEntry
	{
		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		[FieldOffset(Offset = "0x0")]
		public string originDlg;

		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x8")]
		public bool hasCRLF;
	}
}
