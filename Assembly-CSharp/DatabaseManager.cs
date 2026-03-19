using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Il2CppDummyDll;
using SQLite4Unity3d;
using UnityEngine;

// Token: 0x0200020E RID: 526
[Token(Token = "0x200020E")]
public class DatabaseManager : MonoBehaviour
{
	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001B2")]
	public static DatabaseManager Instance
	{
		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x121D6CC", Offset = "0x121D6CC", VA = "0x121D6CC")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1F")]
	[Address(RVA = "0x121DAF8", Offset = "0x121DAF8", VA = "0x121DAF8")]
	public void Initialize(string databaseFile, Action<bool> callback)
	{
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x121E284", Offset = "0x121E284", VA = "0x121E284")]
	public void Release()
	{
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x121DD28", Offset = "0x121DD28", VA = "0x121DD28")]
	private void InitDatabase(string path)
	{
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x000064B0 File Offset: 0x000046B0
	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x121E404", Offset = "0x121E404", VA = "0x121E404")]
	private bool EnsureEncryptedDatabase(string dbPath, string escapedKey)
	{
		return default(bool);
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x000064C8 File Offset: 0x000046C8
	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x121E78C", Offset = "0x121E78C", VA = "0x121E78C")]
	private bool TryEncryptPlaintextDatabase(string dbPath, string escapedKey)
	{
		return default(bool);
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x000064E0 File Offset: 0x000046E0
	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x121F51C", Offset = "0x121F51C", VA = "0x121F51C")]
	private bool ValidateEncryptedExport(SQLiteConnection plain, string encryptedAlias)
	{
		return default(bool);
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x000064F8 File Offset: 0x000046F8
	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x1221190", Offset = "0x1221190", VA = "0x1221190")]
	private bool ValidateMailDataCounts(SQLiteConnection conn, string encryptedAlias)
	{
		return default(bool);
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x12226E4", Offset = "0x12226E4", VA = "0x12226E4")]
	private Dictionary<string, int> GetMailGroupCounts(SQLiteConnection conn, string alias, string targetUser)
	{
		return null;
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x00006510 File Offset: 0x00004710
	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x1222040", Offset = "0x1222040", VA = "0x1222040")]
	private bool HasTable(SQLiteConnection conn, string tableName, string alias)
	{
		return default(bool);
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00006528 File Offset: 0x00004728
	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x12221DC", Offset = "0x12221DC", VA = "0x12221DC")]
	private bool HasColumns(SQLiteConnection conn, string tableName, string[] columns, string alias)
	{
		return default(bool);
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x1221928", Offset = "0x1221928", VA = "0x1221928")]
	private void LogMailDataColumnsWithValue(SQLiteConnection conn, string alias, string label)
	{
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x1222A38", Offset = "0x1222A38", VA = "0x1222A38")]
	private List<string> GetTableColumns(SQLiteConnection conn, string tableName, string alias)
	{
		return null;
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x12200A0", Offset = "0x12200A0", VA = "0x12200A0")]
	private string ComputeTableHash(SQLiteConnection conn, string safeTable, string alias)
	{
		return null;
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x1222F28", Offset = "0x1222F28", VA = "0x1222F28")]
	private static void UpdateHash(HashAlgorithm hash, string text)
	{
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00006540 File Offset: 0x00004740
	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x1222F8C", Offset = "0x1222F8C", VA = "0x1222F8C")]
	private bool TryValidateCurrentKey()
	{
		return default(bool);
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x00006558 File Offset: 0x00004758
	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0x1223134", Offset = "0x1223134", VA = "0x1223134")]
	private bool RekeyDatabaseIfNeeded(string dbPath, string escapedOldKey, string newKey)
	{
		return default(bool);
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x00006570 File Offset: 0x00004770
	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x121F484", Offset = "0x121F484", VA = "0x121F484")]
	private static bool IsNotDatabaseError(SQLiteException ex)
	{
		return default(bool);
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x121F3C4", Offset = "0x121F3C4", VA = "0x121F3C4")]
	public string GetCipherVersion()
	{
		return null;
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x1223454", Offset = "0x1223454", VA = "0x1223454")]
	private void Update()
	{
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x1223458", Offset = "0x1223458", VA = "0x1223458")]
	public void UpdateTask()
	{
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x12235D4", Offset = "0x12235D4", VA = "0x12235D4")]
	public void Execute2(string cmdStr, [Optional] Action<DBExecResult> callback)
	{
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x1223720", Offset = "0x1223720", VA = "0x1223720")]
	public void ExecuteSTMT(string sqlstmt, List<List<DBAnyValue>> values, [Optional] Action<DBExecResult> callback)
	{
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x1223898", Offset = "0x1223898", VA = "0x1223898")]
	public void ExecuteMulti(List<string> cmdStr, [Optional] Action<List<DBExecResult>> callback)
	{
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E36")]
	public static string GetPrimaryKeyValue<T>(T obj, SQLiteConnection dbConnection)
	{
		return null;
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x12239E4", Offset = "0x12239E4", VA = "0x12239E4")]
	public DatabaseManager()
	{
	}

	// Token: 0x04001162 RID: 4450
	[Token(Token = "0x4001162")]
	[FieldOffset(Offset = "0x0")]
	private static DatabaseManager _instance;

	// Token: 0x04001163 RID: 4451
	[Token(Token = "0x4001163")]
	[FieldOffset(Offset = "0x8")]
	private static readonly object _lock;

	// Token: 0x04001164 RID: 4452
	[Token(Token = "0x4001164")]
	[FieldOffset(Offset = "0x18")]
	private Action<bool> OnInitCallback;

	// Token: 0x04001165 RID: 4453
	[Token(Token = "0x4001165")]
	[FieldOffset(Offset = "0x20")]
	private QueuedThread thread;

	// Token: 0x04001166 RID: 4454
	[Token(Token = "0x4001166")]
	[FieldOffset(Offset = "0x28")]
	private SQLiteConnection dbConnection;

	// Token: 0x04001167 RID: 4455
	[Token(Token = "0x4001167")]
	[FieldOffset(Offset = "0x30")]
	private Queue<DatabaseActionTask> taskQueue;

	// Token: 0x04001168 RID: 4456
	[Token(Token = "0x4001168")]
	[FieldOffset(Offset = "0x38")]
	private bool isInited;

	// Token: 0x04001169 RID: 4457
	[Token(Token = "0x4001169")]
	private const string EncryptedBackupSuffix = ".bak";

	// Token: 0x0400116A RID: 4458
	[Token(Token = "0x400116A")]
	private const string EncryptedTempSuffix = ".enc";

	// Token: 0x0400116B RID: 4459
	[Token(Token = "0x400116B")]
	private const string EncryptedKey = "1234567890";

	// Token: 0x0400116C RID: 4460
	[Token(Token = "0x400116C")]
	private const string EncryptedKey2 = "32%sAKfsD#F09BDI2*_";

	// Token: 0x0400116D RID: 4461
	[Token(Token = "0x400116D")]
	[FieldOffset(Offset = "0x39")]
	public bool isEncrypt;

	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	private class TableNameRow
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000E3A RID: 3642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B3")]
		public string name
		{
			[Token(Token = "0x6000E39")]
			[Address(RVA = "0x1223AE8", Offset = "0x1223AE8", VA = "0x1223AE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E3A")]
			[Address(RVA = "0x1223AF0", Offset = "0x1223AF0", VA = "0x1223AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x1223AF8", Offset = "0x1223AF8", VA = "0x1223AF8")]
		public TableNameRow()
		{
		}
	}

	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	private class TableInfoRow
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B4")]
		public string name
		{
			[Token(Token = "0x6000E3C")]
			[Address(RVA = "0x1223B00", Offset = "0x1223B00", VA = "0x1223B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E3D")]
			[Address(RVA = "0x1223B08", Offset = "0x1223B08", VA = "0x1223B08")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00006588 File Offset: 0x00004788
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B5")]
		public int pk
		{
			[Token(Token = "0x6000E3E")]
			[Address(RVA = "0x1223B10", Offset = "0x1223B10", VA = "0x1223B10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x1223B18", Offset = "0x1223B18", VA = "0x1223B18")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x1223B20", Offset = "0x1223B20", VA = "0x1223B20")]
		public TableInfoRow()
		{
		}
	}

	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	private class RowText
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B6")]
		public string row_text
		{
			[Token(Token = "0x6000E41")]
			[Address(RVA = "0x1223B28", Offset = "0x1223B28", VA = "0x1223B28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E42")]
			[Address(RVA = "0x1223B30", Offset = "0x1223B30", VA = "0x1223B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x1223B38", Offset = "0x1223B38", VA = "0x1223B38")]
		public RowText()
		{
		}
	}

	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	private class MailGroupCountRow
	{
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B7")]
		public string toUser
		{
			[Token(Token = "0x6000E44")]
			[Address(RVA = "0x1223B40", Offset = "0x1223B40", VA = "0x1223B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E45")]
			[Address(RVA = "0x1223B48", Offset = "0x1223B48", VA = "0x1223B48")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x000065A0 File Offset: 0x000047A0
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B8")]
		public int type
		{
			[Token(Token = "0x6000E46")]
			[Address(RVA = "0x1223B50", Offset = "0x1223B50", VA = "0x1223B50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000E47")]
			[Address(RVA = "0x1223B58", Offset = "0x1223B58", VA = "0x1223B58")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x000065B8 File Offset: 0x000047B8
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B9")]
		public int cnt
		{
			[Token(Token = "0x6000E48")]
			[Address(RVA = "0x1223B60", Offset = "0x1223B60", VA = "0x1223B60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000E49")]
			[Address(RVA = "0x1223B68", Offset = "0x1223B68", VA = "0x1223B68")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x1223B70", Offset = "0x1223B70", VA = "0x1223B70")]
		public MailGroupCountRow()
		{
		}
	}
}
