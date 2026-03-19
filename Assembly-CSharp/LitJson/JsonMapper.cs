using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000AD9 RID: 2777
	[Token(Token = "0x2000AD9")]
	public class JsonMapper
	{
		// Token: 0x060069A0 RID: 27040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A0")]
		[Address(RVA = "0x3490724", Offset = "0x3490724", VA = "0x3490724")]
		private static void AddArrayMetadata(Type type)
		{
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A1")]
		[Address(RVA = "0x3490BB4", Offset = "0x3490BB4", VA = "0x3490BB4")]
		private static void AddObjectMetadata(Type type)
		{
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A2")]
		[Address(RVA = "0x3491340", Offset = "0x3491340", VA = "0x3491340")]
		private static void AddTypeProperties(Type type)
		{
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069A3")]
		[Address(RVA = "0x3491880", Offset = "0x3491880", VA = "0x3491880")]
		private static MethodInfo GetConvOp(Type t1, Type t2)
		{
			return null;
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069A4")]
		[Address(RVA = "0x349210C", Offset = "0x349210C", VA = "0x349210C")]
		private static object ReadValue(Type inst_type, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060069A5 RID: 27045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069A5")]
		[Address(RVA = "0x3493674", Offset = "0x3493674", VA = "0x3493674")]
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060069A6 RID: 27046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A6")]
		[Address(RVA = "0x349356C", Offset = "0x349356C", VA = "0x349356C")]
		private static void ReadSkip(JsonReader reader)
		{
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A7")]
		[Address(RVA = "0x348EAD4", Offset = "0x348EAD4", VA = "0x348EAD4")]
		private static void RegisterBaseExporters()
		{
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A8")]
		[Address(RVA = "0x348F7F8", Offset = "0x348F7F8", VA = "0x348F7F8")]
		private static void RegisterBaseImporters()
		{
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069A9")]
		[Address(RVA = "0x3493D34", Offset = "0x3493D34", VA = "0x3493D34")]
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
		{
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069AA")]
		[Address(RVA = "0x3493F78", Offset = "0x3493F78", VA = "0x3493F78")]
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
		{
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AB")]
		[Address(RVA = "0x3495B44", Offset = "0x3495B44", VA = "0x3495B44")]
		public static string ToJson(object obj)
		{
			return null;
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069AC")]
		[Address(RVA = "0x3495DAC", Offset = "0x3495DAC", VA = "0x3495DAC")]
		public static void ToJson(object obj, JsonWriter writer)
		{
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AD")]
		[Address(RVA = "0x3495E18", Offset = "0x3495E18", VA = "0x3495E18")]
		public static JsonData ToObject(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AE")]
		[Address(RVA = "0x3495F6C", Offset = "0x3495F6C", VA = "0x3495F6C")]
		public static JsonData ToObject(TextReader reader)
		{
			return null;
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069AF")]
		[Address(RVA = "0x34960F8", Offset = "0x34960F8", VA = "0x34960F8")]
		public static JsonData ToObject(string json)
		{
			return null;
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B0")]
		public static T ToObject<T>(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B1")]
		public static T ToObject<T>(TextReader reader)
		{
			return null;
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B2")]
		public static T ToObject<T>(string json)
		{
			return null;
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B3")]
		[Address(RVA = "0x34962E0", Offset = "0x34962E0", VA = "0x34962E0")]
		public static object ToObject(string json, Type ConvertType)
		{
			return null;
		}

		// Token: 0x060069B4 RID: 27060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B4")]
		[Address(RVA = "0x3493CD0", Offset = "0x3493CD0", VA = "0x3493CD0")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060069B5 RID: 27061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B5")]
		[Address(RVA = "0x349624C", Offset = "0x349624C", VA = "0x349624C")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
		{
			return null;
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B6")]
		public static void RegisterExporter<T>(ExporterFunc<T> exporter)
		{
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B7")]
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
		{
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B8")]
		[Address(RVA = "0x34963EC", Offset = "0x34963EC", VA = "0x34963EC")]
		public static void UnregisterExporters()
		{
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B9")]
		[Address(RVA = "0x34964B8", Offset = "0x34964B8", VA = "0x34964B8")]
		public static void UnregisterImporters()
		{
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069BA")]
		[Address(RVA = "0x3496584", Offset = "0x3496584", VA = "0x3496584")]
		public JsonMapper()
		{
		}

		// Token: 0x04002A70 RID: 10864
		[Token(Token = "0x4002A70")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int max_nesting_depth;

		// Token: 0x04002A71 RID: 10865
		[Token(Token = "0x4002A71")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IFormatProvider datetime_format;

		// Token: 0x04002A72 RID: 10866
		[Token(Token = "0x4002A72")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IDictionary<Type, ExporterFunc> base_exporters_table;

		// Token: 0x04002A73 RID: 10867
		[Token(Token = "0x4002A73")]
		[FieldOffset(Offset = "0x18")]
		private static readonly IDictionary<Type, ExporterFunc> custom_exporters_table;

		// Token: 0x04002A74 RID: 10868
		[Token(Token = "0x4002A74")]
		[FieldOffset(Offset = "0x20")]
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

		// Token: 0x04002A75 RID: 10869
		[Token(Token = "0x4002A75")]
		[FieldOffset(Offset = "0x28")]
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

		// Token: 0x04002A76 RID: 10870
		[Token(Token = "0x4002A76")]
		[FieldOffset(Offset = "0x30")]
		private static readonly IDictionary<Type, ArrayMetadata> array_metadata;

		// Token: 0x04002A77 RID: 10871
		[Token(Token = "0x4002A77")]
		[FieldOffset(Offset = "0x38")]
		private static readonly object array_metadata_lock;

		// Token: 0x04002A78 RID: 10872
		[Token(Token = "0x4002A78")]
		[FieldOffset(Offset = "0x40")]
		private static readonly IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

		// Token: 0x04002A79 RID: 10873
		[Token(Token = "0x4002A79")]
		[FieldOffset(Offset = "0x48")]
		private static readonly object conv_ops_lock;

		// Token: 0x04002A7A RID: 10874
		[Token(Token = "0x4002A7A")]
		[FieldOffset(Offset = "0x50")]
		private static readonly IDictionary<Type, ObjectMetadata> object_metadata;

		// Token: 0x04002A7B RID: 10875
		[Token(Token = "0x4002A7B")]
		[FieldOffset(Offset = "0x58")]
		private static readonly object object_metadata_lock;

		// Token: 0x04002A7C RID: 10876
		[Token(Token = "0x4002A7C")]
		[FieldOffset(Offset = "0x60")]
		private static readonly IDictionary<Type, IList<PropertyMetadata>> type_properties;

		// Token: 0x04002A7D RID: 10877
		[Token(Token = "0x4002A7D")]
		[FieldOffset(Offset = "0x68")]
		private static readonly object type_properties_lock;

		// Token: 0x04002A7E RID: 10878
		[Token(Token = "0x4002A7E")]
		[FieldOffset(Offset = "0x70")]
		private static readonly JsonWriter static_writer;

		// Token: 0x04002A7F RID: 10879
		[Token(Token = "0x4002A7F")]
		[FieldOffset(Offset = "0x78")]
		private static readonly object static_writer_lock;
	}
}
