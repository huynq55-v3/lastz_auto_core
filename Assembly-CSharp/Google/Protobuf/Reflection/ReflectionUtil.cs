using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.Protobuf.Reflection
{
	// Token: 0x02000BE1 RID: 3041
	[Token(Token = "0x2000BE1")]
	internal static class ReflectionUtil
	{
		// Token: 0x060074A6 RID: 29862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074A6")]
		internal static void ForceInitialize<T>()
		{
		}

		// Token: 0x060074A7 RID: 29863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074A7")]
		[Address(RVA = "0x31ADCEC", Offset = "0x31ADCEC", VA = "0x31ADCEC")]
		internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
		{
			return null;
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074A8")]
		[Address(RVA = "0x31B4FE4", Offset = "0x31B4FE4", VA = "0x31B4FE4")]
		internal static Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method)
		{
			return null;
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074A9")]
		[Address(RVA = "0x31B5B68", Offset = "0x31B5B68", VA = "0x31B5B68")]
		internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
		{
			return null;
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074AA")]
		[Address(RVA = "0x31B50F0", Offset = "0x31B50F0", VA = "0x31B50F0")]
		internal static Action<IMessage> CreateActionIMessage(MethodInfo method)
		{
			return null;
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074AB")]
		[Address(RVA = "0x31B5CA0", Offset = "0x31B5CA0", VA = "0x31B5CA0")]
		internal static Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method)
		{
			return null;
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074AC")]
		[Address(RVA = "0x31B3A5C", Offset = "0x31B3A5C", VA = "0x31B3A5C")]
		internal static Func<IMessage, bool> CreateIsInitializedCaller(Type msg)
		{
			return null;
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074AD")]
		[Address(RVA = "0x31ABF38", Offset = "0x31ABF38", VA = "0x31ABF38")]
		internal static ReflectionUtil.IExtensionReflectionHelper CreateExtensionHelper(Extension extension)
		{
			return null;
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074AE")]
		[Address(RVA = "0x31B59E4", Offset = "0x31B59E4", VA = "0x31B59E4")]
		private static ReflectionUtil.IReflectionHelper GetReflectionHelper(Type t1, Type t2)
		{
			return null;
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060074AF RID: 29871 RVA: 0x00051690 File Offset: 0x0004F890
		[Token(Token = "0x17000A23")]
		private static bool CanConvertEnumFuncToInt32Func
		{
			[Token(Token = "0x60074AF")]
			[Address(RVA = "0x31B5DB0", Offset = "0x31B5DB0", VA = "0x31B5DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x000516A8 File Offset: 0x0004F8A8
		[Token(Token = "0x60074B0")]
		[Address(RVA = "0x31B5878", Offset = "0x31B5878", VA = "0x31B5878")]
		private static bool CheckCanConvertEnumFuncToInt32Func()
		{
			return default(bool);
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x000516C0 File Offset: 0x0004F8C0
		[Token(Token = "0x60074B1")]
		[Address(RVA = "0x31B59DC", Offset = "0x31B59DC", VA = "0x31B59DC")]
		public static ReflectionUtil.SampleEnum SampleEnumMethod()
		{
			return ReflectionUtil.SampleEnum.X;
		}

		// Token: 0x04002F99 RID: 12185
		[Token(Token = "0x4002F99")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly Type[] EmptyTypes;

		// Token: 0x02000BE2 RID: 3042
		[Token(Token = "0x2000BE2")]
		private interface IReflectionHelper
		{
			// Token: 0x060074B2 RID: 29874
			[Token(Token = "0x60074B2")]
			Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method);

			// Token: 0x060074B3 RID: 29875
			[Token(Token = "0x60074B3")]
			Action<IMessage> CreateActionIMessage(MethodInfo method);

			// Token: 0x060074B4 RID: 29876
			[Token(Token = "0x60074B4")]
			Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method);

			// Token: 0x060074B5 RID: 29877
			[Token(Token = "0x60074B5")]
			Action<IMessage, object> CreateActionIMessageObject(MethodInfo method);

			// Token: 0x060074B6 RID: 29878
			[Token(Token = "0x60074B6")]
			Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method);
		}

		// Token: 0x02000BE3 RID: 3043
		[Token(Token = "0x2000BE3")]
		internal interface IExtensionReflectionHelper
		{
			// Token: 0x060074B7 RID: 29879
			[Token(Token = "0x60074B7")]
			object GetExtension(IMessage message);

			// Token: 0x060074B8 RID: 29880
			[Token(Token = "0x60074B8")]
			void SetExtension(IMessage message, object value);

			// Token: 0x060074B9 RID: 29881
			[Token(Token = "0x60074B9")]
			bool HasExtension(IMessage message);

			// Token: 0x060074BA RID: 29882
			[Token(Token = "0x60074BA")]
			void ClearExtension(IMessage message);
		}

		// Token: 0x02000BE4 RID: 3044
		[Token(Token = "0x2000BE4")]
		private interface IExtensionSetReflector
		{
			// Token: 0x060074BB RID: 29883
			[Token(Token = "0x60074BB")]
			Func<IMessage, bool> CreateIsInitializedCaller();
		}

		// Token: 0x02000BE5 RID: 3045
		[Token(Token = "0x2000BE5")]
		private class ReflectionHelper<T1, T2> : ReflectionUtil.IReflectionHelper
		{
			// Token: 0x060074BC RID: 29884 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60074BC")]
			public Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method)
			{
				return null;
			}

			// Token: 0x060074BD RID: 29885 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60074BD")]
			public Action<IMessage> CreateActionIMessage(MethodInfo method)
			{
				return null;
			}

			// Token: 0x060074BE RID: 29886 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60074BE")]
			public Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
			{
				return null;
			}

			// Token: 0x060074BF RID: 29887 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60074BF")]
			public Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
			{
				return null;
			}

			// Token: 0x060074C0 RID: 29888 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60074C0")]
			public Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method)
			{
				return null;
			}

			// Token: 0x060074C1 RID: 29889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074C1")]
			public ReflectionHelper()
			{
			}
		}

		// Token: 0x02000BEC RID: 3052
		[Token(Token = "0x2000BEC")]
		private class ExtensionReflectionHelper<T1, T3> : ReflectionUtil.IExtensionReflectionHelper where T1 : IExtendableMessage<T1>
		{
			// Token: 0x060074CE RID: 29902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074CE")]
			public ExtensionReflectionHelper(Extension extension)
			{
			}

			// Token: 0x060074CF RID: 29903 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60074CF")]
			public object GetExtension(IMessage message)
			{
				return null;
			}

			// Token: 0x060074D0 RID: 29904 RVA: 0x00051720 File Offset: 0x0004F920
			[Token(Token = "0x60074D0")]
			public bool HasExtension(IMessage message)
			{
				return default(bool);
			}

			// Token: 0x060074D1 RID: 29905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074D1")]
			public void SetExtension(IMessage message, object value)
			{
			}

			// Token: 0x060074D2 RID: 29906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074D2")]
			public void ClearExtension(IMessage message)
			{
			}

			// Token: 0x04002FA1 RID: 12193
			[Token(Token = "0x4002FA1")]
			[FieldOffset(Offset = "0x0")]
			private readonly Extension extension;
		}

		// Token: 0x02000BED RID: 3053
		[Token(Token = "0x2000BED")]
		private class ExtensionSetReflector<T1> : ReflectionUtil.IExtensionSetReflector where T1 : IExtendableMessage<T1>
		{
			// Token: 0x060074D3 RID: 29907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60074D3")]
			public Func<IMessage, bool> CreateIsInitializedCaller()
			{
				return null;
			}

			// Token: 0x060074D4 RID: 29908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074D4")]
			public ExtensionSetReflector()
			{
			}
		}

		// Token: 0x02000BEF RID: 3055
		[Token(Token = "0x2000BEF")]
		public enum SampleEnum
		{
			// Token: 0x04002FA5 RID: 12197
			[Token(Token = "0x4002FA5")]
			X
		}
	}
}
