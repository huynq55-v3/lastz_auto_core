using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using LitJson;
using Sfs2X.Entities.Data;
using Sfs2X.Util;

namespace Sfs2X.Protocol.Serialization
{
	// Token: 0x02000A64 RID: 2660
	[Token(Token = "0x2000A64")]
	public class UnrealDefaultSFSDataSerializer
	{
		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060064D8 RID: 25816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AD")]
		public static UnrealDefaultSFSDataSerializer Instance
		{
			[Token(Token = "0x60064D8")]
			[Address(RVA = "0x2E04D7C", Offset = "0x2E04D7C", VA = "0x2E04D7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060064D9 RID: 25817 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060064DA RID: 25818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006AE")]
		public static Assembly RunningAssembly
		{
			[Token(Token = "0x60064D9")]
			[Address(RVA = "0x2E04E38", Offset = "0x2E04E38", VA = "0x2E04E38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60064DA")]
			[Address(RVA = "0x2E04E90", Offset = "0x2E04E90", VA = "0x2E04E90")]
			set
			{
			}
		}

		// Token: 0x060064DB RID: 25819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064DB")]
		[Address(RVA = "0x2E04E30", Offset = "0x2E04E30", VA = "0x2E04E30")]
		public UnrealDefaultSFSDataSerializer()
		{
		}

		// Token: 0x060064DC RID: 25820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DC")]
		[Address(RVA = "0x2E04EF0", Offset = "0x2E04EF0", VA = "0x2E04EF0")]
		public ByteArray Object2Binary(ISFSObject obj, ByteArray buffer)
		{
			return null;
		}

		// Token: 0x060064DD RID: 25821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DD")]
		[Address(RVA = "0x2E05004", Offset = "0x2E05004", VA = "0x2E05004")]
		private ByteArray Obj2bin(ISFSObject obj, ByteArray buffer)
		{
			return null;
		}

		// Token: 0x060064DE RID: 25822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DE")]
		[Address(RVA = "0x2E05168", Offset = "0x2E05168", VA = "0x2E05168")]
		public ByteArray Array2Binary(ISFSArray array, ByteArray buffer)
		{
			return null;
		}

		// Token: 0x060064DF RID: 25823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064DF")]
		[Address(RVA = "0x2E0527C", Offset = "0x2E0527C", VA = "0x2E0527C")]
		private ByteArray Arr2bin(ISFSArray array, ByteArray buffer)
		{
			return null;
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E0")]
		[Address(RVA = "0x2E059BC", Offset = "0x2E059BC", VA = "0x2E059BC")]
		public ISFSObject ParseHeaderAndCmd(ByteArray data)
		{
			return null;
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E1")]
		[Address(RVA = "0x2E05A80", Offset = "0x2E05A80", VA = "0x2E05A80")]
		private ISFSObject DecodeSFSObject_1stLevel(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x0004C1D0 File Offset: 0x0004A3D0
		[Token(Token = "0x60064E2")]
		[Address(RVA = "0x2E05E40", Offset = "0x2E05E40", VA = "0x2E05E40")]
		private int DecodeSFSObject_2ndLevel(ByteArray buffer, out SFSDataWrapper cmdWrapper)
		{
			return 0;
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E3")]
		[Address(RVA = "0x2E062E8", Offset = "0x2E062E8", VA = "0x2E062E8")]
		public string DecodeSFSObject_CmdID(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E4")]
		[Address(RVA = "0x2E064D8", Offset = "0x2E064D8", VA = "0x2E064D8")]
		private void DecodeSFSObject(ByteArray buffer)
		{
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E5")]
		[Address(RVA = "0x2E06734", Offset = "0x2E06734", VA = "0x2E06734")]
		public ISFSArray Binary2Array(ByteArray data)
		{
			return null;
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E6")]
		[Address(RVA = "0x2E067F0", Offset = "0x2E067F0", VA = "0x2E067F0")]
		private void DecodeSFSArray(ByteArray buffer)
		{
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E7")]
		[Address(RVA = "0x2E0600C", Offset = "0x2E0600C", VA = "0x2E0600C")]
		private void DecodeObject(ByteArray buffer)
		{
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E8")]
		[Address(RVA = "0x2E053BC", Offset = "0x2E053BC", VA = "0x2E053BC")]
		private ByteArray EncodeObject2(ByteArray buffer, SFSDataWrapper dataWrapper)
		{
			return null;
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064E9")]
		[Address(RVA = "0x2E06C84", Offset = "0x2E06C84", VA = "0x2E06C84")]
		private void BinDecode_TEXT(ByteArray buffer)
		{
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EA")]
		[Address(RVA = "0x2E06AD8", Offset = "0x2E06AD8", VA = "0x2E06AD8")]
		private void BinDecode_SHORT_ARRAY(ByteArray buffer)
		{
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EB")]
		[Address(RVA = "0x2E06B18", Offset = "0x2E06B18", VA = "0x2E06B18")]
		private void BinDecode_INT_ARRAY(ByteArray buffer)
		{
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EC")]
		[Address(RVA = "0x2E06B64", Offset = "0x2E06B64", VA = "0x2E06B64")]
		private void BinDecode_LONG_ARRAY(ByteArray buffer)
		{
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064ED")]
		[Address(RVA = "0x2E06BB0", Offset = "0x2E06BB0", VA = "0x2E06BB0")]
		private void BinDecode_FLOAT_ARRAY(ByteArray buffer)
		{
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EE")]
		[Address(RVA = "0x2E06BF0", Offset = "0x2E06BF0", VA = "0x2E06BF0")]
		private void BinDecode_DOUBLE_ARRAY(ByteArray buffer)
		{
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064EF")]
		[Address(RVA = "0x2E06C30", Offset = "0x2E06C30", VA = "0x2E06C30")]
		private void BinDecode_UTF_STRING_ARRAY(ByteArray buffer)
		{
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x0004C1E8 File Offset: 0x0004A3E8
		[Token(Token = "0x60064F0")]
		[Address(RVA = "0x2E06A38", Offset = "0x2E06A38", VA = "0x2E06A38")]
		private int GetTypedArraySize(ByteArray buffer)
		{
			return 0;
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F1")]
		[Address(RVA = "0x2E06C98", Offset = "0x2E06C98", VA = "0x2E06C98")]
		public ByteArray BinEncode_NULL(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F2")]
		[Address(RVA = "0x2E06CC0", Offset = "0x2E06CC0", VA = "0x2E06CC0")]
		public ByteArray BinEncode_BOOL(ByteArray buffer, bool val)
		{
			return null;
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F3")]
		[Address(RVA = "0x2E06D00", Offset = "0x2E06D00", VA = "0x2E06D00")]
		public ByteArray BinEncode_BYTE(ByteArray buffer, byte val)
		{
			return null;
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F4")]
		[Address(RVA = "0x2E06D40", Offset = "0x2E06D40", VA = "0x2E06D40")]
		public ByteArray BinEncode_SHORT(ByteArray buffer, short val)
		{
			return null;
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F5")]
		[Address(RVA = "0x2E06D80", Offset = "0x2E06D80", VA = "0x2E06D80")]
		public ByteArray BinEncode_INT(ByteArray buffer, int val)
		{
			return null;
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F6")]
		[Address(RVA = "0x2E06DC0", Offset = "0x2E06DC0", VA = "0x2E06DC0")]
		public ByteArray BinEncode_LONG(ByteArray buffer, long val)
		{
			return null;
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F7")]
		[Address(RVA = "0x2E06E00", Offset = "0x2E06E00", VA = "0x2E06E00")]
		public ByteArray BinEncode_FLOAT(ByteArray buffer, float val)
		{
			return null;
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F8")]
		[Address(RVA = "0x2E06E40", Offset = "0x2E06E40", VA = "0x2E06E40")]
		public ByteArray BinEncode_DOUBLE(ByteArray buffer, double val)
		{
			return null;
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064F9")]
		[Address(RVA = "0x2E07538", Offset = "0x2E07538", VA = "0x2E07538")]
		public ByteArray BinEncode_INT(ByteArray buffer, double val)
		{
			return null;
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FA")]
		[Address(RVA = "0x2E06E80", Offset = "0x2E06E80", VA = "0x2E06E80")]
		public ByteArray BinEncode_UTF_STRING(ByteArray buffer, string val)
		{
			return null;
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FB")]
		[Address(RVA = "0x2E074F8", Offset = "0x2E074F8", VA = "0x2E074F8")]
		public ByteArray BinEncode_TEXT(ByteArray buffer, string val)
		{
			return null;
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FC")]
		[Address(RVA = "0x2E06EC0", Offset = "0x2E06EC0", VA = "0x2E06EC0")]
		public ByteArray BinEncode_BOOL_ARRAY(ByteArray buffer, bool[] val)
		{
			return null;
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FD")]
		[Address(RVA = "0x2E06F90", Offset = "0x2E06F90", VA = "0x2E06F90")]
		public ByteArray BinEncode_BYTE_ARRAY(ByteArray buffer, ByteArray val)
		{
			return null;
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FE")]
		[Address(RVA = "0x2E06FE0", Offset = "0x2E06FE0", VA = "0x2E06FE0")]
		public ByteArray BinEncode_SHORT_ARRAY(ByteArray buffer, short[] val)
		{
			return null;
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064FF")]
		[Address(RVA = "0x2E070B0", Offset = "0x2E070B0", VA = "0x2E070B0")]
		public ByteArray BinEncode_INT_ARRAY(ByteArray buffer, int[] val)
		{
			return null;
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006500")]
		[Address(RVA = "0x2E07180", Offset = "0x2E07180", VA = "0x2E07180")]
		public ByteArray BinEncode_LONG_ARRAY(ByteArray buffer, long[] val)
		{
			return null;
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006501")]
		[Address(RVA = "0x2E07250", Offset = "0x2E07250", VA = "0x2E07250")]
		public ByteArray BinEncode_FLOAT_ARRAY(ByteArray buffer, float[] val)
		{
			return null;
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006502")]
		[Address(RVA = "0x2E07320", Offset = "0x2E07320", VA = "0x2E07320")]
		public ByteArray BinEncode_DOUBLE_ARRAY(ByteArray buffer, double[] val)
		{
			return null;
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006503")]
		[Address(RVA = "0x2E073F0", Offset = "0x2E073F0", VA = "0x2E073F0")]
		public ByteArray BinEncode_UTF_STRING_ARRAY(ByteArray buffer, string[] val)
		{
			return null;
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006504")]
		[Address(RVA = "0x2E07578", Offset = "0x2E07578", VA = "0x2E07578")]
		public ByteArray EncodeSFSObjectKey(ByteArray buffer, string val)
		{
			return null;
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006505")]
		[Address(RVA = "0x2E075A0", Offset = "0x2E075A0", VA = "0x2E075A0")]
		public ByteArray AddData(ByteArray buffer, ByteArray newData)
		{
			return null;
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006506")]
		[Address(RVA = "0x2E075C8", Offset = "0x2E075C8", VA = "0x2E075C8")]
		public string Object2Json(Dictionary<string, object> map)
		{
			return null;
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006507")]
		[Address(RVA = "0x2E07620", Offset = "0x2E07620", VA = "0x2E07620")]
		public void flattenObject(Dictionary<string, object> map, ISFSObject sfsObj)
		{
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006508")]
		[Address(RVA = "0x2E07770", Offset = "0x2E07770", VA = "0x2E07770")]
		public string Array2Json(List<object> list)
		{
			return null;
		}

		// Token: 0x06006509 RID: 25865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006509")]
		[Address(RVA = "0x2E077C8", Offset = "0x2E077C8", VA = "0x2E077C8")]
		public void flattenArray(List<object> list, ISFSArray sfsArray)
		{
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650A")]
		[Address(RVA = "0x2E07B80", Offset = "0x2E07B80", VA = "0x2E07B80")]
		public ISFSObject Json2Object(string jsonStr)
		{
			return null;
		}

		// Token: 0x0600650B RID: 25867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650B")]
		[Address(RVA = "0x2E080A4", Offset = "0x2E080A4", VA = "0x2E080A4")]
		public ISFSArray Json2Array(string jsonStr)
		{
			return null;
		}

		// Token: 0x0600650C RID: 25868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650C")]
		[Address(RVA = "0x2E07C84", Offset = "0x2E07C84", VA = "0x2E07C84")]
		private ISFSObject decodeSFSObject(JsonData jdo)
		{
			return null;
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650D")]
		[Address(RVA = "0x2E081A8", Offset = "0x2E081A8", VA = "0x2E081A8")]
		private ISFSArray decodeSFSArray(JsonData jdo)
		{
			return null;
		}

		// Token: 0x0600650E RID: 25870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650E")]
		[Address(RVA = "0x2E0835C", Offset = "0x2E0835C", VA = "0x2E0835C")]
		private SFSDataWrapper decodeJsonObject(JsonData jdo)
		{
			return null;
		}

		// Token: 0x0600650F RID: 25871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600650F")]
		[Address(RVA = "0x2E074C0", Offset = "0x2E074C0", VA = "0x2E074C0")]
		public ISFSObject Cs2Sfs(object csObj)
		{
			return null;
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006510")]
		[Address(RVA = "0x2E086C0", Offset = "0x2E086C0", VA = "0x2E086C0")]
		private void ConvertCsObj(object csObj, ISFSObject sfsObj)
		{
		}

		// Token: 0x06006511 RID: 25873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006511")]
		[Address(RVA = "0x2E08DF4", Offset = "0x2E08DF4", VA = "0x2E08DF4")]
		private SFSDataWrapper WrapField(object val)
		{
			return null;
		}

		// Token: 0x06006512 RID: 25874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006512")]
		[Address(RVA = "0x2E09168", Offset = "0x2E09168", VA = "0x2E09168")]
		private ISFSArray UnrollArray(ArrayList arr)
		{
			return null;
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006513")]
		[Address(RVA = "0x2E0954C", Offset = "0x2E0954C", VA = "0x2E0954C")]
		private ISFSObject UnrollDictionary(Hashtable dict)
		{
			return null;
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006514")]
		[Address(RVA = "0x2E09BB4", Offset = "0x2E09BB4", VA = "0x2E09BB4")]
		public object Sfs2Cs(ISFSObject sfsObj)
		{
			return null;
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006515")]
		[Address(RVA = "0x2E0A14C", Offset = "0x2E0A14C", VA = "0x2E0A14C")]
		private void ConvertSFSObject(ISFSArray fieldList, object csObj, Type objType)
		{
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006516")]
		[Address(RVA = "0x2E0A410", Offset = "0x2E0A410", VA = "0x2E0A410")]
		private object UnwrapField(SFSDataWrapper wrapper)
		{
			return null;
		}

		// Token: 0x06006517 RID: 25879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006517")]
		[Address(RVA = "0x2E0A664", Offset = "0x2E0A664", VA = "0x2E0A664")]
		private ArrayList RebuildArray(ISFSArray sfsArr)
		{
			return null;
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006518")]
		[Address(RVA = "0x2E0A7DC", Offset = "0x2E0A7DC", VA = "0x2E0A7DC")]
		private Hashtable RebuildDict(ISFSObject sfsObj)
		{
			return null;
		}

		// Token: 0x0400289C RID: 10396
		[Token(Token = "0x400289C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string CLASS_MARKER_KEY;

		// Token: 0x0400289D RID: 10397
		[Token(Token = "0x400289D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string CLASS_FIELDS_KEY;

		// Token: 0x0400289E RID: 10398
		[Token(Token = "0x400289E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string FIELD_NAME_KEY;

		// Token: 0x0400289F RID: 10399
		[Token(Token = "0x400289F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string FIELD_VALUE_KEY;

		// Token: 0x040028A0 RID: 10400
		[Token(Token = "0x40028A0")]
		[FieldOffset(Offset = "0x20")]
		private static Assembly runningAssembly;

		// Token: 0x040028A1 RID: 10401
		[Token(Token = "0x40028A1")]
		[FieldOffset(Offset = "0x28")]
		private static UnrealDefaultSFSDataSerializer instance;
	}
}
