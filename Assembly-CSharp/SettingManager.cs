using System;
using GameFramework.Localization;
using Il2CppDummyDll;

// Token: 0x02000230 RID: 560
[Token(Token = "0x2000230")]
public class SettingManager
{
	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00006990 File Offset: 0x00004B90
	// (set) Token: 0x06000F01 RID: 3841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C3")]
	public Language UserLanguage
	{
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x122F07C", Offset = "0x122F07C", VA = "0x122F07C")]
		get
		{
			return Language.Unspecified;
		}
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x122F0E0", Offset = "0x122F0E0", VA = "0x122F0E0")]
		set
		{
		}
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C4")]
	public string UserLanguageName
	{
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x122F13C", Offset = "0x122F13C", VA = "0x122F13C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x122F1A0", Offset = "0x122F1A0", VA = "0x122F1A0")]
		set
		{
		}
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x000069A8 File Offset: 0x00004BA8
	[Token(Token = "0x6000F04")]
	[Address(RVA = "0x122F1EC", Offset = "0x122F1EC", VA = "0x122F1EC")]
	public bool Load()
	{
		return default(bool);
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x000069C0 File Offset: 0x00004BC0
	[Token(Token = "0x6000F05")]
	[Address(RVA = "0x122F1F4", Offset = "0x122F1F4", VA = "0x122F1F4")]
	public bool Save()
	{
		return default(bool);
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x000069D8 File Offset: 0x00004BD8
	[Token(Token = "0x6000F06")]
	[Address(RVA = "0x122F20C", Offset = "0x122F20C", VA = "0x122F20C")]
	public bool HasSetting(string settingName)
	{
		return default(bool);
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F07")]
	[Address(RVA = "0x122F218", Offset = "0x122F218", VA = "0x122F218")]
	public void RemoveSetting(string settingName)
	{
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F08")]
	[Address(RVA = "0x122F224", Offset = "0x122F224", VA = "0x122F224")]
	public void RemoveAllSettings()
	{
	}

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06000F09 RID: 3849 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000F0A RID: 3850 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C5")]
	public string GameUid
	{
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x122F22C", Offset = "0x122F22C", VA = "0x122F22C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x122F234", Offset = "0x122F234", VA = "0x122F234")]
		set
		{
		}
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x000069F0 File Offset: 0x00004BF0
	[Token(Token = "0x6000F0B")]
	[Address(RVA = "0x122F2CC", Offset = "0x122F2CC", VA = "0x122F2CC")]
	public bool GetPublicBool(string settingName)
	{
		return default(bool);
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00006A08 File Offset: 0x00004C08
	[Token(Token = "0x6000F0C")]
	[Address(RVA = "0x122F2EC", Offset = "0x122F2EC", VA = "0x122F2EC")]
	public bool GetPublicBool(string settingName, bool defaultValue)
	{
		return default(bool);
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F0D")]
	[Address(RVA = "0x12145BC", Offset = "0x12145BC", VA = "0x12145BC")]
	public void SetPublicBool(string settingName, bool value)
	{
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x00006A20 File Offset: 0x00004C20
	[Token(Token = "0x6000F0E")]
	[Address(RVA = "0x122F310", Offset = "0x122F310", VA = "0x122F310")]
	public int GetPublicInt(string settingName)
	{
		return 0;
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x00006A38 File Offset: 0x00004C38
	[Token(Token = "0x6000F0F")]
	[Address(RVA = "0x122F0D0", Offset = "0x122F0D0", VA = "0x122F0D0")]
	public int GetPublicInt(string settingName, int defaultValue)
	{
		return 0;
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F10")]
	[Address(RVA = "0x122F12C", Offset = "0x122F12C", VA = "0x122F12C")]
	public void SetPublicInt(string settingName, int value)
	{
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x00006A50 File Offset: 0x00004C50
	[Token(Token = "0x6000F11")]
	[Address(RVA = "0x122F31C", Offset = "0x122F31C", VA = "0x122F31C")]
	public float GetPublicFloat(string settingName)
	{
		return 0f;
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x00006A68 File Offset: 0x00004C68
	[Token(Token = "0x6000F12")]
	[Address(RVA = "0x122F328", Offset = "0x122F328", VA = "0x122F328")]
	public float GetPublicFloat(string settingName, float defaultValue)
	{
		return 0f;
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F13")]
	[Address(RVA = "0x122F334", Offset = "0x122F334", VA = "0x122F334")]
	public void SetPublicFloat(string settingName, float value)
	{
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F14")]
	[Address(RVA = "0x122F340", Offset = "0x122F340", VA = "0x122F340")]
	public string GetPublicString(string settingName)
	{
		return null;
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F15")]
	[Address(RVA = "0x122EC40", Offset = "0x122EC40", VA = "0x122EC40")]
	public string GetPublicString(string settingName, string defaultValue)
	{
		return null;
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F16")]
	[Address(RVA = "0x122EEE8", Offset = "0x122EEE8", VA = "0x122EEE8")]
	public void SetPublicString(string settingName, string value)
	{
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00006A80 File Offset: 0x00004C80
	[Token(Token = "0x6000F17")]
	[Address(RVA = "0x122F34C", Offset = "0x122F34C", VA = "0x122F34C")]
	public bool GetBool(string settingName)
	{
		return default(bool);
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00006A98 File Offset: 0x00004C98
	[Token(Token = "0x6000F18")]
	[Address(RVA = "0x122F36C", Offset = "0x122F36C", VA = "0x122F36C")]
	public bool GetBool(string settingName, bool defaultValue)
	{
		return default(bool);
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F19")]
	[Address(RVA = "0x122F390", Offset = "0x122F390", VA = "0x122F390")]
	public void SetBool(string settingName, bool value)
	{
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00006AB0 File Offset: 0x00004CB0
	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0x122F3A4", Offset = "0x122F3A4", VA = "0x122F3A4")]
	public int GetInt(string settingName)
	{
		return 0;
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00006AC8 File Offset: 0x00004CC8
	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0x122F3B0", Offset = "0x122F3B0", VA = "0x122F3B0")]
	public int GetInt(string settingName, int defaultValue)
	{
		return 0;
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0x122F3C0", Offset = "0x122F3C0", VA = "0x122F3C0")]
	public void SetInt(string settingName, int value)
	{
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00006AE0 File Offset: 0x00004CE0
	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0x122F3D0", Offset = "0x122F3D0", VA = "0x122F3D0")]
	public float GetFloat(string settingName)
	{
		return 0f;
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x00006AF8 File Offset: 0x00004CF8
	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0x122F3DC", Offset = "0x122F3DC", VA = "0x122F3DC")]
	public float GetFloat(string settingName, float defaultValue)
	{
		return 0f;
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0x122F3E8", Offset = "0x122F3E8", VA = "0x122F3E8")]
	public void SetFloat(string settingName, float value)
	{
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F20")]
	[Address(RVA = "0x122F3F4", Offset = "0x122F3F4", VA = "0x122F3F4")]
	public string GetString(string settingName)
	{
		return null;
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F21")]
	[Address(RVA = "0x1225B38", Offset = "0x1225B38", VA = "0x1225B38")]
	public string GetString(string settingName, string defaultValue)
	{
		return null;
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x1225E2C", Offset = "0x1225E2C", VA = "0x1225E2C")]
	public void SetString(string settingName, string value)
	{
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00006B10 File Offset: 0x00004D10
	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x122F400", Offset = "0x122F400", VA = "0x122F400")]
	public bool GetPrivateBool(string settingName)
	{
		return default(bool);
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00006B28 File Offset: 0x00004D28
	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x122F430", Offset = "0x122F430", VA = "0x122F430")]
	public bool GetPrivateBool(string settingName, bool defaultValue)
	{
		return default(bool);
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x122F468", Offset = "0x122F468", VA = "0x122F468")]
	public void SetPrivateBool(string settingName, bool value)
	{
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F26")]
	[Address(RVA = "0x122F514", Offset = "0x122F514", VA = "0x122F514")]
	public void SetPrivateInt(string settingName, int value)
	{
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00006B40 File Offset: 0x00004D40
	[Token(Token = "0x6000F27")]
	[Address(RVA = "0x122F540", Offset = "0x122F540", VA = "0x122F540")]
	public int GetPrivateInt(string settingName, int value)
	{
		return 0;
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F28")]
	[Address(RVA = "0x122F56C", Offset = "0x122F56C", VA = "0x122F56C")]
	public void SetPrivateFloat(string settingName, float value)
	{
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00006B58 File Offset: 0x00004D58
	[Token(Token = "0x6000F29")]
	[Address(RVA = "0x122F5A0", Offset = "0x122F5A0", VA = "0x122F5A0")]
	public float GetPrivateFloat(string settingName, float value)
	{
		return 0f;
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0x122F5D4", Offset = "0x122F5D4", VA = "0x122F5D4")]
	public string GetPrivateString(string settingName, string defaultValue)
	{
		return null;
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0x122F600", Offset = "0x122F600", VA = "0x122F600")]
	public void SetPrivateString(string settingName, string value)
	{
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00006B70 File Offset: 0x00004D70
	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0x122F62C", Offset = "0x122F62C", VA = "0x122F62C")]
	public bool HasSettingById(int keyId)
	{
		return default(bool);
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0x122F68C", Offset = "0x122F68C", VA = "0x122F68C")]
	public void RemoveSettingById(int keyId)
	{
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00006B88 File Offset: 0x00004D88
	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0x122F6EC", Offset = "0x122F6EC", VA = "0x122F6EC")]
	public bool GetBoolById(int keyId, bool defaultValue = false)
	{
		return default(bool);
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00006BA0 File Offset: 0x00004DA0
	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0x122F768", Offset = "0x122F768", VA = "0x122F768")]
	public int GetIntById(int keyId, int defaultValue = 0)
	{
		return 0;
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x00006BB8 File Offset: 0x00004DB8
	[Token(Token = "0x6000F30")]
	[Address(RVA = "0x122F7D8", Offset = "0x122F7D8", VA = "0x122F7D8")]
	public float GetFloatById(int keyId, float defaultValue = 0f)
	{
		return 0f;
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x122F848", Offset = "0x122F848", VA = "0x122F848")]
	public string GetStringById(int keyId)
	{
		return null;
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x122F8A8", Offset = "0x122F8A8", VA = "0x122F8A8")]
	public void SetBoolById(int keyId, bool value)
	{
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F33")]
	[Address(RVA = "0x122F918", Offset = "0x122F918", VA = "0x122F918")]
	public void SetIntById(int keyId, int value)
	{
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F34")]
	[Address(RVA = "0x122F988", Offset = "0x122F988", VA = "0x122F988")]
	public void SetFloatById(int keyId, float value)
	{
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F35")]
	[Address(RVA = "0x122F9F8", Offset = "0x122F9F8", VA = "0x122F9F8")]
	public void SetStringById(int keyId, int valueId)
	{
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x122FA7C", Offset = "0x122FA7C", VA = "0x122FA7C")]
	public void SetStringByKeyId(int keyId, string value)
	{
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x122FAEC", Offset = "0x122FAEC", VA = "0x122FAEC")]
	public void InitWindowsBridge()
	{
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x122FBD8", Offset = "0x122FBD8", VA = "0x122FBD8")]
	public GameSettings LoadSettings()
	{
		return null;
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x122FCA8", Offset = "0x122FCA8", VA = "0x122FCA8")]
	public void SetGMFlag(int gmflag)
	{
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0x122FCAC", Offset = "0x122FCAC", VA = "0x122FCAC")]
	public void SetUUID(string uuid)
	{
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0x122FCB0", Offset = "0x122FCB0", VA = "0x122FCB0")]
	public SettingManager()
	{
	}

	// Token: 0x040011E7 RID: 4583
	[Token(Token = "0x40011E7")]
	[FieldOffset(Offset = "0x10")]
	private string _gameUid;

	// Token: 0x040011E8 RID: 4584
	[Token(Token = "0x40011E8")]
	[FieldOffset(Offset = "0x18")]
	private string _settingsFilePath;

	// Token: 0x040011E9 RID: 4585
	[Token(Token = "0x40011E9")]
	[FieldOffset(Offset = "0x20")]
	private GameSettings _setting_bridge;
}
