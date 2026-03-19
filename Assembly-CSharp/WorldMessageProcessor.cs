using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sfs2X.Entities.Data;
using Sfs2X.Util;

// Token: 0x02000244 RID: 580
[Token(Token = "0x2000244")]
public class WorldMessageProcessor
{
	// Token: 0x170001CB RID: 459
	// (get) Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001CB")]
	public static WorldMessageProcessor Instance
	{
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x1BE3184", Offset = "0x1BE3184", VA = "0x1BE3184")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x1BE4598", Offset = "0x1BE4598", VA = "0x1BE4598")]
	public void Start()
	{
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x1BE4A24", Offset = "0x1BE4A24", VA = "0x1BE4A24")]
	public void Stop()
	{
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x1BE4A9C", Offset = "0x1BE4A9C", VA = "0x1BE4A9C")]
	public void Clear()
	{
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x1BE46BC", Offset = "0x1BE46BC", VA = "0x1BE46BC")]
	private static void InitPbTreeMap()
	{
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00006C30 File Offset: 0x00004E30
	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x1BE3104", Offset = "0x1BE3104", VA = "0x1BE3104")]
	public static bool IsWorldMsg(string cmd)
	{
		return default(bool);
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x1BE323C", Offset = "0x1BE323C", VA = "0x1BE323C")]
	public void PushMessage(string cmd, ByteArray rawData)
	{
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x1BE4EC4", Offset = "0x1BE4EC4", VA = "0x1BE4EC4")]
	private static void PopMessage(string cmd, SFSObject so)
	{
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x1BE515C", Offset = "0x1BE515C", VA = "0x1BE515C")]
	public void Update()
	{
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x1BE5374", Offset = "0x1BE5374", VA = "0x1BE5374")]
	private void WorkerLoop()
	{
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x1BE5574", Offset = "0x1BE5574", VA = "0x1BE5574")]
	private ISFSObject ParseWorldData(string cmd, ByteArray byteArray)
	{
		return null;
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x1BE4C5C", Offset = "0x1BE4C5C", VA = "0x1BE4C5C")]
	private void FreeResultMsg(string cmd, ISFSObject so)
	{
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x1BE61FC", Offset = "0x1BE61FC", VA = "0x1BE61FC")]
	private static void FreePbNodeArray(ISFSArray originArray)
	{
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x1BE58EC", Offset = "0x1BE58EC", VA = "0x1BE58EC")]
	private static void SubThreadLogError(string msg)
	{
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x1BE5938", Offset = "0x1BE5938", VA = "0x1BE5938")]
	private static void ParseSfsNode(ISFSObject obj, string key, WorldMessageProcessor.SfsTreeNode node)
	{
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x1BE636C", Offset = "0x1BE636C", VA = "0x1BE636C")]
	private static void ParseSfsArray(ISFSArray array, WorldMessageProcessor.SfsTreeNode node)
	{
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x1BE67A0", Offset = "0x1BE67A0", VA = "0x1BE67A0")]
	private static void ParsePbArray(ISFSArray originArray, string pbTypeStr, bool needBase64Decode)
	{
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x1BE5E60", Offset = "0x1BE5E60", VA = "0x1BE5E60")]
	private static void FreeSfsNode(ISFSObject obj, string key, WorldMessageProcessor.SfsTreeNode node)
	{
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x1BE6BC0", Offset = "0x1BE6BC0", VA = "0x1BE6BC0")]
	private static void FreeSfsArray(ISFSArray array, WorldMessageProcessor.SfsTreeNode node)
	{
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x1BE4480", Offset = "0x1BE4480", VA = "0x1BE4480")]
	public WorldMessageProcessor()
	{
	}

	// Token: 0x04001228 RID: 4648
	[Token(Token = "0x4001228")]
	public const int Version = 2;

	// Token: 0x04001229 RID: 4649
	[Token(Token = "0x4001229")]
	[FieldOffset(Offset = "0x0")]
	private static WorldMessageProcessor _instance;

	// Token: 0x0400122A RID: 4650
	[Token(Token = "0x400122A")]
	[FieldOffset(Offset = "0x10")]
	private WorldMessageProcessor.WorkerState _currentState;

	// Token: 0x0400122B RID: 4651
	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0x18")]
	private Thread _workerThread;

	// Token: 0x0400122C RID: 4652
	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0x20")]
	private readonly AutoResetEvent _messageEvent;

	// Token: 0x0400122D RID: 4653
	[Token(Token = "0x400122D")]
	[FieldOffset(Offset = "0x28")]
	private readonly ConcurrentQueue<KeyValuePair<string, ByteArray>> _inputQueue;

	// Token: 0x0400122E RID: 4654
	[Token(Token = "0x400122E")]
	[FieldOffset(Offset = "0x30")]
	private readonly ConcurrentQueue<KeyValuePair<string, ISFSObject>> _resultQueue;

	// Token: 0x0400122F RID: 4655
	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ConcurrentDictionary<string, WorldMessageProcessor.SfsTreeNode> PbTreeMap;

	// Token: 0x04001230 RID: 4656
	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x38")]
	public string ParseCodeStr;

	// Token: 0x02000245 RID: 581
	[Token(Token = "0x2000245")]
	private enum WorkerState
	{
		// Token: 0x04001232 RID: 4658
		[Token(Token = "0x4001232")]
		Stopped,
		// Token: 0x04001233 RID: 4659
		[Token(Token = "0x4001233")]
		Running
	}

	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	public class SfsTreeNode
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001CC")]
		[JsonProperty("sfsKey")]
		public string SfsKey
		{
			[Token(Token = "0x6000F9C")]
			[Address(RVA = "0x1BE7064", Offset = "0x1BE7064", VA = "0x1BE7064")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F9D")]
			[Address(RVA = "0x1BE706C", Offset = "0x1BE706C", VA = "0x1BE706C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00006C48 File Offset: 0x00004E48
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001CD")]
		[JsonProperty("sfsType")]
		public SFSDataType SfsType
		{
			[Token(Token = "0x6000F9E")]
			[Address(RVA = "0x1BE7074", Offset = "0x1BE7074", VA = "0x1BE7074")]
			[CompilerGenerated]
			get
			{
				return SFSDataType.NULL;
			}
			[Token(Token = "0x6000F9F")]
			[Address(RVA = "0x1BE707C", Offset = "0x1BE707C", VA = "0x1BE707C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00006C60 File Offset: 0x00004E60
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001CE")]
		[JsonProperty("isPbNode")]
		public bool IsPbNode
		{
			[Token(Token = "0x6000FA0")]
			[Address(RVA = "0x1BE7084", Offset = "0x1BE7084", VA = "0x1BE7084")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FA1")]
			[Address(RVA = "0x1BE708C", Offset = "0x1BE708C", VA = "0x1BE708C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001CF")]
		[JsonProperty("pbType")]
		public string PbType
		{
			[Token(Token = "0x6000FA2")]
			[Address(RVA = "0x1BE7098", Offset = "0x1BE7098", VA = "0x1BE7098")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FA3")]
			[Address(RVA = "0x1BE70A0", Offset = "0x1BE70A0", VA = "0x1BE70A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00006C78 File Offset: 0x00004E78
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D0")]
		[JsonProperty("needBase64Decode")]
		public bool NeedBase64Decode
		{
			[Token(Token = "0x6000FA4")]
			[Address(RVA = "0x1BE70A8", Offset = "0x1BE70A8", VA = "0x1BE70A8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FA5")]
			[Address(RVA = "0x1BE70B0", Offset = "0x1BE70B0", VA = "0x1BE70B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001D1")]
		[JsonProperty("children")]
		public List<WorldMessageProcessor.SfsTreeNode> Children
		{
			[Token(Token = "0x6000FA6")]
			[Address(RVA = "0x1BE70BC", Offset = "0x1BE70BC", VA = "0x1BE70BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FA7")]
			[Address(RVA = "0x1BE70C4", Offset = "0x1BE70C4", VA = "0x1BE70C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x1BE70CC", Offset = "0x1BE70CC", VA = "0x1BE70CC")]
		public SfsTreeNode()
		{
		}
	}
}
