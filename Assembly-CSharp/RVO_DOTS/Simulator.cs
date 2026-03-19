using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace RVO_DOTS
{
	// Token: 0x020003CA RID: 970
	[Token(Token = "0x20003CA")]
	[BurstCompile]
	public class Simulator
	{
		// Token: 0x0600182E RID: 6190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182E")]
		[Address(RVA = "0x20132F8", Offset = "0x20132F8", VA = "0x20132F8")]
		[BurstDiscard]
		public static void Log(object msg)
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000254")]
		public static Simulator Instance
		{
			[Token(Token = "0x600182F")]
			[Address(RVA = "0x2013350", Offset = "0x2013350", VA = "0x2013350")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001830")]
		[Address(RVA = "0x201340C", Offset = "0x201340C", VA = "0x201340C")]
		public void waitForCompletion()
		{
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x6001831")]
		[Address(RVA = "0x2013480", Offset = "0x2013480", VA = "0x2013480")]
		public float doStep()
		{
			return 0f;
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001832")]
		[Address(RVA = "0x201480C", Offset = "0x201480C", VA = "0x201480C")]
		[BurstCompile]
		public void delAgent(int agentNo)
		{
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x6001833")]
		[Address(RVA = "0x201497C", Offset = "0x201497C", VA = "0x201497C")]
		[BurstCompile]
		public bool hasAgent(int agentNo)
		{
			return default(bool);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001834")]
		[Address(RVA = "0x2014668", Offset = "0x2014668", VA = "0x2014668")]
		[BurstCompile]
		public void updateDeleteAgent()
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x2014AE8", Offset = "0x2014AE8", VA = "0x2014AE8")]
		[BurstCompile]
		public int addAgent(int id, float2 position)
		{
			return 0;
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x201535C", Offset = "0x201535C", VA = "0x201535C")]
		[BurstCompile]
		public int getNewAgentID()
		{
			return 0;
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x20149D4", Offset = "0x20149D4", VA = "0x20149D4")]
		[BurstCompile]
		private void onDelAgent()
		{
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x201527C", Offset = "0x201527C", VA = "0x201527C")]
		[BurstCompile]
		private void onAddAgent()
		{
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x20153BC", Offset = "0x20153BC", VA = "0x20153BC")]
		[BurstCompile]
		public void addAgent(int id, float2 position, float neighborDist, int maxNeighbors, float timeHorizon, float timeHorizonObst, float radius, float maxSpeed, float2 velocity)
		{
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x2015B70", Offset = "0x2015B70", VA = "0x2015B70")]
		[BurstCompile]
		public int addObstacle(IList<float2> vertices)
		{
			return 0;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183B")]
		[Address(RVA = "0x2016908", Offset = "0x2016908", VA = "0x2016908")]
		[BurstCompile]
		public void Clear()
		{
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x2017188", Offset = "0x2017188", VA = "0x2017188")]
		public void Destroy()
		{
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x201768C", Offset = "0x201768C", VA = "0x201768C")]
		[BurstCompile]
		public int getAgentMaxNeighbors(int agentNo)
		{
			return 0;
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x600183E")]
		[Address(RVA = "0x2017728", Offset = "0x2017728", VA = "0x2017728")]
		[BurstCompile]
		public float getAgentMaxSpeed(int agentNo)
		{
			return 0f;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x20177C0", Offset = "0x20177C0", VA = "0x20177C0")]
		[BurstCompile]
		public float getAgentSpeed(int agentNo)
		{
			return 0f;
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x201785C", Offset = "0x201785C", VA = "0x201785C")]
		[BurstCompile]
		public void setAgentSpeed(int agentNo, float speed)
		{
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x2017904", Offset = "0x2017904", VA = "0x2017904")]
		[BurstCompile]
		public float getAgentNeighborDist(int agentNo)
		{
			return 0f;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x201799C", Offset = "0x201799C", VA = "0x201799C")]
		[BurstCompile]
		public float2 getAgentPosition(int agentNo)
		{
			return default(float2);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x2017CDC", Offset = "0x2017CDC", VA = "0x2017CDC")]
		[BurstCompile]
		public float2 getRawAgentPosition(int agentNo)
		{
			return default(float2);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x2017D98", Offset = "0x2017D98", VA = "0x2017D98")]
		[BurstCompile]
		public float2 getAgentPrefVelocity(int agentNo)
		{
			return default(float2);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x2017E5C", Offset = "0x2017E5C", VA = "0x2017E5C")]
		[BurstCompile]
		public float getAgentRadius(int agentNo)
		{
			return 0f;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x2017EF4", Offset = "0x2017EF4", VA = "0x2017EF4")]
		[BurstCompile]
		public float getAgentTimeHorizon(int agentNo)
		{
			return 0f;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x2017F8C", Offset = "0x2017F8C", VA = "0x2017F8C")]
		[BurstCompile]
		public float getAgentTimeHorizonObst(int agentNo)
		{
			return 0f;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x2018024", Offset = "0x2018024", VA = "0x2018024")]
		[BurstCompile]
		public float2 getAgentVelocity(int agentNo)
		{
			return default(float2);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x20180E8", Offset = "0x20180E8", VA = "0x20180E8")]
		[BurstCompile]
		public float getGlobalTime()
		{
			return 0f;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x20180F0", Offset = "0x20180F0", VA = "0x20180F0")]
		[BurstCompile]
		public int getNumAgents()
		{
			return 0;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x2018138", Offset = "0x2018138", VA = "0x2018138")]
		[BurstCompile]
		public int getNumObstacleVertices()
		{
			return 0;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x2018180", Offset = "0x2018180", VA = "0x2018180")]
		[BurstCompile]
		public float2 getObstacleVertex(int vertexNo)
		{
			return default(float2);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x600184D")]
		[Address(RVA = "0x20181E4", Offset = "0x20181E4", VA = "0x20181E4")]
		[BurstCompile]
		public int getNextObstacleVertexNo(int vertexNo)
		{
			return 0;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x2018254", Offset = "0x2018254", VA = "0x2018254")]
		[BurstCompile]
		public int getPrevObstacleVertexNo(int vertexNo)
		{
			return 0;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184F")]
		[Address(RVA = "0x20182C4", Offset = "0x20182C4", VA = "0x20182C4")]
		[BurstCompile]
		public void processObstacles()
		{
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001850")]
		[Address(RVA = "0x20182E8", Offset = "0x20182E8", VA = "0x20182E8")]
		[BurstCompile]
		public void setAgentDefaults(float neighborDist, int maxNeighbors, float timeHorizon, float timeHorizonObst, float radius, float maxSpeed, float2 velocity)
		{
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001851")]
		[Address(RVA = "0x2018390", Offset = "0x2018390", VA = "0x2018390")]
		[BurstCompile]
		public void setAgentMaxNeighbors(int agentNo, int maxNeighbors)
		{
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001852")]
		[Address(RVA = "0x2018430", Offset = "0x2018430", VA = "0x2018430")]
		public void setAgentMaxSpeed(int agentNo, float maxSpeed)
		{
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001853")]
		[Address(RVA = "0x2018530", Offset = "0x2018530", VA = "0x2018530")]
		[BurstCompile]
		public void setAgentNeighborDist(int agentNo, float neighborDist)
		{
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x6001854")]
		[Address(RVA = "0x20185D8", Offset = "0x20185D8", VA = "0x20185D8")]
		public bool setAgentPosition(int agentNo, float2 position)
		{
			return default(bool);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001855")]
		[Address(RVA = "0x20189C4", Offset = "0x20189C4", VA = "0x20189C4")]
		public void setAgentPrefVelocity(int agentNo, float2 prefVelocity)
		{
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001856")]
		[Address(RVA = "0x2018B0C", Offset = "0x2018B0C", VA = "0x2018B0C")]
		public void setAgentTargetPosition(int agentNo, float2 targetPosition)
		{
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x2018C48", Offset = "0x2018C48", VA = "0x2018C48")]
		public void setAgentRadius(int agentNo, float radius)
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x2018D6C", Offset = "0x2018D6C", VA = "0x2018D6C")]
		[BurstCompile]
		public void setAgentTimeHorizon(int agentNo, float timeHorizon)
		{
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001859")]
		[Address(RVA = "0x2018E14", Offset = "0x2018E14", VA = "0x2018E14")]
		[BurstCompile]
		public void setAgentTimeHorizonObst(int agentNo, float timeHorizonObst)
		{
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x2018EBC", Offset = "0x2018EBC", VA = "0x2018EBC")]
		[BurstCompile]
		public void setAgentVelocity(int agentNo, float2 velocity)
		{
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185B")]
		[Address(RVA = "0x2018F60", Offset = "0x2018F60", VA = "0x2018F60")]
		[BurstCompile]
		public void setGlobalTime(float globalTime)
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185C")]
		[Address(RVA = "0x2018F68", Offset = "0x2018F68", VA = "0x2018F68")]
		[BurstCompile]
		public void setTimeStep(float timeStep)
		{
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185D")]
		[Address(RVA = "0x2013404", Offset = "0x2013404", VA = "0x2013404")]
		private Simulator()
		{
		}

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly bool isDebug;

		// Token: 0x04001AF3 RID: 6899
		[Token(Token = "0x4001AF3")]
		[FieldOffset(Offset = "0x10")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMap<int, int>* agentNo2indexDict_;

		// Token: 0x04001AF4 RID: 6900
		[Token(Token = "0x4001AF4")]
		[FieldOffset(Offset = "0x18")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMap<int, int>* index2agentNoDict_;

		// Token: 0x04001AF5 RID: 6901
		[Token(Token = "0x4001AF5")]
		[FieldOffset(Offset = "0x20")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafePtrList<Agent>* agents_;

		// Token: 0x04001AF6 RID: 6902
		[Token(Token = "0x4001AF6")]
		[FieldOffset(Offset = "0x28")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafePtrList<Agent>* agentsCopy_;

		// Token: 0x04001AF7 RID: 6903
		[Token(Token = "0x4001AF7")]
		[FieldOffset(Offset = "0x30")]
		internal UnsafePtrList<Obstacle> obstacles_;

		// Token: 0x04001AF8 RID: 6904
		[Token(Token = "0x4001AF8")]
		[FieldOffset(Offset = "0x50")]
		internal KdTree kdTree_;

		// Token: 0x04001AF9 RID: 6905
		[Token(Token = "0x4001AF9")]
		[FieldOffset(Offset = "0x58")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe int* agentCount_;

		// Token: 0x04001AFA RID: 6906
		[Token(Token = "0x4001AFA")]
		[FieldOffset(Offset = "0x60")]
		internal unsafe UnsafeList<AgentTreeNode>* agentTree_;

		// Token: 0x04001AFB RID: 6907
		[Token(Token = "0x4001AFB")]
		[FieldOffset(Offset = "0x68")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe ObstacleTreeNode* obstacleTree_;

		// Token: 0x04001AFC RID: 6908
		[Token(Token = "0x4001AFC")]
		[FieldOffset(Offset = "0x70")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafePtrList<ObstacleTreeNode>* obstacleTreeList_;

		// Token: 0x04001AFD RID: 6909
		[Token(Token = "0x4001AFD")]
		[FieldOffset(Offset = "0x78")]
		internal float timeStep_;

		// Token: 0x04001AFE RID: 6910
		[Token(Token = "0x4001AFE")]
		[FieldOffset(Offset = "0x8")]
		private static Simulator instance_;

		// Token: 0x04001AFF RID: 6911
		[Token(Token = "0x4001AFF")]
		[FieldOffset(Offset = "0x80")]
		private unsafe Agent* defaultAgent_;

		// Token: 0x04001B00 RID: 6912
		[Token(Token = "0x4001B00")]
		[FieldOffset(Offset = "0x88")]
		private bool hasDefaultAgent_;

		// Token: 0x04001B01 RID: 6913
		[Token(Token = "0x4001B01")]
		[FieldOffset(Offset = "0x8C")]
		private float globalTime_;

		// Token: 0x04001B02 RID: 6914
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x90")]
		private int agentSize_;

		// Token: 0x04001B03 RID: 6915
		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x94")]
		private int agentAlignment_;

		// Token: 0x04001B04 RID: 6916
		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x98")]
		private int obstacleSize_;

		// Token: 0x04001B05 RID: 6917
		[Token(Token = "0x4001B05")]
		[FieldOffset(Offset = "0x9C")]
		private int obstacleAlignment_;

		// Token: 0x04001B06 RID: 6918
		[Token(Token = "0x4001B06")]
		[FieldOffset(Offset = "0xA0")]
		private JobHandle prepareJobHandle_;

		// Token: 0x04001B07 RID: 6919
		[Token(Token = "0x4001B07")]
		[FieldOffset(Offset = "0xB0")]
		private JobHandle computeJobHandle_;

		// Token: 0x04001B08 RID: 6920
		[Token(Token = "0x4001B08")]
		[FieldOffset(Offset = "0xC0")]
		private JobHandle updateJobHandle_;

		// Token: 0x04001B09 RID: 6921
		[Token(Token = "0x4001B09")]
		[FieldOffset(Offset = "0x10")]
		public static bool isDOTS_;

		// Token: 0x04001B0A RID: 6922
		[Token(Token = "0x4001B0A")]
		[FieldOffset(Offset = "0x14")]
		private static int s_totalID;

		// Token: 0x04001B0B RID: 6923
		[Token(Token = "0x4001B0B")]
		public const int MAX_AGENTS = 256;

		// Token: 0x04001B0C RID: 6924
		[Token(Token = "0x4001B0C")]
		public const int MAX_OBSTACLES = 16;

		// Token: 0x04001B0D RID: 6925
		[Token(Token = "0x4001B0D")]
		[FieldOffset(Offset = "0xD0")]
		private bool isReportSetAgentPosition;

		// Token: 0x04001B0E RID: 6926
		[Token(Token = "0x4001B0E")]
		[FieldOffset(Offset = "0xD4")]
		private int reportSetAgentPositionCount;

		// Token: 0x04001B0F RID: 6927
		[Token(Token = "0x4001B0F")]
		[FieldOffset(Offset = "0xD8")]
		private bool isReportSetAgentPrefVelocity;

		// Token: 0x04001B10 RID: 6928
		[Token(Token = "0x4001B10")]
		[FieldOffset(Offset = "0xDC")]
		private int reportSetAgentPrefVelocityCount;

		// Token: 0x04001B11 RID: 6929
		[Token(Token = "0x4001B11")]
		[FieldOffset(Offset = "0xE0")]
		private bool isReportSetAgentTargetPosition;

		// Token: 0x04001B12 RID: 6930
		[Token(Token = "0x4001B12")]
		[FieldOffset(Offset = "0xE4")]
		private int reportSetAgentTargetPositionCount;

		// Token: 0x04001B13 RID: 6931
		[Token(Token = "0x4001B13")]
		[FieldOffset(Offset = "0xE8")]
		private bool isReportSetAgentRadius;

		// Token: 0x04001B14 RID: 6932
		[Token(Token = "0x4001B14")]
		[FieldOffset(Offset = "0xEC")]
		private int reportSetAgentRadiusCount;
	}
}
