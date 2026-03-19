using System;
using System.Collections;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000ACD RID: 2765
	[Token(Token = "0x2000ACD")]
	public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060068FC RID: 26876
		[Token(Token = "0x17000756")]
		bool IsArray
		{
			[Token(Token = "0x60068FC")]
			get;
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060068FD RID: 26877
		[Token(Token = "0x17000757")]
		bool IsBoolean
		{
			[Token(Token = "0x60068FD")]
			get;
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060068FE RID: 26878
		[Token(Token = "0x17000758")]
		bool IsDouble
		{
			[Token(Token = "0x60068FE")]
			get;
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060068FF RID: 26879
		[Token(Token = "0x17000759")]
		bool IsInt
		{
			[Token(Token = "0x60068FF")]
			get;
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06006900 RID: 26880
		[Token(Token = "0x1700075A")]
		bool IsLong
		{
			[Token(Token = "0x6006900")]
			get;
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06006901 RID: 26881
		[Token(Token = "0x1700075B")]
		bool IsObject
		{
			[Token(Token = "0x6006901")]
			get;
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06006902 RID: 26882
		[Token(Token = "0x1700075C")]
		bool IsString
		{
			[Token(Token = "0x6006902")]
			get;
		}

		// Token: 0x06006903 RID: 26883
		[Token(Token = "0x6006903")]
		bool GetBoolean();

		// Token: 0x06006904 RID: 26884
		[Token(Token = "0x6006904")]
		double GetDouble();

		// Token: 0x06006905 RID: 26885
		[Token(Token = "0x6006905")]
		int GetInt();

		// Token: 0x06006906 RID: 26886
		[Token(Token = "0x6006906")]
		JsonType GetJsonType();

		// Token: 0x06006907 RID: 26887
		[Token(Token = "0x6006907")]
		long GetLong();

		// Token: 0x06006908 RID: 26888
		[Token(Token = "0x6006908")]
		string GetString();

		// Token: 0x06006909 RID: 26889
		[Token(Token = "0x6006909")]
		void SetBoolean(bool val);

		// Token: 0x0600690A RID: 26890
		[Token(Token = "0x600690A")]
		void SetDouble(double val);

		// Token: 0x0600690B RID: 26891
		[Token(Token = "0x600690B")]
		void SetInt(int val);

		// Token: 0x0600690C RID: 26892
		[Token(Token = "0x600690C")]
		void SetJsonType(JsonType type);

		// Token: 0x0600690D RID: 26893
		[Token(Token = "0x600690D")]
		void SetLong(long val);

		// Token: 0x0600690E RID: 26894
		[Token(Token = "0x600690E")]
		void SetString(string val);

		// Token: 0x0600690F RID: 26895
		[Token(Token = "0x600690F")]
		string ToJson();

		// Token: 0x06006910 RID: 26896
		[Token(Token = "0x6006910")]
		void ToJson(JsonWriter writer);
	}
}
