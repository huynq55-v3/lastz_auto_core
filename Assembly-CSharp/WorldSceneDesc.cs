using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Unity.Mathematics;
using UnityEngine;

// Token: 0x0200030C RID: 780
[Token(Token = "0x200030C")]
public class WorldSceneDesc
{
	// Token: 0x17000235 RID: 565
	// (get) Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000235")]
	public List<WorldSceneDesc.ObjectDesc> objectDescs
	{
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x198557C", Offset = "0x198557C", VA = "0x198557C")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x06001495 RID: 5269 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000236")]
	public WorldSceneDesc.GridDesc gridDesc
	{
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x1985584", Offset = "0x1985584", VA = "0x1985584")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001496")]
	[Address(RVA = "0x198558C", Offset = "0x198558C", VA = "0x198558C")]
	public void Load(byte[] data)
	{
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001497")]
	[Address(RVA = "0x1985B80", Offset = "0x1985B80", VA = "0x1985B80")]
	public void LoadWorldStatic(byte[] data)
	{
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001498")]
	[Address(RVA = "0x19860B4", Offset = "0x19860B4", VA = "0x19860B4")]
	public List<WorldSceneDesc.ObjectDesc> LoadWithReturn(byte[] data)
	{
		return null;
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001499")]
	[Address(RVA = "0x198644C", Offset = "0x198644C", VA = "0x198644C")]
	public void Save(string savePath)
	{
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149A")]
	[Address(RVA = "0x198694C", Offset = "0x198694C", VA = "0x198694C")]
	public void SaveWorldStaic(string savePath)
	{
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149B")]
	[Address(RVA = "0x1986CF0", Offset = "0x1986CF0", VA = "0x1986CF0")]
	public WorldSceneDesc()
	{
	}

	// Token: 0x0400176E RID: 5998
	[Token(Token = "0x400176E")]
	public const string WorldDescPath = "Assets/Main/Scenes/WorldSceneDesc.bytes";

	// Token: 0x0400176F RID: 5999
	[Token(Token = "0x400176F")]
	public const string WorldDescXmlPath = "Assets/Main/Scenes/WorldSceneDesc.xml";

	// Token: 0x04001770 RID: 6000
	[Token(Token = "0x4001770")]
	public const string WorldDescNewWorldPath = "Assets/Main/Scenes/WorldSceneNewWorldDesc.bytes";

	// Token: 0x04001771 RID: 6001
	[Token(Token = "0x4001771")]
	public const string WorldDescNewWorldXmlPath = "Assets/Main/Scenes/WorldSceneNewWorldDesc.xml";

	// Token: 0x04001772 RID: 6002
	[Token(Token = "0x4001772")]
	public const string WorldEdenDescPath = "Assets/Main/Scenes/WorldEdenSceneDesc.bytes";

	// Token: 0x04001773 RID: 6003
	[Token(Token = "0x4001773")]
	public const string WorldEdenDescXmlPath = "Assets/Main/Scenes/WorldEdenSceneDesc.xml";

	// Token: 0x04001774 RID: 6004
	[Token(Token = "0x4001774")]
	public const string WorldAllianceCityDescPath = "Assets/Main/Scenes/WorldSceneAllianceCityDesc.bytes";

	// Token: 0x04001775 RID: 6005
	[Token(Token = "0x4001775")]
	public const string WorldAllianceCityDescXmlPath = "Assets/Main/Scenes/WorldSceneAllianceCityDesc.xml";

	// Token: 0x04001776 RID: 6006
	[Token(Token = "0x4001776")]
	public const string CityDescPath = "Assets/Main/Scenes/CitySceneDesc.bytes";

	// Token: 0x04001777 RID: 6007
	[Token(Token = "0x4001777")]
	public const string CityDescXmlPath = "Assets/Main/Scenes/CitySceneDesc.xml";

	// Token: 0x04001778 RID: 6008
	[Token(Token = "0x4001778")]
	[FieldOffset(Offset = "0x10")]
	public List<WorldSceneDesc.ObjectDesc> _objectDescs;

	// Token: 0x04001779 RID: 6009
	[Token(Token = "0x4001779")]
	[FieldOffset(Offset = "0x18")]
	public WorldSceneDesc.GridDesc _gridDesc;

	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	public class ObjectDesc
	{
		// Token: 0x0600149C RID: 5276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x1985874", Offset = "0x1985874", VA = "0x1985874")]
		public void Load(BinaryReader reader)
		{
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x1985E60", Offset = "0x1985E60", VA = "0x1985E60")]
		public void LoadWorldStatic(BinaryReader reader)
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x1986DBC", Offset = "0x1986DBC", VA = "0x1986DBC")]
		public void LoadWorldOptimize(BinaryReader reader, int extends)
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x1986B20", Offset = "0x1986B20", VA = "0x1986B20")]
		public void SaveWorldStatic(BinaryWriter writer)
		{
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x19866A0", Offset = "0x19866A0", VA = "0x19866A0")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x1986F3C", Offset = "0x1986F3C", VA = "0x1986F3C")]
		public void SaveWorldOptimize(BinaryWriter writer)
		{
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x198701C", Offset = "0x198701C", VA = "0x198701C")]
		public HashSet<int> GetTileIndexSet()
		{
			return null;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x198586C", Offset = "0x198586C", VA = "0x198586C")]
		public ObjectDesc()
		{
		}

		// Token: 0x0400177A RID: 6010
		[Token(Token = "0x400177A")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x0400177B RID: 6011
		[Token(Token = "0x400177B")]
		[FieldOffset(Offset = "0x14")]
		public int type;

		// Token: 0x0400177C RID: 6012
		[Token(Token = "0x400177C")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 localPos;

		// Token: 0x0400177D RID: 6013
		[Token(Token = "0x400177D")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 rotation;

		// Token: 0x0400177E RID: 6014
		[Token(Token = "0x400177E")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 scale;

		// Token: 0x0400177F RID: 6015
		[Token(Token = "0x400177F")]
		[FieldOffset(Offset = "0x40")]
		public string assetPath;

		// Token: 0x04001780 RID: 6016
		[Token(Token = "0x4001780")]
		[FieldOffset(Offset = "0x48")]
		public int assetGuid;

		// Token: 0x04001781 RID: 6017
		[Token(Token = "0x4001781")]
		[FieldOffset(Offset = "0x4C")]
		public bool isStatic;

		// Token: 0x04001782 RID: 6018
		[Token(Token = "0x4001782")]
		[FieldOffset(Offset = "0x50")]
		public float distance;

		// Token: 0x04001783 RID: 6019
		[Token(Token = "0x4001783")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 boundCenter;

		// Token: 0x04001784 RID: 6020
		[Token(Token = "0x4001784")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 boundSize;

		// Token: 0x04001785 RID: 6021
		[Token(Token = "0x4001785")]
		[FieldOffset(Offset = "0x6C")]
		public Vector2Int worldDecorationTilePos;

		// Token: 0x04001786 RID: 6022
		[Token(Token = "0x4001786")]
		[FieldOffset(Offset = "0x74")]
		public int4 worldDecorationTileRect;
	}

	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	public class GridDesc
	{
		// Token: 0x060014A4 RID: 5284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x1985A2C", Offset = "0x1985A2C", VA = "0x1985A2C")]
		public void Load(BinaryReader reader)
		{
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x19867E0", Offset = "0x19867E0", VA = "0x19867E0")]
		public void Save(BinaryWriter writer)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x1986DB4", Offset = "0x1986DB4", VA = "0x1986DB4")]
		public GridDesc()
		{
		}

		// Token: 0x04001787 RID: 6023
		[Token(Token = "0x4001787")]
		[FieldOffset(Offset = "0x10")]
		public int width;

		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		[FieldOffset(Offset = "0x14")]
		public int height;

		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		[FieldOffset(Offset = "0x18")]
		public int scale;

		// Token: 0x0400178A RID: 6026
		[Token(Token = "0x400178A")]
		[FieldOffset(Offset = "0x20")]
		public byte[] grids;
	}
}
