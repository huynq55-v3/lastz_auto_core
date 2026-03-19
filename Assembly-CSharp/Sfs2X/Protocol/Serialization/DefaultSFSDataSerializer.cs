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
	// Token: 0x02000A5E RID: 2654
	[Token(Token = "0x2000A5E")]
	public class DefaultSFSDataSerializer : ISFSDataSerializer
	{
		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06006480 RID: 25728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AB")]
		public static DefaultSFSDataSerializer Instance
		{
			[Token(Token = "0x6006480")]
			[Address(RVA = "0x2DFDCFC", Offset = "0x2DFDCFC", VA = "0x2DFDCFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06006481 RID: 25729 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006482 RID: 25730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006AC")]
		public static Assembly RunningAssembly
		{
			[Token(Token = "0x6006481")]
			[Address(RVA = "0x2DFDDB8", Offset = "0x2DFDDB8", VA = "0x2DFDDB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006482")]
			[Address(RVA = "0x2DFDE10", Offset = "0x2DFDE10", VA = "0x2DFDE10")]
			set
			{
			}
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006483")]
		[Address(RVA = "0x2DFDDB0", Offset = "0x2DFDDB0", VA = "0x2DFDDB0")]
		public DefaultSFSDataSerializer()
		{
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006484")]
		[Address(RVA = "0x2DFDE70", Offset = "0x2DFDE70", VA = "0x2DFDE70", Slot = "4")]
		public ByteArray Object2Binary(ISFSObject obj, ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006485")]
		[Address(RVA = "0x2DFDF84", Offset = "0x2DFDF84", VA = "0x2DFDF84")]
		private ByteArray Obj2bin(ISFSObject obj, ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006486")]
		[Address(RVA = "0x2DFE0E8", Offset = "0x2DFE0E8", VA = "0x2DFE0E8", Slot = "5")]
		public ByteArray Array2Binary(ISFSArray array, ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006487")]
		[Address(RVA = "0x2DFE1FC", Offset = "0x2DFE1FC", VA = "0x2DFE1FC")]
		private ByteArray Arr2bin(ISFSArray array, ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006488")]
		[Address(RVA = "0x2DFE93C", Offset = "0x2DFE93C", VA = "0x2DFE93C", Slot = "6")]
		public ISFSObject Binary2Object(ByteArray data)
		{
			return null;
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006489")]
		[Address(RVA = "0x2DFEA58", Offset = "0x2DFEA58", VA = "0x2DFEA58")]
		private ISFSObject DecodeSFSObject(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600648A RID: 25738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648A")]
		[Address(RVA = "0x2DFF34C", Offset = "0x2DFF34C", VA = "0x2DFF34C", Slot = "7")]
		public ISFSArray Binary2Array(ByteArray data)
		{
			return null;
		}

		// Token: 0x0600648B RID: 25739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648B")]
		[Address(RVA = "0x2DFF400", Offset = "0x2DFF400", VA = "0x2DFF400")]
		private ISFSArray DecodeSFSArray(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600648C RID: 25740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648C")]
		[Address(RVA = "0x2DFED38", Offset = "0x2DFED38", VA = "0x2DFED38")]
		private SFSDataWrapper DecodeObject(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600648D RID: 25741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648D")]
		[Address(RVA = "0x2DFE33C", Offset = "0x2DFE33C", VA = "0x2DFE33C")]
		private ByteArray EncodeObject2(ByteArray buffer, SFSDataWrapper dataWrapper)
		{
			return null;
		}

		// Token: 0x0600648E RID: 25742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648E")]
		[Address(RVA = "0x2DFF7B4", Offset = "0x2DFF7B4", VA = "0x2DFF7B4")]
		private SFSDataWrapper BinDecode_NULL(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600648F RID: 25743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600648F")]
		[Address(RVA = "0x2DFF814", Offset = "0x2DFF814", VA = "0x2DFF814")]
		private SFSDataWrapper BinDecode_BOOL(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006490 RID: 25744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006490")]
		[Address(RVA = "0x2DFF88C", Offset = "0x2DFF88C", VA = "0x2DFF88C")]
		private SFSDataWrapper BinDecode_BYTE(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006491 RID: 25745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006491")]
		[Address(RVA = "0x2DFF904", Offset = "0x2DFF904", VA = "0x2DFF904")]
		private SFSDataWrapper BinDecode_SHORT(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006492 RID: 25746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006492")]
		[Address(RVA = "0x2DFF97C", Offset = "0x2DFF97C", VA = "0x2DFF97C")]
		private SFSDataWrapper BinDecode_INT(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006493")]
		[Address(RVA = "0x2DFF9F4", Offset = "0x2DFF9F4", VA = "0x2DFF9F4")]
		private SFSDataWrapper BinDecode_LONG(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006494")]
		[Address(RVA = "0x2DFFA6C", Offset = "0x2DFFA6C", VA = "0x2DFFA6C")]
		private SFSDataWrapper BinDecode_FLOAT(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006495")]
		[Address(RVA = "0x2DFFB10", Offset = "0x2DFFB10", VA = "0x2DFFB10")]
		private SFSDataWrapper BinDecode_DOUBLE(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006496 RID: 25750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006496")]
		[Address(RVA = "0x2DFFBB4", Offset = "0x2DFFBB4", VA = "0x2DFFBB4")]
		private SFSDataWrapper BinDecode_UTF_STRING(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006497 RID: 25751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006497")]
		[Address(RVA = "0x2E00A30", Offset = "0x2E00A30", VA = "0x2E00A30")]
		private SFSDataWrapper BinDecode_TEXT(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006498 RID: 25752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006498")]
		[Address(RVA = "0x2DFFC2C", Offset = "0x2DFFC2C", VA = "0x2DFFC2C")]
		private SFSDataWrapper BinDecode_BOOL_ARRAY(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x06006499 RID: 25753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006499")]
		[Address(RVA = "0x2DFFD14", Offset = "0x2DFFD14", VA = "0x2DFFD14")]
		private SFSDataWrapper BinDecode_BYTE_ARRAY(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600649A RID: 25754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649A")]
		[Address(RVA = "0x2DFFE40", Offset = "0x2DFFE40", VA = "0x2DFFE40")]
		private SFSDataWrapper BinDecode_SHORT_ARRAY(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600649B RID: 25755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649B")]
		[Address(RVA = "0x2DFFF24", Offset = "0x2DFFF24", VA = "0x2DFFF24")]
		private SFSDataWrapper BinDecode_INT_ARRAY(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600649C RID: 25756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649C")]
		[Address(RVA = "0x2E00008", Offset = "0x2E00008", VA = "0x2E00008")]
		private SFSDataWrapper BinDecode_LONG_ARRAY(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600649D RID: 25757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649D")]
		[Address(RVA = "0x2E000EC", Offset = "0x2E000EC", VA = "0x2E000EC")]
		private SFSDataWrapper BinDecode_FLOAT_ARRAY(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600649E RID: 25758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649E")]
		[Address(RVA = "0x2E001D0", Offset = "0x2E001D0", VA = "0x2E001D0")]
		private SFSDataWrapper BinDecode_DOUBLE_ARRAY(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x0600649F RID: 25759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600649F")]
		[Address(RVA = "0x2E002B4", Offset = "0x2E002B4", VA = "0x2E002B4")]
		private SFSDataWrapper BinDecode_UTF_STRING_ARRAY(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x060064A0 RID: 25760 RVA: 0x0004C1B8 File Offset: 0x0004A3B8
		[Token(Token = "0x60064A0")]
		[Address(RVA = "0x2E018F4", Offset = "0x2E018F4", VA = "0x2E018F4")]
		private int GetTypedArraySize(ByteArray buffer)
		{
			return 0;
		}

		// Token: 0x060064A1 RID: 25761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A1")]
		[Address(RVA = "0x2E00AA8", Offset = "0x2E00AA8", VA = "0x2E00AA8")]
		public ByteArray BinEncode_NULL(ByteArray buffer)
		{
			return null;
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A2")]
		[Address(RVA = "0x2E00AE8", Offset = "0x2E00AE8", VA = "0x2E00AE8")]
		public ByteArray BinEncode_BOOL(ByteArray buffer, bool val)
		{
			return null;
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A3")]
		[Address(RVA = "0x2E00B38", Offset = "0x2E00B38", VA = "0x2E00B38")]
		public ByteArray BinEncode_BYTE(ByteArray buffer, byte val)
		{
			return null;
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A4")]
		[Address(RVA = "0x2E00B88", Offset = "0x2E00B88", VA = "0x2E00B88")]
		public ByteArray BinEncode_SHORT(ByteArray buffer, short val)
		{
			return null;
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A5")]
		[Address(RVA = "0x2E00BD8", Offset = "0x2E00BD8", VA = "0x2E00BD8")]
		public ByteArray BinEncode_INT(ByteArray buffer, int val)
		{
			return null;
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A6")]
		[Address(RVA = "0x2E00D08", Offset = "0x2E00D08", VA = "0x2E00D08")]
		public ByteArray BinEncode_LONG(ByteArray buffer, long val)
		{
			return null;
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A7")]
		[Address(RVA = "0x2E00E64", Offset = "0x2E00E64", VA = "0x2E00E64")]
		public ByteArray BinEncode_FLOAT(ByteArray buffer, float val)
		{
			return null;
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A8")]
		[Address(RVA = "0x2E00EA4", Offset = "0x2E00EA4", VA = "0x2E00EA4")]
		public ByteArray BinEncode_DOUBLE(ByteArray buffer, double val)
		{
			return null;
		}

		// Token: 0x060064A9 RID: 25769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A9")]
		[Address(RVA = "0x2E01994", Offset = "0x2E01994", VA = "0x2E01994")]
		public ByteArray BinEncode_INT(ByteArray buffer, double val)
		{
			return null;
		}

		// Token: 0x060064AA RID: 25770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AA")]
		[Address(RVA = "0x2E00EE4", Offset = "0x2E00EE4", VA = "0x2E00EE4")]
		public ByteArray BinEncode_UTF_STRING(ByteArray buffer, string val)
		{
			return null;
		}

		// Token: 0x060064AB RID: 25771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AB")]
		[Address(RVA = "0x2E0155C", Offset = "0x2E0155C", VA = "0x2E0155C")]
		public ByteArray BinEncode_TEXT(ByteArray buffer, string val)
		{
			return null;
		}

		// Token: 0x060064AC RID: 25772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AC")]
		[Address(RVA = "0x2E00F24", Offset = "0x2E00F24", VA = "0x2E00F24")]
		public ByteArray BinEncode_BOOL_ARRAY(ByteArray buffer, bool[] val)
		{
			return null;
		}

		// Token: 0x060064AD RID: 25773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AD")]
		[Address(RVA = "0x2E00FF4", Offset = "0x2E00FF4", VA = "0x2E00FF4")]
		public ByteArray BinEncode_BYTE_ARRAY(ByteArray buffer, ByteArray val)
		{
			return null;
		}

		// Token: 0x060064AE RID: 25774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AE")]
		[Address(RVA = "0x2E01044", Offset = "0x2E01044", VA = "0x2E01044")]
		public ByteArray BinEncode_SHORT_ARRAY(ByteArray buffer, short[] val)
		{
			return null;
		}

		// Token: 0x060064AF RID: 25775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064AF")]
		[Address(RVA = "0x2E01114", Offset = "0x2E01114", VA = "0x2E01114")]
		public ByteArray BinEncode_INT_ARRAY(ByteArray buffer, int[] val)
		{
			return null;
		}

		// Token: 0x060064B0 RID: 25776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B0")]
		[Address(RVA = "0x2E011E4", Offset = "0x2E011E4", VA = "0x2E011E4")]
		public ByteArray BinEncode_LONG_ARRAY(ByteArray buffer, long[] val)
		{
			return null;
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B1")]
		[Address(RVA = "0x2E012B4", Offset = "0x2E012B4", VA = "0x2E012B4")]
		public ByteArray BinEncode_FLOAT_ARRAY(ByteArray buffer, float[] val)
		{
			return null;
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B2")]
		[Address(RVA = "0x2E01384", Offset = "0x2E01384", VA = "0x2E01384")]
		public ByteArray BinEncode_DOUBLE_ARRAY(ByteArray buffer, double[] val)
		{
			return null;
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B3")]
		[Address(RVA = "0x2E01454", Offset = "0x2E01454", VA = "0x2E01454")]
		public ByteArray BinEncode_UTF_STRING_ARRAY(ByteArray buffer, string[] val)
		{
			return null;
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B4")]
		[Address(RVA = "0x2E019D4", Offset = "0x2E019D4", VA = "0x2E019D4")]
		public ByteArray EncodeSFSObjectKey(ByteArray buffer, string val)
		{
			return null;
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B5")]
		[Address(RVA = "0x2E019FC", Offset = "0x2E019FC", VA = "0x2E019FC")]
		public ByteArray AddData(ByteArray buffer, ByteArray newData)
		{
			return null;
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B6")]
		[Address(RVA = "0x2E01A24", Offset = "0x2E01A24", VA = "0x2E01A24", Slot = "8")]
		public string Object2Json(Dictionary<string, object> map)
		{
			return null;
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B7")]
		[Address(RVA = "0x2E01A7C", Offset = "0x2E01A7C", VA = "0x2E01A7C")]
		public void flattenObject(Dictionary<string, object> map, ISFSObject sfsObj)
		{
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B8")]
		[Address(RVA = "0x2E01BCC", Offset = "0x2E01BCC", VA = "0x2E01BCC", Slot = "9")]
		public string Array2Json(List<object> list)
		{
			return null;
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064B9")]
		[Address(RVA = "0x2E01C24", Offset = "0x2E01C24", VA = "0x2E01C24")]
		public void flattenArray(List<object> list, ISFSArray sfsArray)
		{
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BA")]
		[Address(RVA = "0x2E01FDC", Offset = "0x2E01FDC", VA = "0x2E01FDC", Slot = "10")]
		public ISFSObject Json2Object(string jsonStr)
		{
			return null;
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BB")]
		[Address(RVA = "0x2E02500", Offset = "0x2E02500", VA = "0x2E02500", Slot = "11")]
		public ISFSArray Json2Array(string jsonStr)
		{
			return null;
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BC")]
		[Address(RVA = "0x2E020E0", Offset = "0x2E020E0", VA = "0x2E020E0")]
		private ISFSObject decodeSFSObject(JsonData jdo)
		{
			return null;
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BD")]
		[Address(RVA = "0x2E02604", Offset = "0x2E02604", VA = "0x2E02604")]
		private ISFSArray decodeSFSArray(JsonData jdo)
		{
			return null;
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BE")]
		[Address(RVA = "0x2E027B8", Offset = "0x2E027B8", VA = "0x2E027B8")]
		private SFSDataWrapper decodeJsonObject(JsonData jdo)
		{
			return null;
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064BF")]
		[Address(RVA = "0x2E01524", Offset = "0x2E01524", VA = "0x2E01524")]
		public ISFSObject Cs2Sfs(object csObj)
		{
			return null;
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C0")]
		[Address(RVA = "0x2E02B74", Offset = "0x2E02B74", VA = "0x2E02B74")]
		private void ConvertCsObj(object csObj, ISFSObject sfsObj)
		{
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C1")]
		[Address(RVA = "0x2E032A8", Offset = "0x2E032A8", VA = "0x2E032A8")]
		private SFSDataWrapper WrapField(object val)
		{
			return null;
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C2")]
		[Address(RVA = "0x2E0361C", Offset = "0x2E0361C", VA = "0x2E0361C")]
		private ISFSArray UnrollArray(ArrayList arr)
		{
			return null;
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C3")]
		[Address(RVA = "0x2E03A00", Offset = "0x2E03A00", VA = "0x2E03A00")]
		private ISFSObject UnrollDictionary(Hashtable dict)
		{
			return null;
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C4")]
		[Address(RVA = "0x2E00498", Offset = "0x2E00498", VA = "0x2E00498")]
		public object Sfs2Cs(ISFSObject sfsObj)
		{
			return null;
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C5")]
		[Address(RVA = "0x2E04068", Offset = "0x2E04068", VA = "0x2E04068")]
		private void ConvertSFSObject(ISFSArray fieldList, object csObj, Type objType)
		{
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C6")]
		[Address(RVA = "0x2E0432C", Offset = "0x2E0432C", VA = "0x2E0432C")]
		private object UnwrapField(SFSDataWrapper wrapper)
		{
			return null;
		}

		// Token: 0x060064C7 RID: 25799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C7")]
		[Address(RVA = "0x2E04580", Offset = "0x2E04580", VA = "0x2E04580")]
		private ArrayList RebuildArray(ISFSArray sfsArr)
		{
			return null;
		}

		// Token: 0x060064C8 RID: 25800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C8")]
		[Address(RVA = "0x2E046F8", Offset = "0x2E046F8", VA = "0x2E046F8")]
		private Hashtable RebuildDict(ISFSObject sfsObj)
		{
			return null;
		}

		// Token: 0x04002890 RID: 10384
		[Token(Token = "0x4002890")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string CLASS_MARKER_KEY;

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string CLASS_FIELDS_KEY;

		// Token: 0x04002892 RID: 10386
		[Token(Token = "0x4002892")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string FIELD_NAME_KEY;

		// Token: 0x04002893 RID: 10387
		[Token(Token = "0x4002893")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string FIELD_VALUE_KEY;

		// Token: 0x04002894 RID: 10388
		[Token(Token = "0x4002894")]
		[FieldOffset(Offset = "0x20")]
		private static Assembly runningAssembly;

		// Token: 0x04002895 RID: 10389
		[Token(Token = "0x4002895")]
		[FieldOffset(Offset = "0x28")]
		private static DefaultSFSDataSerializer instance;
	}
}
