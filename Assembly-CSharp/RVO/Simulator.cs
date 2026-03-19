using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace RVO
{
	// Token: 0x020003D4 RID: 980
	[Token(Token = "0x20003D4")]
	public class Simulator
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000255")]
		public static Simulator Instance
		{
			[Token(Token = "0x6001890")]
			[Address(RVA = "0x201F408", Offset = "0x201F408", VA = "0x201F408")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001891")]
		[Address(RVA = "0x201F460", Offset = "0x201F460", VA = "0x201F460")]
		public void delAgent(int agentNo)
		{
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x6001892")]
		[Address(RVA = "0x201F608", Offset = "0x201F608", VA = "0x201F608")]
		public bool hasAgent(int agentNo)
		{
			return default(bool);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x201F6B4", Offset = "0x201F6B4", VA = "0x201F6B4")]
		private void updateDeleteAgent()
		{
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x201FB90", Offset = "0x201FB90", VA = "0x201FB90")]
		public int addAgent(Vector2 position)
		{
			return 0;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x201F87C", Offset = "0x201F87C", VA = "0x201F87C")]
		private void onDelAgent()
		{
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x201FDE4", Offset = "0x201FDE4", VA = "0x201FDE4")]
		private void onAddAgent()
		{
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x2020070", Offset = "0x2020070", VA = "0x2020070")]
		public int addAgent(Vector2 position, float neighborDist, int maxNeighbors, float timeHorizon, float timeHorizonObst, float radius, float maxSpeed, Vector2 velocity)
		{
			return 0;
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x20202C4", Offset = "0x20202C4", VA = "0x20202C4")]
		public int addObstacle(IList<Vector2> vertices)
		{
			return 0;
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x2020C10", Offset = "0x2020C10", VA = "0x2020C10")]
		public void Clear()
		{
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x2020E00", Offset = "0x2020E00", VA = "0x2020E00")]
		public float doStep()
		{
			return 0f;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x20215A0", Offset = "0x20215A0", VA = "0x20215A0")]
		public int getAgentAgentNeighbor(int agentNo, int neighborNo)
		{
			return 0;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x2021764", Offset = "0x2021764", VA = "0x2021764")]
		public int getAgentMaxNeighbors(int agentNo)
		{
			return 0;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x2021894", Offset = "0x2021894", VA = "0x2021894")]
		public float getAgentMaxSpeed(int agentNo)
		{
			return 0f;
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x20219C4", Offset = "0x20219C4", VA = "0x20219C4")]
		public float getAgentNeighborDist(int agentNo)
		{
			return 0f;
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x2021AF4", Offset = "0x2021AF4", VA = "0x2021AF4")]
		public int getAgentNumAgentNeighbors(int agentNo)
		{
			return 0;
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x2021C90", Offset = "0x2021C90", VA = "0x2021C90")]
		public int getAgentNumObstacleNeighbors(int agentNo)
		{
			return 0;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x2021E2C", Offset = "0x2021E2C", VA = "0x2021E2C")]
		public int getAgentObstacleNeighbor(int agentNo, int neighborNo)
		{
			return 0;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x2021FF0", Offset = "0x2021FF0", VA = "0x2021FF0")]
		public IList<Line> getAgentOrcaLines(int agentNo)
		{
			return null;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x2022120", Offset = "0x2022120", VA = "0x2022120")]
		public Vector2 getAgentPosition(int agentNo)
		{
			return default(Vector2);
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x20224D0", Offset = "0x20224D0", VA = "0x20224D0")]
		public Vector2 getAgentPrefVelocity(int agentNo)
		{
			return default(Vector2);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x2022600", Offset = "0x2022600", VA = "0x2022600")]
		public float getAgentRadius(int agentNo)
		{
			return 0f;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x2022730", Offset = "0x2022730", VA = "0x2022730")]
		public float getAgentTimeHorizon(int agentNo)
		{
			return 0f;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x2022860", Offset = "0x2022860", VA = "0x2022860")]
		public float getAgentTimeHorizonObst(int agentNo)
		{
			return 0f;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x2022990", Offset = "0x2022990", VA = "0x2022990")]
		public Vector2 getAgentVelocity(int agentNo)
		{
			return default(Vector2);
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x2022AC0", Offset = "0x2022AC0", VA = "0x2022AC0")]
		public float getGlobalTime()
		{
			return 0f;
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x2021184", Offset = "0x2021184", VA = "0x2021184")]
		public int getNumAgents()
		{
			return 0;
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x2022AC8", Offset = "0x2022AC8", VA = "0x2022AC8")]
		public int getNumObstacleVertices()
		{
			return 0;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x2022B68", Offset = "0x2022B68", VA = "0x2022B68")]
		public int GetNumWorkers()
		{
			return 0;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x2022B70", Offset = "0x2022B70", VA = "0x2022B70")]
		public Vector2 getObstacleVertex(int vertexNo)
		{
			return default(Vector2);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x2022C24", Offset = "0x2022C24", VA = "0x2022C24")]
		public int getNextObstacleVertexNo(int vertexNo)
		{
			return 0;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x2022CE0", Offset = "0x2022CE0", VA = "0x2022CE0")]
		public int getPrevObstacleVertexNo(int vertexNo)
		{
			return 0;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x2022D9C", Offset = "0x2022D9C", VA = "0x2022D9C")]
		public float getTimeStep()
		{
			return 0f;
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x2022DA4", Offset = "0x2022DA4", VA = "0x2022DA4")]
		public void processObstacles()
		{
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x2022DBC", Offset = "0x2022DBC", VA = "0x2022DBC")]
		public bool queryVisibility(Vector2 point1, Vector2 point2, float radius)
		{
			return default(bool);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x2022DD8", Offset = "0x2022DD8", VA = "0x2022DD8")]
		public int queryNearAgent(Vector2 point, float radius)
		{
			return 0;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x2022E58", Offset = "0x2022E58", VA = "0x2022E58")]
		public void setAgentDefaults(float neighborDist, int maxNeighbors, float timeHorizon, float timeHorizonObst, float radius, float maxSpeed, Vector2 velocity)
		{
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x2022F24", Offset = "0x2022F24", VA = "0x2022F24")]
		public void setAgentMaxNeighbors(int agentNo, int maxNeighbors)
		{
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x2023060", Offset = "0x2023060", VA = "0x2023060")]
		public void setAgentMaxSpeed(int agentNo, float maxSpeed)
		{
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x202319C", Offset = "0x202319C", VA = "0x202319C")]
		public void setAgentNeighborDist(int agentNo, float neighborDist)
		{
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x20232D8", Offset = "0x20232D8", VA = "0x20232D8")]
		public bool setAgentPosition(int agentNo, Vector2 position)
		{
			return default(bool);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x20237DC", Offset = "0x20237DC", VA = "0x20237DC")]
		public void setAgentPrefVelocity(int agentNo, Vector2 prefVelocity)
		{
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BA")]
		[Address(RVA = "0x202391C", Offset = "0x202391C", VA = "0x202391C")]
		public void setAgentRadius(int agentNo, float radius)
		{
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x2023A58", Offset = "0x2023A58", VA = "0x2023A58")]
		public void setAgentTimeHorizon(int agentNo, float timeHorizon)
		{
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x2023B94", Offset = "0x2023B94", VA = "0x2023B94")]
		public void setAgentTimeHorizonObst(int agentNo, float timeHorizonObst)
		{
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x2023CD0", Offset = "0x2023CD0", VA = "0x2023CD0")]
		public void setAgentVelocity(int agentNo, Vector2 velocity)
		{
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x2023E10", Offset = "0x2023E10", VA = "0x2023E10")]
		public void setGlobalTime(float globalTime)
		{
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x2020DD8", Offset = "0x2020DD8", VA = "0x2020DD8")]
		public void SetNumWorkers(int numWorkers)
		{
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x2023E18", Offset = "0x2023E18", VA = "0x2023E18")]
		public void setTimeStep(float timeStep)
		{
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x2023E20", Offset = "0x2023E20", VA = "0x2023E20")]
		private Simulator()
		{
		}

		// Token: 0x04001B40 RID: 6976
		[Token(Token = "0x4001B40")]
		[FieldOffset(Offset = "0x10")]
		public bool isDebug;

		// Token: 0x04001B41 RID: 6977
		[Token(Token = "0x4001B41")]
		[FieldOffset(Offset = "0x18")]
		internal IDictionary<int, int> agentNo2indexDict_;

		// Token: 0x04001B42 RID: 6978
		[Token(Token = "0x4001B42")]
		[FieldOffset(Offset = "0x20")]
		internal IDictionary<int, int> index2agentNoDict_;

		// Token: 0x04001B43 RID: 6979
		[Token(Token = "0x4001B43")]
		[FieldOffset(Offset = "0x28")]
		internal IList<Agent> agents_;

		// Token: 0x04001B44 RID: 6980
		[Token(Token = "0x4001B44")]
		[FieldOffset(Offset = "0x30")]
		internal IList<Obstacle> obstacles_;

		// Token: 0x04001B45 RID: 6981
		[Token(Token = "0x4001B45")]
		[FieldOffset(Offset = "0x38")]
		internal KdTree kdTree_;

		// Token: 0x04001B46 RID: 6982
		[Token(Token = "0x4001B46")]
		[FieldOffset(Offset = "0x40")]
		internal float timeStep_;

		// Token: 0x04001B47 RID: 6983
		[Token(Token = "0x4001B47")]
		[FieldOffset(Offset = "0x0")]
		private static Simulator instance_;

		// Token: 0x04001B48 RID: 6984
		[Token(Token = "0x4001B48")]
		[FieldOffset(Offset = "0x48")]
		private Agent defaultAgent_;

		// Token: 0x04001B49 RID: 6985
		[Token(Token = "0x4001B49")]
		[FieldOffset(Offset = "0x50")]
		private ManualResetEvent[] doneEvents_;

		// Token: 0x04001B4A RID: 6986
		[Token(Token = "0x4001B4A")]
		[FieldOffset(Offset = "0x58")]
		private Simulator.Worker[] workers_;

		// Token: 0x04001B4B RID: 6987
		[Token(Token = "0x4001B4B")]
		[FieldOffset(Offset = "0x60")]
		private int numWorkers_;

		// Token: 0x04001B4C RID: 6988
		[Token(Token = "0x4001B4C")]
		[FieldOffset(Offset = "0x64")]
		private int workerAgentCount_;

		// Token: 0x04001B4D RID: 6989
		[Token(Token = "0x4001B4D")]
		[FieldOffset(Offset = "0x68")]
		private float globalTime_;

		// Token: 0x04001B4E RID: 6990
		[Token(Token = "0x4001B4E")]
		[FieldOffset(Offset = "0x8")]
		private static int s_totalID;

		// Token: 0x020003D5 RID: 981
		[Token(Token = "0x20003D5")]
		private class Worker
		{
			// Token: 0x060018C3 RID: 6339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60018C3")]
			[Address(RVA = "0x2021224", Offset = "0x2021224", VA = "0x2021224")]
			internal Worker(int start, int end, ManualResetEvent doneEvent)
			{
			}

			// Token: 0x060018C4 RID: 6340 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60018C4")]
			[Address(RVA = "0x2021268", Offset = "0x2021268", VA = "0x2021268")]
			internal void config(int start, int end)
			{
			}

			// Token: 0x060018C5 RID: 6341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60018C5")]
			[Address(RVA = "0x2021270", Offset = "0x2021270", VA = "0x2021270")]
			internal void step(object obj)
			{
			}

			// Token: 0x060018C6 RID: 6342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60018C6")]
			[Address(RVA = "0x2021458", Offset = "0x2021458", VA = "0x2021458")]
			internal void update(object obj)
			{
			}

			// Token: 0x04001B4F RID: 6991
			[Token(Token = "0x4001B4F")]
			[FieldOffset(Offset = "0x10")]
			private ManualResetEvent doneEvent_;

			// Token: 0x04001B50 RID: 6992
			[Token(Token = "0x4001B50")]
			[FieldOffset(Offset = "0x18")]
			private int end_;

			// Token: 0x04001B51 RID: 6993
			[Token(Token = "0x4001B51")]
			[FieldOffset(Offset = "0x1C")]
			private int start_;
		}
	}
}
